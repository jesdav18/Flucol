using Devart.Data.PostgreSql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Clases
{
    public class Tiempos
    {

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public DateTime Pro_Tiempo_Inicio_Espera { get; set; }
        public DateTime Pro_Tiempo_Finalizacion_Espera { get; set; }
        public DateTime Pro_Tiempo_Inicio_Atencion { get; set; }
        public DateTime Pro_Tiempo_Finalizacion_Atencion { get; set; }

        #endregion

        #region FUNCIONES


        public void ActualizarEstadoTicket(PgSqlConnection pConexion,
                                           int pEstadoTicket, 
                                           int pID_AgenciaServicio, 
                                           int pID_ClienteServicio, 
                                           string pTicketServicio )
        {

            Pro_Conexion = pConexion;

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            try
            {
                string sentencia = @"SELECT * FROM area_servicio.ft_mant_actualizar_estado_ticket (
                                                                                                    :p_estado_ticket,
                                                                                                    :p_id_agencia_servicio,
                                                                                                    :p_id_cliente_servicio,
                                                                                                    :p_ticket_servicio
                                                                                                )";
                PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
                pgComando.Parameters.Add("p_estado_ticket", PgSqlType.Int).Value = (int) pEstadoTicket;
                pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = pID_AgenciaServicio;
                pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = pID_ClienteServicio;
                pgComando.Parameters.Add("p_ticket_servicio", PgSqlType.VarChar).Value = pTicketServicio;

                pgComando.ExecuteNonQuery();

            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "FLUCOL");
            }
        }

        #endregion


    }
}
