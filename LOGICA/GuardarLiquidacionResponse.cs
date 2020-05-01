using ENTITY;
using System;
using System.Collections.Generic;
using Datos;


namespace LOGICA {

    
public class GuardarLiquidacionResponse
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Liquidacion Liquidacion { get; set; }

        public GuardarLiquidacionResponse(Liquidacion liquidacion)
        {
            Error = false;
            Liquidacion = liquidacion;
        }
        public GuardarLiquidacionResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        
    }

}