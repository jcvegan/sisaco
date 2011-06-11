namespace SISACO
{
    partial class Form_PrincipalEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PrincipalEmpleado));
            this.msp_Empleado = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaOrdenDeAcondicionamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirOrdenDeAcondicionamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarOrdenDeAcondicionamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPeriodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porOrdenDeAcondicionamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msp_Empleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // msp_Empleado
            // 
            this.msp_Empleado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.generarToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.msp_Empleado.Location = new System.Drawing.Point(0, 0);
            this.msp_Empleado.Name = "msp_Empleado";
            this.msp_Empleado.Size = new System.Drawing.Size(634, 24);
            this.msp_Empleado.TabIndex = 1;
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaOrdenDeAcondicionamientoToolStripMenuItem,
            this.abrirOrdenDeAcondicionamientoToolStripMenuItem,
            this.buscarOrdenDeAcondicionamientoToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // nuevaOrdenDeAcondicionamientoToolStripMenuItem
            // 
            this.nuevaOrdenDeAcondicionamientoToolStripMenuItem.Name = "nuevaOrdenDeAcondicionamientoToolStripMenuItem";
            this.nuevaOrdenDeAcondicionamientoToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.nuevaOrdenDeAcondicionamientoToolStripMenuItem.Text = "Nueva Orden de Acondicionamiento";
            this.nuevaOrdenDeAcondicionamientoToolStripMenuItem.Click += new System.EventHandler(this.nuevaOrdenDeAcondicionamientoToolStripMenuItem_Click);
            // 
            // abrirOrdenDeAcondicionamientoToolStripMenuItem
            // 
            this.abrirOrdenDeAcondicionamientoToolStripMenuItem.Name = "abrirOrdenDeAcondicionamientoToolStripMenuItem";
            this.abrirOrdenDeAcondicionamientoToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.abrirOrdenDeAcondicionamientoToolStripMenuItem.Text = "Abrir Orden de Acondicionamiento";
            this.abrirOrdenDeAcondicionamientoToolStripMenuItem.Click += new System.EventHandler(this.abrirOrdenDeAcondicionamientoToolStripMenuItem_Click);
            // 
            // buscarOrdenDeAcondicionamientoToolStripMenuItem
            // 
            this.buscarOrdenDeAcondicionamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porProductoToolStripMenuItem,
            this.porPeriodoToolStripMenuItem});
            this.buscarOrdenDeAcondicionamientoToolStripMenuItem.Name = "buscarOrdenDeAcondicionamientoToolStripMenuItem";
            this.buscarOrdenDeAcondicionamientoToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.buscarOrdenDeAcondicionamientoToolStripMenuItem.Text = "Buscar Orden de Acondicionamiento";
            // 
            // porProductoToolStripMenuItem
            // 
            this.porProductoToolStripMenuItem.Name = "porProductoToolStripMenuItem";
            this.porProductoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.porProductoToolStripMenuItem.Text = "Por Producto";
            this.porProductoToolStripMenuItem.Click += new System.EventHandler(this.porProductoToolStripMenuItem_Click);
            // 
            // porPeriodoToolStripMenuItem
            // 
            this.porPeriodoToolStripMenuItem.Name = "porPeriodoToolStripMenuItem";
            this.porPeriodoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.porPeriodoToolStripMenuItem.Text = "Por Periodo";
            this.porPeriodoToolStripMenuItem.Click += new System.EventHandler(this.porPeriodoToolStripMenuItem_Click);
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteToolStripMenuItem});
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.generarToolStripMenuItem.Text = "Generar";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porOrdenDeAcondicionamientoToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // porOrdenDeAcondicionamientoToolStripMenuItem
            // 
            this.porOrdenDeAcondicionamientoToolStripMenuItem.Name = "porOrdenDeAcondicionamientoToolStripMenuItem";
            this.porOrdenDeAcondicionamientoToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.porOrdenDeAcondicionamientoToolStripMenuItem.Text = "Por Orden de Acondicionamiento";
            this.porOrdenDeAcondicionamientoToolStripMenuItem.Click += new System.EventHandler(this.porOrdenDeAcondicionamientoToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form_PrincipalEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(634, 455);
            this.Controls.Add(this.msp_Empleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msp_Empleado;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_PrincipalEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Acondicionamiento - Empleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msp_Empleado.ResumeLayout(false);
            this.msp_Empleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msp_Empleado;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaOrdenDeAcondicionamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirOrdenDeAcondicionamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarOrdenDeAcondicionamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPeriodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porOrdenDeAcondicionamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
    }
}