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
import { LogoutModalComponent } from './shared/logout-modal/logout-modal.component';
import { InventoryComponent } from './inventory/inventory.component';
import { PointOfSaleComponent } from './point-of-sale/point-of-sale.component';
import { EmployeeComponent } from './employee/employee.component';
import { ProductsTableComponent } from './inventory/products-table/products-table.component';
import { AddProductModalComponent } from './inventory/add-product-modal/add-product-modal.component';
import { FormsModule } from '@angular/forms';
import { EmployeeListTableComponent } from './employee/employee-list-table/employee-list-table.component';
import { RawIngredientsTableComponent } from './inventory/raw-ingredients-table/raw-ingredients-table.component';
import { MiscellaneousMaterialsTableComponent } from './inventory/miscellaneous-materials-table/miscellaneous-materials-table.component';
import { AttendancesComponent } from './employee/attendances/attendances.component';
import { ProductListComponent } from './point-of-sale/product-list/product-list.component';
import { OrderPreviewComponent } from './point-of-sale/order-preview/order-preview.component';
import { ItemDetailComponent } from './point-of-sale/item-detail/item-detail.component';
import { ItemDetailModalComponent } from './point-of-sale/item-detail-modal/item-detail-modal.component';
import { OrderItemModalComponent } from './point-of-sale/order-item-modal/order-item-modal.component';

const appRoutes : Routes = [
  {path: 'login', component : LoginComponent},
  {path: '', redirectTo: '/login', pathMatch: 'full'},
  {path: 'dashboard', component: DashboardComponent},
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
    LogoutModalComponent,
    InventoryComponent,
    PointOfSaleComponent,
    EmployeeComponent,
    ProductsTableComponent,
    AddProductModalComponent,
    EmployeeListTableComponent,
    RawIngredientsTableComponent,
    MiscellaneousMaterialsTableComponent,
    AttendancesComponent,
    ProductListComponent,
    OrderPreviewComponent,
    ItemDetailComponent,
    ItemDetailModalComponent,
    OrderItemModalComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }
