using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Clases
{
    public class DepuradorExcepciones
    {

        public void CapturadorExcepciones(Exception pExcepcion, 
                                          string pNombreControl,
                                          string pNombreFuncion)
        {
            try
            {
                AlmacenaArchivoExcepciones(pExcepcion,
                                           pNombreControl,
                                           pNombreFuncion);
            }
            catch (Exception ex)
            {
                AlmacenaArchivoExcepciones(ex, 
                                           "class DepuradorExcepcion",
                                           "CapturadorExcepciones");
            }
        }
        public void AlmacenaArchivoExcepciones(Exception pExcepcion, 
                                               string pNombreControl,
                                               string pNombreFuncion)
        {
            string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!filepath.EndsWith("\\"))
            {
                filepath += "\\";
            }

            filepath += DateTime.Today.ToString("dd-MM-yyyy") + ".txt";
            StreamWriter escritor = File.AppendText(filepath);
            escritor.WriteLine("-------------FLUCOL | DEPURACION-------------");
            escritor.WriteLine("Control o Clase: " + pNombreControl);
            escritor.WriteLine("Función donde se generó: " + pNombreFuncion);
            escritor.WriteLine("Mensaje: " + pExcepcion.Message + ".........." + DateTime.Now.ToString("hh:mm:ss"));
            escritor.WriteLine("Pila de Llamadas: " + pExcepcion.StackTrace);
            escritor.WriteLine("Target Site: " + pExcepcion.TargetSite.Name);
            escritor.WriteLine("Target Site: " + pExcepcion.TargetSite.Name);
            escritor.WriteLine("-------------------------------------------");
            escritor.WriteLine("\n\n");
            escritor.Close();
            escritor.Dispose();
        }
      
    }
}
