using System;
using System.Data;
using System.Windows.Forms;
using Core.DataSets;
using Devart.Data.PostgreSql;
using Core.Controles.Configuraciones.DataSets;

namespace Core.Controles.Configuraciones
{
    public partial class ctlAsignacionPosiciones : UserControl
    {

        #region INICIALIZADOR

        public ctlAsignacionPosiciones()
        {
            InitializeComponent();
            ctlPosicionesDisponibles1.OnSeleccionaPosicion += ctlPosicionesDisponibles1_OnSeleccionaPosicion;
            ctlTipoTicketServicio1.OnSeleccionaTipoTicketServicio += ctlTipoTicketServicio1_OnSeleccionaTipoTicketServicio;
        }

        #endregion

        #region PROPIEDADES

        public PgSqlConnection Pro_Conexion { get; set; }
        public int Pro_ID_Agencia_Servicio { get; set; }
        public int Pro_ID_Cliente_Servicio{ get; set; }
        public string Pro_UsuarioSeleccionado { get; set; }
        public string Pro_Usuario { get; set; }

        #endregion

        #region FUNCIONES

        public void ConstruirControl(PgSqlConnection pConexion,
                                     int pID_AgenciaServicio,
                                     int pID_ClienteServicio,
                                     string pUsuario,
                                     string pNombreSucursal)
        {

            splashScreenManager1.ShowWaitForm();

            Pro_Conexion = pConexion;
            Pro_ID_Agencia_Servicio = pID_AgenciaServicio;
            Pro_ID_Cliente_Servicio = pID_ClienteServicio;
            Pro_Usuario = pUsuario;
            lblTitulo.Text = "ASIGNACION DE POSICIONES PARA AGENCIA " + pNombreSucursal;

            CargarDatos();
            ctlPosicionesDisponibles1.ConstruirControl(Pro_Conexion,
                                                       Pro_ID_Agencia_Servicio,
                                                       Pro_ID_Cliente_Servicio);

            ctlTipoTicketServicio1.ConstruirControl(Pro_Conexion);

            splashScreenManager1.CloseWaitForm();

        }

        private void CargarDatos()
        {
            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_view_empleados_disponibles_para_asignacion_posiciones(:p_id_agencia_servicio,
                                                                                                                      :p_id_cliente_servicio)";

            PgSqlCommand pgComando = new PgSqlCommand(sentencia,Pro_Conexion);
            pgComando.Parameters.Add("p_id_agencia_servicio",PgSqlType.Int).Value = Pro_ID_Agencia_Servicio;
            pgComando.Parameters.Add("p_id_cliente_servicio",PgSqlType.Int).Value = Pro_ID_Cliente_Servicio;

            try
            {
                dsConfiguraciones1.dtAsignacionPosiciones.Clear();
                new PgSqlDataAdapter(pgComando).Fill(dsConfiguraciones1.dtAsignacionPosiciones);

                sentencia = null;
                pgComando.Dispose();

            }
            catch (Exception Exc)
            {
                MessageBox.Show("Algo salió mal en la carga de empleados disponibles. " + Exc.Message);
            }
        }

        private bool AsignarPosicion(int pPosicion, 
                                     int pID_TipoTicketServicio,
                                     string pUsuario)
        {
            bool v_respuesta = false;

            splashScreenManager1.ShowWaitForm();

            if (Pro_Conexion.State != ConnectionState.Open)
            {
                Pro_Conexion.Open();
            }

            string sentencia = @"SELECT * FROM area_servicio.ft_mant_asignar_posicion_a_empleado(:p_id_agencia_servicio,
                                                                                                 :p_id_cliente_servicio,
                                                                                                 :p_empleado_asignado,
                                                                                                 :p_usuario_posteo,
                                                                                                 :p_posicion_asignada,
                                                                                                 :p_id_tipo_ticket_servicio);";
            PgSqlCommand pgComando = new PgSqlCommand(sentencia, Pro_Conexion);
            pgComando.Parameters.Add("p_id_agencia_servicio", PgSqlType.Int).Value = Pro_ID_Agencia_Servicio;
            pgComando.Parameters.Add("p_id_cliente_servicio", PgSqlType.Int).Value = Pro_ID_Cliente_Servicio;
            pgComando.Parameters.Add("p_empleado_asignado", PgSqlType.VarChar).Value = pUsuario ;
            pgComando.Parameters.Add("p_usuario_posteo", PgSqlType.VarChar).Value = Pro_Usuario;
            pgComando.Parameters.Add("p_posicion_asignada", PgSqlType.Int).Value = pPosicion;
            pgComando.Parameters.Add("p_id_tipo_ticket_servicio", PgSqlType.Int).Value = pID_TipoTicketServicio;

            try
            {
                v_respuesta = (bool) pgComando.ExecuteScalar();
                sentencia = null;
                pgComando.Dispose(); 
               
            }
            catch (Exception Exc)
            {
                v_respuesta = false;
                MessageBox.Show(Exc.Message);
                
            }

            splashScreenManager1.CloseWaitForm();
            return v_respuesta;
        }

        #endregion

        #region EVENTOS CONTROLES

        private void cmdCargarPosiciones_Click(object sender, EventArgs e)
        {
            dsConfiguraciones.dtAsignacionPosicionesRow v_fila = (dsConfiguraciones.dtAsignacionPosicionesRow) gvEmpleadosDisponiblesAsignacion.GetFocusedDataRow();
            if (v_fila != null)
            {
                Pro_UsuarioSeleccionado = v_fila.usuario;
                popupPosicionesDisponibles.ShowPopup();           
            }
        }

