import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})  // Injectable diz que eu posso invocar uma instacia atraves do construtor
export class ServiceService {

  private listSendValue : any[];

  constructor() {
    this.listSendValue = [];
   }

   get getToSend(){
      return this.listSendValue;
   }

   addValue(value: any ){
    this.hidrater(value);
    this.listSendValue.push(value);
   }

   private hidrater(value: any){
     value.date = new Date();
   }
}
