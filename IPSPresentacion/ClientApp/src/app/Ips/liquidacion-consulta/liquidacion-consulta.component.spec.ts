import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LiquidacionConsultaComponent } from './liquidacion-consulta.component';

describe('LiquidacionConsultaComponent', () => {
  let component: LiquidacionConsultaComponent;
  let fixture: ComponentFixture<LiquidacionConsultaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LiquidacionConsultaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LiquidacionConsultaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
