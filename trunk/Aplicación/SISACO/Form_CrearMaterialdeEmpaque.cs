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

namespace SISACO
{
    public partial class Form_CrearMaterialdeEmpaque : Form
    {
        #region Constantes

        public const string MSG_Grabo = "Material de empaque ha sido registrado satisfactoriamente.";
        public const string MSG_NoGrabo = "Ocurrió un error inesperado.";

        #endregion

        #region Campos

        BOT_Material_Empaque aSerActualizado;

        #endregion

        #region Eventos

        public event EventHandler MaterialCreado;

        #endregion

        #region Constructor

        public Form_CrearMaterialdeEmpaque()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos

        private void Form_CrearMaterialdeEmpaque_Load(object sender, EventArgs e)
        {
            BLT_Material_Empaque blt_Material_Empaque = new BLT_Material_Empaque();
            txt_Codigo_Material.Text = blt_Material_Empaque.fnSelT_Material_EmpaqueCodigo();
            txt_Material_Empaque.Focus();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (txt_Material_Empaque.Text == "" || cbx_Unidad_Medida.SelectedItem == null)
            {
                MessageBox.Show("Debe de ingresar todos los datos solicitados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Material_Empaque.Focus();
            }
            else
            {
                //

                BOT_Material_Empaque bot_Material_Empaque = new BOT_Material_Empaque();
                bot_Material_Empaque.Codigo_Material_Empaque = txt_Codigo_Material.Text;
                bot_Material_Empaque.Nombre_Material_Empaque = txt_Material_Empaque.Text;
                //bot_Material_Empaque.Unidad_Medida = cbx_Unidad_Medida.SelectedItem;
                bot_Material_Empaque.Unidad_Medida = cbx_Unidad_Medida.SelectedItem.ToString();
                BLT_Material_Empaque blt_Material_Empaque = new BLT_Material_Empaque();
                if (blt_Material_Empaque.fnInsT_Material_Empaque(bot_Material_Empaque))
                {
                    MessageBox.Show(MSG_Grabo, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpia();
                    txt_Codigo_Material.Text = blt_Material_Empaque.fnSelT_Material_EmpaqueCodigo();
                    if (MaterialCreado != null)
                    {
                        MaterialCreado(this, new EventArgs());
                    }
                }
                else
                {
                    MessageBox.Show(MSG_NoGrabo, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpia()
        {
            txt_Codigo_Material.Clear();
            txt_Material_Empaque.Clear();
            cbx_Unidad_Medida.SelectedItem = null;
        }

        #endregion


        
    }
}
