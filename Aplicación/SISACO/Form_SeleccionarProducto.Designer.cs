namespace SISACO {
    partial class Form_SeleccionarProducto {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SeleccionarProducto));
            this.dgv_Seleccionar_Producto = new System.Windows.Forms.DataGridView();
            this.Codigo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Seleccionar_Producto = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Seleccionar_Producto)).BeginInit();
            this.pnl_Seleccionar_Producto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Seleccionar_Producto
            // 
            this.dgv_Seleccionar_Producto.AllowUserToAddRows = false;
            this.dgv_Seleccionar_Producto.AllowUserToDeleteRows = false;
            this.dgv_Seleccionar_Producto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Seleccionar_Producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Seleccionar_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Seleccionar_Producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Producto,
            this.Nombre_Producto});
            this.dgv_Seleccionar_Producto.Location = new System.Drawing.Point(6, 6);
            this.dgv_Seleccionar_Producto.MultiSelect = false;
            this.dgv_Seleccionar_Producto.Name = "dgv_Seleccionar_Producto";
            this.dgv_Seleccionar_Producto.ReadOnly = true;
            this.dgv_Seleccionar_Producto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Seleccionar_Producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Seleccionar_Producto.Size = new System.Drawing.Size(260, 169);
            this.dgv_Seleccionar_Producto.TabIndex = 2;
            this.dgv_Seleccionar_Producto.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Productos_CellMouseDoubleClick);
            // 
            // Codigo_Producto
            // 
            this.Codigo_Producto.DataPropertyName = "Codigo_Producto";
            this.Codigo_Producto.HeaderText = "Código del Producto";
            this.Codigo_Producto.Name = "Codigo_Producto";
            this.Codigo_Producto.ReadOnly = true;
            // 
            // Nombre_Producto
            // 
            this.Nombre_Producto.DataPropertyName = "Nombre_Producto";
            this.Nombre_Producto.HeaderText = "Nombre del Producto";
            this.Nombre_Producto.Name = "Nombre_Producto";
            this.Nombre_Producto.ReadOnly = true;
            // 
            // pnl_Seleccionar_Producto
            // 
            this.pnl_Seleccionar_Producto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Seleccionar_Producto.Controls.Add(this.dgv_Seleccionar_Producto);
            this.pnl_Seleccionar_Producto.Location = new System.Drawing.Point(9, 9);
            this.pnl_Seleccionar_Producto.Name = "pnl_Seleccionar_Producto";
            this.pnl_Seleccionar_Producto.Size = new System.Drawing.Size(273, 182);
            this.pnl_Seleccionar_Producto.TabIndex = 1;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Image = global::SISACO.Properties.Resources.Cancelar;
            this.btn_Cancelar.Location = new System.Drawing.Point(150, 195);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Image = global::SISACO.Properties.Resources.Aceptar;
            this.btn_Aceptar.Location = new System.Drawing.Point(69, 195);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // Form_SeleccionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 222);
            this.Controls.Add(this.pnl_Seleccionar_Producto);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SeleccionarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Producto";
            this.Load += new System.EventHandler(this.Form_SelectorProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Seleccionar_Producto)).EndInit();
            this.pnl_Seleccionar_Producto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Seleccionar_Producto;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Panel pnl_Seleccionar_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Producto;
    }
}