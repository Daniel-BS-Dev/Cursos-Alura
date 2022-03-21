import { BrowserModule } from '@angular/platform-browser';
import { DEFAULT_CURRENCY_CODE, LOCALE_ID, NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TransferenciaComponent } from './component/transferencia/transferencia.component';
import { FormsModule } from '@angular/forms';
import { ExtratoComponent } from './component/extrato/extrato.component'
import { registerLocaleData } from '@angular/common';
import localePt from '@angular/common/locales/pt'

registerLocaleData(localePt, 'pt');
 

@NgModule({
  declarations: [
    AppComponent,
    TransferenciaComponent,
    ExtratoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [
   { provide: LOCALE_ID, useValue: 'pt'}, // date
    {
      provide: DEFAULT_CURRENCY_CODE, // currency
      useValue: 'BRL',
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
