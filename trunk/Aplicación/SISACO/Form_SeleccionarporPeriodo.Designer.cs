namespace SISACO
{
    partial class Form_SeleccionarporPeriodo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SeleccionarporPeriodo));
            this.pnl_Seleccionar_Periodo = new System.Windows.Forms.Panel();
            this.dgv_Seleccionar_Periodo = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.pnl_Seleccionar_Periodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Seleccionar_Periodo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Seleccionar_Periodo
            // 
            this.pnl_Seleccionar_Periodo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Seleccionar_Periodo.Controls.Add(this.dgv_Seleccionar_Periodo);
            this.pnl_Seleccionar_Periodo.Location = new System.Drawing.Point(9, 9);
            this.pnl_Seleccionar_Periodo.Name = "pnl_Seleccionar_Periodo";
            this.pnl_Seleccionar_Periodo.Size = new System.Drawing.Size(373, 228);
            this.pnl_Seleccionar_Periodo.TabIndex = 1;
            // 
            // dgv_Seleccionar_Periodo
            // 
            this.dgv_Seleccionar_Periodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Seleccionar_Periodo.Location = new System.Drawing.Point(6, 6);
            this.dgv_Seleccionar_Periodo.Name = "dgv_Seleccionar_Periodo";
            this.dgv_Seleccionar_Periodo.Size = new System.Drawing.Size(360, 215);
            this.dgv_Seleccionar_Periodo.TabIndex = 2;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Image = global::SISACO.Properties.Resources.Cancelar;
            this.btn_Cancelar.Location = new System.Drawing.Point(200, 244);
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
            this.btn_Aceptar.Location = new System.Drawing.Point(119, 244);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 3;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // Form_SeleccionarporPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 272);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.pnl_Seleccionar_Periodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SeleccionarporPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar por Periodo";
            this.pnl_Seleccionar_Periodo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Seleccionar_Periodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Seleccionar_Periodo;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridView dgv_Seleccionar_Periodo;
    }
}