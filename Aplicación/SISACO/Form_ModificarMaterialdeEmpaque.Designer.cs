namespace SISACO
{
    partial class Form_ModificarMaterialdeEmpaque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ModificarMaterialdeEmpaque));
            this.pnl_Modificar_Material = new System.Windows.Forms.Panel();
            this.lbl_Codigo_Material = new System.Windows.Forms.Label();
            this.lbl_Material_Empaque = new System.Windows.Forms.Label();
            this.lbl_Unidad_Medida = new System.Windows.Forms.Label();
            this.txt_Codigo_Material = new System.Windows.Forms.TextBox();
            this.txt_Material_Empaque = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.cbx_Unidad_Medida = new System.Windows.Forms.ComboBox();
            this.pnl_Modificar_Material.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Modificar_Material
            // 
            this.pnl_Modificar_Material.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Modificar_Material.Controls.Add(this.cbx_Unidad_Medida);
            this.pnl_Modificar_Material.Controls.Add(this.lbl_Codigo_Material);
            this.pnl_Modificar_Material.Controls.Add(this.lbl_Material_Empaque);
            this.pnl_Modificar_Material.Controls.Add(this.lbl_Unidad_Medida);
            this.pnl_Modificar_Material.Controls.Add(this.txt_Codigo_Material);
            this.pnl_Modificar_Material.Controls.Add(this.txt_Material_Empaque);
            this.pnl_Modificar_Material.Location = new System.Drawing.Point(9, 9);
            this.pnl_Modificar_Material.Name = "pnl_Modificar_Material";
            this.pnl_Modificar_Material.Size = new System.Drawing.Size(339, 88);
            this.pnl_Modificar_Material.TabIndex = 1;
            // 
            // lbl_Codigo_Material
            // 
            this.lbl_Codigo_Material.AutoSize = true;
            this.lbl_Codigo_Material.Location = new System.Drawing.Point(3, 11);
            this.lbl_Codigo_Material.Name = "lbl_Codigo_Material";
            this.lbl_Codigo_Material.Size = new System.Drawing.Size(95, 13);
            this.lbl_Codigo_Material.TabIndex = 2;
            this.lbl_Codigo_Material.Text = "Código de Material";
            // 
            // lbl_Material_Empaque
            // 
            this.lbl_Material_Empaque.AutoSize = true;
            this.lbl_Material_Empaque.Location = new System.Drawing.Point(3, 35);
            this.lbl_Material_Empaque.Name = "lbl_Material_Empaque";
            this.lbl_Material_Empaque.Size = new System.Drawing.Size(107, 13);
            this.lbl_Material_Empaque.TabIndex = 4;
            this.lbl_Material_Empaque.Text = "Material de Empaque";
            // 
            // lbl_Unidad_Medida
            // 
            this.lbl_Unidad_Medida.AutoSize = true;
            this.lbl_Unidad_Medida.Location = new System.Drawing.Point(3, 61);
            this.lbl_Unidad_Medida.Name = "lbl_Unidad_Medida";
            this.lbl_Unidad_Medida.Size = new System.Drawing.Size(94, 13);
            this.lbl_Unidad_Medida.TabIndex = 6;
            this.lbl_Unidad_Medida.Text = "Unidad de Medida";
            // 
            // txt_Codigo_Material
            // 
            this.txt_Codigo_Material.Enabled = false;
            this.txt_Codigo_Material.Location = new System.Drawing.Point(130, 8);
            this.txt_Codigo_Material.Name = "txt_Codigo_Material";
            this.txt_Codigo_Material.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo_Material.TabIndex = 3;
            // 
            // txt_Material_Empaque
            // 
            this.txt_Material_Empaque.Location = new System.Drawing.Point(130, 32);
            this.txt_Material_Empaque.Name = "txt_Material_Empaque";
            this.txt_Material_Empaque.Size = new System.Drawing.Size(200, 20);
            this.txt_Material_Empaque.TabIndex = 5;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Image = global::SISACO.Properties.Resources.Cancelar;
            this.btn_Cancelar.Location = new System.Drawing.Point(190, 105);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Image = global::SISACO.Properties.Resources.Aceptar;
            this.btn_Modificar.Location = new System.Drawing.Point(86, 105);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 8;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // cbx_Unidad_Medida
            // 
            this.cbx_Unidad_Medida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Unidad_Medida.FormattingEnabled = true;
            this.cbx_Unidad_Medida.Items.AddRange(new object[] {
            "Kg.",
            "UU"});
            this.cbx_Unidad_Medida.Location = new System.Drawing.Point(130, 58);
            this.cbx_Unidad_Medida.Name = "cbx_Unidad_Medida";
            this.cbx_Unidad_Medida.Size = new System.Drawing.Size(121, 21);
            this.cbx_Unidad_Medida.TabIndex = 7;
            // 
            // Form_ModificarMaterialdeEmpaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 132);
            this.Controls.Add(this.pnl_Modificar_Material);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Modificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ModificarMaterialdeEmpaque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Material de Empaque";
            this.Load += new System.EventHandler(this.Form_ModificarMaterialdeEmpaque_Load);
            this.pnl_Modificar_Material.ResumeLayout(false);
            this.pnl_Modificar_Material.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Modificar_Material;
        private System.Windows.Forms.Label lbl_Codigo_Material;
        private System.Windows.Forms.Label lbl_Material_Empaque;
        private System.Windows.Forms.Label lbl_Unidad_Medida;
        private System.Windows.Forms.TextBox txt_Codigo_Material;
        private System.Windows.Forms.TextBox txt_Material_Empaque;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.ComboBox cbx_Unidad_Medida;
    }
}