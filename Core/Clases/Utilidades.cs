
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
    }
}
