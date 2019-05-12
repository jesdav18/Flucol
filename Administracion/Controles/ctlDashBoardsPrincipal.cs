using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using System.Configuration;
using System.Net.Sockets;
using System.Net;

namespace Administracion.Controles
{
    public partial class ctlDashBoardsPrincipal : UserControl
    {
        #region INICIALIZADOR

        public ctlDashBoardsPrincipal()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Cliente_Servicio { get; set; }
        public int Pro_ID_Agencia_Servicio { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, 
                                     int pID_ClienteServicio,
                                     int pID_AgenciaServicio)
        {
            picLogoCliente.Image = Image.FromFile(ConfigurationSettings.AppSettings["RUTA_LOGO_INSTITUCION"]);

            Pro_Conexion = pConexion;
            Pro_ID_Cliente_Servicio = pID_ClienteServicio;
            Pro_ID_Agencia_Servicio = pID_AgenciaServicio;

            
        }

        private void CargarDatos()
        {
            ssmDashboardsPrincipal.ShowWaitForm();

            ctlEmpleadoConMasTicketsAtendidos1.ConstruirControl(Pro_Conexion,
                                                                4,
                                                                Pro_ID_Agencia_Servicio,
                                                                Pro_ID_Cliente_Servicio);

            ctlTicketsAtendidos_TicketsNoAtendidos1.ConstruirControl(Pro_Conexion,
                                                                     Pro_ID_Cliente_Servicio,
                                                                     Pro_ID_Agencia_Servicio,
                                                                     4);
            ctlVisitasSegunPrioridadServicio1.ConstruirControl(Pro_Conexion,
                                                               Pro_ID_Cliente_Servicio,
                                                               Pro_ID_Agencia_Servicio,
                                                               4);
            
            navegacionDasboards.SelectedPage = pageDashBoardsPrincipal;
            ssmDashboardsPrincipal.CloseWaitForm();
        }

        private void bgCargaDashboards_DoWork(object sender, DoWorkEventArgs e)
        {
            

        }

        private void cmdDashboards_Click(object sender, EventArgs e)
        {

            /*if (!bgCargaDashboards.IsBusy)
            {
                bgCargaDashboards.RunWorkerAsync();
            }*/

            CargarDatos();

            
        }

        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Socket obj_socket = new Socket(AddressFamily.InterNetwork,
                                            SocketType.Unknown,
                                            ProtocolType.Tcp);

            IPEndPoint obj_direccion = new IPEndPoint(IPAddress.Parse("127.0.0.1"),
                                                      1234);

            obj_socket.Connect(obj_direccion);
            obj_socket.Listen(5);

            listBox1.Items.Add("Conectado.....");



            string v_info = "Hola Jesuar";
            byte[] v_cadena_bytes = Encoding.Default.GetBytes(v_info);

            obj_socket.Send(v_cadena_bytes, 0, v_info.Length, 0);
            obj_socket.Close();

            

           
        }
    }
}
