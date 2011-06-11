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
    public partial class Form_RegistrarMaterialdeEmpaque : Form
    {
        #region Constantes

        private const string MSG_Elimino = "Material de empaque eliminado.";
        private const string MSG_NoElimino = "Material de empaque no ha sido eliminado. Error inesperado";
        private const string TIT_Confirmacion = "Mensaje";
        private const string TIT_Error = "Error";

        #endregion

        #region Eventos

        public event EventHandler MaterialEmpaqueRegistrado;
        public event EventHandler MaterialEmpaqueEliminado;
        public event EventHandler MaterialEmpaqueModificado;
        public event MaterialEmpaqueSeleccionadoEventHandler MaterialEmpaqueSeleccionado;

        #endregion

        public Form_RegistrarMaterialdeEmpaque()
        {
            InitializeComponent();
        }

        private void Form_RegistrarMaterialdeEmpaque_Load(object sender, EventArgs e)
        {
            //
            CargaMaterialesEmpaque();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_CrearMaterialdeEmpaque cme = new Form_CrearMaterialdeEmpaque();
            cme.MaterialCreado += new EventHandler(cme_MaterialCreado);
            cme.ShowDialog();
        }

        void cme_MaterialCreado(object sender, EventArgs e)
        {
            if (MaterialEmpaqueRegistrado != null)
            {
                MaterialEmpaqueRegistrado(this, new EventArgs());
            }
            CargaMaterialesEmpaque();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_Material_Empaque.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un material para realizar la operación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BOT_Material_Empaque bot_MaterialEmpaque = (BOT_Material_Empaque)dgv_Material_Empaque.CurrentRow.DataBoundItem;
                BLT_Material_Empaque_x_Producto blt_material_empaque_x_producto = new BLT_Material_Empaque_x_Producto();
                if (blt_material_empaque_x_producto.fnExsT_Material_Empaque_x_Material_Empaque_Producto(bot_MaterialEmpaque.Codigo_Material_Empaque)) {
                    MessageBox.Show("No se puede eliminar el material empaque porque está siendo usada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar al Material de Empaque seleccionado?", "Eliminar Material de Empaque", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes) {

                        BLT_Material_Empaque blt_MaterialEmpaque = new BLT_Material_Empaque();
                        //dgv_Usuarios.Rows.RemoveAt(dgv_Usuarios.CurrentRow.Index);
                        //MessageBox.Show(cUsu.Eliminar_Usuario(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (blt_MaterialEmpaque.fnDelT_Material_Empaque(bot_MaterialEmpaque.Codigo_Material_Empaque)) {
                            CargaMaterialesEmpaque();
                            if (MaterialEmpaqueEliminado != null) {
                                this.MaterialEmpaqueEliminado(this, new EventArgs());
                            }
                            //MessageBox.Show(MSG_Elimino, TIT_Confirmacion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else {
                            MessageBox.Show(MSG_NoElimino, TIT_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            
            }
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_Material_Empaque.CurrentRow != null)
            {
                BOT_Material_Empaque bot_Material_Empaque = dgv_Material_Empaque.CurrentRow.DataBoundItem as BOT_Material_Empaque;
                Form_ModificarMaterialdeEmpaque mme = new Form_ModificarMaterialdeEmpaque(bot_Material_Empaque);
                mme.MaterialEmpaqueModificado += new EventHandler(mme_MaterialEmpaqueModificado);
                mme.ShowDialog();
                if (this.MaterialEmpaqueModificado != null)
                {
                    this.MaterialEmpaqueModificado(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un material para realizar la operación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void mme_MaterialEmpaqueModificado(object sender, EventArgs e)
        {
            CargaMaterialesEmpaque();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_BuscarMaterialdeEmpaque bme = new Form_BuscarMaterialdeEmpaque();
            bme.FiltroRealizado += new FiltroMaterialEventHandler(bme_FiltroRealizado);
            bme.ShowDialog();
        }

        void bme_FiltroRealizado(object sender, FiltroMaterialEmpaqueEventArgs e)
        {
            dgv_Material_Empaque.DataSource = e.ListaFiltro;
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            CargaMaterialesEmpaque();
        }

        internal void CargaMaterialesEmpaque()
        {
            dgv_Material_Empaque.DataSource = null;
            dgv_Material_Empaque.AutoGenerateColumns = false;
            BLT_Material_Empaque blt_Material_Empaque = new BLT_Material_Empaque();
            List<BOT_Material_Empaque> list_bot_material_empaque = blt_Material_Empaque.fnSelT_Material_EmpaqueAll();
            dgv_Material_Empaque.DataSource = list_bot_material_empaque;
        }

        private void dgv_Materiales_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (MaterialEmpaqueSeleccionado != null) {
                if (e.RowIndex >= 0) {
                    BOT_Material_Empaque bot_Material_Empaque = (BOT_Material_Empaque)dgv_Material_Empaque.Rows[e.RowIndex].DataBoundItem;
                    MaterialEmpaqueSeleccionado(this, new MaterialEmpaqueSeleccionadoEventArgs(bot_Material_Empaque));
                }
            }
        }        
    }

    public delegate void MaterialEmpaqueSeleccionadoEventHandler(object sender,MaterialEmpaqueSeleccionadoEventArgs e);
    public class MaterialEmpaqueSeleccionadoEventArgs : EventArgs {
        private BOT_Material_Empaque _materialEmpaqueSeleccionado;
        private DateTime _horaSeleccion;

        public BOT_Material_Empaque MaterialEmpaqueSeleccionado {
            get { return _materialEmpaqueSeleccionado; }
        }

        public DateTime HoraSeleccion {
            get { return _horaSeleccion; }
        }

        public MaterialEmpaqueSeleccionadoEventArgs(BOT_Material_Empaque _matEmp) {
            _horaSeleccion = DateTime.Now;
            _materialEmpaqueSeleccionado = _matEmp;            
        }
    }
}
