import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MiscellaneousMaterialsTableComponent } from './miscellaneous-materials-table.component';

describe('MiscellaneousMaterialsTableComponent', () => {
  let component: MiscellaneousMaterialsTableComponent;
  let fixture: ComponentFixture<MiscellaneousMaterialsTableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MiscellaneousMaterialsTableComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MiscellaneousMaterialsTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
