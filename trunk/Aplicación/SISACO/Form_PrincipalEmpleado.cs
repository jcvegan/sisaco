using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SISACO.Interfaces;
using SISACO.Eventos;

namespace SISACO
{
    public partial class Form_PrincipalEmpleado : Form, ISesionInit
    {
        private bool _soloCierraSesion = false;

        public Form_PrincipalEmpleado()
        {
            InitializeComponent();
        }

        public event SesionIniciadaEventHandler SesionIniciada;

        public event EventHandler SesionTerminada;

        public event EventHandler ProgramaTerminado;

        private void nuevaOrdenDeAcondicionamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_OrdendeAcondicionamiento oa = new Form_OrdendeAcondicionamiento();
            oa.ShowDialog();
        }

        private void abrirOrdenDeAcondicionamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AbrirOrdendeAcondicionamiento aoa = new Form_AbrirOrdendeAcondicionamiento();
            ShowDialog();
        }

        private void porProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_BuscarporProducto bpp = new Form_BuscarporProducto();
            ShowDialog();
        }

        private void porPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_BuscarporPeriodo bpp = new Form_BuscarporPeriodo();
            ShowDialog();
        }

        private void porOrdenDeAcondicionamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_GenerarOrdendeAcondicionamiento goa = new Form_GenerarOrdendeAcondicionamiento();
            ShowDialog();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form_CambiarContraseña cc = new Form_CambiarContraseña();
            //ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro de que desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                _soloCierraSesion = true;
                this.Close();
            }
            else
            {
                //
            }
        }

    }
}
