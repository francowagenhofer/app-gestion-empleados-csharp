namespace AppEscritorio_GestionDeEmpleados
{
    partial class FormMain
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
            msMenu = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            manualDelUsuarioToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            informaciónDelSistemaToolStripMenuItem = new ToolStripMenuItem();
            tlpMenu = new TableLayoutPanel();
            tlpTitulo = new TableLayoutPanel();
            label1 = new Label();
            tlpBotones = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnTareas = new Button();
            btnOperaciones = new Button();
            btnReportes = new Button();
            btnEmpleados = new Button();
            btnProyectos = new Button();
            btnRoles = new Button();
            btnSalir = new Button();
            tsFecha = new ToolStripStatusLabel();
            stMenu = new StatusStrip();
            msMenu.SuspendLayout();
            tlpMenu.SuspendLayout();
            tlpTitulo.SuspendLayout();
            tlpBotones.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            stMenu.SuspendLayout();
            SuspendLayout();
            // 
            // msMenu
            // 
            msMenu.BackColor = SystemColors.Control;
            msMenu.GripStyle = ToolStripGripStyle.Visible;
            msMenu.ImageScalingSize = new Size(20, 20);
            msMenu.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, ayudaToolStripMenuItem, acercaDeToolStripMenuItem });
            msMenu.Location = new Point(0, 0);
            msMenu.Name = "msMenu";
            msMenu.Size = new Size(1008, 33);
            msMenu.TabIndex = 1;
            msMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesiónToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(86, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(200, 30);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(200, 30);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manualDelUsuarioToolStripMenuItem });
            ayudaToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(77, 29);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDelUsuarioToolStripMenuItem
            // 
            manualDelUsuarioToolStripMenuItem.Name = "manualDelUsuarioToolStripMenuItem";
            manualDelUsuarioToolStripMenuItem.Size = new Size(244, 30);
            manualDelUsuarioToolStripMenuItem.Text = "Manual de usuario";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informaciónDelSistemaToolStripMenuItem });
            acercaDeToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(103, 29);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // informaciónDelSistemaToolStripMenuItem
            // 
            informaciónDelSistemaToolStripMenuItem.Name = "informaciónDelSistemaToolStripMenuItem";
            informaciónDelSistemaToolStripMenuItem.Size = new Size(288, 30);
            informaciónDelSistemaToolStripMenuItem.Text = "Información del sistema";
            // 
            // tlpMenu
            // 
            tlpMenu.BackColor = SystemColors.ControlLight;
            tlpMenu.ColumnCount = 3;
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tlpMenu.Controls.Add(tlpTitulo, 1, 1);
            tlpMenu.Controls.Add(tlpBotones, 1, 2);
            tlpMenu.Dock = DockStyle.Fill;
            tlpMenu.Location = new Point(0, 33);
            tlpMenu.MinimumSize = new Size(782, 489);
            tlpMenu.Name = "tlpMenu";
            tlpMenu.RowCount = 3;
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0924368F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 15.12605F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 73.61345F));
            tlpMenu.Size = new Size(1008, 595);
            tlpMenu.TabIndex = 2;
            // 
            // tlpTitulo
            // 
            tlpTitulo.ColumnCount = 3;
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.ColumnStyles.Add(new ColumnStyle());
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.Controls.Add(label1, 1, 0);
            tlpTitulo.Dock = DockStyle.Fill;
            tlpTitulo.Location = new Point(33, 69);
            tlpTitulo.MinimumSize = new Size(716, 64);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.RowCount = 1;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTitulo.Size = new Size(942, 84);
            tlpTitulo.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(247, 21);
            label1.Name = "label1";
            label1.Size = new Size(447, 41);
            label1.TabIndex = 0;
            label1.Text = "Sistema Gestión de Empleados";
            // 
            // tlpBotones
            // 
            tlpBotones.ColumnCount = 3;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.2420387F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.8004265F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.85138F));
            tlpBotones.Controls.Add(tableLayoutPanel1, 1, 1);
            tlpBotones.Controls.Add(btnSalir, 2, 2);
            tlpBotones.Dock = DockStyle.Fill;
            tlpBotones.Location = new Point(33, 159);
            tlpBotones.MinimumSize = new Size(716, 332);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 3;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 143F));
            tlpBotones.Size = new Size(942, 433);
            tlpBotones.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 205F));
            tableLayoutPanel1.Controls.Add(btnTareas, 2, 1);
            tableLayoutPanel1.Controls.Add(btnOperaciones, 1, 0);
            tableLayoutPanel1.Controls.Add(btnReportes, 0, 1);
            tableLayoutPanel1.Controls.Add(btnEmpleados, 0, 0);
            tableLayoutPanel1.Controls.Add(btnProyectos, 2, 0);
            tableLayoutPanel1.Controls.Add(btnRoles, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(156, 11);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(595, 276);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // btnTareas
            // 
            btnTareas.Dock = DockStyle.Fill;
            btnTareas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTareas.ForeColor = Color.SteelBlue;
            btnTareas.Location = new Point(400, 148);
            btnTareas.Margin = new Padding(10);
            btnTareas.Name = "btnTareas";
            btnTareas.Size = new Size(185, 118);
            btnTareas.TabIndex = 4;
            btnTareas.Text = "Tareas";
            btnTareas.UseVisualStyleBackColor = true;
            btnTareas.Click += btnTareas_Click;
            // 
            // btnOperaciones
            // 
            btnOperaciones.Dock = DockStyle.Fill;
            btnOperaciones.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOperaciones.ForeColor = Color.SteelBlue;
            btnOperaciones.Location = new Point(205, 10);
            btnOperaciones.Margin = new Padding(10);
            btnOperaciones.Name = "btnOperaciones";
            btnOperaciones.Size = new Size(175, 118);
            btnOperaciones.TabIndex = 2;
            btnOperaciones.Text = "Operaciones";
            btnOperaciones.UseVisualStyleBackColor = true;
            btnOperaciones.Click += btnOperaciones_Click;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Fill;
            btnReportes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.SteelBlue;
            btnReportes.Location = new Point(10, 148);
            btnReportes.Margin = new Padding(10);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(175, 118);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Dock = DockStyle.Fill;
            btnEmpleados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpleados.ForeColor = Color.SteelBlue;
            btnEmpleados.Location = new Point(10, 10);
            btnEmpleados.Margin = new Padding(10);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(175, 118);
            btnEmpleados.TabIndex = 0;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnProyectos
            // 
            btnProyectos.Dock = DockStyle.Fill;
            btnProyectos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProyectos.ForeColor = Color.SteelBlue;
            btnProyectos.Location = new Point(400, 10);
            btnProyectos.Margin = new Padding(10);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Size = new Size(185, 118);
            btnProyectos.TabIndex = 1;
            btnProyectos.Text = "Proyectos";
            btnProyectos.UseVisualStyleBackColor = true;
            btnProyectos.Click += btnProyectos_Click;
            // 
            // btnRoles
            // 
            btnRoles.Dock = DockStyle.Fill;
            btnRoles.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoles.ForeColor = Color.SteelBlue;
            btnRoles.Location = new Point(205, 148);
            btnRoles.Margin = new Padding(10);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(175, 118);
            btnRoles.TabIndex = 5;
            btnRoles.Text = "Roles";
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.SteelBlue;
            btnSalir.Location = new Point(754, 372);
            btnSalir.Margin = new Padding(0, 0, 0, 10);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(188, 51);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tsFecha
            // 
            tsFecha.BackColor = SystemColors.Control;
            tsFecha.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsFecha.Name = "tsFecha";
            tsFecha.Size = new Size(57, 25);
            tsFecha.Text = "Fecha";
            // 
            // stMenu
            // 
            stMenu.GripStyle = ToolStripGripStyle.Visible;
            stMenu.ImageScalingSize = new Size(20, 20);
            stMenu.Items.AddRange(new ToolStripItem[] { tsFecha });
            stMenu.Location = new Point(0, 628);
            stMenu.MinimumSize = new Size(782, 31);
            stMenu.Name = "stMenu";
            stMenu.Size = new Size(1008, 31);
            stMenu.TabIndex = 0;
            stMenu.Text = "statusStrip1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1008, 659);
            Controls.Add(tlpMenu);
            Controls.Add(stMenu);
            Controls.Add(msMenu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = msMenu;
            MinimumSize = new Size(1030, 710);
            Name = "FormMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            Load += FormMain_Load;
            msMenu.ResumeLayout(false);
            msMenu.PerformLayout();
            tlpMenu.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            tlpBotones.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            stMenu.ResumeLayout(false);
            stMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip msMenu;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private TableLayoutPanel tlpMenu;
        private TableLayoutPanel tlpTitulo;
        private Label label1;
        private TableLayoutPanel tlpBotones;
        private Button btnProyectos;
        private Button btnOperaciones;
        private Button btnReportes;
        private Button btnSalir;
        private Button btnEmpleados;
        private ToolStripMenuItem informaciónDelSistemaToolStripMenuItem;
        private ToolStripMenuItem manualDelUsuarioToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripStatusLabel tsFecha;
        private StatusStrip stMenu;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnRoles;
        private Button btnTareas;
    }
}