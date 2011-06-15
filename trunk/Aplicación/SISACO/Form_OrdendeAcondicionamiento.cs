using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BL_SISACO;
using BO_SISACO;

namespace SISACO
{
    public partial class Form_OrdendeAcondicionamiento : Form 
    {
        #region constantes
        #region Configuracion
        private const int contIndexInit = 0;
        private const char constSeparadorIdentificador = ';';
        #endregion
        #region Constantes para pestañas
        #region Pestaña:Registro de Codificacion
        #region Estados
        private const string constConforme = "Conforme";
        private const string constNoConforme = "No Conforme";
        private const string constNoAplica = "No Aplica";
        #endregion
        #region Areas
        private const string constAreaArea = "Area";
        private const string constAreaEquiposEInstalaciones = "Equipos e Instalaciones";
        private const string constAreaDocumentacion = "Documentación";
        private const string constAreaMaterialesEInsumos = "Materiales e Insumos";
        private const string constAreaPersonales = "Personales";
        #endregion
        #region Especificaciones
        private const string constLimpia = "Limpia";
        private const string constOrdenada = "Ordenada";
        private const string constLibreDeProductoAnterior = "Libre de Producto Anterior";
        private const string constIdetificada = "Identificada";
        private const string constMaterialesLimpiosYSecos = "Materiales Limpios y Secos";
        private const string constCorrectaIluminacionYVentilacion = "Correcta Iluminación y Ventilación";
        private const string constLimpios = "Limpios";
        private const string constIdentificados = "Identificados";
        private const string constBalanzasCalibradasYVerificadas = "Balanzas Calibradas y Verificadas";
        private const string constHumedadRelativa = "Humedad Relativa";
        private const string constDiferencialDePresion = "Diferencial de Presión (Pulg. de Agua)";
        private const string constTemperatura = "Temperatura ( < 25°C)";
        private const string constRegistroManufactura = "Registro de Manufactura";
        private const string constEtiquetas = "Etiquetas";
        private const string constIdentificados2 = "Identificados";
        private const string constVerificados = "Verificados";
        private const string constSobreParihuelas = "Sobre Parihuelas";
        private const string constUniformeCompleto = "Uniforme Completo";
        private const string constDispositivosSeguridad = "Dispositivos de Seguridad";
        private const string constHigiene = "Higiene";
        #endregion
        #endregion
        #endregion
        #endregion
        private bool[] valida = {false, false, false, false, false, false, false};
        private int current = 0;
        string _codigo_orden_acondicionamiento = string.Empty;
        private BindingList<BOT_Adicional> list_bot_Adicional;
        private BindingList<BOT_Devolucion> list_bot_devolucion;
        BOT_Registro_Codificacion_Despeje_Linea_Area bot_Registro_Codificacion_Despeje_Linea_Area = new BOT_Registro_Codificacion_Despeje_Linea_Area();
        BOT_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones bot_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones = new BOT_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones();
        BOT_Registro_Codificacion_Despeje_Linea_Documentacion bot_Registro_Codificacion_Despeje_Linea_Documentacion = new BOT_Registro_Codificacion_Despeje_Linea_Documentacion();
        BOT_Registro_Codificacion_Despeje_Linea_Materiales_Insumos bot_Registro_Codificacion_Despeje_Linea_Materiales_Insumos = new BOT_Registro_Codificacion_Despeje_Linea_Materiales_Insumos();
        BOT_Registro_Codificacion_Despeje_Linea_Personal bot_Registro_Codificacion_Despeje_Linea_Personal = new BOT_Registro_Codificacion_Despeje_Linea_Personal();
        BOT_Registro_Codificacion bot_RegistroCodificacion = new BOT_Registro_Codificacion();
        BOT_Registro_Codificacion_Despeje_Linea bot_Registro_Codificacion_Despeje_Linea = new BOT_Registro_Codificacion_Despeje_Linea();
        
        public Form_OrdendeAcondicionamiento()
        {
            list_bot_Adicional = new BindingList<BOT_Adicional>();
            list_bot_devolucion = new BindingList<BOT_Devolucion>();
            InitializeComponent();
            Init();
            tct_Nueva_Orden_Acondicionamiento.SelectedIndex = current;
        }

        internal void Init() 
        {
            dgv_Adicional.AutoGenerateColumns = false;
            dgv_Adicional.DataSource = list_bot_Adicional;
            dgv_Devolucion.AutoGenerateColumns = false;
            dgv_Devolucion.DataSource = list_bot_devolucion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Codigo_Producto.Focus();
            txt_Vigencia.Text = DateTime.Now.ToShortDateString();
            txt_Fecha_Emision.Text = DateTime.Now.ToShortDateString();
            BLT_Orden_Acondicionamiento blt_Orden_Acondicionamiento = new BLT_Orden_Acondicionamiento();
            txt_Codigo.Text = blt_Orden_Acondicionamiento.fnSelT_OrdenAcondicionamientoCodigo();
        }

        private void btn_Buscar_Producto_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_Producto.Text == "")
            {
                Form_SeleccionarProducto fSelProducto = new Form_SeleccionarProducto(false);
                fSelProducto.ProductoSeleccionado += new ProductoSeleccionadoEventHandler(fSelProducto_ProductoSeleccionado);
                fSelProducto.ShowDialog();
            }
            else
            {
                CargarProducto(txt_Codigo_Producto.Text);
            }

