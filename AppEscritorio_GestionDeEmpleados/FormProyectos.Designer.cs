namespace AppEscritorio_GestionDeEmpleados
{
    partial class FormProyectos
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
            stEmpleados = new StatusStrip();
            tsFecha = new ToolStripStatusLabel();
            tsEstado = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            manualDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            informaciónDToolStripMenuItem = new ToolStripMenuItem();
            tlpMenuEmpleados = new TableLayoutPanel();
            tlpBotones = new TableLayoutPanel();
            btnAgregar = new Button();
            btnAsignaciones = new Button();
            btnModificar = new Button();
            btnVerDetalle = new Button();
            btnSalir = new Button();
            btnEliminar = new Button();
            tlpFiltrar = new TableLayoutPanel();
            tbFiltro = new TextBox();
            cbActivo = new CheckBox();
            tlpTitulo = new TableLayoutPanel();
            lblTitulo = new Label();
            dgvProyectos = new DataGridView();
            stEmpleados.SuspendLayout();
            menuStrip1.SuspendLayout();
            tlpMenuEmpleados.SuspendLayout();
            tlpBotones.SuspendLayout();
            tlpFiltrar.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).BeginInit();
            SuspendLayout();
            // 
            // stEmpleados
            // 
            stEmpleados.ImageScalingSize = new Size(20, 20);
            stEmpleados.Items.AddRange(new ToolStripItem[] { tsFecha, tsEstado });
            stEmpleados.Location = new Point(0, 628);
            stEmpleados.Name = "stEmpleados";
            stEmpleados.Size = new Size(1008, 31);
            stEmpleados.TabIndex = 0;
            // 
            // tsFecha
            // 
            tsFecha.BackColor = SystemColors.Control;
            tsFecha.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsFecha.Name = "tsFecha";
            tsFecha.Size = new Size(57, 25);
            tsFecha.Text = "Fecha";
            // 
            // tsEstado
            // 
            tsEstado.BackColor = SystemColors.Control;
            tsEstado.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsEstado.Name = "tsEstado";
            tsEstado.Size = new Size(66, 25);
            tsEstado.Text = "Estado";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, ayudaToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1008, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
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
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manualDeUsuarioToolStripMenuItem });
            ayudaToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(77, 29);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            manualDeUsuarioToolStripMenuItem.Size = new Size(244, 30);
            manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informaciónDToolStripMenuItem });
            acercaDeToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(108, 29);
            acercaDeToolStripMenuItem.Text = "Acerca de ";
            // 
            // informaciónDToolStripMenuItem
            // 
            informaciónDToolStripMenuItem.Name = "informaciónDToolStripMenuItem";
            informaciónDToolStripMenuItem.Size = new Size(288, 30);
            informaciónDToolStripMenuItem.Text = "Información del sistema";
            // 
            // tlpMenuEmpleados
            // 
            tlpMenuEmpleados.ColumnCount = 3;
            tlpMenuEmpleados.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tlpMenuEmpleados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMenuEmpleados.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tlpMenuEmpleados.Controls.Add(tlpBotones, 1, 3);
            tlpMenuEmpleados.Controls.Add(tlpFiltrar, 1, 1);
            tlpMenuEmpleados.Controls.Add(tlpTitulo, 1, 0);
            tlpMenuEmpleados.Controls.Add(dgvProyectos, 1, 2);
            tlpMenuEmpleados.Dock = DockStyle.Fill;
            tlpMenuEmpleados.Location = new Point(0, 33);
            tlpMenuEmpleados.MinimumSize = new Size(800, 489);
            tlpMenuEmpleados.Name = "tlpMenuEmpleados";
            tlpMenuEmpleados.RowCount = 5;
            tlpMenuEmpleados.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpMenuEmpleados.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpMenuEmpleados.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tlpMenuEmpleados.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tlpMenuEmpleados.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpMenuEmpleados.Size = new Size(1008, 595);
            tlpMenuEmpleados.TabIndex = 2;
            // 
            // tlpBotones
            // 
            tlpBotones.ColumnCount = 6;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tlpBotones.Controls.Add(btnAgregar, 0, 1);
            tlpBotones.Controls.Add(btnAsignaciones, 3, 1);
            tlpBotones.Controls.Add(btnModificar, 1, 1);
            tlpBotones.Controls.Add(btnVerDetalle, 2, 1);
            tlpBotones.Controls.Add(btnSalir, 5, 1);
            tlpBotones.Controls.Add(btnEliminar, 4, 1);
            tlpBotones.Dock = DockStyle.Fill;
            tlpBotones.Location = new Point(33, 422);
            tlpBotones.MinimumSize = new Size(734, 107);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 3;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpBotones.Size = new Size(942, 144);
            tlpBotones.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Dock = DockStyle.Fill;
            btnAgregar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.SteelBlue;
            btnAgregar.Location = new Point(10, 30);
            btnAgregar.Margin = new Padding(10);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(136, 84);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnAsignaciones
            // 
            btnAsignaciones.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAsignaciones.ForeColor = Color.SteelBlue;
            btnAsignaciones.Location = new Point(478, 30);
            btnAsignaciones.Margin = new Padding(10);
            btnAsignaciones.Name = "btnAsignaciones";
            btnAsignaciones.Size = new Size(136, 84);
            btnAsignaciones.TabIndex = 5;
            btnAsignaciones.Text = "Gestionar Asignaciones";
            btnAsignaciones.UseVisualStyleBackColor = true;
            btnAsignaciones.Click += btnAsignaciones_Click;
            // 
            // btnModificar
            // 
            btnModificar.Dock = DockStyle.Fill;
            btnModificar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.SteelBlue;
            btnModificar.Location = new Point(166, 30);
            btnModificar.Margin = new Padding(10);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(136, 84);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnVerDetalle
            // 
            btnVerDetalle.Dock = DockStyle.Fill;
            btnVerDetalle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerDetalle.ForeColor = Color.SteelBlue;
            btnVerDetalle.Location = new Point(322, 30);
            btnVerDetalle.Margin = new Padding(10);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(136, 84);
            btnVerDetalle.TabIndex = 2;
            btnVerDetalle.Text = "Ver Detalle";
            btnVerDetalle.UseVisualStyleBackColor = true;
            btnVerDetalle.Click += btnVerDetalle_Click;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Fill;
            btnSalir.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.SteelBlue;
            btnSalir.Location = new Point(795, 30);
            btnSalir.Margin = new Padding(15, 10, 10, 10);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(137, 84);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.SteelBlue;
            btnEliminar.Location = new Point(634, 30);
            btnEliminar.Margin = new Padding(10);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 84);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // tlpFiltrar
            // 
            tlpFiltrar.ColumnCount = 2;
            tlpFiltrar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFiltrar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFiltrar.Controls.Add(tbFiltro, 0, 1);
            tlpFiltrar.Controls.Add(cbActivo, 1, 1);
            tlpFiltrar.Dock = DockStyle.Fill;
            tlpFiltrar.Location = new Point(33, 73);
            tlpFiltrar.MinimumSize = new Size(734, 64);
            tlpFiltrar.Name = "tlpFiltrar";
            tlpFiltrar.RowCount = 3;
            tlpFiltrar.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpFiltrar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFiltrar.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpFiltrar.Size = new Size(942, 64);
            tlpFiltrar.TabIndex = 1;
            // 
            // tbFiltro
            // 
            tbFiltro.BorderStyle = BorderStyle.FixedSingle;
            tbFiltro.Dock = DockStyle.Bottom;
            tbFiltro.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFiltro.Location = new Point(0, 23);
            tbFiltro.Margin = new Padding(0);
            tbFiltro.Name = "tbFiltro";
            tbFiltro.PlaceholderText = "Buscar por nombre, ID o descripción...";
            tbFiltro.Size = new Size(471, 31);
            tbFiltro.TabIndex = 1;
            tbFiltro.TextChanged += tbFiltrar_TextChanged;
            // 
            // cbActivo
            // 
            cbActivo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbActivo.AutoSize = true;
            cbActivo.FlatStyle = FlatStyle.Flat;
            cbActivo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbActivo.Location = new Point(486, 25);
            cbActivo.Margin = new Padding(15, 0, 0, 0);
            cbActivo.MinimumSize = new Size(340, 29);
            cbActivo.Name = "cbActivo";
            cbActivo.Size = new Size(340, 29);
            cbActivo.TabIndex = 0;
            cbActivo.Text = "Mostrar solo activos";
            cbActivo.UseVisualStyleBackColor = true;
            cbActivo.CheckedChanged += cbActivo_CheckedChanged;
            // 
            // tlpTitulo
            // 
            tlpTitulo.ColumnCount = 3;
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.ColumnStyles.Add(new ColumnStyle());
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tlpTitulo.Controls.Add(lblTitulo, 1, 0);
            tlpTitulo.Dock = DockStyle.Fill;
            tlpTitulo.Location = new Point(33, 3);
            tlpTitulo.MinimumSize = new Size(734, 64);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.RowCount = 1;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTitulo.Size = new Size(942, 64);
            tlpTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Navy;
            lblTitulo.Location = new Point(324, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(293, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Proyectos";
            // 
            // dgvProyectos
            // 
            dgvProyectos.AllowUserToAddRows = false;
            dgvProyectos.AllowUserToDeleteRows = false;
            dgvProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProyectos.Dock = DockStyle.Fill;
            dgvProyectos.Location = new Point(33, 143);
            dgvProyectos.MinimumSize = new Size(734, 204);
            dgvProyectos.MultiSelect = false;
            dgvProyectos.Name = "dgvProyectos";
            dgvProyectos.ReadOnly = true;
            dgvProyectos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProyectos.RowHeadersVisible = false;
            dgvProyectos.RowHeadersWidth = 51;
            dgvProyectos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProyectos.Size = new Size(942, 273);
            dgvProyectos.TabIndex = 3;
            // 
            // FormProyectos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1008, 659);
            Controls.Add(tlpMenuEmpleados);
            Controls.Add(stEmpleados);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1030, 710);
            Name = "FormProyectos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "🗂️ Proyectos";
            Load += FormProyectos_Load;
            stEmpleados.ResumeLayout(false);
            stEmpleados.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tlpMenuEmpleados.ResumeLayout(false);
            tlpBotones.ResumeLayout(false);
            tlpFiltrar.ResumeLayout(false);
            tlpFiltrar.PerformLayout();
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip stEmpleados;
        private ToolStripStatusLabel tsFecha;
        private ToolStripStatusLabel tsEstado;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem informaciónDToolStripMenuItem;
        private TableLayoutPanel tlpMenuEmpleados;
        private TableLayoutPanel tlpBotones;
        private TableLayoutPanel tlpFiltrar;
        private TableLayoutPanel tlpTitulo;
        private Label lblTitulo;
        private DataGridView dgvProyectos;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnVerDetalle;
        private Button btnEliminar;
        private Button btnSalir;
        private CheckBox cbActivo;
        private TextBox tbFiltro;
        private Button btnAsignaciones;
    }
}