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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.btnProyectos = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.menuStrip5.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip5
            // 
            this.menuStrip5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip5.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip5.Location = new System.Drawing.Point(0, 0);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(682, 31);
            this.menuStrip5.TabIndex = 2;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(81, 27);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(236, 28);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoDelSistemaToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(99, 27);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // infoDelSistemaToolStripMenuItem
            // 
            this.infoDelSistemaToolStripMenuItem.Name = "infoDelSistemaToolStripMenuItem";
            this.infoDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
            this.infoDelSistemaToolStripMenuItem.Text = "Info del sistema";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.72564F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.27436F));
            this.tableLayoutPanel.Controls.Add(this.btnSalir, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.btnReportes, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.btnOperaciones, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.btnProyectos, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.btnEmpleados, 0, 0);
            this.tableLayoutPanel.ForeColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel.Location = new System.Drawing.Point(69, 114);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(30);
            this.tableLayoutPanel.MaximumSize = new System.Drawing.Size(500, 500);
            this.tableLayoutPanel.MinimumSize = new System.Drawing.Size(500, 500);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(40);
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.94624F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.94624F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(500, 500);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(264, 368);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.btnSalir.MaximumSize = new System.Drawing.Size(275, 85);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(176, 77);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.CausesValidation = false;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(264, 160);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.btnReportes.MaximumSize = new System.Drawing.Size(275, 85);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(176, 74);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.TabStop = false;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.CausesValidation = false;
            this.btnOperaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOperaciones.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperaciones.Location = new System.Drawing.Point(60, 160);
            this.btnOperaciones.Margin = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.btnOperaciones.MaximumSize = new System.Drawing.Size(275, 85);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Size = new System.Drawing.Size(164, 74);
            this.btnOperaciones.TabIndex = 2;
            this.btnOperaciones.TabStop = false;
            this.btnOperaciones.Text = "Operaciones";
            this.btnOperaciones.UseVisualStyleBackColor = true;
            this.btnOperaciones.Click += new System.EventHandler(this.btnOperaciones_Click);
            // 
            // btnProyectos
            // 
            this.btnProyectos.CausesValidation = false;
            this.btnProyectos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProyectos.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyectos.Location = new System.Drawing.Point(264, 55);
            this.btnProyectos.Margin = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.btnProyectos.MaximumSize = new System.Drawing.Size(275, 85);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.Size = new System.Drawing.Size(176, 75);
            this.btnProyectos.TabIndex = 1;
            this.btnProyectos.TabStop = false;
            this.btnProyectos.Text = "Proyectos";
            this.btnProyectos.UseVisualStyleBackColor = true;
            this.btnProyectos.Click += new System.EventHandler(this.btnProyectos_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.CausesValidation = false;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Location = new System.Drawing.Point(60, 55);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.btnEmpleados.MaximumSize = new System.Drawing.Size(275, 85);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(164, 75);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.TabStop = false;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.UseWaitCursor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.tableLayoutPanel1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 31);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(682, 77);
            this.panelSuperior.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFecha});
            this.statusStrip1.Location = new System.Drawing.Point(0, 622);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(682, 31);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "Usuario";
            // 
            // tsFecha
            // 
            this.tsFecha.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsFecha.Name = "tsFecha";
            this.tsFecha.Size = new System.Drawing.Size(57, 25);
            this.tsFecha.Text = "Fecha";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.89264F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.10735F));
            this.tableLayoutPanel1.Controls.Add(this.labelTitulo, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 77);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(72, 3);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Padding = new System.Windows.Forms.Padding(15);
            this.labelTitulo.Size = new System.Drawing.Size(520, 71);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Sistema de Gestión de Empleados";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.menuStrip5);
            this.ForeColor = System.Drawing.Color.Navy;
            this.MainMenuStrip = this.menuStrip5;
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "FormMain";
            this.Text = "\tSistema de Gestión de Empleados";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoDelSistemaToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnProyectos;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsFecha;
        private System.Windows.Forms.Button btnOperaciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTitulo;
    }
}

