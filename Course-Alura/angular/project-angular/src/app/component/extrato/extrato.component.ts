import { Component, Input, OnInit } from '@angular/core';
import { ServiceService } from '../service.service';

@Component({
  selector: 'app-extrato',
  templateUrl: './extrato.component.html',
  styleUrls: ['./extrato.component.scss']
})
export class ExtratoComponent implements OnInit {


 // @Input() toSendValue : any[]; // input vai permitir que seja 
  //criada um properte biding no meu component 
  // app-extrato com o nome toSendValue

  toSendValue : any[];

  constructor(private service: ServiceService) { }

  ngOnInit(): void {
    this.toSendValue = this.service.getToSend;

  }


}
