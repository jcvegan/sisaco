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
    public partial class Form_RegistrarMaterialdeEmpaqueporProducto : Form {

        #region Constantes

        private const string const_titAdvertencia = "Advertencia";
        private const string const_msgErrorCodProductoIng = "Debe de ingresar el Código del Producto.";
        private const string const_msgEliminarMaterialEmpaque = "¿Está seguro que desea eliminar el material de empaque para este producto?";

        #endregion

        #region Campos

        private BOT_Producto bot_Producto;

        #endregion

        #region Constructor

        public Form_RegistrarMaterialdeEmpaqueporProducto() {
            InitializeComponent();
            
        }
        
        #endregion

        #region Métodos

        #region Privados

        private void Form_CantidaddeMaterialporProducto_Load(object sender, EventArgs e)
        {
            txt_Codigo_Producto.Focus();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_Producto.Text == "") {
                Form_SeleccionarProducto frm_SeleccionarProducto = new Form_SeleccionarProducto(true);
                frm_SeleccionarProducto.ProductoSeleccionado += new ProductoSeleccionadoEventHandler(frm_SeleccionarProducto_ProductoSeleccionado);
                frm_SeleccionarProducto.ShowDialog();
            }
            else {
                CargaProducto(txt_Codigo_Producto.Text);
            }
        }

        void frm_SeleccionarProducto_ProductoSeleccionado(object sender, ProductoSeleccionadoEventArgs e) {
            txt_Codigo_Producto.Text = e.ProductoSeleccionado.Codigo_Producto;
            CargaProducto(txt_Codigo_Producto.Text);
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Tamaño_Lote.Text == "")
            {
                MessageBox.Show("Debe de ingresar el Tamaño del Lote.", const_titAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Tamaño_Lote.Focus();
            }
            else
            {
                if (int.Parse(txt_Tamaño_Lote.Text) < 0)
                {
                    MessageBox.Show("El tamaño del lote no acepta valores negativos", const_titAdvertencia, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    lbl_Tamaño_Lote.Enabled = false;
                    txt_Tamaño_Lote.Enabled = false;
                    btn_Aceptar.Enabled = false;
                    lbl_Tamaño_Lote.Enabled = false;
                    btn_Agregar.Enabled = true;
                    btn_Eliminar.Enabled = true;
                    btn_Aceptar_2.Enabled = true;
                    dgv_Cantidad_Material_x_Producto.Enabled = true;
                    CargaMaterialesXProducto();
                }
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Codigo_Producto.Text = "";
            txt_Nombre_Producto.Text = "";
            txt_Tamaño_Lote.Text = "";
            dgv_Cantidad_Material_x_Producto.DataSource = new List<BOT_Material_Empaque>();
            lbl_Codigo_Producto.Enabled = true;
            txt_Codigo_Producto.Enabled = true;
            btn_Buscar.Enabled = true;
            lbl_Tamaño_Lote.Enabled = false;
            txt_Tamaño_Lote.Enabled = false;
            btn_Aceptar.Enabled = false;
            dgv_Cantidad_Material_x_Producto.Enabled = false;
            btn_Limpiar.Enabled = false;
            btn_Agregar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Aceptar_2.Enabled = false;
            txt_Codigo_Producto.Focus();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Form_RegistrarMaterialdeEmpaque rme = new Form_RegistrarMaterialdeEmpaque();
            rme.MaterialEmpaqueRegistrado += new EventHandler(rme_MaterialEmpaqueRegistrado);
            rme.MaterialEmpaqueModificado += new EventHandler(rme_MaterialEmpaqueModificado);
            rme.MaterialEmpaqueEliminado += new EventHandler(rme_MaterialEmpaqueEliminado);
            rme.MaterialEmpaqueSeleccionado += new MaterialEmpaqueSeleccionadoEventHandler(rme_MaterialEmpaqueSeleccionado);
            rme.ShowDialog();
        }

        void rme_MaterialEmpaqueSeleccionado(object sender, MaterialEmpaqueSeleccionadoEventArgs e) {            
            BLT_Material_Empaque_x_Producto blt_Material_Empaque_x_Producto = new BLT_Material_Empaque_x_Producto();
            if (!blt_Material_Empaque_x_Producto.fnExsT_Material_Empaque_x_Producto(txt_Codigo_Producto.Text, e.MaterialEmpaqueSeleccionado.Codigo_Material_Empaque,int.Parse(txt_Tamaño_Lote.Text))) {
                BOT_Material_Empaque me = e.MaterialEmpaqueSeleccionado;
                BOT_Material_Empaque_x_Producto bot_Material_Empaque_x_Producto = new BOT_Material_Empaque_x_Producto();
                bot_Material_Empaque_x_Producto.Codigo_Producto = txt_Codigo_Producto.Text;
                bot_Material_Empaque_x_Producto.Codigo_Material_Empaque = e.MaterialEmpaqueSeleccionado.Codigo_Material_Empaque;
                bot_Material_Empaque_x_Producto.Tamaño_Lote = Convert.ToInt32(txt_Tamaño_Lote.Text);
                bot_Material_Empaque_x_Producto.Lote_Fabricacion = DateTime.Now.Year.ToString() + ((DateTime.Now.Month.ToString().Length == 1) ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + ((DateTime.Now.Day.ToString().Length == 1) ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString());
                if (blt_Material_Empaque_x_Producto.fnInsUpdT_Material_Empaque_x_Producto(bot_Material_Empaque_x_Producto)) {
                    CargaMaterialesXProducto();
                }
            }
            else {
                MessageBox.Show("Material ya se encuentra asignado a dicho producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void rme_MaterialEmpaqueEliminado(object sender, EventArgs e)
        {
            CargaMaterialesXProducto();
        }

        void rme_MaterialEmpaqueModificado(object sender, EventArgs e)
        {
            CargaMaterialesXProducto();
        }

        void rme_MaterialEmpaqueRegistrado(object sender, EventArgs e)
        {
            CargaMaterialesXProducto();
        }

        private void btn_Aceptar_2_Click(object sender, EventArgs e)
        {
            List<BOT_Material_Empaque> data_Material_Empaque = dgv_Cantidad_Material_x_Producto.DataSource as List<BOT_Material_Empaque>;

            if (txt_Tamaño_Lote.Text == "" || dgv_Cantidad_Material_x_Producto.Rows.Count == 0)
            {
                MessageBox.Show("Debe de Ingresar el Tamaño del Lote y luego los Materiales de Empaque que conformaran el Producto elegido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Tamaño_Lote.Focus();
            }
            else
            {
                //
                List<BOT_Material_Empaque_x_Producto> list_Material_Empaque_x_Producto = new List<BOT_Material_Empaque_x_Producto>();
                foreach (BOT_Material_Empaque oMaterial_Empaque in data_Material_Empaque)
                {
                    BOT_Material_Empaque_x_Producto oMaterial_Empaque_x_Producto = new BOT_Material_Empaque_x_Producto();
                    oMaterial_Empaque_x_Producto.Codigo_Producto = txt_Codigo_Producto.Text;
                    oMaterial_Empaque_x_Producto.Codigo_Material_Empaque = oMaterial_Empaque.Codigo_Material_Empaque;
                    oMaterial_Empaque_x_Producto.Cantidad_Pedida = Convert.ToDecimal(oMaterial_Empaque.Cantidad_Pedida);
                    oMaterial_Empaque_x_Producto.Unidad_Medida = oMaterial_Empaque.Unidad_Medida;
                    oMaterial_Empaque_x_Producto.Tamaño_Lote = Int32.Parse(txt_Tamaño_Lote.Text);
                    oMaterial_Empaque_x_Producto.Codigo_Material_Empaque_x_Producto = oMaterial_Empaque.CodigoMaterialEmpaquexProducto;
                    //DateTime dLote = DateTime.Now;
                    oMaterial_Empaque_x_Producto.Lote_Fabricacion = DateTime.Now.Year.ToString() + ((DateTime.Now.Month.ToString().Length == 1) ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString()) + ((DateTime.Now.Day.ToString().Length == 1) ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString());
                    BLT_Material_Empaque_x_Producto blt_Material_Empaque_x_Producto = new BLT_Material_Empaque_x_Producto();
                    blt_Material_Empaque_x_Producto.fnInsUpdT_Material_Empaque_x_Producto(oMaterial_Empaque_x_Producto);
                }
                CargaMaterialesXProducto();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            BOT_Material_Empaque bot_MaterialEmpaque = dgv_Cantidad_Material_x_Producto.CurrentRow.DataBoundItem as BOT_Material_Empaque;
            DialogResult result = MessageBox.Show(const_msgEliminarMaterialEmpaque, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                BLT_Material_Empaque_x_Producto blt_Material_Empaque_x_Producto = new BLT_Material_Empaque_x_Producto();
                BOT_Material_Empaque_x_Producto bot_Material_Empaque_x_Producto;
                bot_Material_Empaque_x_Producto = blt_Material_Empaque_x_Producto.fnSelT_Material_Empaque_x_Producto(bot_MaterialEmpaque.CodigoMaterialEmpaquexProducto);
                bool _resultado = true;
                if (bot_Material_Empaque_x_Producto != null)
                {
                    _resultado = blt_Material_Empaque_x_Producto.fnDelT_Material_Empaque_x_Producto(bot_Material_Empaque_x_Producto.Codigo_Material_Empaque_x_Producto);
                }
                if (_resultado)
                {
                    CargaMaterialesXProducto();
                }
            }
        }

        #endregion

        #region Internos

        internal void CargaProducto(string cd_Producto)
        {
            BLT_Producto blt_Producto = new BLT_Producto();
            bot_Producto = new BOT_Producto();
            bot_Producto = blt_Producto.fnSelT_Producto(cd_Producto);
            if (bot_Producto.Codigo_Producto != null)
            {
                txt_Nombre_Producto.Text = bot_Producto.Nombre_Producto;
                lbl_Codigo_Producto.Enabled = false;
                txt_Codigo_Producto.Enabled = false;
                btn_Buscar.Enabled = false;
                lbl_Tamaño_Lote.Enabled = true;
                txt_Tamaño_Lote.Enabled = true;
                btn_Aceptar.Enabled = true;
                btn_Limpiar.Enabled = true;
                txt_Tamaño_Lote.Focus();
            }
            else
            {
                MessageBox.Show("Producto no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void CargaMaterialesXProducto()
        {
            dgv_Cantidad_Material_x_Producto.DataSource = null;
            BLT_Material_Empaque blt_Material_Empaque = new BLT_Material_Empaque();
            BLT_Material_Empaque_x_Producto blt_Material_Empaque_x_Producto = new BLT_Material_Empaque_x_Producto();
            List<BOT_Material_Empaque> list_oME = new List<BOT_Material_Empaque>();
            List<BOT_Material_Empaque_x_Producto> list_OMEP = new List<BOT_Material_Empaque_x_Producto>();
            list_OMEP = blt_Material_Empaque_x_Producto.fnSelT_Material_Empaque_x_ProductoDin("Codigo_Producto = '" + txt_Codigo_Producto.Text + "' and Tamaño_Lote = " + txt_Tamaño_Lote.Text, "");
            if (list_OMEP.Count != 0) {
                foreach (BOT_Material_Empaque_x_Producto oMEP in list_OMEP) {
                    BOT_Material_Empaque oME = new BOT_Material_Empaque();
                    oME = blt_Material_Empaque.fnSelT_Material_Empaque(oMEP.Codigo_Material_Empaque);
                    oME.Cantidad_Pedida = oMEP.Cantidad_Pedida;
                    oME.CodigoMaterialEmpaquexProducto = oMEP.Codigo_Material_Empaque_x_Producto;
                    list_oME.Add(oME);
                }
                dgv_Cantidad_Material_x_Producto.AutoGenerateColumns = false;
                dgv_Cantidad_Material_x_Producto.DataSource = list_oME;
            }
            else {
                MessageBox.Show("El producto no tiene asignados materiales de empaque", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #endregion

    }
}
