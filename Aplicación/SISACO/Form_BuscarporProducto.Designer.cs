namespace SISACO
{
    partial class Form_BuscarporProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BuscarporProducto));
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Codigo_Producto = new System.Windows.Forms.TextBox();
            this.lbl_Codigo_Producto = new System.Windows.Forms.Label();
            this.pnl_BuscarporProducto = new System.Windows.Forms.Panel();
            this.pnl_BuscarporProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::SISACO.Properties.Resources.Buscar;
            this.btn_Buscar.Location = new System.Drawing.Point(216, 11);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Codigo_Producto
            // 
            this.txt_Codigo_Producto.Location = new System.Drawing.Point(110, 13);
            this.txt_Codigo_Producto.Name = "txt_Codigo_Producto";
            this.txt_Codigo_Producto.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo_Producto.TabIndex = 3;
            // 
            // lbl_Codigo_Producto
            // 
            this.lbl_Codigo_Producto.AutoSize = true;
            this.lbl_Codigo_Producto.Location = new System.Drawing.Point(3, 16);
            this.lbl_Codigo_Producto.Name = "lbl_Codigo_Producto";
            this.lbl_Codigo_Producto.Size = new System.Drawing.Size(101, 13);
            this.lbl_Codigo_Producto.TabIndex = 2;
            this.lbl_Codigo_Producto.Text = "Código de Producto";
            // 
            // pnl_BuscarporProducto
            // 
            this.pnl_BuscarporProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_BuscarporProducto.Controls.Add(this.lbl_Codigo_Producto);
            this.pnl_BuscarporProducto.Controls.Add(this.btn_Buscar);
            this.pnl_BuscarporProducto.Controls.Add(this.txt_Codigo_Producto);
            this.pnl_BuscarporProducto.Location = new System.Drawing.Point(9, 9);
            this.pnl_BuscarporProducto.Name = "pnl_BuscarporProducto";
            this.pnl_BuscarporProducto.Size = new System.Drawing.Size(305, 50);
            this.pnl_BuscarporProducto.TabIndex = 1;
            // 
            // Form_BuscarporProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 72);
            this.Controls.Add(this.pnl_BuscarporProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_BuscarporProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar por Producto";
            this.Load += new System.EventHandler(this.Form_BuscarporProducto_Load);
            this.pnl_BuscarporProducto.ResumeLayout(false);
            this.pnl_BuscarporProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Codigo_Producto;
        private System.Windows.Forms.Label lbl_Codigo_Producto;
        private System.Windows.Forms.Panel pnl_BuscarporProducto;
    }
}