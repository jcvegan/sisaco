namespace SISACO
{
    partial class Form_BuscarporPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BuscarporPeriodo));
            this.lbl_Fecha_Inicial = new System.Windows.Forms.Label();
            this.lbl_Fecha_Final = new System.Windows.Forms.Label();
            this.dtp_Fecha_Inicial = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fecha_Final = new System.Windows.Forms.DateTimePicker();
            this.pnl_BuscarporPeriodo = new System.Windows.Forms.Panel();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.pnl_BuscarporPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Fecha_Inicial
            // 
            this.lbl_Fecha_Inicial.AutoSize = true;
            this.lbl_Fecha_Inicial.Location = new System.Drawing.Point(3, 17);
            this.lbl_Fecha_Inicial.Name = "lbl_Fecha_Inicial";
            this.lbl_Fecha_Inicial.Size = new System.Drawing.Size(67, 13);
            this.lbl_Fecha_Inicial.TabIndex = 2;
            this.lbl_Fecha_Inicial.Text = "Fecha Inicial";
            // 
            // lbl_Fecha_Final
            // 
            this.lbl_Fecha_Final.AutoSize = true;
            this.lbl_Fecha_Final.Location = new System.Drawing.Point(3, 43);
            this.lbl_Fecha_Final.Name = "lbl_Fecha_Final";
            this.lbl_Fecha_Final.Size = new System.Drawing.Size(62, 13);
            this.lbl_Fecha_Final.TabIndex = 4;
            this.lbl_Fecha_Final.Text = "Fecha Final";
            // 
            // dtp_Fecha_Inicial
            // 
            this.dtp_Fecha_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha_Inicial.Location = new System.Drawing.Point(76, 13);
            this.dtp_Fecha_Inicial.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtp_Fecha_Inicial.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_Fecha_Inicial.Name = "dtp_Fecha_Inicial";
            this.dtp_Fecha_Inicial.Size = new System.Drawing.Size(100, 20);
            this.dtp_Fecha_Inicial.TabIndex = 3;
            this.dtp_Fecha_Inicial.Value = new System.DateTime(2011, 4, 24, 0, 0, 0, 0);
            // 
            // dtp_Fecha_Final
            // 
            this.dtp_Fecha_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha_Final.Location = new System.Drawing.Point(76, 39);
            this.dtp_Fecha_Final.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dtp_Fecha_Final.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_Fecha_Final.Name = "dtp_Fecha_Final";
            this.dtp_Fecha_Final.Size = new System.Drawing.Size(100, 20);
            this.dtp_Fecha_Final.TabIndex = 5;
            this.dtp_Fecha_Final.Value = new System.DateTime(2011, 4, 24, 0, 0, 0, 0);
            // 
            // pnl_BuscarporPeriodo
            // 
            this.pnl_BuscarporPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_BuscarporPeriodo.Controls.Add(this.btn_Buscar);
            this.pnl_BuscarporPeriodo.Controls.Add(this.lbl_Fecha_Inicial);
            this.pnl_BuscarporPeriodo.Controls.Add(this.dtp_Fecha_Final);
            this.pnl_BuscarporPeriodo.Controls.Add(this.lbl_Fecha_Final);
            this.pnl_BuscarporPeriodo.Controls.Add(this.dtp_Fecha_Inicial);
            this.pnl_BuscarporPeriodo.Location = new System.Drawing.Point(9, 9);
            this.pnl_BuscarporPeriodo.Name = "pnl_BuscarporPeriodo";
            this.pnl_BuscarporPeriodo.Size = new System.Drawing.Size(185, 100);
            this.pnl_BuscarporPeriodo.TabIndex = 1;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(101, 70);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 6;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // Form_BuscarporPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 117);
            this.Controls.Add(this.pnl_BuscarporPeriodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_BuscarporPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar por Periodo";
            this.Load += new System.EventHandler(this.Form_BuscarporPeriodo_Load);
            this.pnl_BuscarporPeriodo.ResumeLayout(false);
            this.pnl_BuscarporPeriodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Fecha_Inicial;
        private System.Windows.Forms.Label lbl_Fecha_Final;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Inicial;
        private System.Windows.Forms.DateTimePicker dtp_Fecha_Final;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Panel pnl_BuscarporPeriodo;
    }
}