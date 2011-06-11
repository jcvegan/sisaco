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
    public partial class Form_BuscarporProducto : Form {
        

        public Form_BuscarporProducto()
        {
            InitializeComponent();
        }

        private void Form_BuscarporProducto_Load(object sender, EventArgs e)
        {
            txt_Codigo_Producto.Focus();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_Producto.Text == "")
            {
                MessageBox.Show("Debe ingresar el Código del Producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Codigo_Producto.Focus();
            }
            else
            {
                Form_SeleccionarporProducto spp = new Form_SeleccionarporProducto();
                spp.ShowDialog();
            }
        }
    }

}
