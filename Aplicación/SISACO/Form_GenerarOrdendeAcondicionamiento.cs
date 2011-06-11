using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SISACO
{
    public partial class Form_GenerarOrdendeAcondicionamiento : Form
    {
        public Form_GenerarOrdendeAcondicionamiento()
        {
            InitializeComponent();
        }

        private void Form_GenerarOrdendeAcondicionamiento_Load(object sender, EventArgs e)
        {
            txt_Codigo_Orden_Acondicionamiento.Focus();
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_Orden_Acondicionamiento.Text == "")
            {
                MessageBox.Show("Debe de ingresar el Código de la Orden de Acondicionamiento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Codigo_Orden_Acondicionamiento.Focus();
            }
            else
            {
                //
            }
        }
    }
}
