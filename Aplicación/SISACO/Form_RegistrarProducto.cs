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
    public partial class Form_RegistrarProducto : Form
    {
        public event ProductoSeleccionadoEventHandler ProductoSeleccionado;
        public event EventHandler ProductoEliminado;
        public Form_RegistrarProducto()
        {
            InitializeComponent();
        }

        private void Form_RegistrarProducto_Load(object sender, EventArgs e)
        {
            CargaProductos();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_CrearProducto cp = new Form_CrearProducto();
            cp.ProductoRegistrado += new EventHandler(cp_ProductoRegistrado);
            cp.ShowDialog();
        }

        void cp_ProductoRegistrado(object sender, EventArgs e) {
            CargaProductos();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_Producto.CurrentRow == null) {
                MessageBox.Show("Debe seleccionar un producto para realizar la operación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                BLT_Producto blt_Producto = new BLT_Producto();
                BOT_Producto bot_Producto = (BOT_Producto)dgv_Producto.CurrentRow.DataBoundItem;
                if (blt_Producto.fnEsReferenciadoT_Producto(bot_Producto)) {
                    MessageBox.Show("El producto no puede ser eliminado porque está siendo usado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar el Producto seleccionado?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes) {

                        if (blt_Producto.fnDelT_Producto(bot_Producto.Codigo_Producto)) {
                            CargaProductos();
                            if (ProductoEliminado != null) {
                                ProductoEliminado(this, new EventArgs());
                            }                            
                        }
                        else {
                            MessageBox.Show("El producto no ha sido eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_Producto.CurrentRow != null) {
                BOT_Producto bot_producto = (BOT_Producto)dgv_Producto.CurrentRow.DataBoundItem;
                Form_ModificarProducto mp = new Form_ModificarProducto(bot_producto);
                mp.ProductoModificado += new EventHandler(mp_ProductoModificado);
                mp.ShowDialog();
            }
            else {
                MessageBox.Show("Debe seleccionar un producto para realizar la operación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        void mp_ProductoModificado(object sender, EventArgs e) {
            CargaProductos();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_BuscarProducto bp = new Form_BuscarProducto();
            bp.FiltroRealizado += new FiltroProductoEventHandler(bp_FiltroRealizado);
            bp.ShowDialog();
        }

        void bp_FiltroRealizado(object sender, FiltroProductoEventArgs e) {
            dgv_Producto.DataSource = e.ListaProducto;
        }

        private void verTodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CargaProductos();
        }

        private void CargaProductos() {
            dgv_Producto.DataSource = null;
            dgv_Producto.AutoGenerateColumns = false;
            BLT_Producto blt_Producto = new BLT_Producto();
            List<BOT_Producto> list_bot_producto = blt_Producto.fnSelT_ProductoAll();
            dgv_Producto.DataSource = list_bot_producto;
        }
    }

    public delegate void ProductoSeleccionadoEventHandler(object sender,ProductoSeleccionadoEventArgs e);
    public class ProductoSeleccionadoEventArgs : EventArgs {
        private BOT_Producto _productoSeleccionado;
        private DateTime _horaSeleccion;

        public BOT_Producto ProductoSeleccionado {
            get { return _productoSeleccionado; }
        }

        public DateTime HoraSeleccion {
            get { return _horaSeleccion; }
        }

        public ProductoSeleccionadoEventArgs(BOT_Producto prod_sel) {
            _productoSeleccionado = prod_sel;
            _horaSeleccion = DateTime.Now;
        }
    }
}
