import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { LiquidacionConsultaComponent } from './Ips/liquidacion-consulta/liquidacion-consulta.component';
import { LiquidacionRegistroComponent } from './Ips/liquidacion-registro/liquidacion-registro.component';


const routes: Routes = [
    {
    path: 'liquidacionConsulta',
    component:LiquidacionConsultaComponent
    },
    {
      path: 'liquidacionRegistro',
      component:LiquidacionRegistroComponent
    }
  ];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports:[RouterModule]

})
export class AppRoutingModule { }
