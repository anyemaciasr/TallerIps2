using ENTITY;
using Datos;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace LOGICA {
    public class LiquidacionService {
        private readonly ConnectionManager Conexion;
        private readonly LiquidacionRepository Repositorio;
        public GuardarLiquidacionResponse guardarLiquidacionResponse;

        public LiquidacionService (string connectionString) {
            Conexion = new ConnectionManager(connectionString);
            Repositorio = new LiquidacionRepository (Conexion);
        }
        
        public GuardarLiquidacionResponse Guardar(Liquidacion liquidacion) {
            try {
                liquidacion.CalcularValorCopago();
                Conexion.Open ();
                Repositorio.Guardar (liquidacion);
                Conexion.Close ();
                return new GuardarLiquidacionResponse (liquidacion);
            } catch (Exception e) {
                return new GuardarLiquidacionResponse ($"Error de la Aplicacion: {e.Message}");
            } finally { Conexion.Close (); }
        }
        public ConsultarLiquidacionResponse ConsultarTodos()
        {
            try
            {
                Conexion.Open();
                List<Liquidacion> liquidaciones = Repositorio.ConsultarTodos();
                Conexion.Close();
                return new ConsultarLiquidacionResponse(liquidaciones);
            }
            catch (Exception e)
            {
                return new ConsultarLiquidacionResponse($"Error de la Aplicacion: {e.Message}");
            }finally{Conexion.Close ();}
           
        }


    }
   

}