import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Router } from '@angular/router';
import { Tranferencia } from 'src/app/models/models';
import { ServiceService } from '../service.service';

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

  constructor(private service: ServiceService, private router: Router) {}

  ngOnInit(): void {}

  transferir() {
    console.log('Solicitado nova transferencia');
    const valueEmit: Tranferencia = { valueOrigin: this.origin, valueDestiny: this.destiny}
    //this.aoTransferir.emit(valueEmit); // vou emiti um evento

    this.service.addValue(valueEmit).subscribe(result => {
      console.log(result);
      this.router.navigateByUrl("extrato")

    },
    error => console.error(error)
    );
    
    this.cleaInput();
  }

  cleaInput(){
    this.origin = 0;
    this.destiny = 0;
  }
}
