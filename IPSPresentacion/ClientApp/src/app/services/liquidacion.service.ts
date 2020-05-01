import { Injectable, Inject } from '@angular/core';
import {HttpHeaders,HttpClient }from '@angular/common/http';
import { tap, catchError } from 'rxjs/operators';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { Observable } from 'rxjs';
import { Liquidacion } from '../Ips/models/liquidacion';

@Injectable({
  providedIn: 'root'
})
export class LiquidacionService {
  baseUrl:string;
  constructor(private http:HttpClient,
    @Inject('BASE_URL')baseUrl:string,
    private handleErrorService: HandleHttpErrorService) {
      this.baseUrl=baseUrl
     }
     get(): Observable<Liquidacion[]> {
      return this.http.get<Liquidacion[]>(this.baseUrl + 'api/Liquidacion')
          .pipe(
              tap(_ => this.handleErrorService.log('datos enviados')),
              catchError(this.handleErrorService.handleError<Liquidacion[]>('Consulta Liquidacion', null))
          );
    }
    post(persona: Liquidacion): Observable<Liquidacion> {
      return this.http.post<Liquidacion>(this.baseUrl + 'api/Liquidacion', persona)
          .pipe(
              tap(_ => this.handleErrorService.log('datos enviados')),
              catchError(this.handleErrorService.handleError<Liquidacion>('Registrar Liquidacion', null))
          );
  }
  
  
}
