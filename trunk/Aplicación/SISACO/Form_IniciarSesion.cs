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
using SISACO.Interfaces;
using SISACO.Utilitarios;
using SISACO.Eventos;

namespace SISACO
{
    public partial class Form_IniciarSesion : Form
    {
        private const string PERFIL_ADMINISTRADOR = "Administrador";
        private const string PERFIL_EMPLEADO = "Empleado";
        public Dictionary<string, Form> pantallaXPerfil;
        Form_PrincipalAdministrador appAdministrador;
        Form_PrincipalEmpleado appEmpleado;
        BOT_Usuario usuario;

        public Form_IniciarSesion()
        {
            InitializeComponent();
        }

        private void Form_IniciarSesion_Load(object sender, EventArgs e)
        {
            pantallaXPerfil = new Dictionary<string, Form>();
            pantallaXPerfil.Add(PERFIL_ADMINISTRADOR, appAdministrador);
            pantallaXPerfil.Add(PERFIL_EMPLEADO, appEmpleado);
            BLT_Perfil_Usuario blt_perfil_usuario = new BLT_Perfil_Usuario();
            cbx_Perfil.DataSource = blt_perfil_usuario.fnSelT_Perfil_UsuarioAll();
            txt_Nombre_Usuario.Focus();
            
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Nombre_Usuario.Text == "" || txt_Contraseña.Text == "" || cbx_Perfil.Text == "" || cbx_Perfil.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar su Usuario, su Contraseña y su Perfil.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Nombre_Usuario.Focus();
            }
            else
            {
                BLT_Usuario blt_usuario = new BLT_Usuario();
                usuario = blt_usuario.fnSelT_Usuario_by_Nombre(txt_Nombre_Usuario.Text);
                if (usuario.Codigo_Usuario == null) {
                    MessageBox.Show("Usuario no existe. No puede iniciar sesión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    //Encriptador _encriptador = new Encriptador();
                    BOT_Perfil_Usuario perfilSeleccionado = cbx_Perfil.SelectedItem as BOT_Perfil_Usuario;
                    if (Encriptador.Decrypt(usuario.Contraseña) == txt_Contraseña.Text && perfilSeleccionado.Codigo_Perfil_Usuario == usuario.DescripcionPerfil.Codigo_Perfil_Usuario) {
                        BOT_Perfil_Usuario bot_perfil_usuario = cbx_Perfil.SelectedItem as BOT_Perfil_Usuario;
                        Form appPrincipal = null;
                        switch (bot_perfil_usuario.Perfil_Usuario) {
                            case PERFIL_ADMINISTRADOR:
                                appPrincipal = new Form_PrincipalAdministrador();

                                break;
                            case PERFIL_EMPLEADO:
                                appPrincipal = new Form_PrincipalEmpleado();
                                break;
                            default:
                                break;
                        }
                        ISesionInit sesion = (ISesionInit)appPrincipal;
                        sesion.ProgramaTerminado += new EventHandler(sesion_ProgramaTerminado);
                        sesion.SesionIniciada += new Eventos.SesionIniciadaEventHandler(sesion_SesionIniciada);
                        sesion.SesionTerminada += new EventHandler(sesion_SesionTerminada);
                        if (appPrincipal != null) {
                            appPrincipal.Show();
                        }
                    }
                    else {
                        MessageBox.Show("Contraseña no válida o no corresponde al perfil del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        void sesion_SesionTerminada(object sender, EventArgs e) {
            txt_Contraseña.Clear();
            txt_Nombre_Usuario.Clear();
            txt_Nombre_Usuario.Focus();
            this.Show();
        }

        void sesion_SesionIniciada(object sender, SesionIniciadaEventArgs e) {
            e.UsuarioIniciaSesion = usuario;
            this.Hide();
        }

        void sesion_ProgramaTerminado(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro de que desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                //this.Close();
                Application.Exit();
            else
            {
                //
            }
        }
    }
}
