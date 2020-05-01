import { Component, OnInit } from '@angular/core';
import { LiquidacionService } from 'src/app/services/liquidacion.service';
import { Liquidacion } from '../models/liquidacion';
import { FormGroup, FormBuilder, Validators, AbstractControl } from '@angular/forms';

@Component({
  selector: 'app-liquidacion-registro',
  templateUrl: './liquidacion-registro.component.html',
  styleUrls: ['./liquidacion-registro.component.css']
})
export class LiquidacionRegistroComponent implements OnInit {
  formGroup: FormGroup;
  liquidacion:Liquidacion;
  constructor(private liquidacionService: LiquidacionService, private formBuilder: FormBuilder) { }
  ngOnInit(): void {
    this.liquidacion=new Liquidacion();
    this.buildForm();
  }
  private buildForm() {
      this.liquidacion=new Liquidacion();
      this.liquidacion.identificacionPaciente="";
      this.liquidacion.valorHospitalizacion=0;
      this.liquidacion.salario=0;

      this.formGroup = this.formBuilder.group({
      identificacionPaciente:[this.liquidacion.identificacionPaciente,Validators.required],
      valorHospitalizacion:[this.liquidacion.valorHospitalizacion,[Validators.required,Validators.min(1)]],
      salario:[this.liquidacion.salario,[Validators.required,Validators.min(1)]],
     });
  }

  onSubmit() {
        if (this.formGroup.invalid) {
          return;
        }
        this.add();
      }
    
  add() {
    this.liquidacion=this.formGroup.value;
    this.liquidacionService.post(this.liquidacion).subscribe(p => {
      if (p != null) {
        alert('liquidacion Registrada!');
        this.liquidacion = p;
      }
    });
  }
  get control() { return this.formGroup.controls; }
    

}
