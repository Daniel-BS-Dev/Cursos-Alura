import { ExtratoComponent } from './component/extrato/extrato.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TransferenciaComponent } from './component/transferencia/transferencia.component';

const routes: Routes = [
  {path:'', redirectTo:'extrato', pathMatch: 'full'},
  {path:'extrato', component: ExtratoComponent},
  {path:'transferencia', component: TransferenciaComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
