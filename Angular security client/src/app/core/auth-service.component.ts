import { Injectable } from '@angular/core';
import { CoreModule } from './core.module';
import { UserManager, User } from 'oidc-client';
import { Constants } from '../constants';
import { Subject } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { AuthContext } from '../model/auth-context';

@Injectable()

export class AuthService {
    private _usermanager: UserManager;
    private _user: User;
    private _loginChangedSubject =  new Subject<boolean>();
    authContext : AuthContext;
    loginChanged = this._loginChangedSubject.asObservable();

    constructor( private _httpClient : HttpClient) {
        const stsSettings = {
            // authority: "https://securingangularappscoursev2-sts.azurewebsites.net/",
            authority: Constants.stsAuthority,
            client_id:  Constants.clientId,
            redirect_uri:  `${Constants.clientRoot}signin-callback`,
            scope: 'openid profile projects-api',
            response_type: 'code',
            post_logout_redirect_uri: `${Constants.clientRoot}signout-callback`,
            automaticSilentRenew : true,
            silent_redirect_uri : `${Constants.clientRoot}assets/silent-callback.html` ,
        }

        this._usermanager = new UserManager(stsSettings)
        this._usermanager.events.addAccessTokenExpired(_ =>{
            this._loginChangedSubject.next(false);
            // alert("session expired");

            this._usermanager.events.addUserLoaded(user =>{
                if(this._user !== user){
                    this._user = user;
                    this.loadSecurityContext();
                    this._loginChangedSubject.next(!!user && !user.expired);
                }
            })
        });
    }

    login(){
        return this._usermanager.signinRedirect();
    }

    isLoggedIn(): Promise<boolean>{
        return this._usermanager.getUser().then(user=>{
            const userCurrent = !! user &&  !user.expired;
            this._user = user;
            if(this._user !== user){
                this._loginChangedSubject.next(userCurrent);
            }
            return userCurrent;
        });
    }

    completeLogin(){
        return this._usermanager.signinRedirectCallback().then(user =>{
            this._user = user;
            this._loginChangedSubject.next(!!user && !user.expired);
            return user;
        });
    }

    logout(){
        this._usermanager.signoutRedirect();
    }

    completeLogout(){
        this._user = null;
        this._loginChangedSubject.next(false);
        return this._usermanager.signoutRedirectCallback();
    }

    getAccessToken(){
        return this._usermanager.getUser().then(user =>{
            if(!!user && !user.expired){
                return user.access_token;
            }
            else{
                return null;
            }
        });
    }

    loadSecurityContext(){
        this._httpClient.get<AuthContext>(`${Constants.apiRoot} Project/AuthContext`)
        .subscribe(
            context =>{
                this.authContext = new AuthContext();
                this.authContext.claims = context.claims;
                this.authContext.userProfile = context.userProfile 
            },
        )
    }
}
