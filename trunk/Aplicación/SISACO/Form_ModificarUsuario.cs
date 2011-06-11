using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BO_SISACO;
using SISACO.Utilitarios;
using BL_SISACO;

namespace SISACO
{
    public partial class Form_ModificarUsuario : Form
    {
        private BOT_Usuario bot_usuario;
        public event EventHandler UsuarioModificado;
        public Form_ModificarUsuario(BOT_Usuario usuario)
        {
            bot_usuario = usuario;
            InitializeComponent();
        }

        private void Form_ModificarUsuario_Load(object sender, EventArgs e)
        {
            BLT_Perfil_Usuario blt_perfil_usuario = new BLT_Perfil_Usuario();
            cbx_Perfil_Usuario.DataSource = blt_perfil_usuario.fnSelT_Perfil_UsuarioAll();
            cbx_Perfil_Usuario.SelectedItem = bot_usuario.DescripcionPerfil;
            //txt_Contraseña_Usuario.Text = Encriptador.Desencripta(bot_usuario.Contraseña);
            txt_Nombre_Usuario.Text = bot_usuario.Nombre_Usuario;
            txt_Nombres_Usuario.Text = bot_usuario.Nombres;
            txt_Codigo_Usuario.Enabled = false;
            txt_Apellidos_Usuario.Text = bot_usuario.Apellidos;
            txt_Codigo_Usuario.Text = bot_usuario.Codigo_Usuario;
            
            txt_Nombres_Usuario.Focus();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_Usuario.Text == "" || txt_Nombres_Usuario.Text == "" || txt_Apellidos_Usuario.Text == "" || txt_Nombre_Usuario.Text == "" || txt_Contraseña_Usuario.Text == "" || cbx_Perfil_Usuario.Text == "" || cbx_Perfil_Usuario.SelectedItem == null)
            {
                MessageBox.Show("Debe de ingresar todos los datos solicitados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Nombres_Usuario.Focus();
            }
            else
            {
                Encriptador _encriptador = new Encriptador();
                BLT_Usuario blt_usuario = new BLT_Usuario();
                bot_usuario.Apellidos = txt_Apellidos_Usuario.Text;
                bot_usuario.Contraseña = Encriptador.Encrypt(txt_Contraseña_Usuario.Text);
                bot_usuario.Nombre_Usuario = txt_Nombre_Usuario.Text;
                bot_usuario.Nombres = txt_Nombres_Usuario.Text;
                bot_usuario.Codigo_Perfil_Usuario = (cbx_Perfil_Usuario.SelectedItem as BOT_Perfil_Usuario).Codigo_Perfil_Usuario;
                if (blt_usuario.fnInsUpdT_Usuario(bot_usuario)) {
                    if (UsuarioModificado != null) {
                        UsuarioModificado(this, new EventArgs());
                    }
                    MessageBox.Show("Usuario actualizado satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Usuario no actualizado. Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
