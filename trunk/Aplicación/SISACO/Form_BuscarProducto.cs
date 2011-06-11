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
    public partial class Form_BuscarProducto : Form
    {
        #region Constantes

        private const string LST_TIPO1 = "Codigo de Producto";
        private const string LST_TIPO2 = "Nombre de Producto";
        private const string LST_TIPO3 = "Forma Farmaceutica";
        private const string LST_TIPO4 = "Proceso";
        private const string LST_TIPO5 = "Presentacion";
        private const string SQL_TIPO1 = "Codigo_Producto";
        private const string SQL_TIPO2 = "Nombre_Producto";
        private const string SQL_TIPO3 = "Forma_Farmaceutica";
        private const string SQL_TIPO4 = "Proceso";
        private const string SQL_TIPO5 = "Presentacion";

        #endregion

        #region Atributos

        private Dictionary<string, string> equivalencias;

        #endregion

        #region Eventos

        public event FiltroProductoEventHandler FiltroRealizado;

        #endregion

        public Form_BuscarProducto()
        {
            InitializeComponent();
        }

        private void Form_BuscarProducto_Load(object sender, EventArgs e)
        {
            equivalencias = new Dictionary<string, string>();
            equivalencias.Add(LST_TIPO1, SQL_TIPO1);
            equivalencias.Add(LST_TIPO2, SQL_TIPO2);
            equivalencias.Add(LST_TIPO3, SQL_TIPO3);
            equivalencias.Add(LST_TIPO4, SQL_TIPO4);
            equivalencias.Add(LST_TIPO5, SQL_TIPO5);
            txt_Parametro_Busqueda.Focus();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_Parametro_Busqueda.Text == "" || cbx_Buscar.SelectedItem == null)
            {
                MessageBox.Show("Debe de ingresar un Parámetro de Búsqueda y un Tipo de Búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Parametro_Busqueda.Focus();
            }
            else
            {
                //
                BLT_Producto blt_producto =new BLT_Producto();
                string tipoFiltro;
                string valorFiltro;
                tipoFiltro = cbx_Buscar.SelectedItem.ToString();
                valorFiltro = "'%" + txt_Parametro_Busqueda.Text + "%'";
                List<BOT_Producto> lista;
                lista = blt_producto.fnSelT_ProductoDin(equivalencias[tipoFiltro] + " like " + valorFiltro, "");
                if (FiltroRealizado != null) {
                    FiltroRealizado(this, new FiltroProductoEventArgs(tipoFiltro, lista));
                }
            } 
        }
    }


    public delegate void FiltroProductoEventHandler(object sender, FiltroProductoEventArgs e);
    public class FiltroProductoEventArgs : EventArgs {
        private string _tipoFiltro;
        private List<BOT_Producto> _listaProducto;


        public string TipoFiltro {
            get { return _tipoFiltro; }
        }
        public List<BOT_Producto> ListaProducto {
            get { return _listaProducto; }
        }

        public FiltroProductoEventArgs(string tipo, List<BOT_Producto> lista) {
            _tipoFiltro = tipo;
            _listaProducto = lista;
        }
    }
}
