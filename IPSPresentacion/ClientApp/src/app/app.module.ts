import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { LiquidacionConsultaComponent } from './Ips/liquidacion-consulta/liquidacion-consulta.component';
import { LiquidacionRegistroComponent } from './Ips/liquidacion-registro/liquidacion-registro.component';
import { AppRoutingModule } from './app-routing.module';
import { LiquidacionService } from './services/liquidacion.service';
import { FiltroLiquidacionPipe } from './pipe/filtro-liquidacion.pipe';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    LiquidacionConsultaComponent,
    LiquidacionRegistroComponent,
    FiltroLiquidacionPipe
  ],
  imports: [
    ReactiveFormsModule,
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ]),
    AppRoutingModule
  ],
  providers: [LiquidacionService],
  bootstrap: [AppComponent]
})
export class AppModule { }
