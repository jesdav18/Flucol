using Core.Clases;
using Flucol.Pantallas;
using System;
using System.Threading;
using System.Windows.Forms;


namespace Constructor
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            ThreadExceptionHandler handler = new ThreadExceptionHandler();
            Application.ThreadException += new ThreadExceptionEventHandler(handler.LanzadorExcepciones);
            try
            {
                
                Application.Run(new frmConstructor());
            }
            catch (Exception exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(exc,
                                                  "program.cs",
                                                  "Main()");
                v_depurador = null;
            }
        }

        internal class ThreadExceptionHandler
        {
            /// 
            /// Manejador de Excepciones.
            /// 
            public void LanzadorExcepciones(object sender, ThreadExceptionEventArgs e)
            {
                try
                {
                    // Cierra el programa si el usuario presiona Abortar
                    DialogResult result = MostrarMensajeDeError(e.Exception);

                    if (result == DialogResult.Abort)
                        Application.Exit();
                }
                catch (Exception exc)
                {
                    // Error fatal, el programa será cerrado
                    try
                    {
                        DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                        v_depurador.CapturadorExcepciones(exc,
                                                          "program.cs",
                                                          "LanzadorExcepciones(object sender, ThreadExceptionEventArgs e)");
                        v_depurador = null;

                        MessageBox.Show("NO SE LOGRÓ RECUPERAR LA ESTABILIDAD DEL PROGRAMA. A CONTINUACION EL PROGRAMA SERA CERRADO. \n", "FLUCOL", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    finally
                    {
                        Application.Exit();
                    }
                }
            }

            ///  
            /// Crea y muestra mensaje de Error.
            /// 
            private DialogResult MostrarMensajeDeError(Exception ex)
            {
                string errorMessage = @"ALGO SALIO MAL DURANTE LA EJECUCION DE FLUCOL. CIERRE EL PROGRAMA Y ENSEGUIDA, VUELVA A EJECUTARLO.\n\n\n
                                       PARA EQUIPO DE IMPLEMENTACION Y SISTEMAS, FAVOR CONSULTAR LOG DE ERRORES EN APP DATA PARA OBTENER MAS INFORMACION.";

                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(ex,
                                                  "program.cs",
                                                  "MostrarMensajeDeError(Exception ex)");
                v_depurador = null;

                return
                    MessageBox.Show(errorMessage, "FLUCOL | ERROR", MessageBoxButtons.AbortRetryIgnore,
                                    MessageBoxIcon.Stop);
            }
        } 

    }
}
