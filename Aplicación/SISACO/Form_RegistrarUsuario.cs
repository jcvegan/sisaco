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
    public partial class Form_RegistrarUsuario : Form
    {
        BOT_Usuario cUsu = new BOT_Usuario();

        public Form_RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void Form_RegistrarEmpleado_Load(object sender, EventArgs e)
        {
            //BLT_Usuario cUsu = new BLT_Usuario();
            //dgv_Usuarios.DataSource = cUsu.fnSelT_UsuarioAll();
            CargaUsuarios();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_CrearUsuario cu = new Form_CrearUsuario();
            cu.UsuarioCreado += new EventHandler(cu_UsuarioCreado);
            cu.ShowDialog();
        }

        void cu_UsuarioCreado(object sender, EventArgs e) {
            CargaUsuarios();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_Usuario.CurrentRow != null) {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar al Usuario seleccionado?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes) {
                    BOT_Usuario bot_Usuario = dgv_Usuario.CurrentRow.DataBoundItem as BOT_Usuario;
                    BLT_Usuario blt_Usuario = new BLT_Usuario();
                    if (blt_Usuario.fnDelT_Usuario(bot_Usuario.Codigo_Usuario)) {
                        CargaUsuarios();
                    }
                    else {
                        MessageBox.Show("Usuario no eliminado. Ocurrió un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //dgv_Usuarios.Rows.RemoveAt(dgv_Usuarios.CurrentRow.Index);
                    //MessageBox.Show(cUsu.Eliminar_Usuario(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else {
                MessageBox.Show("Debe seleccionar un usuario para realizar esta operación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_Usuario.CurrentRow != null) {
                BOT_Usuario bt_usuario = dgv_Usuario.CurrentRow.DataBoundItem as BOT_Usuario;
                Form_ModificarUsuario mu = new Form_ModificarUsuario(bt_usuario);
                mu.UsuarioModificado += new EventHandler(mu_UsuarioModificado);
                mu.ShowDialog();
            }
            
        }

        void mu_UsuarioModificado(object sender, EventArgs e) {
            CargaUsuarios();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_BuscarUsuario bp = new Form_BuscarUsuario();
            bp.FiltroRealizado += new FiltroUsuarioEventHandler(bp_FiltroRealizado);
            bp.ShowDialog();
        }

        void bp_FiltroRealizado(object sender, FiltroUsuarioEventArgs e) {
            dgv_Usuario.DataSource = e.ListaUsuario;
        }

        private void verTodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CargaUsuarios();
        }

        private void CargaUsuarios() {
            dgv_Usuario.DataSource = null;
            dgv_Usuario.AutoGenerateColumns = false;
            BLT_Usuario blt_Usuario = new BLT_Usuario();
            List<BOT_Usuario> list_bot_usuario = blt_Usuario.fnSelT_UsuarioAll();
            if (list_bot_usuario.Count == 0) {
                eliminarToolStripMenuItem1.Enabled = false;
                modificarToolStripMenuItem1.Enabled = false;
            }
            else {
                eliminarToolStripMenuItem1.Enabled = true;
                modificarToolStripMenuItem1.Enabled = true;
            }
            dgv_Usuario.DataSource = list_bot_usuario;
        }

        private void dgv_Usuario_SelectionChanged(object sender, EventArgs e) {
            if (dgv_Usuario.SelectedRows == null) {
                eliminarToolStripMenuItem1.Enabled = false;
                modificarToolStripMenuItem1.Enabled = false;
            }
            else {
                eliminarToolStripMenuItem1.Enabled = true;
                modificarToolStripMenuItem1.Enabled = true;
            }
        }
    }
}