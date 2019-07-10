using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Core.Clases;
using Core.Controles.Configuraciones.DataSets;
using Devart.Data.PostgreSql;
using DevExpress.XtraEditors;

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
        public bool Pro_Habilitar { get; set; }
        public bool Pro_ModoEdicion {
            get
            {
                return v_modo_edicion;
            }
            set
            {
                v_modo_edicion = value;
                if (v_modo_edicion)
                {
                    lblTitulo.Text = "EDICION DE EMPLEADO";
                    cmdRegistrarEmpleado.Text = "GUARDAR CAMBIOS";

                    lblUsuario.Visible = false;
                    txtUsuario.Visible = false;
                    lblContraseniaTemporal.Visible = false;
                    txtContraseniaTemporal.Visible = false;

                    picIrAtras.Visible = true;
                }
                else
                {
                    lblTitulo.Text = "REGISTRO DE EMPLEADO";
                    cmdRegistrarEmpleado.Text = "REGISTRAR EMPLEADO";

                    lblUsuario.Visible = true;
                    txtUsuario.Visible = true;
                    lblContraseniaTemporal.Visible = true;
                    txtContraseniaTemporal.Visible = true;

                    picIrAtras.Visible = false;

                }
            }
        }

        #endregion

        #region VARIABLES GLOBALES

        bool v_modo_edicion;

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pID_AgenciaServicio,
                                     int pID_ClienteServicio,
                                     string pUsuario,
                                     string pNombreSucursal
                                     )
        {
            LimpiarCajasTexto();
            Pro_Conexion = pConexion;
            Pro_ID_AgenciaServicio = pID_AgenciaServicio;
            Pro_ID_ClienteServicio = pID_ClienteServicio;
            Pro_Usuario = pUsuario;

            NavigationPrincipal.SelectedPage = pageInicial;

            lblListaEmpleados.Text = "LISTA DE EMPLEADOS EN AGENCIA " + pNombreSucursal;
            CargarDatosEmpleados();
          
        }

        private void CargarDatosEmpleados()
        {
            ValidarConexion();

            string sentencia = @"SELECT * FROM area_servicio.ft_view_empleados_usuarios(:p_id_agencia_servicio,
                                                                                        :p_id_cliente_servicio);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_agencia_servicio",PgSqlType.Int).Value = Pro_ID_AgenciaServicio;
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_ClienteServicio;

            try
            {
                dsConfiguraciones1.dtListaEmpleados.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguraciones1.dtListaEmpleados);

                sentencia = null;
                pgComando.Dispose();
            }
            catch (Exception Exc)
            {

                MessageBox.Show("ALGO SALIÓ MAL EN LA CARGA DE AGENCIA SERVICIO. " + Exc.Message, "FLUCOL");
            }
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

            string sentencia = @"SELECT * FROM area_servicio.ft_mant_registrar_empleado(:pID_ClienteServicio,
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

        private void HabilitarDeshabilitarEmpleado(string pCodigoEmpleado, bool pHabilitar)
        {
            ValidarConexion();

            string sentencia = @"SELECT * FROM area_servicio.ft_mant_habilitar_deshabilitar_empleado(:pCodigoEmpleado,
                                                                                                     :pHabilitar,
                                                                                                     :pUsuario);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);          
            pgComando.Parameters.Add("pCodigoEmpleado", PgSqlType.VarChar).Value = pCodigoEmpleado;
            pgComando.Parameters.Add("pHabilitar", PgSqlType.Boolean).Value = pHabilitar;
            pgComando.Parameters.Add("pUsuario", PgSqlType.VarChar).Value = Pro_Usuario;

            try
            {
                pgComando.ExecuteNonQuery();

                sentencia = null;
                pgComando.Dispose();

            }
            catch (Exception Exc)
            {
                MessageBox.Show("ALGO SALIO EN EL MOMENTO DE REGISTRAR EL EMPLEADO. " + Exc.Message, "FLUCOL");
            }
        }

        private void EditarEmpleado()
        {
            ValidarConexion();

            string sentencia = @"SELECT * FROM area_servicio.ft_mant_editar_empleado(:pID_ClienteServicio,
                                                                                        :pID_AgenciaServicio,
                                                                                        :pUsuario,
                                                                                        :pCodigoEmpleado,                                           
                                                                                        :pPrimerNombre,
                                                                                        :pSegundoNombre,
                                                                                        :pPrimerApellido,
                                                                                        :pSegundoApellido,
                                                                                        :pIdentidad,
                                                                                        :pID_Cargo,
                                                                                        :pID_AgenciaAsignacion                                                                                       
                                                                                        );";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("pID_ClienteServicio", PgSqlType.Int).Value = Pro_ID_ClienteServicio;
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
           

            try
            {
                pgComando.ExecuteNonQuery();

                sentencia = null;
                pgComando.Dispose();

                MessageBox.Show("EMPLEADO EDITADO EXITOSAMENTE", "FLUCOL");

                LimpiarCajasTexto();
                NavigationEmpleados.SelectedPage = pagePrimeraPagina;

            }
            catch (Exception Exc)
            {
                MessageBox.Show("ALGO SALIO EN EL MOMENTO DE EDITAR EL EMPLEADO. " + Exc.Message, "FLUCOL");
            }
        }

        private void CargarDatosEmpleadoParaEdicion(string pCodigoEmpleado)
        {
            ValidarConexion();

            string sentencia = @"SELECT * FROM area_servicio.ft_view_datos_empleado_para_edicion(:pCodigoEmpleado);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);           
            pgComando.Parameters.Add("pCodigoEmpleado", PgSqlType.VarChar).Value = pCodigoEmpleado;
            
            try
            {
                PgSqlDataReader pgDr = pgComando.ExecuteReader();

                int v_id_cargo = 0;
                int v_id_agencia = 0;

                while (pgDr.Read())
                {
                    txtCodigoEmpleado.Text = pgDr.GetString("codigo_empleado");
                    txtPrimerNombre.Text = pgDr.GetString("primer_nombre");
                    txtSegundoNombre.Text = pgDr.GetString("segundo_nombre");
                    txtPrimerApellido.Text = pgDr.GetString("primer_apellido");
                    txtSegundoApellido.Text = pgDr.GetString("segundo_apellido");
                    txtIdentidadEmpleado.Text = pgDr.GetString("identidad_empleado");
                    v_id_cargo = pgDr.GetInt32("id_cargo");
                    v_id_agencia = pgDr.GetInt32("id_agencia");
                }

                foreach (dsConfiguraciones.dtCargosEmpleadosRow iterador in dsConfiguraciones1.dtCargosEmpleados)
                {
                    if (iterador.id_cargo == v_id_cargo)
                    {
                        gridCargos.EditValue = iterador.id_cargo;
                        break;
                    }
                }

                foreach (dsConfiguraciones.dtAgenciasServicioRow iterador in dsConfiguraciones1.dtAgenciasServicio)
                {
                    if (iterador.id_agencia_servicio == v_id_agencia)
                    {
                        gridAgencias.EditValue = iterador.id_agencia_servicio;
                        break;
                    }
                }

                pgDr.Close();
                sentencia = null;
                pgComando.Dispose();

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
                
                v_contador_errores++;
            }

            if (string.IsNullOrEmpty(txtPrimerNombre.Text))
            {
                epProveedorErrores.SetError(txtPrimerNombre, "INGRESE PRIMER NOMBRE");
               
                v_contador_errores++;
            }

            if (string.IsNullOrEmpty(txtPrimerApellido.Text))
            {
                epProveedorErrores.SetError(txtPrimerApellido, "INGRESE PRIMER APELLIDO");
               
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
            Pro_ModoEdicion = false;
            LimpiarCajasTexto();
            ReinicioImagenesIcono();
            cmdCrearUsuarios.Image = Properties.Resources.icon_nuevo_usuario_verde_64;
            NavigationPrincipal.SelectedPage = pageCrearUsuarios;
            CargarDatosAgenciasServicio();
            CargarDatosCargosDisponibles();
        }

        private void cmdModicarUsuarios_Click(object sender, EventArgs e)
        {
            Pro_ModoEdicion = true;
            LimpiarCajasTexto();
            ReinicioImagenesIcono();
            cmdModicarUsuarios.Image = Properties.Resources.icon_configuracion_verde_64;
            NavigationPrincipal.SelectedPage = pageConfiguracionUsuarios;
        }

        private void cmdRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            if (ValidarCamposObligatorios())
            {
                if (Pro_ModoEdicion)
                {
                    EditarEmpleado();
                }
                else
                {
                    RegistrarEmpleado();
                }

                LimpiarCajasTexto();
                
            }           
        }

        private void PicBusquedaEmpleado_Click(object sender, EventArgs e)
        {
            popupBusquedaEmpleados.ShowPopup();
            pnlPopup.Size = new Size(popupBusquedaEmpleados.Size.Width, popupBusquedaEmpleados.Size.Height);
        }

        private void TxtBusquedaEmpleado_TextChanged(object sender, EventArgs e)
        {
            gvListaEmpleados.FindFilterText = "\"" + txtBusquedaEmpleado.Text + "\"";
        }

        private void PopupBusquedaEmpleados_Hidden(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            pnlPopup.Size = new Size(1213, 5);
            this.BringToFront();
            this.Select();
        }

        private void CmdEditarEmpleado_Click(object sender, EventArgs e)
        {
            
            Pro_ModoEdicion = true;
            NavigationPrincipal.SelectedPage = pageCrearUsuarios;

            var v_fila = (dsConfiguraciones.dtListaEmpleadosRow)gvListaEmpleados.GetFocusedDataRow();
            if (v_fila != null)
            {
                CargarDatosEmpleadoParaEdicion(v_fila.codigoempleado);
            }
  
        }

        #endregion

        private void ChkHabilitar_Deshabilitar_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            var v_fila = (dsConfiguraciones.dtListaEmpleadosRow)gvListaEmpleados.GetFocusedDataRow();

            Pro_Habilitar = !v_fila.habilitado;

            foreach (dsConfiguraciones.dtListaEmpleadosRow iterador in dsConfiguraciones1.dtListaEmpleados)
            {
                if (iterador.codigoempleado == v_fila.codigoempleado)
                {
                    iterador.habilitado = Pro_Habilitar;
                    iterador.AcceptChanges();
                    break;
                }

                
            }

            CargarDatosCargosDisponibles();
            CargarDatosAgenciasServicio();


            HabilitarDeshabilitarEmpleado(v_fila.codigoempleado, Pro_Habilitar);
        }

        private void PicIrAtras_Click(object sender, EventArgs e)
        {
            NavigationPrincipal.SelectedPage = pageConfiguracionUsuarios;
        }
    }
}
