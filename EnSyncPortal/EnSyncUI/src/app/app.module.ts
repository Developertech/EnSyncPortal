import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppService } from './app.service';
import { HttpModule } from '@angular/http';

import { MDBBootstrapModulesPro } from 'ng-uikit-pro-standard';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'; 
import { MDBSpinningPreloader } from 'ng-uikit-pro-standard';
import { ApiService } from './api.service';
import { EmployeeComponent } from './Employee/Employee.Component';

@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpModule,
    MDBBootstrapModulesPro.forRoot()
  ],
  providers: [AppService,MDBSpinningPreloader, ApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
