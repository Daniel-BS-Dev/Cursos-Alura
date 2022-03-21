import { ServiceService } from './component/service.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'project-angular';

  constructor(private service: ServiceService){

  }

  transferir($event){ // recebendo os valores da minha tranferencia
    this.service.addValue($event);

  }
}
