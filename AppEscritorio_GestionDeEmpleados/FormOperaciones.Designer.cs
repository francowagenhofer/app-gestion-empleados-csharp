namespace AppEscritorio_GestionDeEmpleados
{
    partial class FormOperaciones
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
            statusStrip1 = new StatusStrip();
            tsFecha = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            tbOperaciones = new TabControl();
            tpCategorias = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAgregarCategoria = new Button();
            btnModificarCategoria = new Button();
            btnVerDetalleCategoria = new Button();
            btnSalirCategoria = new Button();
            btnEliminarCategoria = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtFiltroCategoria = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblTitulo = new Label();
            dgvCategorias = new DataGridView();
            tpBonos = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnAgregarBono = new Button();
            btnModificarBono = new Button();
            btnVerDetalleBono = new Button();
            btnSalirBono = new Button();
            btnEliminar = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            txtBonos = new TextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            label1 = new Label();
            dgvBonos = new DataGridView();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            tbOperaciones.SuspendLayout();
            tpCategorias.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            tpBonos.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBonos).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsFecha });
            statusStrip1.Location = new Point(0, 632);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1012, 31);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsFecha
            // 
            tsFecha.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsFecha.Name = "tsFecha";
            tsFecha.Size = new Size(57, 25);
            tsFecha.Text = "Fecha";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, ayudaToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1012, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(86, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(77, 29);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(103, 29);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // tbOperaciones
            // 
            tbOperaciones.Appearance = TabAppearance.Buttons;
            tbOperaciones.Controls.Add(tpCategorias);
            tbOperaciones.Controls.Add(tpBonos);
            tbOperaciones.Dock = DockStyle.Fill;
            tbOperaciones.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbOperaciones.Location = new Point(0, 33);
            tbOperaciones.Name = "tbOperaciones";
            tbOperaciones.SelectedIndex = 0;
            tbOperaciones.Size = new Size(1012, 599);
            tbOperaciones.TabIndex = 2;
            // 
            // tpCategorias
            // 
            tpCategorias.BackColor = SystemColors.ControlLight;
            tpCategorias.BorderStyle = BorderStyle.Fixed3D;
            tpCategorias.Controls.Add(tableLayoutPanel1);
            tpCategorias.Location = new Point(4, 40);
            tpCategorias.Name = "tpCategorias";
            tpCategorias.Padding = new Padding(3);
            tpCategorias.Size = new Size(1004, 555);
            tpCategorias.TabIndex = 0;
            tpCategorias.Text = "Puestos y Salarios";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Controls.Add(dgvCategorias, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.MinimumSize = new Size(800, 489);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Size = new Size(994, 545);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel2.Controls.Add(btnAgregarCategoria, 0, 1);
            tableLayoutPanel2.Controls.Add(btnModificarCategoria, 1, 1);
            tableLayoutPanel2.Controls.Add(btnVerDetalleCategoria, 2, 1);
            tableLayoutPanel2.Controls.Add(btnSalirCategoria, 5, 1);
            tableLayoutPanel2.Controls.Add(btnEliminarCategoria, 4, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(33, 401);
            tableLayoutPanel2.MinimumSize = new Size(734, 107);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(928, 132);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Dock = DockStyle.Fill;
            btnAgregarCategoria.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCategoria.ForeColor = Color.SteelBlue;
            btnAgregarCategoria.Location = new Point(10, 30);
            btnAgregarCategoria.Margin = new Padding(10);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(134, 72);
            btnAgregarCategoria.TabIndex = 0;
            btnAgregarCategoria.Text = "Agregar";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // btnModificarCategoria
            // 
            btnModificarCategoria.Dock = DockStyle.Fill;
            btnModificarCategoria.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarCategoria.ForeColor = Color.SteelBlue;
            btnModificarCategoria.Location = new Point(164, 30);
            btnModificarCategoria.Margin = new Padding(10);
            btnModificarCategoria.Name = "btnModificarCategoria";
            btnModificarCategoria.Size = new Size(134, 72);
            btnModificarCategoria.TabIndex = 1;
            btnModificarCategoria.Text = "Modificar";
            btnModificarCategoria.UseVisualStyleBackColor = true;
            btnModificarCategoria.Click += btnModificarCategoria_Click;
            // 
            // btnVerDetalleCategoria
            // 
            btnVerDetalleCategoria.Dock = DockStyle.Fill;
            btnVerDetalleCategoria.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerDetalleCategoria.ForeColor = Color.SteelBlue;
            btnVerDetalleCategoria.Location = new Point(318, 30);
            btnVerDetalleCategoria.Margin = new Padding(10);
            btnVerDetalleCategoria.Name = "btnVerDetalleCategoria";
            btnVerDetalleCategoria.Size = new Size(134, 72);
            btnVerDetalleCategoria.TabIndex = 2;
            btnVerDetalleCategoria.Text = "Ver Detalle";
            btnVerDetalleCategoria.UseVisualStyleBackColor = true;
            btnVerDetalleCategoria.Click += btnVerDetalleCategoria_Click;
            // 
            // btnSalirCategoria
            // 
            btnSalirCategoria.Dock = DockStyle.Fill;
            btnSalirCategoria.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalirCategoria.ForeColor = Color.SteelBlue;
            btnSalirCategoria.Location = new Point(785, 30);
            btnSalirCategoria.Margin = new Padding(15, 10, 10, 10);
            btnSalirCategoria.Name = "btnSalirCategoria";
            btnSalirCategoria.Size = new Size(133, 72);
            btnSalirCategoria.TabIndex = 4;
            btnSalirCategoria.Text = "Salir";
            btnSalirCategoria.UseVisualStyleBackColor = true;
            btnSalirCategoria.Click += btnSalirCategoria_Click;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarCategoria.ForeColor = Color.SteelBlue;
            btnEliminarCategoria.Location = new Point(626, 30);
            btnEliminarCategoria.Margin = new Padding(10);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(131, 66);
            btnEliminarCategoria.TabIndex = 3;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.UseVisualStyleBackColor = true;
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(txtFiltroCategoria, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(33, 73);
            tableLayoutPanel3.MinimumSize = new Size(734, 64);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.Size = new Size(928, 64);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // txtFiltroCategoria
            // 
            txtFiltroCategoria.BorderStyle = BorderStyle.FixedSingle;
            txtFiltroCategoria.Dock = DockStyle.Bottom;
            txtFiltroCategoria.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFiltroCategoria.Location = new Point(0, 23);
            txtFiltroCategoria.Margin = new Padding(0);
            txtFiltroCategoria.Name = "txtFiltroCategoria";
            txtFiltroCategoria.PlaceholderText = "Buscar por puesto, ID o monto...";
            txtFiltroCategoria.Size = new Size(464, 31);
            txtFiltroCategoria.TabIndex = 1;
            txtFiltroCategoria.TextChanged += txtFiltroCategoria_TextChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel4.Controls.Add(lblTitulo, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(33, 3);
            tableLayoutPanel4.MinimumSize = new Size(734, 64);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(928, 64);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Navy;
            lblTitulo.Location = new Point(264, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(399, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Puestos y Salarios";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Dock = DockStyle.Fill;
            dgvCategorias.Location = new Point(33, 143);
            dgvCategorias.MinimumSize = new Size(734, 204);
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(928, 252);
            dgvCategorias.TabIndex = 3;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // tpBonos
            // 
            tpBonos.BackColor = SystemColors.ControlLight;
            tpBonos.Controls.Add(tableLayoutPanel5);
            tpBonos.Location = new Point(4, 40);
            tpBonos.Name = "tpBonos";
            tpBonos.Padding = new Padding(3);
            tpBonos.Size = new Size(1004, 555);
            tpBonos.TabIndex = 1;
            tpBonos.Text = "Bonos";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 1, 3);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 1, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel8, 1, 0);
            tableLayoutPanel5.Controls.Add(dgvBonos, 1, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.MinimumSize = new Size(800, 489);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel5.Size = new Size(998, 549);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel6.ColumnCount = 6;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel6.Controls.Add(btnAgregarBono, 0, 1);
            tableLayoutPanel6.Controls.Add(btnModificarBono, 1, 1);
            tableLayoutPanel6.Controls.Add(btnVerDetalleBono, 2, 1);
            tableLayoutPanel6.Controls.Add(btnSalirBono, 5, 1);
            tableLayoutPanel6.Controls.Add(btnEliminar, 4, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(33, 403);
            tableLayoutPanel6.MinimumSize = new Size(734, 107);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(932, 134);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // btnAgregarBono
            // 
            btnAgregarBono.Dock = DockStyle.Fill;
            btnAgregarBono.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarBono.ForeColor = Color.SteelBlue;
            btnAgregarBono.Location = new Point(10, 30);
            btnAgregarBono.Margin = new Padding(10);
            btnAgregarBono.Name = "btnAgregarBono";
            btnAgregarBono.Size = new Size(135, 74);
            btnAgregarBono.TabIndex = 0;
            btnAgregarBono.Text = "Agregar";
            btnAgregarBono.UseVisualStyleBackColor = true;
            // 
            // btnModificarBono
            // 
            btnModificarBono.Dock = DockStyle.Fill;
            btnModificarBono.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarBono.ForeColor = Color.SteelBlue;
            btnModificarBono.Location = new Point(165, 30);
            btnModificarBono.Margin = new Padding(10);
            btnModificarBono.Name = "btnModificarBono";
            btnModificarBono.Size = new Size(135, 74);
            btnModificarBono.TabIndex = 1;
            btnModificarBono.Text = "Modificar";
            btnModificarBono.UseVisualStyleBackColor = true;
            // 
            // btnVerDetalleBono
            // 
            btnVerDetalleBono.Dock = DockStyle.Fill;
            btnVerDetalleBono.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerDetalleBono.ForeColor = Color.SteelBlue;
            btnVerDetalleBono.Location = new Point(320, 30);
            btnVerDetalleBono.Margin = new Padding(10);
            btnVerDetalleBono.Name = "btnVerDetalleBono";
            btnVerDetalleBono.Size = new Size(135, 74);
            btnVerDetalleBono.TabIndex = 2;
            btnVerDetalleBono.Text = "Ver Detalle";
            btnVerDetalleBono.UseVisualStyleBackColor = true;
            // 
            // btnSalirBono
            // 
            btnSalirBono.Dock = DockStyle.Fill;
            btnSalirBono.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalirBono.ForeColor = Color.SteelBlue;
            btnSalirBono.Location = new Point(790, 30);
            btnSalirBono.Margin = new Padding(15, 10, 10, 10);
            btnSalirBono.Name = "btnSalirBono";
            btnSalirBono.Size = new Size(132, 74);
            btnSalirBono.TabIndex = 4;
            btnSalirBono.Text = "Salir";
            btnSalirBono.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.SteelBlue;
            btnEliminar.Location = new Point(630, 30);
            btnEliminar.Margin = new Padding(10);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 66);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(txtBonos, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(33, 73);
            tableLayoutPanel7.MinimumSize = new Size(734, 64);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel7.Size = new Size(932, 64);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // txtBonos
            // 
            txtBonos.BorderStyle = BorderStyle.FixedSingle;
            txtBonos.Dock = DockStyle.Bottom;
            txtBonos.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBonos.Location = new Point(0, 23);
            txtBonos.Margin = new Padding(0);
            txtBonos.Name = "txtBonos";
            txtBonos.PlaceholderText = "Buscar por nombre, ID o monto...";
            txtBonos.Size = new Size(466, 31);
            txtBonos.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel8.Controls.Add(label1, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Bottom;
            tableLayoutPanel8.Location = new Point(33, 3);
            tableLayoutPanel8.MinimumSize = new Size(734, 64);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(932, 64);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(342, 13);
            label1.Name = "label1";
            label1.Size = new Size(246, 38);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Bonos";
            // 
            // dgvBonos
            // 
            dgvBonos.AllowUserToAddRows = false;
            dgvBonos.AllowUserToDeleteRows = false;
            dgvBonos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBonos.Dock = DockStyle.Fill;
            dgvBonos.Location = new Point(33, 143);
            dgvBonos.MinimumSize = new Size(734, 204);
            dgvBonos.MultiSelect = false;
            dgvBonos.Name = "dgvBonos";
            dgvBonos.ReadOnly = true;
            dgvBonos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBonos.RowHeadersVisible = false;
            dgvBonos.RowHeadersWidth = 51;
            dgvBonos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBonos.Size = new Size(932, 254);
            dgvBonos.TabIndex = 3;
            // 
            // FormOperaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1012, 663);
            Controls.Add(tbOperaciones);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1030, 710);
            Name = "FormOperaciones";
            ShowIcon = false;
            Text = "⚙️ Operaciones";
            Load += FormOperaciones_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tbOperaciones.ResumeLayout(false);
            tpCategorias.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            tpBonos.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBonos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsFecha;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private TabControl tbOperaciones;
        private TabPage tpCategorias;
        private TabPage tpBonos;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAgregarCategoria;
        private Button btnModificarCategoria;
        private Button btnVerDetalleCategoria;
        private Button btnSalirCategoria;
        private Button btnEliminarCategoria;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblTitulo;
        private DataGridView dgvCategorias;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtFiltroCategoria;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnAgregarBono;
        private Button btnModificarBono;
        private Button btnVerDetalleBono;
        private Button btnSalirBono;
        private Button btnEliminar;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox txtBonos;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label1;
        private DataGridView dgvBonos;
    }
}