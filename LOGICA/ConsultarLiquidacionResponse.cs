using System;
using System.Collections.Generic;
using Datos;
using ENTITY;

namespace LOGICA
{
    public class ConsultarLiquidacionResponse
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public List<Liquidacion> Liquidaciones { get; set; }

        public ConsultarLiquidacionResponse(List<Liquidacion> liquidaciones)
        {
            Error=false;
            Liquidaciones=liquidaciones;
        }
        public ConsultarLiquidacionResponse(string mensaje)
        {
            Error=true;
            Mensaje=mensaje;
        }
    }
}