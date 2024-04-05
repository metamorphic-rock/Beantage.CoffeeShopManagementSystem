import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { Routes, RouterModule } from '@angular/router';
import { FooterComponent } from './shared/footer/footer.component';
import { HeaderComponent } from './shared/header/header.component';
import { BasePageComponent } from './base-page/base-page.component';
import { LogoutModalComponent } from './shared/logout-modal/logout-modal.component';
import { InventoryComponent } from './inventory/inventory.component';
import { PointOfSaleComponent } from './point-of-sale/point-of-sale.component';
import { EmployeeComponent } from './employee/employee.component';

const appRoutes : Routes = [
  {path: 'login', component : LoginComponent},
  {path: '', component: DashboardComponent},
  {path: 'pointOfSale', component : PointOfSaleComponent},
  {path: 'inventory', component : InventoryComponent},
  {path: 'employees', component : EmployeeComponent }
]

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    NavbarComponent,
    DashboardComponent,
    FooterComponent,
    HeaderComponent,
    BasePageComponent,
    LogoutModalComponent,
    InventoryComponent,
    PointOfSaleComponent,
    EmployeeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
