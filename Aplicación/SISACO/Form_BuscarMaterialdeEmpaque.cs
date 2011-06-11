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
    public partial class Form_BuscarMaterialdeEmpaque : Form
    {
        #region Constates

        public const string LST_TIPO1 = "Codigo de Material de Empaque";
        public const string LST_TIPO2 = "Nombre de Material de Empaque";
        public const string SQL_TIPO1 = "Codigo_Material_Empaque";
        public const string SQL_TIPO2 = "Nombre_Material_Empaque";

        #endregion

        #region Atributos

        private Dictionary<string, string> equivalencias;

        #endregion

        #region Events

        public event FiltroMaterialEventHandler FiltroRealizado;

        #endregion

        public Form_BuscarMaterialdeEmpaque()
        {
            InitializeComponent();
        }

        private void Form_BuscarMaterialdeEmpaque_Load(object sender, EventArgs e)
        {
            equivalencias = new Dictionary<string, string>();
            equivalencias.Add(LST_TIPO1, SQL_TIPO1);
            equivalencias.Add(LST_TIPO2, SQL_TIPO2);
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
                BLT_Material_Empaque blt_material_empaque = new BLT_Material_Empaque();
                string tipoFiltro;
                string valorFiltro;
                tipoFiltro = cbx_Buscar.SelectedItem.ToString();
                valorFiltro = "'%" + txt_Parametro_Busqueda.Text + "%'";
                List<BOT_Material_Empaque> lista;
                lista = blt_material_empaque.fnSelT_Material_EmpaqueDin(equivalencias[tipoFiltro] + " like " + valorFiltro, "");
                if (FiltroRealizado != null)
                {
                    FiltroRealizado(this, new FiltroMaterialEmpaqueEventArgs(tipoFiltro, lista));
                }
            }
        } 
    }

    public delegate void FiltroMaterialEventHandler(object sender, FiltroMaterialEmpaqueEventArgs e);
    public class FiltroMaterialEmpaqueEventArgs : EventArgs
    {
        private string _tipoFiltro;
        private List<BOT_Material_Empaque> _listaFiltro;

        public string TipoFiltro
        {
            get 
            {
                return _tipoFiltro; 
            } 
        }

        public List<BOT_Material_Empaque> ListaFiltro
        {
            get 
            {
                return _listaFiltro; 
            }
        }

        public FiltroMaterialEmpaqueEventArgs(string tipo, List<BOT_Material_Empaque> lista)
        {
            _tipoFiltro = tipo;
            _listaFiltro = lista;
        }
    }
}
