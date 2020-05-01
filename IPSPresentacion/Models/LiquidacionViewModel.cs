using ENTITY;
namespace IPSPresentacion.Models
{
    public class LiquidacionViewModel:LiquidacionInputModel
    {
         public LiquidacionViewModel()
        {

        }
        public decimal Tarifa { get; set; }
        public decimal ValorCopago { get; set; }
        public LiquidacionViewModel(Liquidacion liquidacion)
        {
            IdentificacionPaciente =liquidacion.IdentificacionPaciente ;
            ValorHospitalizacion = liquidacion.ValorHospitalizacion;
            Tarifa = liquidacion.Tarifa;
            Salario= liquidacion.Salario;
            ValorCopago = liquidacion.ValorCopago;
        }
       
    }
}