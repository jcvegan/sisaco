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
using BO_SISACO;

namespace SISACO
{
    public partial class Form_PrincipalAdministrador : Form, ISesionInit
    {
        private bool _soloCierraSesion = false;
        private BOT_Usuario usuario;
        public event SesionIniciadaEventHandler SesionIniciada;
        public event EventHandler SesionTerminada;
        public event EventHandler ProgramaTerminado;

        public Form_PrincipalAdministrador()
        {
            InitializeComponent();
        }

        private void Form_PrincipalAdministrador_Load(object sender, EventArgs e)
        {
            SesionIniciadaEventArgs siEventArgs;
            if (SesionIniciada != null) {
                siEventArgs = new SesionIniciadaEventArgs(new BOT_Usuario());
                SesionIniciada(this, siEventArgs);
                usuario = siEventArgs.UsuarioIniciaSesion;
            }
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RegistrarUsuario ru = new Form_RegistrarUsuario();
            ru.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RegistrarProducto rp = new Form_RegistrarProducto();
            rp.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro de que desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                this.Close();
            else
            {
                //
            }
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RegistrarMaterialdeEmpaque rm = new Form_RegistrarMaterialdeEmpaque();
            rm.Show();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_OrdendeAcondicionamiento oa = new Form_OrdendeAcondicionamiento();
            oa.Show();
        }

        private void abrirOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AbrirOrdendeAcondicionamiento ao = new Form_AbrirOrdendeAcondicionamiento();
            ao.Show();
        }

        private void porPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_BuscarporPeriodo bp = new Form_BuscarporPeriodo();
            bp.Show();
        }

        private void porProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_BuscarporProducto bp = new Form_BuscarporProducto();
            bp.Show();
        }

        private void porPeriodoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void detalladoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearCopiaDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restaurarCopiaDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configurarImpresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ayudaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeSISACOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cantidadDeMaterialPorTamañoDeLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RegistrarMaterialdeEmpaqueporProducto mep = new Form_RegistrarMaterialdeEmpaqueporProducto();
            mep.ShowDialog();
        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_GenerarOrdendeAcondicionamiento goa = new Form_GenerarOrdendeAcondicionamiento();
            goa.ShowDialog();
        }

        private void nuevaOrdenDeAcondicionamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_OrdendeAcondicionamiento oa = new Form_OrdendeAcondicionamiento();
            oa.ShowDialog();
        }

        private void abrirOrdenDeAcondicionamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AbrirOrdendeAcondicionamiento aoa = new Form_AbrirOrdendeAcondicionamiento();
            aoa.ShowDialog();
        }

        private void porToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_BuscarporProducto bp = new Form_BuscarporProducto();
            bp.ShowDialog();
        }

        private void porPeriodoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form_BuscarporPeriodo bp = new Form_BuscarporPeriodo();
            bp.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RegistrarUsuario ru = new Form_RegistrarUsuario();
            ru.ShowDialog();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_RegistrarProducto rp = new Form_RegistrarProducto();
            rp.ShowDialog();
        }

        private void materialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_RegistrarMaterialdeEmpaque rme = new Form_RegistrarMaterialdeEmpaque();
            rme.ShowDialog();
        }

        private void materialPorProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RegistrarMaterialdeEmpaqueporProducto rmep = new Form_RegistrarMaterialdeEmpaqueporProducto();
            rmep.ShowDialog();
        }

        private void porOrdenDeAcondiconamientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_GenerarOrdendeAcondicionamiento goa = new Form_GenerarOrdendeAcondicionamiento();
            goa.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void cambiarContraseñaToolStripMenuItem_Click(object sender,EventArgs e){
            Form_CambiarContraseña cc = new Form_CambiarContraseña(usuario);
            cc.ShowDialog();
        }

        private void Form_PrincipalAdministrador_FormClosed(object sender, FormClosedEventArgs e) {
            if (_soloCierraSesion) {
                if (SesionTerminada != null) {
                    SesionTerminada(this, new EventArgs());
                }
            }
            else {
                if (ProgramaTerminado != null) {
                    ProgramaTerminado(this, new EventArgs());
                }
            }
        }


        
    }
}
