using System;

namespace ENTITY
{
    public class Liquidacion
    {
    public string IdentificacionPaciente { get; set; }
    public decimal ValorHospitalizacion { get; set; }
    public decimal Tarifa { get; set; }
    public decimal Salario { get; set; }
    public decimal ValorCopago { get; set; }

    public void CalcularTarifa(){
        if(this.Salario>0){
            if(this.Salario>2500000){
                this.Tarifa=0.2m;
            }else{
                this.Tarifa=0.1m;
            }
        }

    }
    public void CalcularValorCopago(){
        CalcularTarifa();
        this.ValorCopago=this.Tarifa*this.ValorHospitalizacion;
    }
    }
}
