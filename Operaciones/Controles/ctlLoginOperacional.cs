using System;
using System.Data;
using System.Windows.Forms;
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
            GERENCIA = 1,
            OPERACIONAL = 2,
            ADMINISTRACION = 3,
            INVITADO = 4
        }


        #endregion

        #region VARIABLES GLOBALES

        NIVELES_ACCESO vNivelAcceso;

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
            
        }

        private bool ValidarUsuarioLogueo()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            try
            {
                string sentencia = @"SELECT * FROM area_servicio.ft_proc_valida_usuario_acceso (
                                                                                                  :p_usuario,
                                                                                                  :p_contrasenia,
                                                                                                  :p_id_cliente_servicio,
                                                                                                  :p_id_agencia_servicio
                                                                                                );";
                PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
                pgComando.Parameters.Add("p_usuario", PgSqlType.VarChar).Value = txtUsuario.Text;
                pgComando.Parameters.Add("p_contrasenia", PgSqlType.VarChar).Value = txtContrasenia.Text;
                pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_Cliente;
                pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_Sucursal;

                PgSqlDataReader pgDr = pgComando.ExecuteReader();
                if (pgDr.Read())
                {
                    Pro_NombreEmpleado = pgDr.GetString("nombre_empleado");
                    Pro_UsuarioEmpleado = pgDr.GetString("usuario_empleado");
                    Pro_ID_NivelAcceso = pgDr.GetInt32("id_nivel_acceso_empleado");
                    Pro_DescripcionNivelAcceso = pgDr.GetString("nivel_acceso_empleado");
                    Pro_CargoEmpleado = pgDr.GetString("cargo_empleado");
                    Pro_CodigoEmpleado = pgDr.GetString("codigo_empleado");
                }

                pgDr.Close();

                sentencia = null;
                pgDr = null;
                pgComando.Dispose();

                return true;


            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "FLUCOL");
                txtUsuario.Focus();
                return false;    
            }

        }

        private void RedireccionPantallasSegunNivelAcceso()
        {
            vNivelAcceso = (NIVELES_ACCESO) Pro_ID_NivelAcceso;

            switch (vNivelAcceso)
            {
                case NIVELES_ACCESO.GERENCIA:
                    break;
                case NIVELES_ACCESO.OPERACIONAL:
                    frmOperaciones frmOperacional = new frmOperaciones(Pro_Conexion,
                                                                       Pro_Sucursal,
                                                                       Pro_Cliente,
                                                                       Pro_ID_NivelAcceso,
                                                                       Pro_NombreEmpleado,
                                                                       Pro_UsuarioEmpleado,
                                                                       Pro_DescripcionNivelAcceso,
                                                                       Pro_CargoEmpleado,
                                                                       Pro_CodigoEmpleado);
                    frmOperacional.Show();
                    break;
                case NIVELES_ACCESO.ADMINISTRACION:
                    break;
                case NIVELES_ACCESO.INVITADO:
                    break;
             
            }
        }


        #endregion

        #region EVENTOS CONTROLES

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarUsuarioLogueo())
            {
                RedireccionPantallasSegunNivelAcceso();
                OnUsuarioLogueado?.Invoke(sender, e);
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
                cmdIngresar.Focus();
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
