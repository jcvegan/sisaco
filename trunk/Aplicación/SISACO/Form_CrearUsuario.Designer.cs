namespace SISACO
{
    partial class Form_CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CrearUsuario));
            this.cbx_Perfil_Usuario = new System.Windows.Forms.ComboBox();
            this.Perfil_Usuario = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.txt_Contraseña_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Contraseña_Usuario = new System.Windows.Forms.Label();
            this.txt_Nombre_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Apellidos_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Nombres_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Codigo_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Nombre_Usuario = new System.Windows.Forms.Label();
            this.lbl_Apellidos_Usuario = new System.Windows.Forms.Label();
            this.lbl_Nombres_Usuario = new System.Windows.Forms.Label();
            this.lbl_Codigo_Usuario = new System.Windows.Forms.Label();
            this.pnl_Crear_Usuario = new System.Windows.Forms.Panel();
            this.pnl_Crear_Usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_Perfil_Usuario
            // 
            this.cbx_Perfil_Usuario.DisplayMember = "Perfil_Usuario";
            this.cbx_Perfil_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Perfil_Usuario.FormattingEnabled = true;
            this.cbx_Perfil_Usuario.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cbx_Perfil_Usuario.Location = new System.Drawing.Point(130, 136);
            this.cbx_Perfil_Usuario.Name = "cbx_Perfil_Usuario";
            this.cbx_Perfil_Usuario.Size = new System.Drawing.Size(121, 21);
            this.cbx_Perfil_Usuario.TabIndex = 13;
            this.cbx_Perfil_Usuario.ValueMember = "Codigo_Perfil_Usuario";
            // 
            // Perfil_Usuario
            // 
            this.Perfil_Usuario.AutoSize = true;
            this.Perfil_Usuario.Location = new System.Drawing.Point(3, 139);
            this.Perfil_Usuario.Name = "Perfil_Usuario";
            this.Perfil_Usuario.Size = new System.Drawing.Size(84, 13);
            this.Perfil_Usuario.TabIndex = 12;
            this.Perfil_Usuario.Text = "Perfil de Usuario";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Image = global::SISACO.Properties.Resources.Cancelar;
            this.btn_Cancelar.Location = new System.Drawing.Point(190, 185);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 15;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Image = global::SISACO.Properties.Resources.Aceptar;
            this.btn_Registrar.Location = new System.Drawing.Point(86, 185);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Registrar.TabIndex = 14;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // txt_Contraseña_Usuario
            // 
            this.txt_Contraseña_Usuario.AcceptsTab = true;
            this.txt_Contraseña_Usuario.Location = new System.Drawing.Point(130, 110);
            this.txt_Contraseña_Usuario.Name = "txt_Contraseña_Usuario";
            this.txt_Contraseña_Usuario.PasswordChar = '*';
            this.txt_Contraseña_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_Contraseña_Usuario.TabIndex = 11;
            // 
            // lbl_Contraseña_Usuario
            // 
            this.lbl_Contraseña_Usuario.AutoSize = true;
            this.lbl_Contraseña_Usuario.Location = new System.Drawing.Point(3, 113);
            this.lbl_Contraseña_Usuario.Name = "lbl_Contraseña_Usuario";
            this.lbl_Contraseña_Usuario.Size = new System.Drawing.Size(115, 13);
            this.lbl_Contraseña_Usuario.TabIndex = 10;
            this.lbl_Contraseña_Usuario.Text = "Contraseña de Usuario";
            // 
            // txt_Nombre_Usuario
            // 
            this.txt_Nombre_Usuario.Location = new System.Drawing.Point(130, 84);
            this.txt_Nombre_Usuario.Name = "txt_Nombre_Usuario";
            this.txt_Nombre_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre_Usuario.TabIndex = 9;
            // 
            // txt_Apellidos_Usuario
            // 
            this.txt_Apellidos_Usuario.Location = new System.Drawing.Point(130, 58);
            this.txt_Apellidos_Usuario.Name = "txt_Apellidos_Usuario";
            this.txt_Apellidos_Usuario.Size = new System.Drawing.Size(200, 20);
            this.txt_Apellidos_Usuario.TabIndex = 7;
            // 
            // txt_Nombres_Usuario
            // 
            this.txt_Nombres_Usuario.Location = new System.Drawing.Point(130, 32);
            this.txt_Nombres_Usuario.Name = "txt_Nombres_Usuario";
            this.txt_Nombres_Usuario.Size = new System.Drawing.Size(200, 20);
            this.txt_Nombres_Usuario.TabIndex = 5;
            // 
            // txt_Codigo_Usuario
            // 
            this.txt_Codigo_Usuario.Enabled = false;
            this.txt_Codigo_Usuario.Location = new System.Drawing.Point(130, 8);
            this.txt_Codigo_Usuario.Name = "txt_Codigo_Usuario";
            this.txt_Codigo_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo_Usuario.TabIndex = 3;
            // 
            // lbl_Nombre_Usuario
            // 
            this.lbl_Nombre_Usuario.AutoSize = true;
            this.lbl_Nombre_Usuario.Location = new System.Drawing.Point(3, 87);
            this.lbl_Nombre_Usuario.Name = "lbl_Nombre_Usuario";
            this.lbl_Nombre_Usuario.Size = new System.Drawing.Size(98, 13);
            this.lbl_Nombre_Usuario.TabIndex = 8;
            this.lbl_Nombre_Usuario.Text = "Nombre de Usuario";
            // 
            // lbl_Apellidos_Usuario
            // 
            this.lbl_Apellidos_Usuario.AutoSize = true;
            this.lbl_Apellidos_Usuario.Location = new System.Drawing.Point(3, 61);
            this.lbl_Apellidos_Usuario.Name = "lbl_Apellidos_Usuario";
            this.lbl_Apellidos_Usuario.Size = new System.Drawing.Size(49, 13);
            this.lbl_Apellidos_Usuario.TabIndex = 6;
            this.lbl_Apellidos_Usuario.Text = "Apellidos";
            // 
            // lbl_Nombres_Usuario
            // 
            this.lbl_Nombres_Usuario.AutoSize = true;
            this.lbl_Nombres_Usuario.Location = new System.Drawing.Point(3, 35);
            this.lbl_Nombres_Usuario.Name = "lbl_Nombres_Usuario";
            this.lbl_Nombres_Usuario.Size = new System.Drawing.Size(49, 13);
            this.lbl_Nombres_Usuario.TabIndex = 4;
            this.lbl_Nombres_Usuario.Text = "Nombres";
            // 
            // lbl_Codigo_Usuario
            // 
            this.lbl_Codigo_Usuario.AutoSize = true;
            this.lbl_Codigo_Usuario.Location = new System.Drawing.Point(3, 11);
            this.lbl_Codigo_Usuario.Name = "lbl_Codigo_Usuario";
            this.lbl_Codigo_Usuario.Size = new System.Drawing.Size(94, 13);
            this.lbl_Codigo_Usuario.TabIndex = 2;
            this.lbl_Codigo_Usuario.Text = "Código de Usuario";
            // 
            // pnl_Crear_Usuario
            // 
            this.pnl_Crear_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Crear_Usuario.Controls.Add(this.cbx_Perfil_Usuario);
            this.pnl_Crear_Usuario.Controls.Add(this.lbl_Codigo_Usuario);
            this.pnl_Crear_Usuario.Controls.Add(this.Perfil_Usuario);
            this.pnl_Crear_Usuario.Controls.Add(this.lbl_Nombres_Usuario);
            this.pnl_Crear_Usuario.Controls.Add(this.lbl_Apellidos_Usuario);
            this.pnl_Crear_Usuario.Controls.Add(this.lbl_Nombre_Usuario);
            this.pnl_Crear_Usuario.Controls.Add(this.txt_Contraseña_Usuario);
            this.pnl_Crear_Usuario.Controls.Add(this.txt_Codigo_Usuario);
            this.pnl_Crear_Usuario.Controls.Add(this.lbl_Contraseña_Usuario);
            this.pnl_Crear_Usuario.Controls.Add(this.txt_Nombres_Usuario);
            this.pnl_Crear_Usuario.Controls.Add(this.txt_Nombre_Usuario);
            this.pnl_Crear_Usuario.Controls.Add(this.txt_Apellidos_Usuario);
            this.pnl_Crear_Usuario.Location = new System.Drawing.Point(9, 9);
            this.pnl_Crear_Usuario.Name = "pnl_Crear_Usuario";
            this.pnl_Crear_Usuario.Size = new System.Drawing.Size(339, 168);
            this.pnl_Crear_Usuario.TabIndex = 1;
            // 
            // Form_CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 212);
            this.Controls.Add(this.pnl_Crear_Usuario);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Registrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Usuario";
            this.Load += new System.EventHandler(this.Form_CrearUsuario_Load);
            this.pnl_Crear_Usuario.ResumeLayout(false);
            this.pnl_Crear_Usuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Perfil_Usuario;
        private System.Windows.Forms.Label Perfil_Usuario;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.TextBox txt_Contraseña_Usuario;
        private System.Windows.Forms.Label lbl_Contraseña_Usuario;
        private System.Windows.Forms.TextBox txt_Nombre_Usuario;
        private System.Windows.Forms.TextBox txt_Apellidos_Usuario;
        private System.Windows.Forms.TextBox txt_Nombres_Usuario;
        private System.Windows.Forms.TextBox txt_Codigo_Usuario;
        private System.Windows.Forms.Label lbl_Nombre_Usuario;
        private System.Windows.Forms.Label lbl_Apellidos_Usuario;
        private System.Windows.Forms.Label lbl_Nombres_Usuario;
        private System.Windows.Forms.Label lbl_Codigo_Usuario;
        private System.Windows.Forms.Panel pnl_Crear_Usuario;
    }
}