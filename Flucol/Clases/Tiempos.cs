using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flucol
{
    class Tiempos
    {
        public DateTime Pro_Tiempo_Inicio_Cola { get; set; }
        public DateTime Pro_Tiempo_Finalizacion_Cola { get; set; }
        public DateTime Pro_Tiempo_Inicio_Espera { get; set; }
        public DateTime Pro_Tiempo_Finalizacion_Espera { get; set; }
        public DateTime Pro_Tiempo_Inicio_Atencion { get; set; }
        public DateTime Pro_Tiempo_Finalizacion_Atencion { get; set; }

        public void Iniciar_Tiempo_Cola()
        {

        }

        public void Finalizar_Tiempo_Cola()
        {

        }

        public void Iniciar_Tiempo_Espera()
        {

        } 

        public void Finalizar_Tiempo_Espera()
        {

        }

        public void Iniciar_Tiempo_Atencion()
        {

        }

        public void Finalizar_Tiempo_Atencion()
        {

        }
    }
}
