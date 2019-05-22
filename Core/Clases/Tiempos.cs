using Devart.Data.PostgreSql;
using System;
using System.Data;
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


        public bool ActualizarEstadoTicket(PgSqlConnection pConexion,
                                           int pEstadoTicket, 
                                           int pID_AgenciaServicio, 
                                           int pID_ClienteServicio, 
                                           string pTicketServicio,
                                           string pUsuario)
        {

            Pro_Conexion = pConexion;

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_mant_actualizar_estado_ticket (
                                                                                                :p_estado_ticket,
                                                                                                :p_id_agencia_servicio,
                                                                                                :p_id_cliente_servicio,
                                                                                                :p_ticket_servicio,
                                                                                                :p_usuario
                                                                                            )";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_estado_ticket", PgSqlType.Int).Value = (int)pEstadoTicket;
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = pID_AgenciaServicio;
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = pID_ClienteServicio;
            pgComando.Parameters.Add("p_ticket_servicio", PgSqlType.VarChar).Value = pTicketServicio;
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = pUsuario;

            try
            {
                
                pgComando.ExecuteNonQuery();

                sentencia = null;
                pgComando.Dispose();

                return true;

            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  "class Tiempos",
                                                  @"ActualizarEstadoTicket(PgSqlConnection pConexion,
                                                                           int pEstadoTicket, 
                                                                           int pID_AgenciaServicio, 
                                                                           int pID_ClienteServicio, 
                                                                           string pTicketServicio,
                                                                           string pUsuario)");
                v_depurador = null;

                MessageBox.Show(Exc.Message, "FLUCOL");
                return false;
            }
        }
        #endregion


    }
}
