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
    public partial class Form_CrearProducto : Form
    {
        public const string MSG_Grabo = "Producto ha sido registrado satisfactoriamente.";
        public const string MSG_NoGrabo = "Ocurrió un error inesperado.";

        public event EventHandler ProductoRegistrado;

        public Form_CrearProducto()
        {
            InitializeComponent();
        }

        private void Form_CrearProducto_Load(object sender, EventArgs e)
        {
            Limpia();
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
                //
                BOT_Producto bot_Producto = new BOT_Producto();
                bot_Producto.Forma_Farmaceutica = txt_Forma_Farmaceutica.Text;
                bot_Producto.Nombre_Producto = txt_Producto.Text;
                bot_Producto.Presentacion = txt_Presentacion.Text;
                bot_Producto.Proceso = txt_Proceso.Text;
                BLT_Producto blt_Producto = new BLT_Producto();
                if (blt_Producto.fnInsUpdT_Producto(bot_Producto)) {
                    MessageBox.Show(MSG_Grabo, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ProductoRegistrado != null) {
                        ProductoRegistrado(this, new EventArgs());
                    }
                    Limpia();
                }
                else {
                    MessageBox.Show(MSG_NoGrabo, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpia() {
            txt_Codigo_Producto.Clear();
            txt_Forma_Farmaceutica.Clear();
            txt_Producto.Clear();
            txt_Presentacion.Clear();
            txt_Proceso.Clear();
            BLT_Producto blt_Producto = new BLT_Producto();
            txt_Codigo_Producto.Text = blt_Producto.fnSelT_ProductoCodigo();
            txt_Producto.Focus();
        }
    }
}
