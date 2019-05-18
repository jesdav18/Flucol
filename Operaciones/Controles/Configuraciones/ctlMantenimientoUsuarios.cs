using System;
using System.Data;
using System.Windows.Forms;
using Devart.Data.PostgreSql;

namespace Operaciones.Controles.Configuraciones
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
            Pro_Conexion = pConexion;
            Pro_ID_AgenciaServicio = pID_AgenciaServicio;
            Pro_ID_ClienteServicio = pID_ClienteServicio;
            Pro_Usuario = pUsuario;
        }

        private void CargarDatosAgenciasServicio()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

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

                MessageBox.Show("Algo salió mal en la carga de agencia servicio. " + Exc.Message);
            }
        }

        private void CargarDatosCargosDisponibles()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

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

                MessageBox.Show("Algo salió mal en la carga de los cargos de empleado. " + Exc.Message);
            }
        }

        private void RegistrarEmpleado()
        {
            
            if (Pro_Conexion.State != System.Data.ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

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

                MessageBox.Show("Empleado Registrado Exitosamente");

            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salio en el momento de registrar el empleado. " + Exc.Message);
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
                epProveedorErrores.SetError(txtCodigoEmpleado, "Ingrese Codigo de Empleado");
                epProveedorErrores.SetError(cmdIrAtras, "Algunos campos en la pagina anterior necesitan llenarse.");
                v_contador_errores++;
            }

            if (string.IsNullOrEmpty(txtPrimerNombre.Text))
            {
                epProveedorErrores.SetError(txtPrimerNombre, "Ingrese Primer Nombre");
                epProveedorErrores.SetError(cmdIrAtras, "Algunos campos en la pagina anterior necesitan llenarse.");
                v_contador_errores++;
            }

            if (string.IsNullOrEmpty(txtPrimerApellido.Text))
            {
                epProveedorErrores.SetError(txtPrimerApellido, "Ingrese Primer Apellido");
                epProveedorErrores.SetError(cmdIrAtras, "Algunos campos en la pagina anterior necesitan llenarse.");
                v_contador_errores++;
            }

            if (string.IsNullOrEmpty(txtIdentidadEmpleado.Text))
            {
                epProveedorErrores.SetError(txtIdentidadEmpleado, "Ingrese Numero de Identidad");
                v_contador_errores++;
            }

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                epProveedorErrores.SetError(txtUsuario, "Ingrese Usuario");
                v_contador_errores++;
            }

            if (string.IsNullOrEmpty(txtContraseniaTemporal.Text))
            {
                epProveedorErrores.SetError(txtContraseniaTemporal, "Ingrese una contraseña");
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
            CargarDatosAgenciasServicio();
            CargarDatosCargosDisponibles();
            NavigationEmpleados.SelectedPage = pageSegundaPagina;
        }

        private void cmdIrAtras_Click(object sender, EventArgs e)
        {
            NavigationEmpleados.SelectedPage = pagePrimeraPagina;
        }

        #endregion
    }
}
