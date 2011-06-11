using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BO_SISACO;
using BL_SISACO;

namespace SISACO
{
    public partial class Form_ModificarProducto : Form
    {
        BOT_Producto bot_Producto;

        public event EventHandler ProductoModificado;

        public Form_ModificarProducto(BOT_Producto _bot_producto)
        {
            bot_Producto = _bot_producto;
            InitializeComponent();
        }

        private void Form_ModificarProducto_Load(object sender, EventArgs e) {
            BLT_Producto blt_producto = new BLT_Producto();
            if (blt_producto.fnEsReferenciadoT_Producto(bot_Producto)) {
                txt_Forma_Farmaceutica.Enabled = false;
                txtPresentacion.Enabled = false;
                txtProceso.Enabled = false;
            }
            txt_Codigo_Producto.Text = bot_Producto.Codigo_Producto;
            txt_Forma_Farmaceutica.Text = bot_Producto.Forma_Farmaceutica;
            txt_Producto.Text = bot_Producto.Nombre_Producto;
            txtPresentacion.Text = bot_Producto.Presentacion;
            txtProceso.Text = bot_Producto.Proceso;
            txt_Producto.Focus();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_Producto.Text == "" || txt_Producto.Text == "" || txt_Forma_Farmaceutica.Text == "")
            {
                MessageBox.Show("Debe de ingresar todos los datos solicitados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Producto.Focus();
            }
            else
            {
                BLT_Producto blt_Producto = new BLT_Producto();
                bot_Producto.Forma_Farmaceutica = txt_Forma_Farmaceutica.Text;
                bot_Producto.Nombre_Producto = txt_Producto.Text;
                bot_Producto.Presentacion = txtPresentacion.Text;
                bot_Producto.Proceso = txtProceso.Text;
                if (blt_Producto.fnInsUpdT_Producto(bot_Producto)) {
                    if (ProductoModificado != null) {
                        ProductoModificado(this, new EventArgs());
                    }
                    MessageBox.Show("Producto modificado satisfactoriamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Producto no fue modificado debido a un error interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
