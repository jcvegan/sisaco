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
    public partial class Form_ModificarMaterialdeEmpaque : Form
    {
        BOT_Material_Empaque bot_Material_Empaque;
        public event EventHandler MaterialEmpaqueModificado;
        public Form_ModificarMaterialdeEmpaque(BOT_Material_Empaque _bot_material_empaque)
        {
            bot_Material_Empaque = _bot_material_empaque;
            InitializeComponent();
        }

        private void Form_ModificarMaterialdeEmpaque_Load(object sender, EventArgs e)
        {
            txt_Codigo_Material.Text = bot_Material_Empaque.Codigo_Material_Empaque;
            txt_Material_Empaque.Text = bot_Material_Empaque.Nombre_Material_Empaque;
            cbx_Unidad_Medida.SelectedItem = bot_Material_Empaque.Unidad_Medida;
            txt_Material_Empaque.Focus();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (txt_Material_Empaque.Text == "" || cbx_Unidad_Medida.SelectedItem == null)
            {
                MessageBox.Show("Debe de ingresar todos los datos solicitados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Material_Empaque.Focus();
            }
            else
            {
                BLT_Material_Empaque blt_Material_Empaque = new BLT_Material_Empaque();
                bot_Material_Empaque.Nombre_Material_Empaque = txt_Material_Empaque.Text;
                //bot_Material_Empaque.Unidad_Medida = cbx_Unidad_Medida.SelectedItem;
                bot_Material_Empaque.Unidad_Medida = cbx_Unidad_Medida.SelectedItem.ToString();
                if (blt_Material_Empaque.fnUpdT_Material_Empaque(bot_Material_Empaque))
                {
                    MessageBox.Show("Material empaque modificado satisfactoriamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MaterialEmpaqueModificado != null)
                    {
                        MaterialEmpaqueModificado(this, new EventArgs());
                    }
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
