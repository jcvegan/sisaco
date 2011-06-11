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
    public partial class Form_BuscarUsuario : Form
    {

        private const string LST_TIPO1 = "Codigo Usuario";
        private const string LST_TIPO2 = "Nombre Usuario";
        private const string LST_TIPO3 = "Nombres";
        private const string LST_TIPO4 = "Apellidos";
        private const string SQL_TIPO1 = "Codigo_Usuario";
        private const string SQL_TIPO2 = "Nombre_Usuario";
        private const string SQL_TIPO3 = "Nombres";
        private const string SQL_TIPO4 = "Apellidos";

        private Dictionary<string, string> equivalencias;

        public event FiltroUsuarioEventHandler FiltroRealizado;

        public Form_BuscarUsuario()
        {
            InitializeComponent();
        }

        private void Form_BuscarUsuario_Load(object sender, EventArgs e)
        {
            equivalencias = new Dictionary<string, string>();
            equivalencias.Add(LST_TIPO1, SQL_TIPO1);
            equivalencias.Add(LST_TIPO2, SQL_TIPO2);
            equivalencias.Add(LST_TIPO3, SQL_TIPO3);
            equivalencias.Add(LST_TIPO4, SQL_TIPO4);
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
                BLT_Usuario blt_usuario = new BLT_Usuario();
                string tipoFiltro;
                string valorFiltro;
                tipoFiltro = cbx_Buscar.SelectedItem.ToString();
                valorFiltro = "'%" + txt_Parametro_Busqueda.Text + "%'";
                List<BOT_Usuario> lista;
                lista = blt_usuario.fnSelT_UsuarioDin(equivalencias[tipoFiltro] + " like " + valorFiltro, "");
                if (FiltroRealizado != null) {
                    FiltroRealizado(this, new FiltroUsuarioEventArgs(tipoFiltro, lista));
                }
            } 
        }
    }

    public delegate void FiltroUsuarioEventHandler(object sender,FiltroUsuarioEventArgs e);
    public class FiltroUsuarioEventArgs : EventArgs {
        private string _tipoFiltro;
        private List<BOT_Usuario> _listaUsuario;

        public string TipoFiltro {
            get { return _tipoFiltro; }
        }
        public List<BOT_Usuario> ListaUsuario {
            get { return _listaUsuario; }
        }

        public FiltroUsuarioEventArgs(string tipo, List<BOT_Usuario> lista) {
            _tipoFiltro = tipo;
            _listaUsuario = lista;
        }
    }
}
