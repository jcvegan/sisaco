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

namespace SISACO {
    public partial class Form_CambiarContraseña : Form {
        BOT_Usuario usuario;
        public Form_CambiarContraseña(BOT_Usuario usr) {
            usuario = usr;
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e) {
            if (txt_Contraseña_Actual.Text != "" && txt_Contraseña_Nueva.Text != "" && txt_Confirmar_Contraseña_Nueva.Text != "") {
                if (txt_Contraseña_Actual.Text == Encriptador.Decrypt(usuario.Contraseña)) {
                    if (txt_Contraseña_Nueva.Text == txt_Confirmar_Contraseña_Nueva.Text) {
                        BLT_Usuario blt_usuario = new BLT_Usuario();
                        usuario.Contraseña = Encriptador.Encrypt(txt_Contraseña_Nueva.Text);
                        if (blt_usuario.fnInsUpdT_Usuario(usuario)) {
                            MessageBox.Show("Cambio de contraseña realizado.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else {
                    MessageBox.Show("No se puede realizar operación. Su contraseña actual no coincide con la ingresada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("No se puede realizar operación. Todos los campos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e) {

        }
    }
}