        private void ctlPosicionesDisponibles1_OnSeleccionaPosicion(object sender, EventArgs e)
        {
            int v_posicion_anterior;
            dsCore.dtPosicionesDisponiblesRow v_fila = (dsCore.dtPosicionesDisponiblesRow)sender;

            if (v_fila != null)
            {
                popupPosicionesDisponibles.HidePopup();
                this.BringToFront();
                this.Focus();

                try
                {
                    foreach (dsConfiguraciones.dtAsignacionPosicionesRow iterador in dsConfiguraciones1.dtAsignacionPosiciones)
                    {
                        if (iterador.usuario == Pro_UsuarioSeleccionado)
                        {

                            if (iterador.Isposicion_asignadaNull())
                            {
                                v_posicion_anterior = 0;
                            }
                            else
                            {
                                v_posicion_anterior = iterador.posicion_asignada;
                            }

                            
                            iterador.posicion_asignada = v_fila.posicion;
                            iterador.tiene_cambios = true;
                            iterador.AcceptChanges();

                            foreach (dsCore.dtPosicionesDisponiblesRow iterador_posiciones in ctlPosicionesDisponibles1.dsCore1.dtPosicionesDisponibles)
                            {

                                if (iterador_posiciones.posicion == v_fila.posicion)
                                {
                                    if (v_posicion_anterior != 0)
                                    {
                                                                    
                                        iterador_posiciones.posicion = v_posicion_anterior;
                                        iterador.AcceptChanges();
                                    }

                                    break;
                                }

                            }

                            break;
                        }
                    }
                }
                catch (Exception Exc)
                {

                    MessageBox.Show("Algo salio mal");
                }
            }       
        }

        private void cmdAsignarPrioridadAtencion_Click(object sender, EventArgs e)
        {
            dsConfiguraciones.dtAsignacionPosicionesRow v_fila = (dsConfiguraciones.dtAsignacionPosicionesRow)gvEmpleadosDisponiblesAsignacion.GetFocusedDataRow();

            if (v_fila != null)
            {
                Pro_UsuarioSeleccionado = v_fila.usuario;
                popupTipoTickets.ShowPopup();               
            }
        }

        private void ctlTipoTicketServicio1_OnSeleccionaTipoTicketServicio(object sender, EventArgs e)
        {        
            dsCore.dtTipoTicketsRow v_fila = (dsCore.dtTipoTicketsRow)sender;

            if (v_fila != null)
            {
                popupTipoTickets.HidePopup();
                this.BringToFront();
                this.Focus();

                try
                {           
                    foreach (dsConfiguraciones.dtAsignacionPosicionesRow iterador in dsConfiguraciones1.dtAsignacionPosiciones)
                    {
                        if (iterador.usuario == Pro_UsuarioSeleccionado)
                        {                   
                            iterador.descripcion_tipo_ticket = v_fila.descripcion;
                            iterador.tiene_cambios = true;
                            iterador.id_tipo_ticket = v_fila.id_tipo_ticket_servicio;
                            iterador.AcceptChanges();

                            break;
                        }
                    }
                }
                catch (Exception Exc)
                {
                    MessageBox.Show("Algo salio mal");
                }
            }         
        }

        public bool ValidarSiHayCambiosSinGuardar()
        {
            bool v_respuesta = false;
            foreach (dsConfiguraciones.dtAsignacionPosicionesRow iterador in dsConfiguraciones1.dtAsignacionPosiciones)
            {
                if (iterador.tiene_cambios)
                {
                    v_respuesta = true;
                    break;
                }
            }

             return v_respuesta;
        }


        private void cmdGuardaraCambios_Click(object sender, EventArgs e)
        {
            bool v_respuesta = false;

            try
            {
                foreach (dsConfiguraciones.dtAsignacionPosicionesRow iterador in dsConfiguraciones1.dtAsignacionPosiciones)
                {
                    if (iterador.tiene_cambios)
                    {

                        if (!iterador.Isid_tipo_ticketNull() &&
                        !iterador.Isposicion_asignadaNull())
                        {
                            if (
                                 AsignarPosicion(
                                                    iterador.posicion_asignada,
                                                    iterador.id_tipo_ticket,
                                                    iterador.usuario 
                                                 
                                                ) )
                            {
                                v_respuesta = true;
                            }
                        }
                        else
                        {
                            if (iterador.Isid_tipo_ticketNull() && 
                                iterador.Isposicion_asignadaNull())
                            {
                                MessageBox.Show("AUN NO SE HA ASIGNADO UNA POSICION, NI EL TIPO DE FILA QUE ATENDERA " + iterador.nombre_empleado,"FLUCOL");
                            }
                            else if(iterador.Isposicion_asignadaNull()){
                                MessageBox.Show("NO SE HA ASIGNADO UNA POSICION A " + iterador.nombre_empleado);
                            }
                            else if(iterador.Isid_tipo_ticketNull())
                            {
                                MessageBox.Show("NO SE HA ASIGNADO UN TIPO DE FILA A " + iterador.nombre_empleado);
                            }

                            break;

                        }
                                    
                    }
                                    
                }

                if (v_respuesta)
                {
                    MessageBox.Show("LA ASIGNACIÓN DE POSICIONES HA CONCLUIDO DE MANERA CORRECTA.", "FLUCOL");
                    CargarDatos();
                }

            }
            catch (Exception Exc)
            {
                MessageBox.Show("ALGO SALIO MAL EN LA ASIGNACION DE POSICIONES. " + Exc.Message);
            }
        }

        #endregion
    }
}
