using System.Collections.Generic;
using LOGICA;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using IPSPresentacion.Models;
using System.Linq;
using ENTITY;
namespace IPSPresentacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LiquidacionController:ControllerBase
    {
        private readonly LiquidacionService liquidacionService;
        public IConfiguration Configuration { get; }
        public LiquidacionController(IConfiguration configuration)
        {
            Configuration = configuration;
            string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
            liquidacionService = new LiquidacionService(connectionString);
        }
        // GET: api/Persona
        [HttpGet]
        public IEnumerable<LiquidacionViewModel> Gets()
        {
            var liquidaciones = liquidacionService.ConsultarTodos().Liquidaciones.Select(p=> new LiquidacionViewModel(p));
            return liquidaciones;
        }
        // POST: api/Persona
        [HttpPost]
        public ActionResult<LiquidacionViewModel> Post(LiquidacionInputModel LiquidacionInput)
        {
            Liquidacion liquidacion = MapearLiquidacion(LiquidacionInput);
            var response = liquidacionService.Guardar(liquidacion);
            if (response.Error) 
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Liquidacion);
        }
        private Liquidacion MapearLiquidacion(LiquidacionInputModel LiquidacionInput)
{
            var liquidacion = new Liquidacion
            {
                IdentificacionPaciente =LiquidacionInput.IdentificacionPaciente ,
                ValorHospitalizacion=LiquidacionInput.ValorHospitalizacion,
                Salario=LiquidacionInput.Salario,
            };
            return liquidacion;
}


        



    }
}