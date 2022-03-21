import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-transferencia',
  templateUrl: './transferencia.component.html',
  styleUrls: ['./transferencia.component.scss'],
})
export class TransferenciaComponent implements OnInit {

 @Output() aoTransferir = new EventEmitter<any>(); // criando um evento
// o que o output faze -> ele pega o valores e joga pra fora pra quem o invocou

  origin: number;
  destiny: number;

  constructor() {}

  ngOnInit(): void {}

  transferir() {
    console.log('Solicitado nova transferencia');
    const valueEmit = { valueOrigin: this.origin, valueDestiny: this.destiny}
    this.aoTransferir.emit(valueEmit); // vou emiti um evento
    
    this.cleaInput();
  }

  cleaInput(){
    this.origin = 0;
    this.destiny = 0;
  }
}
