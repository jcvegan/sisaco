namespace SISACO
{
    partial class Form_RegistrarMaterialdeEmpaque
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RegistrarMaterialdeEmpaque));
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_Material_Empaque = new System.Windows.Forms.DataGridView();
            this.Codigo_Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad_de_Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msp_Material_Empaque = new System.Windows.Forms.MenuStrip();
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Material_Empaque)).BeginInit();
            this.msp_Material_Empaque.SuspendLayout();
            this.SuspendLayout();
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.crearToolStripMenuItem.Text = "Crear";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // verTodoToolStripMenuItem
            // 
            this.verTodoToolStripMenuItem.Name = "verTodoToolStripMenuItem";
            this.verTodoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.verTodoToolStripMenuItem.Text = "Ver Todos";
            // 
            // dgv_Material_Empaque
            // 
            this.dgv_Material_Empaque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Material_Empaque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Material_Empaque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Material,
            this.Nombre_Material,
            this.Unidad_de_Medida});
            this.dgv_Material_Empaque.Location = new System.Drawing.Point(9, 25);
            this.dgv_Material_Empaque.Name = "dgv_Material_Empaque";
            this.dgv_Material_Empaque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Material_Empaque.Size = new System.Drawing.Size(543, 236);
            this.dgv_Material_Empaque.TabIndex = 2;
            this.dgv_Material_Empaque.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Materiales_CellMouseDoubleClick);
            // 
            // Codigo_Material
            // 
            this.Codigo_Material.DataPropertyName = "Codigo_Material_Empaque";
            this.Codigo_Material.HeaderText = "Codigo";
            this.Codigo_Material.Name = "Codigo_Material";
            this.Codigo_Material.ReadOnly = true;
            // 
            // Nombre_Material
            // 
            this.Nombre_Material.DataPropertyName = "Nombre_Material_Empaque";
            this.Nombre_Material.HeaderText = "Material";
            this.Nombre_Material.Name = "Nombre_Material";
            this.Nombre_Material.ReadOnly = true;
            // 
            // Unidad_de_Medida
            // 
            this.Unidad_de_Medida.DataPropertyName = "Unidad_Medida";
            this.Unidad_de_Medida.HeaderText = "Unidad";
            this.Unidad_de_Medida.Name = "Unidad_de_Medida";
            this.Unidad_de_Medida.ReadOnly = true;
            // 
            // msp_Material_Empaque
            // 
            this.msp_Material_Empaque.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1,
            this.eliminarToolStripMenuItem1,
            this.modificarToolStripMenuItem1,
            this.buscarToolStripMenuItem1,
            this.verTodosToolStripMenuItem});
            this.msp_Material_Empaque.Location = new System.Drawing.Point(0, 0);
            this.msp_Material_Empaque.Name = "msp_Material_Empaque";
            this.msp_Material_Empaque.Size = new System.Drawing.Size(564, 24);
            this.msp_Material_Empaque.TabIndex = 1;
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.crearToolStripMenuItem1.Text = "Crear";
            this.crearToolStripMenuItem1.Click += new System.EventHandler(this.crearToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // buscarToolStripMenuItem1
            // 
            this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem1.Text = "Buscar";
            this.buscarToolStripMenuItem1.Click += new System.EventHandler(this.buscarToolStripMenuItem1_Click);
            // 
            // verTodosToolStripMenuItem
            // 
            this.verTodosToolStripMenuItem.Name = "verTodosToolStripMenuItem";
            this.verTodosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.verTodosToolStripMenuItem.Text = "Ver Todos";
            this.verTodosToolStripMenuItem.Click += new System.EventHandler(this.verTodosToolStripMenuItem_Click);
            // 
            // Form_RegistrarMaterialdeEmpaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 272);
            this.Controls.Add(this.dgv_Material_Empaque);
            this.Controls.Add(this.msp_Material_Empaque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_RegistrarMaterialdeEmpaque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material de Empaque";
            this.Load += new System.EventHandler(this.Form_RegistrarMaterialdeEmpaque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Material_Empaque)).EndInit();
            this.msp_Material_Empaque.ResumeLayout(false);
            this.msp_Material_Empaque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_Material_Empaque;
        private System.Windows.Forms.MenuStrip msp_Material_Empaque;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verTodosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad_de_Medida;
    }
}