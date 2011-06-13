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
    public partial class Form_SeleccionarProducto : Form 
    {
        private bool muestraTodos;

        public event ProductoSeleccionadoEventHandler ProductoSeleccionado;

        public Form_SeleccionarProducto(bool _muestraTodos) 
        {
            muestraTodos = _muestraTodos;
            InitializeComponent();
        }

        public void Init() {
            BLT_Producto blt_producto = new BLT_Producto();
            dgv_Seleccionar_Producto.AutoGenerateColumns = false;
            if (muestraTodos) {
                dgv_Seleccionar_Producto.DataSource = blt_producto.fnSelT_ProductoAll();
            }
            else {
                dgv_Seleccionar_Producto.DataSource = blt_producto.fnSelT_Producto_conMaterialEmpaque();
            }
        }

        private void dgv_Productos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) 
        {
            if (dgv_Seleccionar_Producto.SelectedRows != null) 
            {
                if (e.RowIndex >= 0) {
                    BOT_Producto bot_producto = dgv_Seleccionar_Producto.Rows[e.RowIndex].DataBoundItem as BOT_Producto;

                    if (ProductoSeleccionado != null) {
                        ProductoSeleccionado(this, new ProductoSeleccionadoEventArgs(bot_producto));
                        this.Close();
                    }
                }
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e) 
        {
            if (dgv_Seleccionar_Producto.SelectedRows != null) 
            {
                BOT_Producto bot_producto = dgv_Seleccionar_Producto.CurrentRow.DataBoundItem as BOT_Producto;

                if (ProductoSeleccionado != null) 
                {
                    ProductoSeleccionado(this, new ProductoSeleccionadoEventArgs(bot_producto));
                    this.Close();
                }
            }
        }

        private void Form_SelectorProducto_Load(object sender, EventArgs e) 
        {
            Init();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
