
using Devart.Data.PostgreSql;
using System;
using System.Net;


namespace Core.Clases
{
    public class Utilidades
    {

        public string ObtenerIP_Host()
        {
            IPHostEntry v_host;
            string v_ip_host = "";
            v_host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress iterador_ip in v_host.AddressList)
            {
                if (iterador_ip.AddressFamily.ToString() == "InterNetwork")
                {
                    v_ip_host = iterador_ip.ToString();
                    break;
                }
            }

            return v_ip_host;
           
        }

        public DateTime ObtenerHoraServidor(PgSqlConnection pConexion)
        {
           
            string sentencia = "SELECT * FROM configuracion.ft_obtener_hora_servidor();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);

            return (DateTime)pgComando.ExecuteScalar();

        }

        public int ObtenerNumeroMes(PgSqlConnection pConexion)
        {
            string sentencia = "SELECT * FROM configuracion.ft_proc_obtener_numero_mes();";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, pConexion);

            return (int)pgComando.ExecuteScalar();
        }

       
    }
}
