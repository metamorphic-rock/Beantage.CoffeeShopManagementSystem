import { Component, OnInit, ViewChild } from '@angular/core';

@Component({
  selector: 'app-add-product-modal',
  templateUrl: './add-product-modal.component.html',
  styleUrls: ['./add-product-modal.component.scss']
})
export class AddProductModalComponent implements OnInit{
  @ViewChild('addProductModal') addProductModal: any;

  ngOnInit(): void {

  }
  openModal(){
    this.addProductModal.modal.show();
  }
  closeModal(){
    this.addProductModal.modal.hide();
  }
}
