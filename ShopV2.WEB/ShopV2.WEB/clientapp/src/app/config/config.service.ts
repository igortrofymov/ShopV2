import { HttpClient, HttpErrorResponse, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, retry } from 'rxjs/operators';
import { throwError, Observable } from 'rxjs';

export interface Config {
  productsUrl: string;
  textfile: string;
}
@Injectable({
  providedIn: 'root'
})
export class ConfigService {

constructor(private http : HttpClient) { }
configUrl = './../../assets/config.json';

getAllHeroes(){
  
}

getConfig() {
  return this.http.get<Config>(this.configUrl);
}
getConfigResponse(): Observable<HttpResponse<Config>> {
  return this.http.get<Config>(
    this.configUrl, { observe: 'response' });
}

private handleError(error: HttpErrorResponse){
  if(error. error instanceof ErrorEvent){
    console.error('An error occurred:', error.error.message);
  } else {
    console.error(`
    Backend error returned code ${error.status}, `+
    `body was ${error.error}`);
    return throwError(
      'Something bad happened; please try again later.');
  }
}

}
