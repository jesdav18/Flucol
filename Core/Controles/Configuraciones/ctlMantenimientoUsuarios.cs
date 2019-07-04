using System;
using System.Data;
using System.Windows.Forms;
using Core.Clases;
using Devart.Data.PostgreSql;

namespace Core.Controles.Configuraciones
{
    public partial class ctlMantenimientoUsuarios : UserControl
    {

        #region INICIALIZADOR

        public ctlMantenimientoUsuarios()
        {
            InitializeComponent();
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_ClienteServicio { get; set; }
        public int Pro_ID_AgenciaServicio { get; set; }
        public string Pro_Usuario { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pID_AgenciaServicio,
                                     int pID_ClienteServicio,
                                     string pUsuario)
        {
            LimpiarCajasTexto();
            Pro_Conexion = pConexion;
            Pro_ID_AgenciaServicio = pID_AgenciaServicio;
            Pro_ID_ClienteServicio = pID_ClienteServicio;
            Pro_Usuario = pUsuario;          
        }

        private void CargarDatosAgenciasServicio()
        {
            ValidarConexion();

            string sentencia = @"SELECT * FROM area_servicio.ft_view_agencias_servicio_disponibles(:p_id_cliente_servicio,
                                                                                                   :p_id_agencia_servicio);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_ClienteServicio;
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
            try
            {
                dsConfiguraciones1.dtAgenciasServicio.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguraciones1.dtAgenciasServicio);

                sentencia = null;
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {

                MessageBox.Show("ALGO SALIÓ MAL EN LA CARGA DE AGENCIA SERVICIO. " + Exc.Message,"FLUCOL");
            }
        }

        private void CargarDatosCargosDisponibles()
        {
            ValidarConexion();

            string sentencia = @"SELECT * FROM area_servicio.ft_view_cargos_disponibles();";                                                                                        
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            
            try
            {
                dsConfiguraciones1.dtCargosEmpleados.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguraciones1.dtCargosEmpleados);

                sentencia = null;
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {

                MessageBox.Show("ALGO SALIÓ MAL EN LA CARGA DE LOS CARGOS DE EMPLEADO. " + Exc.Message,"FLUCOL");
            }
        }

        private void RegistrarEmpleado()
        {

            ValidarConexion();

            string sentencia = @"SELECT * FROM area_servicio.ft_proc_registrar_empleado(:pID_ClienteServicio,
                                                                                        :pID_AgenciaServicio,
                                                                                        :pUsuario,
                                                                                        :pCodigoEmpleado,                                           
                                                                                        :pPrimerNombre,
                                                                                        :pSegundoNombre,
                                                                                        :pPrimerApellido,
                                                                                        :pSegundoApellido,
                                                                                        :pIdentidad,
                                                                                        :pID_Cargo,
                                                                                        :pID_AgenciaAsignacion,
                                                                                        :pUsuarioEmpleado,
                                                                                        :pContraseniaTemporal
                                                                                        );";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("pID_ClienteServicio",PgSqlType.Int).Value = Pro_ID_ClienteServicio;
            pgComando.Parameters.Add("pID_AgenciaServicio", PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
            pgComando.Parameters.Add("pUsuario", PgSqlType.VarChar).Value = Pro_Usuario;
            pgComando.Parameters.Add("pCodigoEmpleado", PgSqlType.VarChar).Value = txtCodigoEmpleado.Text;
            pgComando.Parameters.Add("pPrimerNombre", PgSqlType.VarChar).Value = txtPrimerNombre.Text;
            pgComando.Parameters.Add("pSegundoNombre", PgSqlType.VarChar).Value = txtSegundoNombre.Text;
            pgComando.Parameters.Add("pPrimerApellido", PgSqlType.VarChar).Value = txtPrimerApellido.Text;
            pgComando.Parameters.Add("pSegundoApellido", PgSqlType.VarChar).Value = txtSegundoApellido.Text;
            pgComando.Parameters.Add("pIdentidad", PgSqlType.VarChar).Value = txtIdentidadEmpleado.Text;
            pgComando.Parameters.Add("pID_Cargo", PgSqlType.Int).Value = gridCargos.EditValue;
            pgComando.Parameters.Add("pID_AgenciaAsignacion", PgSqlType.Int).Value = gridAgencias.EditValue;
            pgComando.Parameters.Add("pUsuarioEmpleado", PgSqlType.VarChar).Value = txtUsuario.Text;
            pgComando.Parameters.Add("pContraseniaTemporal", PgSqlType.VarChar).Value = txtContraseniaTemporal.Text;

            try
            {
                pgComando.ExecuteNonQuery();

                sentencia = null;
                pgComando.Dispose();

                MessageBox.Show("EMPLEADO REGISTRADO EXITOSAMENTE", "FLUCOL");

                LimpiarCajasTexto();
                NavigationEmpleados.SelectedPage = pagePrimeraPagina;

            }
            catch (Exception Exc)
            {
                MessageBox.Show("ALGO SALIO EN EL MOMENTO DE REGISTRAR EL EMPLEADO. " + Exc.Message, "FLUCOL");
            }
        }

