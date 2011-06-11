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
    public partial class Form_BuscarporPeriodo : Form
    {
        public Form_BuscarporPeriodo()
        {
            InitializeComponent();
        }

        private void Form_BuscarporPeriodo_Load(object sender, EventArgs e)
        {
            dtp_Fecha_Inicial.Focus();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (dtp_Fecha_Inicial.Value > dtp_Fecha_Final.Value)
            {
                MessageBox.Show("La Fecha Inicial debe ser menor a la Fecha Final.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtp_Fecha_Inicial.Focus();
            }
            else
            {
                Form_SeleccionarporPeriodo spp = new Form_SeleccionarporPeriodo();
                spp.ShowDialog();
            }
        }
    }
}
