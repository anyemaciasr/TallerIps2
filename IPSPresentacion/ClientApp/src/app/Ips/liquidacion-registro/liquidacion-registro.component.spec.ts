import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LiquidacionRegistroComponent } from './liquidacion-registro.component';

describe('LiquidacionRegistroComponent', () => {
  let component: LiquidacionRegistroComponent;
  let fixture: ComponentFixture<LiquidacionRegistroComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LiquidacionRegistroComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LiquidacionRegistroComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
