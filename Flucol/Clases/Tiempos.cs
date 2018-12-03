using Devart.Data.PostgreSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flucol.Clases
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

     
        public void Registrar_Inicio_Tiempo_Espera(DateTime pInicioEspera, PgSqlConnection pConexion)
        {
            Pro_Conexion = pConexion;

            if (Pro_Conexion.State != System.Data.ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            PgSqlTransaction pgTrans = Pro_Conexion.BeginTransaction();
            try
            {
                
            }
            catch (PgSqlException Exc)
            {
                MessageBox.Show(Exc.Message, "FLUCOL");
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "FLUCOL");
            }
        } 

        public void Registrar_Finalizacion_Tiempo_Espera(DateTime pFinalizacionEspera)
        {

        }

        public void Registrar_Inicio_Tiempo_Atencion(DateTime pInicioEspera)
        {

        }

        public void Registrar_Finalizacion_Tiempo_Atencion(DateTime pFinalizacionEspera)
        {

        }

        #endregion


    }
}
