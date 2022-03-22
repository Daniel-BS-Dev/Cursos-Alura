import { Tranferencia } from 'src/app/models/models';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})  // Injectable diz que eu posso invocar uma instacia atraves do construtor
export class ServiceService {

  private listSendValue : any[];
  private baseUrl = "http://localhost:3001/tranferencias";


  constructor(private http: HttpClient) {
    this.listSendValue = [];
   }

   get getToSend(){
      return this.listSendValue;
   }

   read(): Observable<Tranferencia[]>{
      return this.http.get<Tranferencia[]>(this.baseUrl)
   }

   addValue(value: Tranferencia): Observable<Tranferencia>{
      this.hidrater(value);
      return this.http.post<Tranferencia>(this.baseUrl, value);
   }

   private hidrater(value: any){
     value.date = new Date();
   }
}
