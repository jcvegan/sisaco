namespace SISACO {
    partial class Form_CambiarContraseña {
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
            this.pnl_Cambiar_Contraseña = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_Confirmar_Contraseña_Nueva = new System.Windows.Forms.TextBox();
            this.lbl_Confirmar_Contraseña_Nueva = new System.Windows.Forms.Label();
            this.txt_Contraseña_Nueva = new System.Windows.Forms.TextBox();
            this.txt_Contraseña_Actual = new System.Windows.Forms.TextBox();
            this.lbl_Contraseña_Nueva = new System.Windows.Forms.Label();
            this.lbl_Contraseña_Actual = new System.Windows.Forms.Label();
            this.pnl_Cambiar_Contraseña.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Cambiar_Contraseña
            // 
            this.pnl_Cambiar_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Cambiar_Contraseña.Controls.Add(this.txt_Confirmar_Contraseña_Nueva);
            this.pnl_Cambiar_Contraseña.Controls.Add(this.lbl_Confirmar_Contraseña_Nueva);
            this.pnl_Cambiar_Contraseña.Controls.Add(this.txt_Contraseña_Nueva);
            this.pnl_Cambiar_Contraseña.Controls.Add(this.txt_Contraseña_Actual);
            this.pnl_Cambiar_Contraseña.Controls.Add(this.lbl_Contraseña_Nueva);
            this.pnl_Cambiar_Contraseña.Controls.Add(this.lbl_Contraseña_Actual);
            this.pnl_Cambiar_Contraseña.Location = new System.Drawing.Point(9, 9);
            this.pnl_Cambiar_Contraseña.Name = "pnl_Cambiar_Contraseña";
            this.pnl_Cambiar_Contraseña.Size = new System.Drawing.Size(265, 90);
            this.pnl_Cambiar_Contraseña.TabIndex = 1;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Image = global::SISACO.Properties.Resources.Cancelar;
            this.btn_Cancelar.Location = new System.Drawing.Point(145, 105);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Image = global::SISACO.Properties.Resources.Aceptar;
            this.btn_Aceptar.Location = new System.Drawing.Point(64, 105);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 8;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_Confirmar_Contraseña_Nueva
            // 
            this.txt_Confirmar_Contraseña_Nueva.Location = new System.Drawing.Point(152, 60);
            this.txt_Confirmar_Contraseña_Nueva.Name = "txt_Confirmar_Contraseña_Nueva";
            this.txt_Confirmar_Contraseña_Nueva.PasswordChar = '*';
            this.txt_Confirmar_Contraseña_Nueva.Size = new System.Drawing.Size(100, 20);
            this.txt_Confirmar_Contraseña_Nueva.TabIndex = 7;
            // 
            // lbl_Confirmar_Contraseña_Nueva
            // 
            this.lbl_Confirmar_Contraseña_Nueva.AutoSize = true;
            this.lbl_Confirmar_Contraseña_Nueva.Location = new System.Drawing.Point(3, 63);
            this.lbl_Confirmar_Contraseña_Nueva.Name = "lbl_Confirmar_Contraseña_Nueva";
            this.lbl_Confirmar_Contraseña_Nueva.Size = new System.Drawing.Size(143, 13);
            this.lbl_Confirmar_Contraseña_Nueva.TabIndex = 6;
            this.lbl_Confirmar_Contraseña_Nueva.Text = "Confirmar Contraseña Nueva";
            // 
            // txt_Contraseña_Nueva
            // 
            this.txt_Contraseña_Nueva.Location = new System.Drawing.Point(152, 34);
            this.txt_Contraseña_Nueva.Name = "txt_Contraseña_Nueva";
            this.txt_Contraseña_Nueva.PasswordChar = '*';
            this.txt_Contraseña_Nueva.Size = new System.Drawing.Size(100, 20);
            this.txt_Contraseña_Nueva.TabIndex = 5;
            // 
            // txt_Contraseña_Actual
            // 
            this.txt_Contraseña_Actual.Location = new System.Drawing.Point(152, 8);
            this.txt_Contraseña_Actual.Name = "txt_Contraseña_Actual";
            this.txt_Contraseña_Actual.PasswordChar = '*';
            this.txt_Contraseña_Actual.Size = new System.Drawing.Size(100, 20);
            this.txt_Contraseña_Actual.TabIndex = 3;
            // 
            // lbl_Contraseña_Nueva
            // 
            this.lbl_Contraseña_Nueva.AutoSize = true;
            this.lbl_Contraseña_Nueva.Location = new System.Drawing.Point(3, 37);
            this.lbl_Contraseña_Nueva.Name = "lbl_Contraseña_Nueva";
            this.lbl_Contraseña_Nueva.Size = new System.Drawing.Size(96, 13);
            this.lbl_Contraseña_Nueva.TabIndex = 4;
            this.lbl_Contraseña_Nueva.Text = "Contraseña Nueva";
            // 
            // lbl_Contraseña_Actual
            // 
            this.lbl_Contraseña_Actual.AutoSize = true;
            this.lbl_Contraseña_Actual.Location = new System.Drawing.Point(3, 11);
            this.lbl_Contraseña_Actual.Name = "lbl_Contraseña_Actual";
            this.lbl_Contraseña_Actual.Size = new System.Drawing.Size(94, 13);
            this.lbl_Contraseña_Actual.TabIndex = 2;
            this.lbl_Contraseña_Actual.Text = "Contraseña Actual";
            // 
            // Form_CambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.pnl_Cambiar_Contraseña);
            this.Controls.Add(this.btn_Aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_CambiarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.pnl_Cambiar_Contraseña.ResumeLayout(false);
            this.pnl_Cambiar_Contraseña.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Cambiar_Contraseña;
        private System.Windows.Forms.TextBox txt_Confirmar_Contraseña_Nueva;
        private System.Windows.Forms.Label lbl_Confirmar_Contraseña_Nueva;
        private System.Windows.Forms.TextBox txt_Contraseña_Nueva;
        private System.Windows.Forms.TextBox txt_Contraseña_Actual;
        private System.Windows.Forms.Label lbl_Contraseña_Nueva;
        private System.Windows.Forms.Label lbl_Contraseña_Actual;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
    }
}