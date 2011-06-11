namespace SISACO
{
    partial class Form_BuscarMaterialdeEmpaque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BuscarMaterialdeEmpaque));
            this.pnl_Buscar_Material_Empaque = new System.Windows.Forms.Panel();
            this.lbl_Buscar = new System.Windows.Forms.Label();
            this.cbx_Buscar = new System.Windows.Forms.ComboBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Parametro_Busqueda = new System.Windows.Forms.TextBox();
            this.lbl_Parametro_Busqueda = new System.Windows.Forms.Label();
            this.pnl_Buscar_Material_Empaque.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Buscar_Material_Empaque
            // 
            this.pnl_Buscar_Material_Empaque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Buscar_Material_Empaque.Controls.Add(this.lbl_Buscar);
            this.pnl_Buscar_Material_Empaque.Controls.Add(this.cbx_Buscar);
            this.pnl_Buscar_Material_Empaque.Controls.Add(this.btn_Buscar);
            this.pnl_Buscar_Material_Empaque.Controls.Add(this.txt_Parametro_Busqueda);
            this.pnl_Buscar_Material_Empaque.Controls.Add(this.lbl_Parametro_Busqueda);
            this.pnl_Buscar_Material_Empaque.Location = new System.Drawing.Point(9, 9);
            this.pnl_Buscar_Material_Empaque.Name = "pnl_Buscar_Material_Empaque";
            this.pnl_Buscar_Material_Empaque.Size = new System.Drawing.Size(295, 100);
            this.pnl_Buscar_Material_Empaque.TabIndex = 1;
            // 
            // lbl_Buscar
            // 
            this.lbl_Buscar.AutoSize = true;
            this.lbl_Buscar.Location = new System.Drawing.Point(3, 51);
            this.lbl_Buscar.Name = "lbl_Buscar";
            this.lbl_Buscar.Size = new System.Drawing.Size(58, 13);
            this.lbl_Buscar.TabIndex = 4;
            this.lbl_Buscar.Text = "Buscar por";
            // 
            // cbx_Buscar
            // 
            this.cbx_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Buscar.FormattingEnabled = true;
            this.cbx_Buscar.Items.AddRange(new object[] {
            "Codigo de Material de Empaque",
            "Nombre de Material de Empaque"});
            this.cbx_Buscar.Location = new System.Drawing.Point(6, 67);
            this.cbx_Buscar.Name = "cbx_Buscar";
            this.cbx_Buscar.Size = new System.Drawing.Size(200, 21);
            this.cbx_Buscar.TabIndex = 5;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::SISACO.Properties.Resources.Buscar;
            this.btn_Buscar.Location = new System.Drawing.Point(212, 26);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 6;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Parametro_Busqueda
            // 
            this.txt_Parametro_Busqueda.Location = new System.Drawing.Point(6, 28);
            this.txt_Parametro_Busqueda.Name = "txt_Parametro_Busqueda";
            this.txt_Parametro_Busqueda.Size = new System.Drawing.Size(200, 20);
            this.txt_Parametro_Busqueda.TabIndex = 3;
            // 
            // lbl_Parametro_Busqueda
            // 
            this.lbl_Parametro_Busqueda.AutoSize = true;
            this.lbl_Parametro_Busqueda.Location = new System.Drawing.Point(3, 12);
            this.lbl_Parametro_Busqueda.Name = "lbl_Parametro_Busqueda";
            this.lbl_Parametro_Busqueda.Size = new System.Drawing.Size(121, 13);
            this.lbl_Parametro_Busqueda.TabIndex = 2;
            this.lbl_Parametro_Busqueda.Text = "Parámetro de Búsqueda";
            // 
            // Form_BuscarMaterialdeEmpaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 117);
            this.Controls.Add(this.pnl_Buscar_Material_Empaque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_BuscarMaterialdeEmpaque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Material de Empaque";
            this.Load += new System.EventHandler(this.Form_BuscarMaterialdeEmpaque_Load);
            this.pnl_Buscar_Material_Empaque.ResumeLayout(false);
            this.pnl_Buscar_Material_Empaque.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Buscar_Material_Empaque;
        private System.Windows.Forms.Label lbl_Buscar;
        private System.Windows.Forms.ComboBox cbx_Buscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Parametro_Busqueda;
        private System.Windows.Forms.Label lbl_Parametro_Busqueda;
    }
}