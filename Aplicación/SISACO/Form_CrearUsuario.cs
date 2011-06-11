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
using SISACO.Utilitarios;

namespace SISACO
{
    public partial class Form_CrearUsuario : Form
    {
        public event EventHandler UsuarioCreado;
        public Form_CrearUsuario()
        {
            InitializeComponent();
        }

        private void Form_CrearUsuario_Load(object sender, EventArgs e)
        {
            txt_Nombres_Usuario.Focus();
            BLT_Usuario blt_usuario = new BLT_Usuario();
            txt_Codigo_Usuario.Text = blt_usuario.fnSelT_UsuarioCodigo();
            BLT_Perfil_Usuario blt_perfil_usuario = new BLT_Perfil_Usuario();
            cbx_Perfil_Usuario.DataSource = blt_perfil_usuario.fnSelT_Perfil_UsuarioAll();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (txt_Nombres_Usuario.Text == "" || txt_Apellidos_Usuario.Text == "" || txt_Nombre_Usuario.Text == "" || txt_Contraseña_Usuario.Text == "" || cbx_Perfil_Usuario.Text == "" || cbx_Perfil_Usuario.SelectedItem == null)
            {
                MessageBox.Show("Debe de ingresar todos los datos solicitados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Nombres_Usuario.Focus();
            }
            else
            {

                //BOT_Perfil_Usuario cUsu = new BOT_Perfil_Usuario();
                //cUsu.Codigo_Empleado = txt_Codigo_Usuario.Text;
                //cUsu.Nombres_Empleado = txt_Nombres_Usuario.Text;
                //cUsu.Apellidos_Empleado = txt_Apellidos_Usuario.Text;
                //cUsu.Nombre_Usuario_Empleado = txt_Nombre_Usuario.Text;
                //cUsu.Contraseña_Usuario_Empleado = txt_Contraseña_Usuario.Text;
                //cUsu.Perfil_Empleado = cbx_Perfil_Usuario.Text;
                Encriptador _encriptador = new Encriptador();
                BOT_Usuario bot_usuario = new BOT_Usuario();
                bot_usuario.Apellidos = txt_Apellidos_Usuario.Text;
                bot_usuario.Codigo_Perfil_Usuario = (string)cbx_Perfil_Usuario.SelectedValue;
                bot_usuario.Contraseña = Encriptador.Encrypt(txt_Contraseña_Usuario.Text);
                bot_usuario.Nombres = txt_Nombres_Usuario.Text;
                bot_usuario.Nombre_Usuario = txt_Nombre_Usuario.Text;
                BLT_Usuario blt_usuario = new BLT_Usuario();
                if (blt_usuario.fnInsUpdT_Usuario(bot_usuario)) {
                    if (UsuarioCreado != null) {
                        UsuarioCreado(this, new EventArgs());
                    }
                    MessageBox.Show("Usuario ha sido registrado satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Apellidos_Usuario.Clear();
                    txt_Codigo_Usuario.Clear();
                    txt_Contraseña_Usuario.Clear();
                    txt_Nombre_Usuario.Clear();
                    txt_Nombres_Usuario.Clear();
                    txt_Codigo_Usuario.Text = blt_usuario.fnSelT_UsuarioCodigo();
                }
                else {
                    MessageBox.Show("Ha ocurrido un error inesperado, usuario no ha sido registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //MessageBox.Show(cUsu.Nuevo_Usuario(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
