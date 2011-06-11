namespace SISACO
{
    partial class Form_AbrirOrdendeAcondicionamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AbrirOrdendeAcondicionamiento));
            this.lbl_Codigo_Orden_Acondicionamiento = new System.Windows.Forms.Label();
            this.txt_Codigo_Orden_Acondicionamiento = new System.Windows.Forms.TextBox();
            this.pnl_Abrir_Orden_Acondicionamiento = new System.Windows.Forms.Panel();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.pnl_Abrir_Orden_Acondicionamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Codigo_Orden_Acondicionamiento
            // 
            this.lbl_Codigo_Orden_Acondicionamiento.AutoSize = true;
            this.lbl_Codigo_Orden_Acondicionamiento.Location = new System.Drawing.Point(3, 16);
            this.lbl_Codigo_Orden_Acondicionamiento.Name = "lbl_Codigo_Orden_Acondicionamiento";
            this.lbl_Codigo_Orden_Acondicionamiento.Size = new System.Drawing.Size(195, 13);
            this.lbl_Codigo_Orden_Acondicionamiento.TabIndex = 2;
            this.lbl_Codigo_Orden_Acondicionamiento.Text = "Código de Orden de Acondicionamiento";
            // 
            // txt_Codigo_Orden_Acondicionamiento
            // 
            this.txt_Codigo_Orden_Acondicionamiento.Location = new System.Drawing.Point(204, 13);
            this.txt_Codigo_Orden_Acondicionamiento.Name = "txt_Codigo_Orden_Acondicionamiento";
            this.txt_Codigo_Orden_Acondicionamiento.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo_Orden_Acondicionamiento.TabIndex = 3;
            // 
            // pnl_Abrir_Orden_Acondicionamiento
            // 
            this.pnl_Abrir_Orden_Acondicionamiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Abrir_Orden_Acondicionamiento.Controls.Add(this.btn_Abrir);
            this.pnl_Abrir_Orden_Acondicionamiento.Controls.Add(this.lbl_Codigo_Orden_Acondicionamiento);
            this.pnl_Abrir_Orden_Acondicionamiento.Controls.Add(this.txt_Codigo_Orden_Acondicionamiento);
            this.pnl_Abrir_Orden_Acondicionamiento.Location = new System.Drawing.Point(9, 9);
            this.pnl_Abrir_Orden_Acondicionamiento.Name = "pnl_Abrir_Orden_Acondicionamiento";
            this.pnl_Abrir_Orden_Acondicionamiento.Size = new System.Drawing.Size(395, 50);
            this.pnl_Abrir_Orden_Acondicionamiento.TabIndex = 1;
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Image = global::SISACO.Properties.Resources.Abrir;
            this.btn_Abrir.Location = new System.Drawing.Point(310, 11);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(75, 23);
            this.btn_Abrir.TabIndex = 4;
            this.btn_Abrir.Text = "Abrir";
            this.btn_Abrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Abrir.UseVisualStyleBackColor = true;
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // Form_AbrirOrdendeAcondicionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 72);
            this.Controls.Add(this.pnl_Abrir_Orden_Acondicionamiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AbrirOrdendeAcondicionamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Orden de Acondicionamiento";
            this.Load += new System.EventHandler(this.Form_AbrirOrden_Load);
            this.pnl_Abrir_Orden_Acondicionamiento.ResumeLayout(false);
            this.pnl_Abrir_Orden_Acondicionamiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Codigo_Orden_Acondicionamiento;
        private System.Windows.Forms.TextBox txt_Codigo_Orden_Acondicionamiento;
        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.Panel pnl_Abrir_Orden_Acondicionamiento;
    }
}