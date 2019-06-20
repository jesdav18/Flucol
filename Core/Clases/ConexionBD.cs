using Devart.Data.PostgreSql;
using System;
using System.Data;


namespace Core.Clases
{
    public static class ConexionBD
    {
        public static bool ConexionActiva(ref PgSqlConnection pConexion)
        {
            if (pConexion.State == ConnectionState.Open)
            {
                return true;
            }

            pConexion.Open();
            string sentencia_prueba = "SELECT 1";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia_prueba, pConexion);

            try
            {              
                pgComando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                PgSqlConnection v_conexion_temporal = new PgSqlConnection(pConexion.ConnectionString);
                v_conexion_temporal.Password = pConexion.Password;
               
                int v_intentos = 0;
                while (v_intentos ++ <= 30)
                {
                    v_conexion_temporal = new PgSqlConnection(pConexion.ConnectionString);
                    v_conexion_temporal.Password = pConexion.Password;
                    
                    try
                    {
                        v_conexion_temporal.Open();
                        pConexion = v_conexion_temporal;
                        return true;
                    }
                    catch (Exception)
                    { }
                }
            }

            return false;
        }
    }
}
