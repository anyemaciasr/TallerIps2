using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ENTITY;
namespace Datos {
    public class LiquidacionRepository {

        private readonly SqlConnection Conexion;

        public LiquidacionRepository(ConnectionManager conexion)
        {
            Conexion = conexion.Conexion;
        }
        public void Guardar (Liquidacion liquidacion) {
            using (var command = Conexion.CreateCommand ()) {
                command.CommandText = @"Insert Into LiquidacionIps (Identificacion,ValorHospitalizacion,Tarifa,Salario, ValorCopago) 
                                        values (@Identificacion,@ValorHospitalizacion,@Tarifa,@Salario,@ValorCopago)";
                command.Parameters.AddWithValue ("@Identificacion", liquidacion.IdentificacionPaciente);
                command.Parameters.AddWithValue ("@ValorHospitalizacion", liquidacion.ValorHospitalizacion);
                command.Parameters.AddWithValue ("@Tarifa", liquidacion.Tarifa);
                command.Parameters.AddWithValue ("@Salario", liquidacion.Salario);
                command.Parameters.AddWithValue ("@ValorCopago", liquidacion.ValorCopago);
                var filas = command.ExecuteNonQuery ();
            }
        }
        public List<Liquidacion> ConsultarTodos () {
            SqlDataReader dataReader;
            List<Liquidacion> liquidaciones = new List<Liquidacion> ();
            using (var command = Conexion.CreateCommand ()) {
                command.CommandText = "Select * from LiquidacionIps";
                dataReader = command.ExecuteReader ();
                if (dataReader.HasRows) {
                    while (dataReader.Read()) {
                        Liquidacion liquidacion = MapearLiquidacion (dataReader);
                        liquidaciones.Add (liquidacion);
                    }
                }
            }
            return liquidaciones;
        }
        private Liquidacion MapearLiquidacion (SqlDataReader dataReader) {

            if (!dataReader.HasRows) return null;
            Liquidacion liquidacion = new Liquidacion ();
            liquidacion.IdentificacionPaciente = (string) dataReader["Identificacion"];
            liquidacion.ValorHospitalizacion= (decimal) dataReader["ValorHospitalizacion"];
            liquidacion.Tarifa = (decimal) dataReader["Tarifa"];
            liquidacion.Salario = (decimal) dataReader["Salario"];
            liquidacion.ValorCopago=(decimal) dataReader["ValorCopago"];
            return liquidacion;
            
        }

    }
}