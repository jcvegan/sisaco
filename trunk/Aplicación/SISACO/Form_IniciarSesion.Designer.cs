namespace SISACO
{
    partial class Form_IniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_IniciarSesion));
            this.lb_Nombre_Usuario = new System.Windows.Forms.Label();
            this.lb_Contraseña = new System.Windows.Forms.Label();
            this.lb_Perfil = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txt_Nombre_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.cbx_Perfil = new System.Windows.Forms.ComboBox();
            this.pbx_Iniciar_Sesion = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.pnl_Iniciar_Sesion = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Iniciar_Sesion)).BeginInit();
            this.pnl_Iniciar_Sesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Nombre_Usuario
            // 
            this.lb_Nombre_Usuario.AutoSize = true;
            this.lb_Nombre_Usuario.Location = new System.Drawing.Point(123, 19);
            this.lb_Nombre_Usuario.Name = "lb_Nombre_Usuario";
            this.lb_Nombre_Usuario.Size = new System.Drawing.Size(98, 13);
            this.lb_Nombre_Usuario.TabIndex = 2;
            this.lb_Nombre_Usuario.Text = "Nombre de Usuario";
            // 
            // lb_Contraseña
            // 
            this.lb_Contraseña.AutoSize = true;
            this.lb_Contraseña.Location = new System.Drawing.Point(123, 52);
            this.lb_Contraseña.Name = "lb_Contraseña";
            this.lb_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.lb_Contraseña.TabIndex = 4;
            this.lb_Contraseña.Text = "Contraseña";
            // 
            // lb_Perfil
            // 
            this.lb_Perfil.AutoSize = true;
            this.lb_Perfil.Location = new System.Drawing.Point(123, 85);
            this.lb_Perfil.Name = "lb_Perfil";
            this.lb_Perfil.Size = new System.Drawing.Size(30, 13);
            this.lb_Perfil.TabIndex = 6;
            this.lb_Perfil.Text = "Perfil";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Image = global::SISACO.Properties.Resources.Aceptar;
            this.btn_Aceptar.Location = new System.Drawing.Point(159, 120);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(80, 25);
            this.btn_Aceptar.TabIndex = 8;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txt_Nombre_Usuario
            // 
            this.txt_Nombre_Usuario.Location = new System.Drawing.Point(240, 16);
            this.txt_Nombre_Usuario.Name = "txt_Nombre_Usuario";
            this.txt_Nombre_Usuario.Size = new System.Drawing.Size(150, 20);
            this.txt_Nombre_Usuario.TabIndex = 3;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(240, 49);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(150, 20);
            this.txt_Contraseña.TabIndex = 5;
            // 
            // cbx_Perfil
            // 
            this.cbx_Perfil.DisplayMember = "Perfil_Usuario";
            this.cbx_Perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Perfil.FormattingEnabled = true;
            this.cbx_Perfil.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cbx_Perfil.Location = new System.Drawing.Point(240, 82);
            this.cbx_Perfil.Name = "cbx_Perfil";
            this.cbx_Perfil.Size = new System.Drawing.Size(150, 21);
            this.cbx_Perfil.TabIndex = 7;
            this.cbx_Perfil.Tag = "";
            this.cbx_Perfil.ValueMember = "Codigo_Perfil_Usuario";
            // 
            // pbx_Iniciar_Sesion
            // 
            this.pbx_Iniciar_Sesion.Image = global::SISACO.Properties.Resources.Iniciar_Sesion;
            this.pbx_Iniciar_Sesion.Location = new System.Drawing.Point(13, 28);
            this.pbx_Iniciar_Sesion.Name = "pbx_Iniciar_Sesion";
            this.pbx_Iniciar_Sesion.Size = new System.Drawing.Size(100, 100);
            this.pbx_Iniciar_Sesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Iniciar_Sesion.TabIndex = 8;
            this.pbx_Iniciar_Sesion.TabStop = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Image = global::SISACO.Properties.Resources.Cancelar;
            this.btn_Salir.Location = new System.Drawing.Point(286, 120);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(80, 25);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pnl_Iniciar_Sesion
            // 
            this.pnl_Iniciar_Sesion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Iniciar_Sesion.Controls.Add(this.pbx_Iniciar_Sesion);
            this.pnl_Iniciar_Sesion.Controls.Add(this.btn_Salir);
            this.pnl_Iniciar_Sesion.Controls.Add(this.lb_Nombre_Usuario);
            this.pnl_Iniciar_Sesion.Controls.Add(this.lb_Contraseña);
            this.pnl_Iniciar_Sesion.Controls.Add(this.cbx_Perfil);
            this.pnl_Iniciar_Sesion.Controls.Add(this.lb_Perfil);
            this.pnl_Iniciar_Sesion.Controls.Add(this.txt_Contraseña);
            this.pnl_Iniciar_Sesion.Controls.Add(this.btn_Aceptar);
            this.pnl_Iniciar_Sesion.Controls.Add(this.txt_Nombre_Usuario);
            this.pnl_Iniciar_Sesion.Location = new System.Drawing.Point(9, 9);
            this.pnl_Iniciar_Sesion.Name = "pnl_Iniciar_Sesion";
            this.pnl_Iniciar_Sesion.Size = new System.Drawing.Size(409, 159);
            this.pnl_Iniciar_Sesion.TabIndex = 1;
            // 
            // Form_IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(429, 182);
            this.Controls.Add(this.pnl_Iniciar_Sesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_IniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISACO - Iniciar Sesión";
            this.Load += new System.EventHandler(this.Form_IniciarSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Iniciar_Sesion)).EndInit();
            this.pnl_Iniciar_Sesion.ResumeLayout(false);
            this.pnl_Iniciar_Sesion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Nombre_Usuario;
        private System.Windows.Forms.Label lb_Contraseña;
        private System.Windows.Forms.Label lb_Perfil;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.TextBox txt_Nombre_Usuario;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.ComboBox cbx_Perfil;
        private System.Windows.Forms.PictureBox pbx_Iniciar_Sesion;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Panel pnl_Iniciar_Sesion;
    }
}

