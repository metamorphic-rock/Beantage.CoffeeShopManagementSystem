import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RawIngredientsTableComponent } from './raw-ingredients-table.component';

describe('RawIngredientsTableComponent', () => {
  let component: RawIngredientsTableComponent;
  let fixture: ComponentFixture<RawIngredientsTableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RawIngredientsTableComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RawIngredientsTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
