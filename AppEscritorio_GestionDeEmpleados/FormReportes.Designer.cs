namespace AppEscritorio_GestionDeEmpleados
{
    partial class FormReportes
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
            tcReportes = new TabControl();
            tpReporteEmpleados = new TabPage();
            tlpMenuEmpleados = new TableLayoutPanel();
            tlpBotones = new TableLayoutPanel();
            btnSalirEmpelados = new Button();
            btnAgregarRepEempleado = new Button();
            btnEliminar = new Button();
            btnVerDetalleRepEmpleado = new Button();
            tlpFiltrar = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            tlpTitulo = new TableLayoutPanel();
            lblReporteEmpleado = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            dgvReporteEmpleados = new DataGridView();
            txtFiltrarRepEmpleado = new TextBox();
            dgvEmpleado = new DataGridView();
            txtFiltrarEmpleado = new TextBox();
            tpReporteProyectos = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnVerDetalleRepProyectos = new Button();
            btnSalirProyectos = new Button();
            btnEliminarRepProyectos = new Button();
            btnAgregarRepProyectos = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblTitulo = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            txtFiltrarRepProyectos = new TextBox();
            dgvReporteProyectos = new DataGridView();
            dgvProyecto = new DataGridView();
            txtFiltrarProyecto = new TextBox();
            tpReporteFinanzas = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnAgregarRepFinanzas = new Button();
            btnSalirFinanzas = new Button();
            btnEliminarRepFinanzas = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            txtFiltrarRepFinanzas = new TextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            label1 = new Label();
            dgvReporteFinanzas = new DataGridView();
            statusStrip1.SuspendLayout();
            tcReportes.SuspendLayout();
            tpReporteEmpleados.SuspendLayout();
            tlpMenuEmpleados.SuspendLayout();
            tlpBotones.SuspendLayout();
            tlpFiltrar.SuspendLayout();
            tlpTitulo.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).BeginInit();
            tpReporteProyectos.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteProyectos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProyecto).BeginInit();
            tpReporteFinanzas.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteFinanzas).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsFecha });
            statusStrip1.Location = new Point(0, 628);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1008, 31);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsFecha
            // 
            tsFecha.BackColor = SystemColors.Control;
            tsFecha.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsFecha.Name = "tsFecha";
            tsFecha.Size = new Size(57, 25);
            tsFecha.Text = "Fecha";
            // 
            // tcReportes
            // 
            tcReportes.Appearance = TabAppearance.Buttons;
            tcReportes.Controls.Add(tpReporteEmpleados);
            tcReportes.Controls.Add(tpReporteProyectos);
            tcReportes.Controls.Add(tpReporteFinanzas);
            tcReportes.Dock = DockStyle.Fill;
            tcReportes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tcReportes.Location = new Point(0, 0);
            tcReportes.Name = "tcReportes";
            tcReportes.SelectedIndex = 0;
            tcReportes.Size = new Size(1008, 628);
            tcReportes.TabIndex = 2;
            // 
            // tpReporteEmpleados
            // 
            tpReporteEmpleados.BorderStyle = BorderStyle.Fixed3D;
            tpReporteEmpleados.Controls.Add(tlpMenuEmpleados);
            tpReporteEmpleados.Location = new Point(4, 40);
            tpReporteEmpleados.Name = "tpReporteEmpleados";
            tpReporteEmpleados.Padding = new Padding(3);
            tpReporteEmpleados.Size = new Size(1000, 584);
            tpReporteEmpleados.TabIndex = 0;
            tpReporteEmpleados.Text = "Empleados";
            tpReporteEmpleados.UseVisualStyleBackColor = true;
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
            tlpMenuEmpleados.Controls.Add(tableLayoutPanel9, 1, 2);
            tlpMenuEmpleados.Dock = DockStyle.Fill;
            tlpMenuEmpleados.Location = new Point(3, 3);
            tlpMenuEmpleados.MinimumSize = new Size(800, 489);
            tlpMenuEmpleados.Name = "tlpMenuEmpleados";
            tlpMenuEmpleados.RowCount = 5;
            tlpMenuEmpleados.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpMenuEmpleados.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpMenuEmpleados.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tlpMenuEmpleados.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tlpMenuEmpleados.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpMenuEmpleados.Size = new Size(990, 574);
            tlpMenuEmpleados.TabIndex = 3;
            // 
            // tlpBotones
            // 
            tlpBotones.ColumnCount = 7;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tlpBotones.Controls.Add(btnSalirEmpelados, 5, 1);
            tlpBotones.Controls.Add(btnAgregarRepEempleado, 4, 1);
            tlpBotones.Controls.Add(btnEliminar, 2, 1);
            tlpBotones.Controls.Add(btnVerDetalleRepEmpleado, 1, 1);
            tlpBotones.Dock = DockStyle.Fill;
            tlpBotones.Location = new Point(33, 408);
            tlpBotones.MinimumSize = new Size(734, 107);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 3;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpBotones.Size = new Size(924, 137);
            tlpBotones.TabIndex = 0;
            // 
            // btnSalirEmpelados
            // 
            btnSalirEmpelados.Dock = DockStyle.Fill;
            btnSalirEmpelados.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalirEmpelados.ForeColor = Color.SteelBlue;
            btnSalirEmpelados.Location = new Point(705, 35);
            btnSalirEmpelados.Margin = new Padding(15);
            btnSalirEmpelados.Name = "btnSalirEmpelados";
            btnSalirEmpelados.Size = new Size(154, 67);
            btnSalirEmpelados.TabIndex = 4;
            btnSalirEmpelados.Text = "Salir";
            btnSalirEmpelados.UseVisualStyleBackColor = true;
            btnSalirEmpelados.Click += CerrarFormulario;
            // 
            // btnAgregarRepEempleado
            // 
            btnAgregarRepEempleado.Dock = DockStyle.Fill;
            btnAgregarRepEempleado.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarRepEempleado.ForeColor = Color.SteelBlue;
            btnAgregarRepEempleado.Location = new Point(521, 35);
            btnAgregarRepEempleado.Margin = new Padding(15);
            btnAgregarRepEempleado.Name = "btnAgregarRepEempleado";
            btnAgregarRepEempleado.Size = new Size(154, 67);
            btnAgregarRepEempleado.TabIndex = 0;
            btnAgregarRepEempleado.Text = "Generar reporte";
            btnAgregarRepEempleado.UseVisualStyleBackColor = true;
            btnAgregarRepEempleado.Click += btnAgregarRepEempleado_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.SteelBlue;
            btnEliminar.Location = new Point(245, 35);
            btnEliminar.Margin = new Padding(15);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(154, 67);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar reporte";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVerDetalleRepEmpleado
            // 
            btnVerDetalleRepEmpleado.Dock = DockStyle.Fill;
            btnVerDetalleRepEmpleado.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerDetalleRepEmpleado.ForeColor = Color.SteelBlue;
            btnVerDetalleRepEmpleado.Location = new Point(61, 35);
            btnVerDetalleRepEmpleado.Margin = new Padding(15);
            btnVerDetalleRepEmpleado.Name = "btnVerDetalleRepEmpleado";
            btnVerDetalleRepEmpleado.Size = new Size(154, 67);
            btnVerDetalleRepEmpleado.TabIndex = 2;
            btnVerDetalleRepEmpleado.Text = "Ver Detalle";
            btnVerDetalleRepEmpleado.UseVisualStyleBackColor = true;
            btnVerDetalleRepEmpleado.Click += btnVerDetalleRepEmpleado_Click;
            // 
            // tlpFiltrar
            // 
            tlpFiltrar.ColumnCount = 2;
            tlpFiltrar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFiltrar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFiltrar.Controls.Add(label3, 1, 1);
            tlpFiltrar.Controls.Add(label2, 0, 1);
            tlpFiltrar.Dock = DockStyle.Fill;
            tlpFiltrar.Location = new Point(33, 73);
            tlpFiltrar.MinimumSize = new Size(734, 64);
            tlpFiltrar.Name = "tlpFiltrar";
            tlpFiltrar.RowCount = 3;
            tlpFiltrar.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpFiltrar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFiltrar.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpFiltrar.Size = new Size(924, 64);
            tlpFiltrar.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(477, 18);
            label3.Margin = new Padding(15, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(188, 28);
            label3.TabIndex = 1;
            label3.Text = "Lista de empleados";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(10, 18);
            label2.Margin = new Padding(10, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(165, 28);
            label2.TabIndex = 0;
            label2.Text = "Lista de reportes";
            // 
            // tlpTitulo
            // 
            tlpTitulo.ColumnCount = 3;
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.ColumnStyles.Add(new ColumnStyle());
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tlpTitulo.Controls.Add(lblReporteEmpleado, 1, 0);
            tlpTitulo.Dock = DockStyle.Fill;
            tlpTitulo.Location = new Point(33, 3);
            tlpTitulo.MinimumSize = new Size(734, 64);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.RowCount = 1;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTitulo.Size = new Size(924, 64);
            tlpTitulo.TabIndex = 2;
            // 
            // lblReporteEmpleado
            // 
            lblReporteEmpleado.Anchor = AnchorStyles.None;
            lblReporteEmpleado.AutoSize = true;
            lblReporteEmpleado.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReporteEmpleado.ForeColor = Color.Navy;
            lblReporteEmpleado.Location = new Point(306, 13);
            lblReporteEmpleado.Name = "lblReporteEmpleado";
            lblReporteEmpleado.Size = new Size(311, 38);
            lblReporteEmpleado.TabIndex = 0;
            lblReporteEmpleado.Text = "Reporte de Empleados";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 5;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tableLayoutPanel9.Controls.Add(dgvReporteEmpleados, 1, 1);
            tableLayoutPanel9.Controls.Add(txtFiltrarRepEmpleado, 1, 0);
            tableLayoutPanel9.Controls.Add(dgvEmpleado, 3, 1);
            tableLayoutPanel9.Controls.Add(txtFiltrarEmpleado, 3, 0);
            tableLayoutPanel9.Location = new Point(33, 143);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel9.Size = new Size(924, 259);
            tableLayoutPanel9.TabIndex = 3;
            // 
            // dgvReporteEmpleados
            // 
            dgvReporteEmpleados.AllowUserToAddRows = false;
            dgvReporteEmpleados.AllowUserToDeleteRows = false;
            dgvReporteEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteEmpleados.Dock = DockStyle.Fill;
            dgvReporteEmpleados.Location = new Point(12, 41);
            dgvReporteEmpleados.MultiSelect = false;
            dgvReporteEmpleados.Name = "dgvReporteEmpleados";
            dgvReporteEmpleados.ReadOnly = true;
            dgvReporteEmpleados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReporteEmpleados.RowHeadersVisible = false;
            dgvReporteEmpleados.RowHeadersWidth = 51;
            dgvReporteEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporteEmpleados.Size = new Size(428, 215);
            dgvReporteEmpleados.TabIndex = 3;
            // 
            // txtFiltrarRepEmpleado
            // 
            txtFiltrarRepEmpleado.BorderStyle = BorderStyle.FixedSingle;
            txtFiltrarRepEmpleado.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFiltrarRepEmpleado.Location = new Point(9, 0);
            txtFiltrarRepEmpleado.Margin = new Padding(0);
            txtFiltrarRepEmpleado.Name = "txtFiltrarRepEmpleado";
            txtFiltrarRepEmpleado.PlaceholderText = "Buscar reporte por nombre o ID...";
            txtFiltrarRepEmpleado.Size = new Size(399, 31);
            txtFiltrarRepEmpleado.TabIndex = 1;
            txtFiltrarRepEmpleado.TextChanged += txtFiltrarRepEmpleado_TextChanged;
            // 
            // dgvEmpleado
            // 
            dgvEmpleado.AllowUserToAddRows = false;
            dgvEmpleado.AllowUserToDeleteRows = false;
            dgvEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleado.Dock = DockStyle.Fill;
            dgvEmpleado.Location = new Point(482, 41);
            dgvEmpleado.MultiSelect = false;
            dgvEmpleado.Name = "dgvEmpleado";
            dgvEmpleado.ReadOnly = true;
            dgvEmpleado.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEmpleado.RowHeadersVisible = false;
            dgvEmpleado.RowHeadersWidth = 51;
            dgvEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleado.Size = new Size(428, 215);
            dgvEmpleado.TabIndex = 4;
            // 
            // txtFiltrarEmpleado
            // 
            txtFiltrarEmpleado.BorderStyle = BorderStyle.FixedSingle;
            txtFiltrarEmpleado.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFiltrarEmpleado.Location = new Point(479, 0);
            txtFiltrarEmpleado.Margin = new Padding(0);
            txtFiltrarEmpleado.Name = "txtFiltrarEmpleado";
            txtFiltrarEmpleado.PlaceholderText = "Buscar empleado por nombre o ID...";
            txtFiltrarEmpleado.Size = new Size(399, 31);
            txtFiltrarEmpleado.TabIndex = 5;
            txtFiltrarEmpleado.TextChanged += txtFiltrarEmpleado_TextChanged;
            // 
            // tpReporteProyectos
            // 
            tpReporteProyectos.BorderStyle = BorderStyle.Fixed3D;
            tpReporteProyectos.Controls.Add(tableLayoutPanel1);
            tpReporteProyectos.Location = new Point(4, 40);
            tpReporteProyectos.Name = "tpReporteProyectos";
            tpReporteProyectos.Padding = new Padding(3);
            tpReporteProyectos.Size = new Size(1000, 584);
            tpReporteProyectos.TabIndex = 1;
            tpReporteProyectos.Text = "Proyectos";
            tpReporteProyectos.UseVisualStyleBackColor = true;
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
            tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.MinimumSize = new Size(800, 489);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(990, 574);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.Controls.Add(btnVerDetalleRepProyectos, 1, 1);
            tableLayoutPanel2.Controls.Add(btnSalirProyectos, 5, 1);
            tableLayoutPanel2.Controls.Add(btnEliminarRepProyectos, 2, 1);
            tableLayoutPanel2.Controls.Add(btnAgregarRepProyectos, 4, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(33, 408);
            tableLayoutPanel2.MinimumSize = new Size(734, 107);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(924, 137);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnVerDetalleRepProyectos
            // 
            btnVerDetalleRepProyectos.Dock = DockStyle.Fill;
            btnVerDetalleRepProyectos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerDetalleRepProyectos.ForeColor = Color.SteelBlue;
            btnVerDetalleRepProyectos.Location = new Point(61, 35);
            btnVerDetalleRepProyectos.Margin = new Padding(15);
            btnVerDetalleRepProyectos.Name = "btnVerDetalleRepProyectos";
            btnVerDetalleRepProyectos.Size = new Size(154, 67);
            btnVerDetalleRepProyectos.TabIndex = 2;
            btnVerDetalleRepProyectos.Text = "Ver Detalle";
            btnVerDetalleRepProyectos.UseVisualStyleBackColor = true;
            btnVerDetalleRepProyectos.Click += btnVerDetalleRepProyectos_Click;
            // 
            // btnSalirProyectos
            // 
            btnSalirProyectos.Dock = DockStyle.Fill;
            btnSalirProyectos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalirProyectos.ForeColor = Color.SteelBlue;
            btnSalirProyectos.Location = new Point(705, 35);
            btnSalirProyectos.Margin = new Padding(15);
            btnSalirProyectos.Name = "btnSalirProyectos";
            btnSalirProyectos.Size = new Size(154, 67);
            btnSalirProyectos.TabIndex = 4;
            btnSalirProyectos.Text = "Salir";
            btnSalirProyectos.UseVisualStyleBackColor = true;
            btnSalirProyectos.Click += CerrarFormulario;
            // 
            // btnEliminarRepProyectos
            // 
            btnEliminarRepProyectos.Dock = DockStyle.Fill;
            btnEliminarRepProyectos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarRepProyectos.ForeColor = Color.SteelBlue;
            btnEliminarRepProyectos.Location = new Point(245, 35);
            btnEliminarRepProyectos.Margin = new Padding(15);
            btnEliminarRepProyectos.Name = "btnEliminarRepProyectos";
            btnEliminarRepProyectos.Size = new Size(154, 67);
            btnEliminarRepProyectos.TabIndex = 3;
            btnEliminarRepProyectos.Text = "Eliminar reporte";
            btnEliminarRepProyectos.UseVisualStyleBackColor = true;
            btnEliminarRepProyectos.Click += btnEliminarRepProyectos_Click;
            // 
            // btnAgregarRepProyectos
            // 
            btnAgregarRepProyectos.Dock = DockStyle.Fill;
            btnAgregarRepProyectos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarRepProyectos.ForeColor = Color.SteelBlue;
            btnAgregarRepProyectos.Location = new Point(521, 35);
            btnAgregarRepProyectos.Margin = new Padding(15);
            btnAgregarRepProyectos.Name = "btnAgregarRepProyectos";
            btnAgregarRepProyectos.Size = new Size(154, 67);
            btnAgregarRepProyectos.TabIndex = 0;
            btnAgregarRepProyectos.Text = "Generar reporte";
            btnAgregarRepProyectos.UseVisualStyleBackColor = true;
            btnAgregarRepProyectos.Click += btnAgregarRepProyectos_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label4, 0, 1);
            tableLayoutPanel3.Controls.Add(label5, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(33, 73);
            tableLayoutPanel3.MinimumSize = new Size(734, 64);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.Size = new Size(924, 64);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(10, 18);
            label4.Margin = new Padding(10, 0, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 1;
            label4.Text = "Lista de reportes";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(477, 18);
            label5.Margin = new Padding(15, 0, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(177, 28);
            label5.TabIndex = 2;
            label5.Text = "Lista de proyectos";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel4.Controls.Add(lblTitulo, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(33, 3);
            tableLayoutPanel4.MinimumSize = new Size(734, 64);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(924, 64);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Navy;
            lblTitulo.Location = new Point(313, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(297, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reporte de Proyectos";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 5;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tableLayoutPanel10.Controls.Add(txtFiltrarRepProyectos, 1, 0);
            tableLayoutPanel10.Controls.Add(dgvReporteProyectos, 1, 1);
            tableLayoutPanel10.Controls.Add(dgvProyecto, 3, 1);
            tableLayoutPanel10.Controls.Add(txtFiltrarProyecto, 3, 0);
            tableLayoutPanel10.Location = new Point(33, 143);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel10.Size = new Size(924, 259);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // txtFiltrarRepProyectos
            // 
            txtFiltrarRepProyectos.BorderStyle = BorderStyle.FixedSingle;
            txtFiltrarRepProyectos.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFiltrarRepProyectos.Location = new Point(9, 0);
            txtFiltrarRepProyectos.Margin = new Padding(0);
            txtFiltrarRepProyectos.Name = "txtFiltrarRepProyectos";
            txtFiltrarRepProyectos.PlaceholderText = "Buscar reporte por nombre o ID...";
            txtFiltrarRepProyectos.Size = new Size(399, 31);
            txtFiltrarRepProyectos.TabIndex = 1;
            txtFiltrarRepProyectos.TextChanged += txtFiltrarRepProyectos_TextChanged;
            // 
            // dgvReporteProyectos
            // 
            dgvReporteProyectos.AllowUserToAddRows = false;
            dgvReporteProyectos.AllowUserToDeleteRows = false;
            dgvReporteProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteProyectos.Dock = DockStyle.Fill;
            dgvReporteProyectos.Location = new Point(12, 41);
            dgvReporteProyectos.MultiSelect = false;
            dgvReporteProyectos.Name = "dgvReporteProyectos";
            dgvReporteProyectos.ReadOnly = true;
            dgvReporteProyectos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReporteProyectos.RowHeadersVisible = false;
            dgvReporteProyectos.RowHeadersWidth = 51;
            dgvReporteProyectos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporteProyectos.Size = new Size(428, 215);
            dgvReporteProyectos.TabIndex = 3;
            // 
            // dgvProyecto
            // 
            dgvProyecto.AllowUserToAddRows = false;
            dgvProyecto.AllowUserToDeleteRows = false;
            dgvProyecto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProyecto.Dock = DockStyle.Fill;
            dgvProyecto.Location = new Point(482, 41);
            dgvProyecto.MultiSelect = false;
            dgvProyecto.Name = "dgvProyecto";
            dgvProyecto.ReadOnly = true;
            dgvProyecto.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProyecto.RowHeadersVisible = false;
            dgvProyecto.RowHeadersWidth = 51;
            dgvProyecto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProyecto.Size = new Size(428, 215);
            dgvProyecto.TabIndex = 4;
            // 
            // txtFiltrarProyecto
            // 
            txtFiltrarProyecto.BorderStyle = BorderStyle.FixedSingle;
            txtFiltrarProyecto.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFiltrarProyecto.Location = new Point(479, 0);
            txtFiltrarProyecto.Margin = new Padding(0);
            txtFiltrarProyecto.Name = "txtFiltrarProyecto";
            txtFiltrarProyecto.PlaceholderText = "Buscar proyecto por nombre o ID...";
            txtFiltrarProyecto.Size = new Size(399, 31);
            txtFiltrarProyecto.TabIndex = 5;
            txtFiltrarProyecto.TextChanged += txtFiltrarProyecto_TextChanged;
            // 
            // tpReporteFinanzas
            // 
            tpReporteFinanzas.BorderStyle = BorderStyle.Fixed3D;
            tpReporteFinanzas.Controls.Add(tableLayoutPanel5);
            tpReporteFinanzas.Location = new Point(4, 40);
            tpReporteFinanzas.Name = "tpReporteFinanzas";
            tpReporteFinanzas.Padding = new Padding(3);
            tpReporteFinanzas.Size = new Size(1074, 588);
            tpReporteFinanzas.TabIndex = 2;
            tpReporteFinanzas.Text = "Finanzas";
            tpReporteFinanzas.UseVisualStyleBackColor = true;
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
            tableLayoutPanel5.Controls.Add(dgvReporteFinanzas, 1, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.MinimumSize = new Size(800, 489);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel5.Size = new Size(1064, 578);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 4;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9999962F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9999962F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(btnAgregarRepFinanzas, 0, 1);
            tableLayoutPanel6.Controls.Add(btnSalirFinanzas, 3, 1);
            tableLayoutPanel6.Controls.Add(btnEliminarRepFinanzas, 1, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(33, 411);
            tableLayoutPanel6.MinimumSize = new Size(734, 107);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(998, 138);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // btnAgregarRepFinanzas
            // 
            btnAgregarRepFinanzas.Dock = DockStyle.Fill;
            btnAgregarRepFinanzas.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarRepFinanzas.ForeColor = Color.SteelBlue;
            btnAgregarRepFinanzas.Location = new Point(15, 35);
            btnAgregarRepFinanzas.Margin = new Padding(15);
            btnAgregarRepFinanzas.Name = "btnAgregarRepFinanzas";
            btnAgregarRepFinanzas.Size = new Size(219, 68);
            btnAgregarRepFinanzas.TabIndex = 0;
            btnAgregarRepFinanzas.Text = "Generar reporte";
            btnAgregarRepFinanzas.UseVisualStyleBackColor = true;
            btnAgregarRepFinanzas.Click += btnAgregarRepFinanzas_Click;
            // 
            // btnSalirFinanzas
            // 
            btnSalirFinanzas.Dock = DockStyle.Fill;
            btnSalirFinanzas.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalirFinanzas.ForeColor = Color.SteelBlue;
            btnSalirFinanzas.Location = new Point(762, 35);
            btnSalirFinanzas.Margin = new Padding(15);
            btnSalirFinanzas.Name = "btnSalirFinanzas";
            btnSalirFinanzas.Size = new Size(221, 68);
            btnSalirFinanzas.TabIndex = 4;
            btnSalirFinanzas.Text = "Salir";
            btnSalirFinanzas.UseVisualStyleBackColor = true;
            btnSalirFinanzas.Click += CerrarFormulario;
            // 
            // btnEliminarRepFinanzas
            // 
            btnEliminarRepFinanzas.Dock = DockStyle.Fill;
            btnEliminarRepFinanzas.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarRepFinanzas.ForeColor = Color.SteelBlue;
            btnEliminarRepFinanzas.Location = new Point(264, 35);
            btnEliminarRepFinanzas.Margin = new Padding(15);
            btnEliminarRepFinanzas.Name = "btnEliminarRepFinanzas";
            btnEliminarRepFinanzas.Size = new Size(219, 68);
            btnEliminarRepFinanzas.TabIndex = 3;
            btnEliminarRepFinanzas.Text = "Eliminar reporte";
            btnEliminarRepFinanzas.UseVisualStyleBackColor = true;
            btnEliminarRepFinanzas.Click += btnEliminarRepFinanzas_Click;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(txtFiltrarRepFinanzas, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(33, 73);
            tableLayoutPanel7.MinimumSize = new Size(734, 64);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel7.Size = new Size(998, 64);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // txtFiltrarRepFinanzas
            // 
            txtFiltrarRepFinanzas.BorderStyle = BorderStyle.FixedSingle;
            txtFiltrarRepFinanzas.Dock = DockStyle.Bottom;
            txtFiltrarRepFinanzas.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFiltrarRepFinanzas.Location = new Point(0, 23);
            txtFiltrarRepFinanzas.Margin = new Padding(0);
            txtFiltrarRepFinanzas.Name = "txtFiltrarRepFinanzas";
            txtFiltrarRepFinanzas.PlaceholderText = "Buscar por fecha o ID...";
            txtFiltrarRepFinanzas.Size = new Size(499, 31);
            txtFiltrarRepFinanzas.TabIndex = 1;
            txtFiltrarRepFinanzas.TextChanged += txtFiltrarRepFinanzas_TextChanged;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel8.Controls.Add(label1, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(33, 3);
            tableLayoutPanel8.MinimumSize = new Size(734, 64);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(998, 64);
            tableLayoutPanel8.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(358, 13);
            label1.Name = "label1";
            label1.Size = new Size(281, 38);
            label1.TabIndex = 0;
            label1.Text = "Reporte de Finanzas";
            // 
            // dgvReporteFinanzas
            // 
            dgvReporteFinanzas.AllowUserToAddRows = false;
            dgvReporteFinanzas.AllowUserToDeleteRows = false;
            dgvReporteFinanzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteFinanzas.Dock = DockStyle.Fill;
            dgvReporteFinanzas.Location = new Point(33, 143);
            dgvReporteFinanzas.MinimumSize = new Size(734, 204);
            dgvReporteFinanzas.MultiSelect = false;
            dgvReporteFinanzas.Name = "dgvReporteFinanzas";
            dgvReporteFinanzas.ReadOnly = true;
            dgvReporteFinanzas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReporteFinanzas.RowHeadersVisible = false;
            dgvReporteFinanzas.RowHeadersWidth = 51;
            dgvReporteFinanzas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporteFinanzas.Size = new Size(998, 262);
            dgvReporteFinanzas.TabIndex = 3;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1008, 659);
            Controls.Add(tcReportes);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MinimumSize = new Size(1030, 710);
            Name = "FormReportes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "📊 Reportes";
            Load += FormReportes_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tcReportes.ResumeLayout(false);
            tpReporteEmpleados.ResumeLayout(false);
            tlpMenuEmpleados.ResumeLayout(false);
            tlpBotones.ResumeLayout(false);
            tlpFiltrar.ResumeLayout(false);
            tlpFiltrar.PerformLayout();
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado).EndInit();
            tpReporteProyectos.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteProyectos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProyecto).EndInit();
            tpReporteFinanzas.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteFinanzas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsFecha;
        private TabControl tcReportes;
        private TabPage tpReporteEmpleados;
        private TabPage tpReporteProyectos;
        private TabPage tpReporteFinanzas;
        private TableLayoutPanel tlpMenuEmpleados;
        private TableLayoutPanel tlpBotones;
        private Button btnAgregarRepEempleado;
        private Button btnVerDetalleRepEmpleado;
        private Button btnSalirEmpelados;
        private Button btnEliminar;
        private TableLayoutPanel tlpFiltrar;
        private TextBox txtFiltrarRepEmpleado;
        private TableLayoutPanel tlpTitulo;
        private Label lblReporteEmpleado;
        private DataGridView dgvReporteEmpleados;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAgregarRepProyectos;
        private Button btnVerDetalleRepProyectos;
        private Button btnSalirProyectos;
        private Button btnEliminarRepProyectos;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtFiltrarRepProyectos;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblTitulo;
        private DataGridView dgvReporteProyectos;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnAgregarRepFinanzas;
        private Button btnSalirFinanzas;
        private Button btnEliminarRepFinanzas;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox txtFiltrarRepFinanzas;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label1;
        private DataGridView dgvReporteFinanzas;
        private TableLayoutPanel tableLayoutPanel9;
        private DataGridView dgvEmpleado;
        private TextBox txtFiltrarEmpleado;
        private Label label3;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel10;
        private DataGridView dgvProyecto;
        private TextBox txtFiltrarProyecto;
        private Label label4;
        private Label label5;
    }
}