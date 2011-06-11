namespace SISACO
{
    partial class Form_RegistrarMaterialdeEmpaqueporProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RegistrarMaterialdeEmpaqueporProducto));
            this.pnl_Cantidad_Material_x_Producto = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Aceptar_2 = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Nombre_Producto = new System.Windows.Forms.TextBox();
            this.lbl_Tamaño_Lote = new System.Windows.Forms.Label();
            this.dgv_Cantidad_Material_x_Producto = new System.Windows.Forms.DataGridView();
            this.txt_Tamaño_Lote = new System.Windows.Forms.TextBox();
            this.txt_Codigo_Producto = new System.Windows.Forms.TextBox();
            this.lbl_Codigo_Producto = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material_Empauqe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Pedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Cantidad_Material_x_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cantidad_Material_x_Producto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Cantidad_Material_x_Producto
            // 
            this.pnl_Cantidad_Material_x_Producto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Cantidad_Material_x_Producto.Controls.Add(this.btn_Eliminar);
            this.pnl_Cantidad_Material_x_Producto.Controls.Add(this.btn_Cancelar);
            this.pnl_Cantidad_Material_x_Producto.Controls.Add(this.btn_Agregar);
            this.pnl_Cantidad_Material_x_Producto.Controls.Add(this.btn_Aceptar);
            this.pnl_Cantidad_Material_x_Producto.Controls.Add(this.btn_Limpiar);
            this.pnl_Cantidad_Material_x_Producto.Controls.Add(this.btn_Aceptar_2);
            this.pnl_Cantidad_Material_x_Producto.Controls.Add(this.btn_Buscar);
            this.pnl_Cantidad_Material_x_Producto.Controls.Add(this.txt_Nombre_Producto);
            this.pnl_Cantidad_Material_x_Producto.Controls.Add(this.lbl_Tamaño_Lote);
            this.pnl_Cantidad_Material_x_Producto.Controls.Add(this.dgv_Cantidad_Material_x_Producto);
            this.pnl_Cantidad_Material_x_Producto.Controls.Add(this.txt_Tamaño_Lote);
            this.pnl_Cantidad_Material_x_Producto.Controls.Add(this.txt_Codigo_Producto);
            this.pnl_Cantidad_Material_x_Producto.Controls.Add(this.lbl_Codigo_Producto);
            this.pnl_Cantidad_Material_x_Producto.Location = new System.Drawing.Point(9, 9);
            this.pnl_Cantidad_Material_x_Producto.Name = "pnl_Cantidad_Material_x_Producto";
            this.pnl_Cantidad_Material_x_Producto.Size = new System.Drawing.Size(508, 306);
            this.pnl_Cantidad_Material_x_Producto.TabIndex = 1;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.Image = global::SISACO.Properties.Resources.Eliminar;
            this.btn_Eliminar.Location = new System.Drawing.Point(183, 276);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 12;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Image = global::SISACO.Properties.Resources.Cancelar;
            this.btn_Cancelar.Location = new System.Drawing.Point(426, 276);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 14;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Enabled = false;
            this.btn_Agregar.Image = global::SISACO.Properties.Resources.Agregar;
            this.btn_Agregar.Location = new System.Drawing.Point(102, 276);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 11;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Enabled = false;
            this.btn_Aceptar.Image = global::SISACO.Properties.Resources.Aceptar;
            this.btn_Aceptar.Location = new System.Drawing.Point(218, 30);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 8;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Enabled = false;
            this.btn_Limpiar.Image = global::SISACO.Properties.Resources.Limpiar;
            this.btn_Limpiar.Location = new System.Drawing.Point(264, 276);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.TabIndex = 10;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Aceptar_2
            // 
            this.btn_Aceptar_2.Enabled = false;
            this.btn_Aceptar_2.Image = global::SISACO.Properties.Resources.Aceptar;
            this.btn_Aceptar_2.Location = new System.Drawing.Point(345, 276);
            this.btn_Aceptar_2.Name = "btn_Aceptar_2";
            this.btn_Aceptar_2.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar_2.TabIndex = 13;
            this.btn_Aceptar_2.Text = "Aceptar";
            this.btn_Aceptar_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Aceptar_2.UseVisualStyleBackColor = true;
            this.btn_Aceptar_2.Click += new System.EventHandler(this.btn_Aceptar_2_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::SISACO.Properties.Resources.Buscar;
            this.btn_Buscar.Location = new System.Drawing.Point(218, 5);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(20, 20);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Nombre_Producto
            // 
            this.txt_Nombre_Producto.Enabled = false;
            this.txt_Nombre_Producto.Location = new System.Drawing.Point(244, 6);
            this.txt_Nombre_Producto.Name = "txt_Nombre_Producto";
            this.txt_Nombre_Producto.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre_Producto.TabIndex = 5;
            // 
            // lbl_Tamaño_Lote
            // 
            this.lbl_Tamaño_Lote.AutoSize = true;
            this.lbl_Tamaño_Lote.Enabled = false;
            this.lbl_Tamaño_Lote.Location = new System.Drawing.Point(3, 35);
            this.lbl_Tamaño_Lote.Name = "lbl_Tamaño_Lote";
            this.lbl_Tamaño_Lote.Size = new System.Drawing.Size(87, 13);
            this.lbl_Tamaño_Lote.TabIndex = 6;
            this.lbl_Tamaño_Lote.Text = "Tamaño del Lote";
            // 
            // dgv_Cantidad_Material_x_Producto
            // 
            this.dgv_Cantidad_Material_x_Producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Cantidad_Material_x_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cantidad_Material_x_Producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Material_Empauqe,
            this.Cantidad_Pedida,
            this.Unidad});
            this.dgv_Cantidad_Material_x_Producto.Enabled = false;
            this.dgv_Cantidad_Material_x_Producto.Location = new System.Drawing.Point(3, 62);
            this.dgv_Cantidad_Material_x_Producto.Name = "dgv_Cantidad_Material_x_Producto";
            this.dgv_Cantidad_Material_x_Producto.Size = new System.Drawing.Size(500, 205);
            this.dgv_Cantidad_Material_x_Producto.TabIndex = 9;
            // 
            // txt_Tamaño_Lote
            // 
            this.txt_Tamaño_Lote.Enabled = false;
            this.txt_Tamaño_Lote.Location = new System.Drawing.Point(112, 32);
            this.txt_Tamaño_Lote.Name = "txt_Tamaño_Lote";
            this.txt_Tamaño_Lote.Size = new System.Drawing.Size(100, 20);
            this.txt_Tamaño_Lote.TabIndex = 7;
            // 
            // txt_Codigo_Producto
            // 
            this.txt_Codigo_Producto.Location = new System.Drawing.Point(112, 6);
            this.txt_Codigo_Producto.Name = "txt_Codigo_Producto";
            this.txt_Codigo_Producto.Size = new System.Drawing.Size(100, 20);
            this.txt_Codigo_Producto.TabIndex = 3;
            // 
            // lbl_Codigo_Producto
            // 
            this.lbl_Codigo_Producto.AutoSize = true;
            this.lbl_Codigo_Producto.Location = new System.Drawing.Point(3, 9);
            this.lbl_Codigo_Producto.Name = "lbl_Codigo_Producto";
            this.lbl_Codigo_Producto.Size = new System.Drawing.Size(103, 13);
            this.lbl_Codigo_Producto.TabIndex = 2;
            this.lbl_Codigo_Producto.Text = "Código del Producto";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo_Material_Empaque";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre_Material_Empaque";
            this.dataGridViewTextBoxColumn2.HeaderText = "Material de Empaque";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 121;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cantidad_Pedida";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad Pedida";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 101;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Unidad_Medida";
            this.dataGridViewTextBoxColumn4.HeaderText = "Unidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 66;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.DataPropertyName = "Codigo_Material_Empaque";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 65;
            // 
            // Material_Empauqe
            // 
            this.Material_Empauqe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Material_Empauqe.DataPropertyName = "Nombre_Material_Empaque";
            this.Material_Empauqe.HeaderText = "Material de Empaque";
            this.Material_Empauqe.Name = "Material_Empauqe";
            this.Material_Empauqe.ReadOnly = true;
            this.Material_Empauqe.Width = 121;
            // 
            // Cantidad_Pedida
            // 
            this.Cantidad_Pedida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad_Pedida.DataPropertyName = "Cantidad_Pedida";
            this.Cantidad_Pedida.HeaderText = "Cantidad Pedida";
            this.Cantidad_Pedida.Name = "Cantidad_Pedida";
            this.Cantidad_Pedida.Width = 101;
            // 
            // Unidad
            // 
            this.Unidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Unidad.DataPropertyName = "Unidad_Medida";
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            this.Unidad.Width = 66;
            // 
            // Form_RegistrarMaterialdeEmpaqueporProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 322);
            this.Controls.Add(this.pnl_Cantidad_Material_x_Producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_RegistrarMaterialdeEmpaqueporProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material de Empaque por Producto";
            this.Load += new System.EventHandler(this.Form_CantidaddeMaterialporProducto_Load);
            this.pnl_Cantidad_Material_x_Producto.ResumeLayout(false);
            this.pnl_Cantidad_Material_x_Producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cantidad_Material_x_Producto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Cantidad_Material_x_Producto;
        private System.Windows.Forms.Label lbl_Codigo_Producto;
        private System.Windows.Forms.TextBox txt_Nombre_Producto;
        private System.Windows.Forms.Label lbl_Tamaño_Lote;
        private System.Windows.Forms.TextBox txt_Tamaño_Lote;
        private System.Windows.Forms.TextBox txt_Codigo_Producto;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Aceptar_2;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.DataGridView dgv_Cantidad_Material_x_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material_Empauqe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Pedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}