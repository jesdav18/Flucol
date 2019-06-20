using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Core.Clases;
using Devart.Data.PostgreSql;
using Operaciones.Pantallas;

namespace Operaciones.Controles
{
    public partial class ctlLoginOperacional : UserControl
    {

        #region INICIALIZADOR

        public ctlLoginOperacional()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_Sucursal { get; set; }
        public int Pro_Cliente { get; set; }
        public int Pro_ID_NivelAcceso { get; set; }
        public string Pro_DescripcionNivelAcceso { get; set; }
        public string Pro_NombreEmpleado { get; set; }
        public string Pro_CargoEmpleado { get; set; }
        public string Pro_UsuarioEmpleado { get; set; }
        public string Pro_CodigoEmpleado { get; set; }


        #endregion

        #region ENUMERACIONES

        public enum NIVELES_ACCESO
        {
            ADMINISTRACION = 1,
            OPERACIONAL = 2,
            SUPERVISOR = 3,
            INVITADO = 4
        }

        #endregion

        #region EVENTOS

        public event EventHandler OnUsuarioLogueado;

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion, int pSucursal, int pCliente)
        {
            Pro_Conexion = pConexion;
            Pro_Sucursal = pSucursal;
            Pro_Cliente = pCliente;
            txtUsuario.Focus();

            picLogoInstitucion.Image = Image.FromFile(ConfigurationSettings.AppSettings["RUTA_LOGO_INSTITUCION"]);

        }

        private bool ValidarUsuarioLogueo()
        {

            bool v_encontro_usuario = false;

            ValidarConexion();

            try
            {
                string sentencia = @"SELECT * FROM area_servicio.ft_proc_valida_usuario_acceso (
                                                                                                  :p_usuario,
                                                                                                  :p_contrasenia,
                                                                                                  :p_id_agencia_servicio,
                                                                                                  :p_id_cliente_servicio
                                                                                                  
                                                                                                );";
                PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
                pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = txtUsuario.Text;
                pgComando.Parameters.Add("p_contrasenia", PgSqlType.VarChar).Value = txtContrasenia.Text;
                pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_Sucursal;
                pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_Cliente;
                

                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    Pro_NombreEmpleado = pgDr.GetString("nombre_empleado");
                    Pro_UsuarioEmpleado = pgDr.GetString("usuario_empleado");
                    Pro_ID_NivelAcceso = pgDr.GetInt32("id_nivel_acceso_empleado");
                    Pro_DescripcionNivelAcceso = pgDr.GetString("nivel_acceso_empleado");
                    Pro_CargoEmpleado = pgDr.GetString("cargo_empleado");
                    Pro_CodigoEmpleado = pgDr.GetString("codigo_empleado");
                    v_encontro_usuario = true;
                }

                pgDr.Close();

                sentencia = null;
                pgDr = null;
                pgComando.Dispose();


                if (v_encontro_usuario)
                {
                    if ((NIVELES_ACCESO) Pro_ID_NivelAcceso == NIVELES_ACCESO.OPERACIONAL)
                    {
                        if (CargarDatosTicketPosicion())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }

            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "FLUCOL");
                txtUsuario.Focus();
                return false;    
            }

        }

        private bool CargarDatosTicketPosicion()
        {
            string v_datos_posicion = null;
            ValidarConexion();

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_proc_devuelve_posicion_asignada (
                                                                                                :p_usuario, 
                                                                                                :p_agencia,
                                                                                                :p_cliente
                                                                                                );";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = Pro_UsuarioEmpleado;
            pgComando.Parameters.Add("p_agencia", PgSqlType.Int).Value = Pro_Sucursal;
            pgComando.Parameters.Add("p_cliente", PgSqlType.Int).Value = Pro_Cliente;

            try
            {

                PgSqlDataReader pgDr = pgComando.ExecuteReader();

                if (pgDr.Read())
                {
                    
                    v_datos_posicion = ConfigurationSettings.AppSettings["TEXTO_DESCRIPTIVO"] + " " +
                                       pgDr.GetString("posicion");
                }


                pgDr.Close();
                pgDr = null;
                pgComando.Dispose();
                sentencia = null;

                if (string.IsNullOrEmpty(v_datos_posicion))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception Exc)
            {
                DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                v_depurador.CapturadorExcepciones(Exc,
                                                  this.Name,
                                                  "CargarDatosTicketPosicion()");
                v_depurador = null;
                MessageBox.Show(Exc.Message, "FLUCOL");
                return false;
            }
        }

        private void ValidarConexion()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                try
                {
                    Pro_Conexion.Open();
                }
                catch (Exception Exc)
                {
                    DepuradorExcepciones v_depurador = new DepuradorExcepciones();
                    v_depurador.CapturadorExcepciones(Exc,
                                                      this.Name,
                                                      "ValidarConexion()");
                    v_depurador = null;

                    PgSqlConnection v_conexion = new PgSqlConnection(Pro_Conexion.ConnectionString);
                    v_conexion.Password = Pro_Conexion.Password;
                    Pro_Conexion = v_conexion;
                    Pro_Conexion.Open();
                    v_conexion = null;
                }
            }
        }


        #endregion

        #region EVENTOS CONTROLES

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarUsuarioLogueo())
            {
                Usuario c_Usuario = new Usuario();
                c_Usuario.Pro_CodigoEmpleado = Pro_CodigoEmpleado;
                c_Usuario.Pro_NombreEmpleado = Pro_NombreEmpleado;
                c_Usuario.Pro_Usuario = Pro_UsuarioEmpleado;
                c_Usuario.Pro_CargoEmpleado = Pro_CargoEmpleado;
                c_Usuario.Pro_ID_NivelAcceso = Pro_ID_NivelAcceso;
                c_Usuario.Pro_Descripcion_NivelAcceso = Pro_DescripcionNivelAcceso;

                OnUsuarioLogueado?.Invoke(c_Usuario, e);
                c_Usuario = null;
            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContrasenia.Focus();
            }

            if (e.KeyCode == Keys.Down)
            {
                txtContrasenia.Focus();
            }
        }

        private void txtContrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdIngresar_Click(sender, e);
            }

            if (e.KeyCode == Keys.Up)
            {
                txtUsuario.Focus();
            }
        }

        private void cmdIngresar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtContrasenia.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                cmdCerrar.Focus();
            }
        }

        private void cmdCerrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtContrasenia.Focus();
            }

            if (e.KeyCode == Keys.Left)
            {
                cmdIngresar.Focus();
            }
        }

        #endregion
    }
}