        private void ReinicioImagenesIcono()
        {
            cmdCrearUsuarios.Image = Properties.Resources.icon_nuevo_usuario_negro_64;
            cmdModicarUsuarios.Image = Properties.Resources.icon_usuario_configuracion_negro_64;
        }

        private bool ValidarCamposObligatorios()
        {
            int v_contador_errores = 0;

            if (string.IsNullOrEmpty(txtCodigoEmpleado.Text))
            {
                epProveedorErrores.SetError(txtCodigoEmpleado, "INGRESE CODIGO DE EMPLEADO");
                epProveedorErrores.SetError(cmdIrAtras, "ALGUNOS CAMPOS EN LA PAGINA ANTERIOR NECESITAN LLENARSE.");
                v_contador_errores++;
            }

            if (string.IsNullOrEmpty(txtPrimerNombre.Text))
            {
                epProveedorErrores.SetError(txtPrimerNombre, "INGRESE PRIMER NOMBRE");
                epProveedorErrores.SetError(cmdIrAtras, "ALGUNOS CAMPOS EN LA PAGINA ANTERIOR NECESITAN LLENARSE.");
                v_contador_errores++;
            }

            if (string.IsNullOrEmpty(txtPrimerApellido.Text))
            {
                epProveedorErrores.SetError(txtPrimerApellido, "INGRESE PRIMER APELLIDO");
                epProveedorErrores.SetError(cmdIrAtras, "ALGUNOS CAMPOS EN LA PAGINA ANTERIOR NECESITAN LLENARSE.");
                v_contador_errores++;
            }

            if (string.IsNullOrEmpty(txtIdentidadEmpleado.Text))
            {
                epProveedorErrores.SetError(txtIdentidadEmpleado, "INGRESE NUMERO DE IDENTIDAD");
                v_contador_errores++;
            }

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                epProveedorErrores.SetError(txtUsuario, "INGRESE USUARIO");
                v_contador_errores++;
            }

            if (string.IsNullOrEmpty(txtContraseniaTemporal.Text))
            {
                epProveedorErrores.SetError(txtContraseniaTemporal, "INGRESE UNA CONTRASEÑA");
                v_contador_errores++;
            }

            if (v_contador_errores == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LimpiarCajasTexto()
        {
            txtIdentidadEmpleado.Text = "";
            txtCodigoEmpleado.Text = "";
            txtPrimerNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtSegundoNombre.Text = "";
            gridCargos.EditValue = "";
            gridAgencias.EditValue = "";
            txtUsuario.Text = "";
            txtContraseniaTemporal.Text = "";
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

        private void cmdCrearUsuarios_Click(object sender, EventArgs e)
        {
            ReinicioImagenesIcono();
            cmdCrearUsuarios.Image = Properties.Resources.icon_nuevo_usuario_verde_64;
            NavigationPrincipal.SelectedPage = pageCrearUsuarios;
        }

        private void cmdModicarUsuarios_Click(object sender, EventArgs e)
        {
            ReinicioImagenesIcono();
            cmdModicarUsuarios.Image = Properties.Resources.icon_configuracion_verde_64;
            NavigationPrincipal.SelectedPage = pageConfiguracionUsuarios;
        }

        private void cmdRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            if (ValidarCamposObligatorios())
            {
                RegistrarEmpleado();
            }           
        }

        private void cmdSiguiente_Click(object sender, EventArgs e)
        {
            txtIdentidadEmpleado.Focus();
            CargarDatosAgenciasServicio();
            CargarDatosCargosDisponibles();
            NavigationEmpleados.SelectedPage = pageSegundaPagina;
        }

        private void cmdIrAtras_Click(object sender, EventArgs e)
        {
            txtCodigoEmpleado.Focus();
            NavigationEmpleados.SelectedPage = pagePrimeraPagina;
        }

        #endregion
    }
}
