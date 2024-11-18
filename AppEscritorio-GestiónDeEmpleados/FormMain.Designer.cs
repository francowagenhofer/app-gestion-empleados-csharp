namespace AppEscritorio_GestiónDeEmpleados
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.gestiónProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip5
            // 
            this.menuStrip5.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónEmpleadosToolStripMenuItem,
            this.gestiónProyectosToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem6});
            this.menuStrip5.Location = new System.Drawing.Point(0, 0);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(843, 28);
            this.menuStrip5.TabIndex = 0;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // gestiónProyectosToolStripMenuItem
            // 
            this.gestiónProyectosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15});
            this.gestiónProyectosToolStripMenuItem.Name = "gestiónProyectosToolStripMenuItem";
            this.gestiónProyectosToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.gestiónProyectosToolStripMenuItem.Text = "Gestión Proyectos";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(106, 24);
            this.toolStripMenuItem4.Text = "Operaciones";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(82, 24);
            this.toolStripMenuItem6.Text = "Reportes";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem8.Text = "Reporte Empleados";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem9.Text = "Reporte Proyectos";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem10.Text = "Reporte Finanzas";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem11.Text = "Salarios";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem12.Text = "Bonos";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem13.Text = "Proyectos";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem14.Text = "Roles ";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem15.Text = "Tareas";
            // 
            // gestiónEmpleadosToolStripMenuItem
            // 
            this.gestiónEmpleadosToolStripMenuItem.Name = "gestiónEmpleadosToolStripMenuItem";
            this.gestiónEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.gestiónEmpleadosToolStripMenuItem.Text = "Gestión Empleados";
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(843, 745);
            this.Controls.Add(this.menuStrip5);
            this.MainMenuStrip = this.menuStrip5;
            this.Name = "FormMain";
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sdlssToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOperacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDetalleDeInformacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarEstadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem gestionarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem buscarDetallesDeUnEmpleadoEspecíficoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUnNuevoEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarLosDatosDeUnEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarElEstadoDeUnEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUnEmpleadoDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteFinanzasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verReporteEmpleaedoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarReporteEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarReporteEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verReporteProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarReporteProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarReporteProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verReporteFinanzasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteFinanzasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarReporteFinanzasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarReporteFinanzasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeSalariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarSalarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularMontoDeSalarioToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.ToolStripMenuItem gestiónProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem gestiónEmpleadosToolStripMenuItem;
    }
}

