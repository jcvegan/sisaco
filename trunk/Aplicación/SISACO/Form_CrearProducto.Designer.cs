﻿namespace SISACO
{
    partial class Form_CrearProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CrearProducto));
            this.pnl_Crear_Producto = new System.Windows.Forms.Panel();
            this.lbl_Presentacion = new System.Windows.Forms.Label();
            this.txt_Presentacion = new System.Windows.Forms.TextBox();
            this.lbl_Proceso = new System.Windows.Forms.Label();
            this.txt_Proceso = new System.Windows.Forms.TextBox();
            this.lbl_Codigo_Producto = new System.Windows.Forms.Label();
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.lbl_Forma_Farmacutica = new System.Windows.Forms.Label();
            this.txt_Codigo_Producto = new System.Windows.Forms.TextBox();
            this.txt_Producto = new System.Windows.Forms.TextBox();
            this.txt_Forma_Farmaceutica = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.pnl_Crear_Producto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Crear_Producto
            // 
            this.pnl_Crear_Producto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Crear_Producto.Controls.Add(this.lbl_Presentacion);
            this.pnl_Crear_Producto.Controls.Add(this.txt_Presentacion);
            this.pnl_Crear_Producto.Controls.Add(this.lbl_Proceso);
            this.pnl_Crear_Producto.Controls.Add(this.txt_Proceso);
            this.pnl_Crear_Producto.Controls.Add(this.lbl_Codigo_Producto);
            this.pnl_Crear_Producto.Controls.Add(this.lbl_Producto);
            this.pnl_Crear_Producto.Controls.Add(this.lbl_Forma_Farmacutica);
            this.pnl_Crear_Producto.Controls.Add(this.txt_Codigo_Producto);
            this.pnl_Crear_Producto.Controls.Add(this.txt_Producto);
            this.pnl_Crear_Producto.Controls.Add(this.txt_Forma_Farmaceutica);
            this.pnl_Crear_Producto.Location = new System.Drawing.Point(9, 9);
            this.pnl_Crear_Producto.Name = "pnl_Crear_Producto";
            this.pnl_Crear_Producto.Size = new System.Drawing.Size(339, 142);
            this.pnl_Crear_Producto.TabIndex = 1;
            // 
            // lbl_Presentacion
            // 
            this.lbl_Presentacion.AutoSize = true;
            this.lbl_Presentacion.Location = new System.Drawing.Point(3, 113);
            this.lbl_Presentacion.Name = "lbl_Presentacion";
            this.lbl_Presentacion.Size = new System.Drawing.Size(69, 13);
            this.lbl_Presentacion.TabIndex = 10;
            this.lbl_Presentacion.Text = "Presentación";
            // 
            // txt_Presentacion
            // 
            this.txt_Presentacion.Location = new System.Drawing.Point(130, 110);
            this.txt_Presentacion.Name = "txt_Presentacion";
            this.txt_Presentacion.Size = new System.Drawing.Size(100, 20);
            this.txt_Presentacion.TabIndex = 11;
            // 
            // lbl_Proceso
            // 
            this.lbl_Proceso.AutoSize = true;
            this.lbl_Proceso.Location = new System.Drawing.Point(3, 87);
            this.lbl_Proceso.Name = "lbl_Proceso";
            this.lbl_Proceso.Size = new System.Drawing.Size(46, 13);
            this.lbl_Proceso.TabIndex = 8;
            this.lbl_Proceso.Text = "Proceso";
            // 
            // txt_Proceso
            // 
            this.txt_Proceso.Location = new System.Drawing.Point(130, 84);
            this.txt_Proceso.Name = "txt_Proceso";
            this.txt_Proceso.Size = new System.Drawing.Size(100, 20);
            this.txt_Proceso.TabIndex = 9;
            // 
            // lbl_Codigo_Producto
            // 
            this.lbl_Codigo_Producto.AutoSize = true;
            this.lbl_Codigo_Producto.Location = new System.Drawing.Point(3, 11);
            this.lbl_Codigo_Producto.Name = "lbl_Codigo_Producto";
            this.lbl_Codigo_Producto.Size = new System.Drawing.Size(103, 13);
            this.lbl_Codigo_Producto.TabIndex = 2;
            this.lbl_Codigo_Producto.Text = "Código del Producto";
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.Location = new System.Drawing.Point(3, 35);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(50, 13);
            this.lbl_Producto.TabIndex = 4;
            this.lbl_Producto.Text = "Producto";
            // 
            // lbl_Forma_Farmacutica
            // 
            this.lbl_Forma_Farmacutica.AutoSize = true;
            this.lbl_Forma_Farmacutica.Location = new System.Drawing.Point(3, 61);
            this.lbl_Forma_Farmacutica.Name = "lbl_Forma_Farmacutica";
            this.lbl_Forma_Farmacutica.Size = new System.Drawing.Size(103, 13);
            this.lbl_Forma_Farmacutica.TabIndex = 6;
            this.lbl_Forma_Farmacutica.Text = "Forma Farmacéutica";
            // 
            // txt_Codigo_Producto
            // 
            this.txt_Codigo_Producto.Enabled = false;
            this.txt_Codigo_Producto.Location = new System.Drawing.Point(130, 8);
            this.txt_Codigo_Producto.Name = "txt_Codigo_Producto";
            this.txt_Codigo_Producto.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo_Producto.TabIndex = 3;
            // 
            // txt_Producto
            // 
            this.txt_Producto.Location = new System.Drawing.Point(130, 32);
            this.txt_Producto.Name = "txt_Producto";
            this.txt_Producto.Size = new System.Drawing.Size(200, 20);
            this.txt_Producto.TabIndex = 5;
            // 
            // txt_Forma_Farmaceutica
            // 
            this.txt_Forma_Farmaceutica.Location = new System.Drawing.Point(130, 58);
            this.txt_Forma_Farmaceutica.Name = "txt_Forma_Farmaceutica";
            this.txt_Forma_Farmaceutica.Size = new System.Drawing.Size(100, 20);
            this.txt_Forma_Farmaceutica.TabIndex = 7;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Image = global::SISACO.Properties.Resources.Cancelar;
            this.btn_Cancelar.Location = new System.Drawing.Point(190, 157);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 13;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Image = global::SISACO.Properties.Resources.Aceptar;
            this.btn_Registrar.Location = new System.Drawing.Point(87, 157);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Registrar.TabIndex = 12;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // Form_CrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 187);
            this.Controls.Add(this.pnl_Crear_Producto);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Registrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_CrearProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Producto";
            this.Load += new System.EventHandler(this.Form_CrearProducto_Load);
            this.pnl_Crear_Producto.ResumeLayout(false);
            this.pnl_Crear_Producto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Crear_Producto;
        private System.Windows.Forms.Label lbl_Codigo_Producto;
        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.Label lbl_Forma_Farmacutica;
        private System.Windows.Forms.TextBox txt_Codigo_Producto;
        private System.Windows.Forms.TextBox txt_Producto;
        private System.Windows.Forms.TextBox txt_Forma_Farmaceutica;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Label lbl_Presentacion;
        private System.Windows.Forms.TextBox txt_Presentacion;
        private System.Windows.Forms.Label lbl_Proceso;
        private System.Windows.Forms.TextBox txt_Proceso;
    }
}