            BLT_Material_Empaque_x_Producto blt_material_empaque_x_producto = new BLT_Material_Empaque_x_Producto();
            cbx_Tamaño_Lote.DataSource = blt_material_empaque_x_producto.fnSelT_Material_Empaque_x_Producto_Tamaño_Lote(txt_Codigo_Producto.Text);
            cbx_Tamaño_Lote.SelectedIndex = -1;
        }

        void fSelProducto_ProductoSeleccionado(object sender, ProductoSeleccionadoEventArgs e) 
        {
            txt_Codigo_Producto.Text = e.ProductoSeleccionado.Codigo_Producto;
            CargarProducto(txt_Codigo_Producto.Text);
        }

        internal void CargarProducto(string cd_producto)
        {
            BLT_Producto blt_Producto = new BLT_Producto();
            BOT_Producto oProducto = new BOT_Producto();
            oProducto = blt_Producto.fnSelT_Producto(cd_producto);
            if (oProducto != null && !string.IsNullOrEmpty(oProducto.Codigo_Producto))
            {
                txt_Producto.Text = oProducto.Nombre_Producto;
                txt_Forma_Farmaceutica.Text = oProducto.Forma_Farmaceutica;
                txt_Proceso.Text = oProducto.Proceso;
                txt_Presentacion.Text = oProducto.Presentacion;
                lbl_Codigo_Producto.Enabled = false;
                txt_Codigo_Producto.Enabled = false;
                btn_Buscar_Codigo_Producto.Enabled = false;
                lbl_Tamaño_Lote.Enabled = true;
                cbx_Tamaño_Lote.Enabled = true;
                lbl_Linea.Enabled = true;
                txt_Linea.Enabled = true;
                lbl_Fecha_Vencimiento.Enabled = true;
                txt_Fecha_Vencimiento.Enabled = true;
                btn_Limpiar.Enabled = true;
                btn_Aceptar.Enabled = true;
                GeneraLoteFabricacion();
            }
            else
            {
                MessageBox.Show("El Código del Producto no existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Codigo_Producto.Focus();
            }
        }

        internal void CargarMateriales(string cd_Producto, string tamañoLote)
        {
            dgv_Material_Empaque.AutoGenerateColumns = false;
            BLT_Material_Empaque_x_Producto blt_Material_Empaque_x_Producto = new BLT_Material_Empaque_x_Producto();
            List<BOT_Material_Empaque_x_Producto> list_oMEP = new List<BOT_Material_Empaque_x_Producto>();
            list_oMEP = blt_Material_Empaque_x_Producto.fnSelT_Material_Empaque_x_ProductoDin("Codigo_Producto = '" + cd_Producto + "' and Tamaño_Lote = '" + tamañoLote + "'", "");
            foreach (BOT_Material_Empaque_x_Producto oMEP in list_oMEP)
            {
                BLT_Material_Empaque bl_ME = new BLT_Material_Empaque();
                BOT_Material_Empaque oME = new BOT_Material_Empaque();
                oME = bl_ME.fnSelT_Material_Empaque(oMEP.Codigo_Material_Empaque);
                oMEP.Nombre_Material_Empaque = oME.Nombre_Material_Empaque;
                oMEP.Unidad_Medida = oME.Unidad_Medida;
            }
            dgv_Material_Empaque.DataSource = list_oMEP;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            lbl_Codigo_Producto.Enabled = true;
            txt_Codigo_Producto.Enabled = true;
            txt_Codigo_Producto.Text = "";
            btn_Buscar_Codigo_Producto.Enabled = true;
            txt_Producto.Text = "";
            txt_Forma_Farmaceutica.Text = "";
            txt_Lote_Fabricacion.Text = "";
            lbl_Tamaño_Lote.Enabled = false;
            cbx_Tamaño_Lote.SelectedItem = null;
            cbx_Tamaño_Lote.Enabled = false;
            lbl_Linea.Enabled = false;
            txt_Linea.Enabled = false;
            txt_Linea.Text = "";
            txt_Proceso.Text = "";
            lbl_Fecha_Vencimiento.Enabled = false;
            txt_Fecha_Vencimiento.Enabled = false;
            txt_Fecha_Vencimiento.Text = "";
            txt_Presentacion.Text = "";
            gpb_Material_Empaque.Enabled = false;
            dgv_Material_Empaque.DataSource = null;
            gpb_Adicional.Enabled = false;
            dgv_Adicional.DataSource = null;
            gpb_Devolucion.Enabled = false;
            dgv_Devolucion.DataSource = null;
            gpb_Observaciones.Enabled = false;
            txt_Observaciones.Text = "";
            btn_Limpiar.Enabled = false;
            btn_Aceptar.Enabled = false;                
            txt_Codigo_Producto.Focus();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            BOT_Orden_Acondicionamiento bot_Orden_Acondicionamiento = new BOT_Orden_Acondicionamiento();
            bot_Orden_Acondicionamiento.Codigo_Producto = txt_Codigo_Producto.Text;
            bot_Orden_Acondicionamiento.Vigencia = Convert.ToDateTime(txt_Vigencia.Text);
            if (txt_Observaciones.Text != "") 
            {
                bot_Orden_Acondicionamiento.Observaciones = txt_Observaciones.Text;
            }
            bool registraOrdenAcondicionamiento;
            BLT_Orden_Acondicionamiento blt_Orden_Acondicionamiento = new BLT_Orden_Acondicionamiento();
            registraOrdenAcondicionamiento = blt_Orden_Acondicionamiento.fnInsUpdT_Orden_Acondicionamiento(bot_Orden_Acondicionamiento,out _codigo_orden_acondicionamiento);
            bool _registraMaterialEmpaquexOrdenAcondicionamiento = false;
            if (registraOrdenAcondicionamiento) 
            {
                bot_Orden_Acondicionamiento.Codigo_Orden_Acondicionamiento = _codigo_orden_acondicionamiento;
                for (int i = 0; i <= dgv_Material_Empaque.Rows.Count - 1; i++) 
                {
                    BOT_Material_Empaque_x_Producto oMEP = (BOT_Material_Empaque_x_Producto)dgv_Material_Empaque.Rows[i].DataBoundItem;
                    BOT_Material_Empaque_x_Orden_Acondicionamiento bot_Material_Empaque_x_Orden_Acondicionamiento = new BOT_Material_Empaque_x_Orden_Acondicionamiento();
                    bot_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Orden_Acondicionamiento=_codigo_orden_acondicionamiento;
                    bot_Material_Empaque_x_Orden_Acondicionamiento.Cantidad_Entregada = oMEP.Cantidad_Entregada;
                    bot_Material_Empaque_x_Orden_Acondicionamiento.Codigo_Material_Empaque_x_Producto = oMEP.Codigo_Material_Empaque_x_Producto;
                    bot_Material_Empaque_x_Orden_Acondicionamiento.Numero_Analisis = oMEP.Numero_Analisis;
                    if (bot_Material_Empaque_x_Orden_Acondicionamiento.Cantidad_Entregada != 0) 
                    {
                        BLT_Material_Empaque_x_Orden_Acondicionamiento blt_Material_Empaque_x_Orden_Acondicionamiento = new BLT_Material_Empaque_x_Orden_Acondicionamiento();
                        _registraMaterialEmpaquexOrdenAcondicionamiento = blt_Material_Empaque_x_Orden_Acondicionamiento.fnInsT_Material_Empaque_x_Orden_Acondicionamiento(bot_Material_Empaque_x_Orden_Acondicionamiento);
                        if (!_registraMaterialEmpaquexOrdenAcondicionamiento) 
                        {
                            registraOrdenAcondicionamiento = false;
                            break;
                        }
                    }
                }
                bool _registraAdicional = false;
                for (int i = 0; i <= dgv_Adicional.Rows.Count - 2; i++) 
                {
                    BOT_Adicional oA = (BOT_Adicional)dgv_Adicional.Rows[i].DataBoundItem;
                    if (oA.Codigo_Producto != "") 
                    {
                        oA.Fecha = DateTime.Now;
                        oA.Codigo_Orden_Acondicionado = _codigo_orden_acondicionamiento;
                        BLT_Adicional blt_adicional = new BLT_Adicional();
                        string codAd;
                        _registraAdicional = blt_adicional.fnInsT_Adicional(oA, out codAd);
                        if (_registraAdicional) 
                        {
                            oA.Codigo_Adicional = codAd;
                            bot_Orden_Acondicionamiento.Codigo_Adicional = oA.Codigo_Adicional;
                            BLT_Orden_Acondicionamiento blt_ordenAcondicionamiento = new BLT_Orden_Acondicionamiento();
                            string codOa;
                            blt_ordenAcondicionamiento.fnUpdT_Orden_Acondicionamiento(bot_Orden_Acondicionamiento);
                        }
                    }
                }
            }
            if (registraOrdenAcondicionamiento) 
            {
                MessageBox.Show("Orden de Acondicionamiento registrada satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gpb_Despeje_Linea.Enabled = true;
                gpb_Codificacion_Cajas.Enabled = true;
                gpb_Observaciones_2.Enabled = true;
                btn_Limpiar_2.Enabled = true;
                btn_Aceptar_2.Enabled = true;
            }
            else 
            {
                MessageBox.Show("Error inesperado al registrar Orden de Acondicionamiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (registraOrdenAcondicionamiento) 
            {
                valida[0] = true;
                current++;
                tct_Nueva_Orden_Acondicionamiento.TabIndex = current;
            }
        }

        private void btn_Conforme_Click(object sender, EventArgs e) 
        {
            rdb_Limpia_Conforme.Checked = true;
            rdb_Ordenada_Conforme.Checked = true;
            rdb_Libre_Producto_Anterior_Conforme.Checked = true;
            rdb_Identificada_Conforme.Checked = true;
            rdb_Materiales_Limpios_Secos_Conforme.Checked = true;
            rdb_Correcta_Iluminacion_Ventilacion_Conforme.Checked = true;
            rdb_Limpios_Conforme.Checked = true;
            rdb_Identificados_Conforme.Checked = true;
            rdb_Balanzas_Calibradas_Verificadas_Conforme.Checked = true;
            rdb_Humedad_Relativa_Conforme.Checked = true;
            rdb_Diferencial_Presion_Conforme.Checked = true;
            rdb_Temperatura_Conforme.Checked = true;
            rdb_Registro_Manufactura_Conforme.Checked = true;
            rdb_Etiquetas_Conforme.Checked = true;
            rdb_Identificados_2_Conforme.Checked = true;
            rdb_Verificados_Conforme.Checked = true;
            rdb_Sobre_Parihuelas_Conforme.Checked = true;
            rdb_Uniforme_Completo_Conforme.Checked = true;
            rdb_Dispositivos_Seguridad_Conforme.Checked = true;
            rdb_Higiene_Comforme.Checked = true;
        }

        private void btn_No_Conforme_Click(object sender, EventArgs e) 
        {
            rdb_Limpia_No_Conforme.Checked = true;
            rdb_Ordenada_No_Conforme.Checked = true;
            rdb_Libre_Producto_Anterior_No_Conforme.Checked = true;
            rdb_Identificada_No_Conforme.Checked = true;
            rdb_Materiales_Limpios_Secos_No_Conforme.Checked = true;
            rdb_Correcta_Iluminacion_Ventilacion_No_Conforme.Checked = true;
            rdb_Limpios_No_Conforme.Checked = true;
            rdb_Identificados_No_Conforme.Checked = true;
            rdb_Balanzas_Calibradas_Verificadas_No_Conforme.Checked = true;
            rdb_Humedad_Relativa_No_Conforme.Checked = true;
            rdb_Diferencial_Presion_No_Conforme.Checked = true;
            rdb_Temperatura_No_Conforme.Checked = true;
            rdb_Registro_Manufactura_No_Conforme.Checked = true;
            rdb_Etiquetas_No_Conforme.Checked = true;
            rdb_Identificados_2_No_Conforme.Checked = true;
            rdb_Verificados_No_Conforme.Checked = true;
            rdb_Sobre_Parihuelas_No_Conforme.Checked = true;
            rdb_Uniforme_Completo_No_Conforme.Checked = true;
            rdb_Dispositivos_Seguridad_No_Conforme.Checked = true;
            rdb_Higiene_No_Comforme.Checked = true;
        }

        private void btn_No_Aplica_Click(object sender, EventArgs e) 
        {
            rdb_Limpia_No_Aplica.Checked = true;
            rdb_Ordenada_No_Aplica.Checked = true;
            rdb_Libre_Producto_Anterior_No_Aplica.Checked = true;
            rdb_Identificada_No_Aplica.Checked = true;
            rdb_Materiales_Limpios_Secos_No_Aplica.Checked = true;
            rdb_Correcta_Iluminacion_Ventilacion_No_Aplica.Checked = true;
            rdb_Limpios_No_Aplica.Checked = true;
            rdb_Identificados_No_Aplica.Checked = true;
            rdb_Balanzas_Calibradas_Verificadas_No_Aplica.Checked = true;
            rdb_Humedad_Relativa_No_Aplica.Checked = true;
            rdb_Diferencial_Presion_No_Aplica.Checked = true;
            rdb_Temperatura_No_Aplica.Checked = true;
            rdb_Registro_Manufactura_No_Aplica.Checked = true;
            rdb_Etiquetas_No_Aplica.Checked = true;
            rdb_Identificados_2_No_Aplica.Checked = true;
            rdb_Verificados_No_Aplica.Checked = true;
            rdb_Sobre_Parihuelas_No_Aplica.Checked = true;
            rdb_Uniforme_Completo_No_Aplica.Checked = true;
            rdb_Dispositivos_Seguridad_No_Aplica.Checked = true;
            rdb_Higiene_No_Aplica.Checked = true;
        }

        private void btn_Limpiar_2_Click(object sender, EventArgs e) 
        {
            rdb_Limpia_Conforme.Checked = false;
            rdb_Ordenada_Conforme.Checked = false;
            rdb_Libre_Producto_Anterior_Conforme.Checked = false;
            rdb_Identificada_Conforme.Checked = false;
            rdb_Materiales_Limpios_Secos_Conforme.Checked = false;
            rdb_Correcta_Iluminacion_Ventilacion_Conforme.Checked = false;
            rdb_Limpios_Conforme.Checked = false;
            rdb_Identificados_Conforme.Checked = false;
            rdb_Balanzas_Calibradas_Verificadas_Conforme.Checked = false;
            rdb_Humedad_Relativa_Conforme.Checked = false;
            rdb_Diferencial_Presion_Conforme.Checked = false;
            rdb_Temperatura_Conforme.Checked = false;
            rdb_Registro_Manufactura_Conforme.Checked = false;
            rdb_Etiquetas_Conforme.Checked = false;
            rdb_Identificados_2_Conforme.Checked = false;
            rdb_Verificados_Conforme.Checked = false;
            rdb_Sobre_Parihuelas_Conforme.Checked = false;
            rdb_Uniforme_Completo_Conforme.Checked = false;
            rdb_Dispositivos_Seguridad_Conforme.Checked = false;
            rdb_Higiene_Comforme.Checked = false;
            rdb_Limpia_No_Conforme.Checked = false;
            rdb_Ordenada_No_Conforme.Checked = false;
            rdb_Libre_Producto_Anterior_No_Conforme.Checked = false;
            rdb_Identificada_No_Conforme.Checked = false;
            rdb_Materiales_Limpios_Secos_No_Conforme.Checked = false;
            rdb_Correcta_Iluminacion_Ventilacion_No_Conforme.Checked = false;
            rdb_Limpios_No_Conforme.Checked = false;
            rdb_Identificados_No_Conforme.Checked = false;
            rdb_Balanzas_Calibradas_Verificadas_No_Conforme.Checked = false;
            rdb_Humedad_Relativa_No_Conforme.Checked = false;
            rdb_Diferencial_Presion_No_Conforme.Checked = false;
            rdb_Temperatura_No_Conforme.Checked = false;
            rdb_Registro_Manufactura_No_Conforme.Checked = false;
            rdb_Etiquetas_No_Conforme.Checked = false;
            rdb_Identificados_2_No_Conforme.Checked = false;
            rdb_Verificados_No_Conforme.Checked = false;
            rdb_Sobre_Parihuelas_No_Conforme.Checked = false;
            rdb_Uniforme_Completo_No_Conforme.Checked = false;
            rdb_Dispositivos_Seguridad_No_Conforme.Checked = false;
            rdb_Higiene_No_Comforme.Checked = false;
            rdb_Limpia_No_Aplica.Checked = false;
            rdb_Ordenada_No_Aplica.Checked = false;
            rdb_Libre_Producto_Anterior_No_Aplica.Checked = false;
            rdb_Identificada_No_Aplica.Checked = false;
            rdb_Materiales_Limpios_Secos_No_Aplica.Checked = false;
            rdb_Correcta_Iluminacion_Ventilacion_No_Aplica.Checked = false;
            rdb_Limpios_No_Aplica.Checked = false;
            rdb_Identificados_No_Aplica.Checked = false;
            rdb_Balanzas_Calibradas_Verificadas_No_Aplica.Checked = false;
            rdb_Humedad_Relativa_No_Aplica.Checked = false;
            rdb_Diferencial_Presion_No_Aplica.Checked = false;
            rdb_Temperatura_No_Aplica.Checked = false;
            rdb_Registro_Manufactura_No_Aplica.Checked = false;
            rdb_Etiquetas_No_Aplica.Checked = false;
            rdb_Identificados_2_No_Aplica.Checked = false;
            rdb_Verificados_No_Aplica.Checked = false;
            rdb_Sobre_Parihuelas_No_Aplica.Checked = false;
            rdb_Uniforme_Completo_No_Aplica.Checked = false;
            rdb_Dispositivos_Seguridad_No_Aplica.Checked = false;
            rdb_Higiene_No_Aplica.Checked = false;
            cbx_Fecha.Checked = false;
            cbx_Hora.Checked = false;
            cbx_Fecha_Procedimiento_1.Checked = false;
            cbx_Fecha_Procedimiento_2.Checked = false;
            cbx_Fecha_Procedimiento_3.Checked = false;
            cbx_Fecha_Procedimiento_4.Checked = false;
            txt_Total.Text = "";
            cbx_Fecha_Procedimiento_5.Checked = false;
            cbx_Fecha_Procedimiento_6.Checked = false;
            txt_Observaciones_2.Text = "";
        }

        private void btn_Aceptar_2_Click(object sender, EventArgs e) 
        {
            string _codigoRegistroCodificacion = string.Empty;
            
            bot_RegistroCodificacion.Codigo_Orden_Acondicionamiento = _codigo_orden_acondicionamiento;
            bot_RegistroCodificacion.Observaciones = txt_Observaciones_2.Text;
            bool registraCodificacion = false;
            BLT_Registro_Codificacion blt_RegistroCodificacion = new BLT_Registro_Codificacion();
            registraCodificacion = blt_RegistroCodificacion.fnInsT_Registro_Codificacion(bot_RegistroCodificacion, out _codigoRegistroCodificacion);
            if (registraCodificacion) 
            {
                bot_RegistroCodificacion.Codigo_Registro_Codificacion = _codigoRegistroCodificacion;
                bot_Registro_Codificacion_Despeje_Linea.Codigo_Registro_Codificacion = _codigoRegistroCodificacion;
                //bot_Registro_Codificacion_Despeje_Linea.Fecha = dtp_Fecha.Value;
                bot_Registro_Codificacion_Despeje_Linea.Hora = txt_Hora.Text;
                BLT_Registro_Codificacion_Despeje_Linea blt_Registro_Codificacion_Despeje_Linea = new BLT_Registro_Codificacion_Despeje_Linea();
                string _codigoRegistroDespejeLinea;
                bool registraCodificacionLinea = blt_Registro_Codificacion_Despeje_Linea.fnInsT_Registro_Codificacion_Despeje_Linea(bot_Registro_Codificacion_Despeje_Linea, out _codigoRegistroDespejeLinea);
                if (registraCodificacionLinea) 
                {
                    bot_RegistroCodificacion.Codigo_Registro_Codificacion_Despeje_Linea = _codigoRegistroDespejeLinea;
                    blt_RegistroCodificacion.fnUpdT_Registro_Codificacion(bot_RegistroCodificacion);
                }
                bool registaCodificacionDespejeLineaArea = false;
                bool registraCodificacionDespejeLineaEquipos = false;
                bool registraCodificacionDespejeLineaDocumentacion = false;
                bool registraCodificacionDespejeLineaMateriales = false;
                bool registraCodificacionDespejeLineaPersonales = false;
                string codigo_registro_codificacion_despeje_linea_area = string.Empty;
                string codigo_registro_codificacion_despeje_linea_equipos_instalaciones = string.Empty;
                string codigo_registro_codificacion_despeje_linea_documentacion = string.Empty;
                string codigo_registro_codificacion_despeje_linea_materiales = string.Empty;
                string codigo_registro_codificacion_despeje_linea_personal = string.Empty;
                if (registraCodificacionLinea) 
                {
                    bot_Registro_Codificacion_Despeje_Linea.Codigo_Registro_Codificacion_Despeje_Linea = _codigoRegistroDespejeLinea;
                    bot_Registro_Codificacion_Despeje_Linea_Area.Codigo_Registro_Codificacion_Despeje_Linea = _codigoRegistroDespejeLinea;
                    BLT_Registro_Codificacion_Despeje_Linea_Area blt_Registro_Codificacion_Despeje_Linea_Area = new BLT_Registro_Codificacion_Despeje_Linea_Area();
                    registaCodificacionDespejeLineaArea = blt_Registro_Codificacion_Despeje_Linea_Area.fnInsUpdT_Registro_Codificacion_Despeje_Linea_Area(bot_Registro_Codificacion_Despeje_Linea_Area, out codigo_registro_codificacion_despeje_linea_area);
                    if (registaCodificacionDespejeLineaArea) 
                    {
                        bot_Registro_Codificacion_Despeje_Linea_Area.Codigo_Registro_Codificacion_Despeje_Linea_Area = codigo_registro_codificacion_despeje_linea_area;
                        bot_Registro_Codificacion_Despeje_Linea.Codigo_Registro_Codificacion_Despeje_Linea_Area = codigo_registro_codificacion_despeje_linea_area;
                        blt_Registro_Codificacion_Despeje_Linea.fnUpdT_Registro_Codificacion_Despeje_Linea(bot_Registro_Codificacion_Despeje_Linea);
                    }
                    bot_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones.Codigo_Registro_Codificacion_Despeje_Linea = _codigoRegistroDespejeLinea;
                    BLT_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones blt_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones = new BL_SISACO.BLT_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones();
                    registraCodificacionDespejeLineaEquipos = blt_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones.fnInsUpdT_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones(bot_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones, out codigo_registro_codificacion_despeje_linea_equipos_instalaciones);
                    if (registraCodificacionDespejeLineaEquipos) 
                    {
                        bot_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones.Codigo_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones = codigo_registro_codificacion_despeje_linea_equipos_instalaciones;
                        bot_Registro_Codificacion_Despeje_Linea.Codigo_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones = codigo_registro_codificacion_despeje_linea_equipos_instalaciones;
                        blt_Registro_Codificacion_Despeje_Linea.fnUpdT_Registro_Codificacion_Despeje_Linea(bot_Registro_Codificacion_Despeje_Linea);
                    }
                    bot_Registro_Codificacion_Despeje_Linea_Documentacion.Codigo_Registro_Codificacion_Despeje_Linea = _codigoRegistroDespejeLinea;
                    BLT_Registro_Codificacion_Despeje_Linea_Documentacion blt_Registro_Codificacion_Despeje_Linea_Documentacion = new BLT_Registro_Codificacion_Despeje_Linea_Documentacion();
                    registraCodificacionDespejeLineaDocumentacion = blt_Registro_Codificacion_Despeje_Linea_Documentacion.fnInsUpdT_Registro_Codificacion_Despeje_Linea_Documentacion(bot_Registro_Codificacion_Despeje_Linea_Documentacion,out codigo_registro_codificacion_despeje_linea_documentacion);
                    if (registraCodificacionDespejeLineaDocumentacion) 
                    {
                        bot_Registro_Codificacion_Despeje_Linea.Codigo_Registro_Codificacion_Despeje_Linea_Documentacion = codigo_registro_codificacion_despeje_linea_documentacion;
                        blt_Registro_Codificacion_Despeje_Linea.fnUpdT_Registro_Codificacion_Despeje_Linea(bot_Registro_Codificacion_Despeje_Linea);
                    }
                    bot_Registro_Codificacion_Despeje_Linea_Documentacion.Codigo_Registro_Codificacion_Despeje_Linea = _codigoRegistroDespejeLinea;
                    BLT_Registro_Codificacion_Despeje_Linea_Materiales_Insumos blt_Registro_Codificacion_Despeje_Linea_Materiales_Insumos = new BLT_Registro_Codificacion_Despeje_Linea_Materiales_Insumos();
                    registraCodificacionDespejeLineaMateriales = blt_Registro_Codificacion_Despeje_Linea_Materiales_Insumos.fnInsUpdT_Registro_Codificacion_Despeje_Linea_Materiales_Insumos(bot_Registro_Codificacion_Despeje_Linea_Materiales_Insumos, out codigo_registro_codificacion_despeje_linea_materiales);
                    if (registraCodificacionDespejeLineaMateriales) 
                    {
                        bot_Registro_Codificacion_Despeje_Linea.Codigo_Registro_Codificacion_Despeje_Linea_Materiales_Insumos = codigo_registro_codificacion_despeje_linea_materiales;
                        blt_Registro_Codificacion_Despeje_Linea.fnUpdT_Registro_Codificacion_Despeje_Linea(bot_Registro_Codificacion_Despeje_Linea);
                    }
                    bot_Registro_Codificacion_Despeje_Linea_Personal.Codigo_Registro_Codificacion_Despeje_Linea = _codigoRegistroDespejeLinea;
                    BLT_Registro_Codificacion_Despeje_Linea_Personal blt_Registro_Codificacion_Despeje_Linea_Personal = new BLT_Registro_Codificacion_Despeje_Linea_Personal();
                    registraCodificacionDespejeLineaPersonales = blt_Registro_Codificacion_Despeje_Linea_Personal.fnInsUpdT_Registro_Codificacion_Despeje_Linea_Personal(bot_Registro_Codificacion_Despeje_Linea_Personal, out codigo_registro_codificacion_despeje_linea_personal);
                    if (registraCodificacionDespejeLineaPersonales) 
                    {
                        bot_Registro_Codificacion_Despeje_Linea_Personal.Codigo_Registro_Codificacion_Despeje_Linea_Personal = codigo_registro_codificacion_despeje_linea_personal;
                        bot_Registro_Codificacion_Despeje_Linea.Codigo_Registro_Codificacion_Despeje_Linea_Personal = codigo_registro_codificacion_despeje_linea_personal;
                        blt_Registro_Codificacion_Despeje_Linea.fnUpdT_Registro_Codificacion_Despeje_Linea(bot_Registro_Codificacion_Despeje_Linea);
                    }
                }
            }
        }

        private void btn_Conforme_2_Click(object sender, EventArgs e) 
        {
            rdb_Limpia_Conforme_2.Checked = true;
            rdb_Ordenada_Conforme_2.Checked = true;
            rdb_Libre_Producto_Anterior_Conforme_2.Checked = true;
            rdb_Identificada_Conforme_2.Checked = true;
            rdb_Materiales_Limpios_Secos_Conforme_2.Checked = true;
            rdb_Correcta_Iluminacion_Ventilacion_Conforme_2.Checked = true;
            rdb_Limpios_Conforme_2.Checked = true;
            rdb_Identificados_3_Conforme.Checked = true;
            rdb_Balanzas_Calibradas_Verificadas_Conforme_2.Checked = true;
            rdb_Humedad_Relativa_Conforme_2.Checked = true;
            rdb_Diferencial_Presion_Conforme_2.Checked = true;
            rdb_Temperatura_Conforme_2.Checked = true;
            rdb_Registro_Manufactura_Conforme_2.Checked = true;
            rdb_Etiquetas_Conforme_2.Checked = true;
            rdb_Identificados_4_Conforme.Checked = true;
            rdb_Verificados_Conforme_2.Checked = true;
            rdb_Sobre_Parihuelas_Conforme_2.Checked = true;
            rdb_Uniforme_Completo_Conforme_2.Checked = true;
            rdb_Dispositivos_Seguridad_Conforme_2.Checked = true;
            rdb_Higiene_Comforme_2.Checked = true;
        }

        private void btn_No_Conforme_2_Click(object sender, EventArgs e) 
        {
            rdb_Limpia_No_Conforme_2.Checked = true;
            rdb_Ordenada_No_Conforme_2.Checked = true;
            rdb_Libre_Producto_Anterior_No_Conforme_2.Checked = true;
            rdb_Identificada_No_Conforme_2.Checked = true;
            rdb_Materiales_Limpios_Secos_No_Conforme_2.Checked = true;
            rdb_Correcta_Iluminacion_Ventilacion_No_Conforme_2.Checked = true;
            rdb_Limpios_No_Conforme_2.Checked = true;
            rdb_Identificados_3_No_Conforme.Checked = true;
            rdb_Balanzas_Calibradas_Verificadas_No_Conforme_2.Checked = true;
            rdb_Humedad_Relativa_No_Conforme_2.Checked = true;
            rdb_Diferencial_Presion_No_Conforme_2.Checked = true;
            rdb_Temperatura_No_Conforme_2.Checked = true;
            rdb_Registro_Manufactura_No_Conforme_2.Checked = true;
            rdb_Etiquetas_No_Conforme_2.Checked = true;
            rdb_Identificados_4_No_Conforme.Checked = true;
            rdb_Verificados_No_Conforme_2.Checked = true;
            rdb_Sobre_Parihuelas_No_Conforme_2.Checked = true;
            rdb_Uniforme_Completo_No_Conforme_2.Checked = true;
            rdb_Dispositivos_Seguridad_No_Conforme_2.Checked = true;
            rdb_Higiene_No_Comforme_2.Checked = true;
        }

        private void btn_No_Aplica_2_Click(object sender, EventArgs e) {
            rdb_Limpia_No_Aplica_2.Checked = true;
            rdb_Ordenada_No_Aplica_2.Checked = true;
            rdb_Libre_Producto_Anterior_No_Aplica_2.Checked = true;
            rdb_Identificada_No_Aplica_2.Checked = true;
            rdb_Materiales_Limpios_Secos_No_Aplica_2.Checked = true;
            rdb_Correcta_Iluminacion_Ventilacion_No_Aplica_2.Checked = true;
            rdb_Limpios_No_Aplica_2.Checked = true;
            rdb_Identificados_3_No_Aplica.Checked = true;
            rdb_Balanzas_Calibradas_Verificadas_No_Aplica_2.Checked = true;
            rdb_Humedad_Relativa_No_Aplica_2.Checked = true;
            rdb_Diferencial_Presion_No_Aplica_2.Checked = true;
            rdb_Temperatura_No_Aplica_2.Checked = true;
            rdb_Registro_Manufactura_No_Aplica_2.Checked = true;
            rdb_Etiquetas_No_Aplica_2.Checked = true;
            rdb_Identificados_4_No_Aplica.Checked = true;
            rdb_Verificados_No_Aplica_2.Checked = true;
            rdb_Sobre_Parihuelas_No_Aplica_2.Checked = true;
            rdb_Uniforme_Completo_No_Aplica_2.Checked = true;
            rdb_Dispositivos_Seguridad_No_Aplica_2.Checked = true;
            rdb_Higiene_No_Aplica_2.Checked = true;
        }

        private void btn_Limpiar_3_Click(object sender, EventArgs e) 
        {
            rdb_Limpia_Conforme_2.Checked = false;
            rdb_Ordenada_Conforme_2.Checked = false;
            rdb_Libre_Producto_Anterior_Conforme_2.Checked = false;
            rdb_Identificada_Conforme_2.Checked = false;
            rdb_Materiales_Limpios_Secos_Conforme_2.Checked = false;
            rdb_Correcta_Iluminacion_Ventilacion_Conforme_2.Checked = false;
            rdb_Limpios_Conforme_2.Checked = false;
            rdb_Identificados_3_Conforme.Checked = false;
            rdb_Balanzas_Calibradas_Verificadas_Conforme_2.Checked = false;
            rdb_Humedad_Relativa_Conforme_2.Checked = false;
            rdb_Diferencial_Presion_Conforme_2.Checked = false;
            rdb_Temperatura_Conforme_2.Checked = false;
            rdb_Registro_Manufactura_Conforme_2.Checked = false;
            rdb_Etiquetas_Conforme_2.Checked = false;
            rdb_Identificados_4_Conforme.Checked = false;
            rdb_Verificados_Conforme_2.Checked = false;
            rdb_Sobre_Parihuelas_Conforme_2.Checked = false;
            rdb_Uniforme_Completo_Conforme_2.Checked = false;
            rdb_Dispositivos_Seguridad_Conforme_2.Checked = false;
            rdb_Higiene_Comforme_2.Checked = false;
            rdb_Limpia_No_Conforme_2.Checked = false;
            rdb_Ordenada_No_Conforme_2.Checked = false;
            rdb_Libre_Producto_Anterior_No_Conforme_2.Checked = false;
            rdb_Identificada_No_Conforme_2.Checked = false;
            rdb_Materiales_Limpios_Secos_No_Conforme_2.Checked = false;
            rdb_Correcta_Iluminacion_Ventilacion_No_Conforme_2.Checked = false;
            rdb_Limpios_No_Conforme_2.Checked = false;
            rdb_Identificados_3_No_Conforme.Checked = false;
            rdb_Balanzas_Calibradas_Verificadas_No_Conforme_2.Checked = false;
            rdb_Humedad_Relativa_No_Conforme_2.Checked = false;
            rdb_Diferencial_Presion_No_Conforme_2.Checked = false;
            rdb_Temperatura_No_Conforme_2.Checked = false;
            rdb_Registro_Manufactura_No_Conforme_2.Checked = false;
            rdb_Etiquetas_No_Conforme_2.Checked = false;
            rdb_Identificados_4_No_Conforme.Checked = false;
            rdb_Verificados_No_Conforme_2.Checked = false;
            rdb_Sobre_Parihuelas_No_Conforme_2.Checked = false;
            rdb_Uniforme_Completo_No_Conforme_2.Checked = false;
            rdb_Dispositivos_Seguridad_No_Conforme_2.Checked = false;
            rdb_Higiene_No_Comforme_2.Checked = false;
            rdb_Limpia_No_Aplica_2.Checked = false;
            rdb_Ordenada_No_Aplica_2.Checked = false;
            rdb_Libre_Producto_Anterior_No_Aplica_2.Checked = false;
            rdb_Identificada_No_Aplica_2.Checked = false;
            rdb_Materiales_Limpios_Secos_No_Aplica_2.Checked = false;
            rdb_Correcta_Iluminacion_Ventilacion_No_Aplica_2.Checked = false;
            rdb_Limpios_No_Aplica_2.Checked = false;
            rdb_Identificados_3_No_Aplica.Checked = false;
            rdb_Balanzas_Calibradas_Verificadas_No_Aplica_2.Checked = false;
            rdb_Humedad_Relativa_No_Aplica_2.Checked = false;
            rdb_Diferencial_Presion_No_Aplica_2.Checked = false;
            rdb_Temperatura_No_Aplica_2.Checked = false;
            rdb_Registro_Manufactura_No_Aplica_2.Checked = false;
            rdb_Etiquetas_No_Aplica_2.Checked = false;
            rdb_Identificados_4_No_Aplica.Checked = false;
            rdb_Verificados_No_Aplica_2.Checked = false;
            rdb_Sobre_Parihuelas_No_Aplica_2.Checked = false;
            rdb_Uniforme_Completo_No_Aplica_2.Checked = false;
            rdb_Dispositivos_Seguridad_No_Aplica_2.Checked = false;
            rdb_Higiene_No_Aplica_2.Checked = false;
            cbx_Fecha_2.Checked = false;
            cbx_Hora_2.Checked = false;
            cbx_Fecha_Procedimiento_1_2.Checked = false;
            cbx_Fecha_Procedimiento_2_2.Checked = false;
            cbx_Fecha_Procedimiento_3_2.Checked = false;
            cbx_Fecha_Procedimiento_4_2.Checked = false;
            cbx_Fecha_Procedimiento_5_2.Checked = false;
            cbx_Fecha_Procedimiento_6_2.Checked = false;
            cbx_Fecha_Procedimiento_7_2.Checked = false;
            txt_insumo.Text = "";
            txt_Cajas.Text = "";
            txt_Observaciones_3.Text = "";
        }

        private void btn_Aceptar_3_Click(object sender, EventArgs e) 
        {
            gpb_Entrega_Producto_Empacar.Enabled = true;
            gpb_Entrega_Producto_Terminado_Almacen.Enabled = true;
            gpb_Observaciones_4.Enabled = true;
            btn_Limpiar_4.Enabled = true;
            btn_Aceptar_4.Enabled = true;
        }

        private void btn_Limpiar_4_Click(object sender, EventArgs e) 
        {
            dgv_Entrega_Producto_Empacar.DataSource = null;
            dgv_Entrega_Producto_Terminado_Almacen.DataSource = null;
            txt_Total_2.Text = "";
            txt_Observaciones_4.Text = "";
        }

        private void btn_Aceptar_4_Click(object sender, EventArgs e) 
        {
            gpb_Material_Empaque_2.Enabled = true;
            gpb_Merma.Enabled = true;
            lbl_Formula_1.Enabled = true;
            lbl_Formula_2.Enabled = true;
            btn_Limpiar_5.Enabled = true;
            btn_Aceptar_5.Enabled = true;
        }

        private void btn_Limpiar_5_Click(object sender, EventArgs e) 
        {
           
        }

        private void btn_Aceptar_5_Click(object sender, EventArgs e) 
        {

        }

        private void btn_Limpiar_7_Click(object sender, EventArgs e) 
        {
            dgv_Material_Empaque_2.DataSource = null;
            dgv_Merma.DataSource = null;
        }

        private void btn_Aceptar_7_Click(object sender, EventArgs e) 
        {
            lbl_Fecha_Inicio.Enabled = true;
            lbl_Fecha_Termino.Enabled = true;
            lbl_Cantidad_Teorica.Enabled = true;
            txt_Cantidad_Teorica.Enabled = true;
            lbl_Cantidad_Obtenida.Enabled = true;
            txt_Cantidad_Obtenida.Enabled = true;
            lbl_Merma.Enabled = true;
            txt_Merma.Enabled = true;
            lbl_Rendimiento_Final.Enabled = true;
            txt_Rendimiento_Final.Enabled = true;
            lbl_Limites_Merma.Enabled = true;
            lbl_3_0_Porciento.Enabled = true;
            lbl_Formula_3.Enabled = true;
            gpb_Observaciones_5.Enabled = true;
            btn_Limpiar_6.Enabled = true;
            btn_Aceptar_6.Enabled = true;
        }

        private void btn_Limpiar_7_Click_1(object sender, EventArgs e) 
        {
            txt_Cantidad_Teorica.Text = "";
            txt_Cantidad_Obtenida.Text = "";
            txt_Cantidad_Teorica.Text = "";
            txt_Merma.Text = "";
            txt_Rendimiento_Final.Text = "";
            txt_Observaciones_5.Text = "";
            txt_Cantidad_Teorica.Focus();
        }

        private void btn_Aceptar_7_Click_1(object sender, EventArgs e) 
        {

        }


        internal void GeneraLoteFabricacion() 
        {
            txt_Lote_Fabricacion.Clear();
            txt_Lote_Fabricacion.Text = DateTime.Now.Year.ToString() + ((DateTime.Now.Month.ToString().Length == 1) ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + ((DateTime.Now.Day.ToString().Length == 1) ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString());
            txt_Lote_Fabricacion.Enabled = false;
        }

        private void tct_Nueva_Orden_Acondicionamiento_SelectedIndexChanged(object sender, EventArgs e) 
        {
            
        }

        internal bool ValidaPrimerTab() 
        {
            return true;
        }

        private void tct_Nueva_Orden_Acondicionamiento_Selecting(object sender, TabControlCancelEventArgs e) 
        {
            gpb_Despeje_Linea.Enabled = true;
            gpb_Codificacion_Cajas.Enabled = true;
            btn_Limpiar_2.Enabled = true;
            btn_Aceptar_2.Enabled = true;
        }

        private void tct_Nueva_Orden_Acondicionamiento_SelectedIndexChanged_1(object sender, EventArgs e) 
        {
            current = tct_Nueva_Orden_Acondicionamiento.SelectedIndex;
        }

        private void DespejeLinea_CheckedChanged(object sender, EventArgs e) 
        {
            RadioButton rrdd = (RadioButton)sender;
            string cadena = rrdd.Tag.ToString();
            int largo = cadena.Length;
            int indiceSeparador = cadena.IndexOf(constSeparadorIdentificador);
            string _area = cadena.Substring(0,indiceSeparador);
            string aux = cadena.Substring(cadena.IndexOf(constSeparadorIdentificador)+1);
            string _categoria = aux.Substring(0, aux.IndexOf(constSeparadorIdentificador));
            string _estado = aux.Substring(aux.IndexOf(constSeparadorIdentificador) + 1);
            switch (_area) 
            {
                case constAreaArea:
                    
                    switch (_categoria) 
                    {
                        case constLimpia:
                            bot_Registro_Codificacion_Despeje_Linea_Area.Area_Limpia = _estado;
                            break;
                        case constOrdenada:
                            bot_Registro_Codificacion_Despeje_Linea_Area.Area_Ordenada = _estado;
                            break;
                        case constLibreDeProductoAnterior:
                            bot_Registro_Codificacion_Despeje_Linea_Area.Area_Libre_Producto_Anterior = _estado;
                            break;
                        case constIdetificada:
                            bot_Registro_Codificacion_Despeje_Linea_Area.Area_Identificada = _estado;
                            break;
                        case constMaterialesLimpiosYSecos:
                            bot_Registro_Codificacion_Despeje_Linea_Area.Area_Materiales_Limpios_Secos = _estado;
                            break;
                        case constCorrectaIluminacionYVentilacion:
                            bot_Registro_Codificacion_Despeje_Linea_Area.Area_Correcta_Iluminacion_Ventilacion = _estado;
                            break;
                        default:
                            break;
                    }
                    break;
                    
                case constAreaEquiposEInstalaciones:
                    switch(_categoria)
                    {
                        case constLimpios:
                            bot_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Limpios = _estado;
                            break;
                        case constIdentificados:
                            bot_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Identificados = _estado;
                            break;
                        case constBalanzasCalibradasYVerificadas:
                            bot_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Balanzas_Calibradas_Verificadas = _estado;
                            break;
                        case constHumedadRelativa:
                            bot_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Humedad_Relativa = _estado;
                            break;
                        case constDiferencialDePresion:
                            bot_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Diferencial_Presion = _estado;
                            break;
                        case constTemperatura:
                            bot_Registro_Codificacion_Despeje_Linea_Equipos_Instalaciones.Equipos_Instalaciones_Temperatura = _estado;
                            break;
                        default:
                            break;
                    }
                    break;
                case constAreaDocumentacion:
                    switch (_categoria) 
                    {
                        case constRegistroManufactura:
                            bot_Registro_Codificacion_Despeje_Linea_Documentacion.Documentacion_Registro_Manufactura = _estado;
                            break;
                        case constEtiquetas:
                            bot_Registro_Codificacion_Despeje_Linea_Documentacion.Documentacion_Etiquetas = _estado;
                            break;
                        default:
                            break;
                    }
                    break;
                case constAreaMaterialesEInsumos:
                    switch (_categoria) 
                    {
                        case constIdentificados:
                            bot_Registro_Codificacion_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Identificados = _estado;
                            break;
                        case constVerificados:
                            bot_Registro_Codificacion_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Verificados = _estado;
                            break;
                        case constSobreParihuelas:
                            bot_Registro_Codificacion_Despeje_Linea_Materiales_Insumos.Materiales_Insumos_Sobre_Parihuelas = _estado;
                            break;
                        default:
                            break;
                    }
                    break;
                case constAreaPersonales:
                    switch (_categoria) 
                    {
                        case constUniformeCompleto:
                            bot_Registro_Codificacion_Despeje_Linea_Personal.Personal_Uniforme_Completo = _estado;
                            break;
                        case constDispositivosSeguridad:
                            bot_Registro_Codificacion_Despeje_Linea_Personal.Personal_Dispositivos_Seguridad = _estado;
                            break;
                        case constHigiene:
                            bot_Registro_Codificacion_Despeje_Linea_Personal.Personal_Higiene = _estado;
                            break;
                        default:
                            break;
                    }
                    break;
            }     
        }

        private void cbx_TamañoLote_SelectedIndexChanged(object sender, EventArgs e) 
        {
            dgv_Material_Empaque.DataSource = null;
            if (txt_Codigo_Producto.Text != "" && cbx_Tamaño_Lote.SelectedIndex != -1) 
            {
                CargarMateriales(txt_Codigo_Producto.Text, cbx_Tamaño_Lote.SelectedItem.ToString());
                gpb_Material_Empaque.Enabled = true;
                gpb_Adicional.Enabled = true;
                gpb_Devolucion.Enabled = true;
                gpb_Observaciones.Enabled = true;
            }
        }

        private void dgv_Material_Empaque_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            BOT_Material_Empaque_x_Producto oMEP = dgv_Material_Empaque.Rows[e.RowIndex].DataBoundItem as BOT_Material_Empaque_x_Producto;
            if (oMEP.Cantidad_Pedida > oMEP.Cantidad_Entregada) {
                BOT_Adicional bot_Adicional = new BOT_Adicional();
                bot_Adicional.Codigo_Producto = oMEP.Codigo_Producto;
                bot_Adicional.Producto = new BLT_Producto().fnSelT_Producto(bot_Adicional.Codigo_Producto);
                bot_Adicional.Fecha = DateTime.Now;
                bot_Adicional.Cantidad = ((oMEP.Cantidad_Entregada - oMEP.Cantidad_Pedida)*(-1)).ToString();
                list_bot_Adicional.Add(bot_Adicional);
                dgv_Adicional.DataSource = list_bot_Adicional;
            }
            else {
                if (oMEP.Cantidad_Pedida == oMEP.Cantidad_Entregada) {

                    BindingList<BOT_Adicional> lstAd = dgv_Adicional.DataSource as BindingList<BOT_Adicional>;
                    if (lstAd.Count != 0) {
                        BOT_Adicional bot_adicional = lstAd.First(ad => ad.Codigo_Producto == oMEP.Codigo_Producto);
                        lstAd.Remove(bot_adicional);
                    }

                }
                else {
                    BindingList<BOT_Adicional> lstAd = dgv_Adicional.DataSource as BindingList<BOT_Adicional>;
                    if (lstAd.Count != 0) {
                        BOT_Adicional bot_adicional = lstAd.First(ad => ad.Codigo_Producto == oMEP.Codigo_Producto);
                        lstAd.Remove(bot_adicional);
                    }
                    BOT_Devolucion bot_Devolucion = new BOT_Devolucion();
                    bot_Devolucion.Codigo_Producto = oMEP.Codigo_Producto;
                    bot_Devolucion.Producto = new BLT_Producto().fnSelT_Producto(bot_Devolucion.Codigo_Producto);
                    bot_Devolucion.Cantidad = ((oMEP.Cantidad_Pedida - oMEP.Cantidad_Entregada)*(-1)).ToString();
                    list_bot_devolucion.Add(bot_Devolucion);
                    dgv_Devolucion.DataSource = list_bot_devolucion;
                    
                }
            }

        }

    }
}
