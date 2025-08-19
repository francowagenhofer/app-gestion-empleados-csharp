namespace AppEscritorio_GestionDeEmpleados
{
    partial class FormAsignacionProyecto
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
            tpAsignacionTarea = new TabPage();
            tableLayoutPanel10 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            tableLayoutPanel12 = new TableLayoutPanel();
            groupBox5 = new GroupBox();
            btnDesasignarTarea = new Button();
            dgvTareasAsignadas = new DataGridView();
            tableLayoutPanel13 = new TableLayoutPanel();
            groupBox6 = new GroupBox();
            btnSalirTareas = new Button();
            btnAsignarTarea = new Button();
            dgvTareasDisponibles = new DataGridView();
            tableLayoutPanel14 = new TableLayoutPanel();
            lblEmpleadoTarea = new Label();
            label4 = new Label();
            tpAsignacionRol = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            btnDesasignarRol = new Button();
            dgvRolesAsignados = new DataGridView();
            tableLayoutPanel8 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            btnSalirRoles = new Button();
            btnAsignarRol = new Button();
            dgvRolesDisponibles = new DataGridView();
            tableLayoutPanel9 = new TableLayoutPanel();
            lblEmpleadoRol = new Label();
            label2 = new Label();
            tpAsignacionEmpleado = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            btnDesasignarEmpleado = new Button();
            dgvEmpleadosAsignados = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            btnSalirProyectos = new Button();
            btnAsignarEmpleado = new Button();
            dgvEmpleadosDisponibles = new DataGridView();
            tlpTitulo = new TableLayoutPanel();
            lblEmpleadoProyecto = new Label();
            lblTitulo = new Label();
            tabControl1 = new TabControl();
            statusStrip1.SuspendLayout();
            tpAsignacionTarea.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTareasAsignadas).BeginInit();
            tableLayoutPanel13.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTareasDisponibles).BeginInit();
            tableLayoutPanel14.SuspendLayout();
            tpAsignacionRol.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRolesAsignados).BeginInit();
            tableLayoutPanel8.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRolesDisponibles).BeginInit();
            tableLayoutPanel9.SuspendLayout();
            tpAsignacionEmpleado.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosAsignados).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosDisponibles).BeginInit();
            tlpTitulo.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsFecha });
            statusStrip1.Location = new Point(0, 628);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1008, 31);
            statusStrip1.TabIndex = 1;
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
            // tpAsignacionTarea
            // 
            tpAsignacionTarea.BackColor = SystemColors.ControlLight;
            tpAsignacionTarea.BorderStyle = BorderStyle.Fixed3D;
            tpAsignacionTarea.Controls.Add(tableLayoutPanel10);
            tpAsignacionTarea.Location = new Point(4, 40);
            tpAsignacionTarea.Name = "tpAsignacionTarea";
            tpAsignacionTarea.Padding = new Padding(3);
            tpAsignacionTarea.Size = new Size(1000, 584);
            tpAsignacionTarea.TabIndex = 2;
            tpAsignacionTarea.Text = "Tareas";
            tpAsignacionTarea.UseWaitCursor = true;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 3;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel10.Controls.Add(tableLayoutPanel11, 1, 1);
            tableLayoutPanel10.Controls.Add(tableLayoutPanel14, 1, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 3);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 3;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel10.Size = new Size(990, 574);
            tableLayoutPanel10.TabIndex = 1;
            tableLayoutPanel10.UseWaitCursor = true;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(tableLayoutPanel12, 0, 0);
            tableLayoutPanel11.Controls.Add(tableLayoutPanel13, 1, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(33, 85);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Size = new Size(924, 460);
            tableLayoutPanel11.TabIndex = 0;
            tableLayoutPanel11.UseWaitCursor = true;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 3;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel12.Controls.Add(groupBox5, 1, 1);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 3;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel12.Size = new Size(456, 454);
            tableLayoutPanel12.TabIndex = 2;
            tableLayoutPanel12.UseWaitCursor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnDesasignarTarea);
            groupBox5.Controls.Add(dgvTareasAsignadas);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.SteelBlue;
            groupBox5.Location = new Point(13, 23);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(430, 408);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tareas asignadas";
            groupBox5.UseWaitCursor = true;
            // 
            // btnDesasignarTarea
            // 
            btnDesasignarTarea.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDesasignarTarea.Location = new Point(6, 343);
            btnDesasignarTarea.Name = "btnDesasignarTarea";
            btnDesasignarTarea.Size = new Size(210, 57);
            btnDesasignarTarea.TabIndex = 1;
            btnDesasignarTarea.Text = "Desasignar tareas";
            btnDesasignarTarea.UseVisualStyleBackColor = true;
            btnDesasignarTarea.UseWaitCursor = true;
            btnDesasignarTarea.Click += btnDesasignarTarea_Click;
            // 
            // dgvTareasAsignadas
            // 
            dgvTareasAsignadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareasAsignadas.Location = new Point(6, 37);
            dgvTareasAsignadas.MinimumSize = new Size(418, 227);
            dgvTareasAsignadas.Name = "dgvTareasAsignadas";
            dgvTareasAsignadas.RowHeadersWidth = 51;
            dgvTareasAsignadas.Size = new Size(418, 300);
            dgvTareasAsignadas.TabIndex = 0;
            dgvTareasAsignadas.UseWaitCursor = true;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 3;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel13.Controls.Add(groupBox6, 1, 1);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(465, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 3;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel13.Size = new Size(456, 454);
            tableLayoutPanel13.TabIndex = 3;
            tableLayoutPanel13.UseWaitCursor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnSalirTareas);
            groupBox6.Controls.Add(btnAsignarTarea);
            groupBox6.Controls.Add(dgvTareasDisponibles);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox6.ForeColor = Color.SteelBlue;
            groupBox6.Location = new Point(13, 23);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(430, 408);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tareas disponibles";
            groupBox6.UseWaitCursor = true;
            // 
            // btnSalirTareas
            // 
            btnSalirTareas.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalirTareas.Location = new Point(314, 343);
            btnSalirTareas.Name = "btnSalirTareas";
            btnSalirTareas.Size = new Size(110, 57);
            btnSalirTareas.TabIndex = 4;
            btnSalirTareas.Text = "Salir";
            btnSalirTareas.UseVisualStyleBackColor = true;
            btnSalirTareas.UseWaitCursor = true;
            btnSalirTareas.Click += CerrarFormulario;
            // 
            // btnAsignarTarea
            // 
            btnAsignarTarea.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsignarTarea.Location = new Point(6, 343);
            btnAsignarTarea.Name = "btnAsignarTarea";
            btnAsignarTarea.Size = new Size(194, 57);
            btnAsignarTarea.TabIndex = 2;
            btnAsignarTarea.Text = "Asignar tareas";
            btnAsignarTarea.UseVisualStyleBackColor = true;
            btnAsignarTarea.UseWaitCursor = true;
            btnAsignarTarea.Click += btnAsignarTarea_Click;
            // 
            // dgvTareasDisponibles
            // 
            dgvTareasDisponibles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTareasDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareasDisponibles.Location = new Point(6, 37);
            dgvTareasDisponibles.MinimumSize = new Size(418, 227);
            dgvTareasDisponibles.Name = "dgvTareasDisponibles";
            dgvTareasDisponibles.RowHeadersWidth = 51;
            dgvTareasDisponibles.Size = new Size(418, 302);
            dgvTareasDisponibles.TabIndex = 0;
            dgvTareasDisponibles.UseWaitCursor = true;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 3;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel14.Controls.Add(lblEmpleadoTarea, 2, 0);
            tableLayoutPanel14.Controls.Add(label4, 0, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(33, 3);
            tableLayoutPanel14.MinimumSize = new Size(734, 64);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Size = new Size(924, 76);
            tableLayoutPanel14.TabIndex = 3;
            tableLayoutPanel14.UseWaitCursor = true;
            // 
            // lblEmpleadoTarea
            // 
            lblEmpleadoTarea.Anchor = AnchorStyles.Left;
            lblEmpleadoTarea.AutoSize = true;
            lblEmpleadoTarea.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleadoTarea.ForeColor = Color.Navy;
            lblEmpleadoTarea.Location = new Point(465, 22);
            lblEmpleadoTarea.Name = "lblEmpleadoTarea";
            lblEmpleadoTarea.Size = new Size(107, 31);
            lblEmpleadoTarea.TabIndex = 3;
            lblEmpleadoTarea.Text = "Proyecto";
            lblEmpleadoTarea.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(3, 19);
            label4.Name = "label4";
            label4.Size = new Size(281, 38);
            label4.TabIndex = 0;
            label4.Text = "Asignación de tareas";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.UseWaitCursor = true;
            // 
            // tpAsignacionRol
            // 
            tpAsignacionRol.BackColor = SystemColors.ControlLight;
            tpAsignacionRol.BorderStyle = BorderStyle.Fixed3D;
            tpAsignacionRol.Controls.Add(tableLayoutPanel5);
            tpAsignacionRol.Location = new Point(4, 40);
            tpAsignacionRol.Name = "tpAsignacionRol";
            tpAsignacionRol.Padding = new Padding(3);
            tpAsignacionRol.Size = new Size(1000, 584);
            tpAsignacionRol.TabIndex = 1;
            tpAsignacionRol.Text = "Roles";
            tpAsignacionRol.UseWaitCursor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 1, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel9, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel5.Size = new Size(990, 574);
            tableLayoutPanel5.TabIndex = 1;
            tableLayoutPanel5.UseWaitCursor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel8, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(33, 85);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(924, 460);
            tableLayoutPanel6.TabIndex = 0;
            tableLayoutPanel6.UseWaitCursor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel7.Controls.Add(groupBox3, 1, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(456, 454);
            tableLayoutPanel7.TabIndex = 2;
            tableLayoutPanel7.UseWaitCursor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDesasignarRol);
            groupBox3.Controls.Add(dgvRolesAsignados);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.SteelBlue;
            groupBox3.Location = new Point(13, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(430, 408);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Roles asignados";
            groupBox3.UseWaitCursor = true;
            // 
            // btnDesasignarRol
            // 
            btnDesasignarRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDesasignarRol.Location = new Point(6, 343);
            btnDesasignarRol.Name = "btnDesasignarRol";
            btnDesasignarRol.Size = new Size(210, 57);
            btnDesasignarRol.TabIndex = 1;
            btnDesasignarRol.Text = "Desasignar rol";
            btnDesasignarRol.UseVisualStyleBackColor = true;
            btnDesasignarRol.UseWaitCursor = true;
            btnDesasignarRol.Click += btnDesasignarRol_Click;
            // 
            // dgvRolesAsignados
            // 
            dgvRolesAsignados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRolesAsignados.Location = new Point(6, 37);
            dgvRolesAsignados.MinimumSize = new Size(418, 227);
            dgvRolesAsignados.Name = "dgvRolesAsignados";
            dgvRolesAsignados.RowHeadersWidth = 51;
            dgvRolesAsignados.Size = new Size(418, 300);
            dgvRolesAsignados.TabIndex = 0;
            dgvRolesAsignados.UseWaitCursor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel8.Controls.Add(groupBox4, 1, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(465, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(456, 454);
            tableLayoutPanel8.TabIndex = 3;
            tableLayoutPanel8.UseWaitCursor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSalirRoles);
            groupBox4.Controls.Add(btnAsignarRol);
            groupBox4.Controls.Add(dgvRolesDisponibles);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.SteelBlue;
            groupBox4.Location = new Point(13, 23);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(430, 408);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Roles disponibles";
            groupBox4.UseWaitCursor = true;
            // 
            // btnSalirRoles
            // 
            btnSalirRoles.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalirRoles.Location = new Point(314, 343);
            btnSalirRoles.Name = "btnSalirRoles";
            btnSalirRoles.Size = new Size(110, 57);
            btnSalirRoles.TabIndex = 5;
            btnSalirRoles.Text = "Salir";
            btnSalirRoles.UseVisualStyleBackColor = true;
            btnSalirRoles.UseWaitCursor = true;
            btnSalirRoles.Click += CerrarFormulario;
            // 
            // btnAsignarRol
            // 
            btnAsignarRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsignarRol.Location = new Point(6, 343);
            btnAsignarRol.Name = "btnAsignarRol";
            btnAsignarRol.Size = new Size(194, 57);
            btnAsignarRol.TabIndex = 2;
            btnAsignarRol.Text = "Asignar rol";
            btnAsignarRol.UseVisualStyleBackColor = true;
            btnAsignarRol.UseWaitCursor = true;
            btnAsignarRol.Click += btnAsignarRol_Click;
            // 
            // dgvRolesDisponibles
            // 
            dgvRolesDisponibles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRolesDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRolesDisponibles.Location = new Point(6, 37);
            dgvRolesDisponibles.MinimumSize = new Size(418, 227);
            dgvRolesDisponibles.Name = "dgvRolesDisponibles";
            dgvRolesDisponibles.RowHeadersWidth = 51;
            dgvRolesDisponibles.Size = new Size(418, 302);
            dgvRolesDisponibles.TabIndex = 0;
            dgvRolesDisponibles.UseWaitCursor = true;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.Anchor = AnchorStyles.Left;
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Controls.Add(lblEmpleadoRol, 2, 0);
            tableLayoutPanel9.Controls.Add(label2, 0, 0);
            tableLayoutPanel9.Location = new Point(33, 6);
            tableLayoutPanel9.MinimumSize = new Size(734, 64);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(924, 70);
            tableLayoutPanel9.TabIndex = 3;
            tableLayoutPanel9.UseWaitCursor = true;
            // 
            // lblEmpleadoRol
            // 
            lblEmpleadoRol.Anchor = AnchorStyles.Left;
            lblEmpleadoRol.AutoSize = true;
            lblEmpleadoRol.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleadoRol.ForeColor = Color.Navy;
            lblEmpleadoRol.Location = new Point(465, 19);
            lblEmpleadoRol.Name = "lblEmpleadoRol";
            lblEmpleadoRol.Size = new Size(107, 31);
            lblEmpleadoRol.TabIndex = 2;
            lblEmpleadoRol.Text = "Proyecto";
            lblEmpleadoRol.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(265, 38);
            label2.TabIndex = 0;
            label2.Text = "Asignación de roles";
            label2.UseWaitCursor = true;
            // 
            // tpAsignacionEmpleado
            // 
            tpAsignacionEmpleado.BackColor = SystemColors.ControlLight;
            tpAsignacionEmpleado.BorderStyle = BorderStyle.Fixed3D;
            tpAsignacionEmpleado.Controls.Add(tableLayoutPanel1);
            tpAsignacionEmpleado.Location = new Point(4, 40);
            tpAsignacionEmpleado.Name = "tpAsignacionEmpleado";
            tpAsignacionEmpleado.Padding = new Padding(3);
            tpAsignacionEmpleado.Size = new Size(1000, 584);
            tpAsignacionEmpleado.TabIndex = 0;
            tpAsignacionEmpleado.Text = "Empleados";
            tpAsignacionEmpleado.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tlpTitulo, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(990, 574);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.UseWaitCursor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(33, 85);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(924, 460);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.UseWaitCursor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.Controls.Add(groupBox1, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(456, 454);
            tableLayoutPanel3.TabIndex = 2;
            tableLayoutPanel3.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDesasignarEmpleado);
            groupBox1.Controls.Add(dgvEmpleadosAsignados);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.SteelBlue;
            groupBox1.Location = new Point(13, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 408);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Empleados asignados";
            groupBox1.UseWaitCursor = true;
            // 
            // btnDesasignarEmpleado
            // 
            btnDesasignarEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDesasignarEmpleado.Location = new Point(6, 342);
            btnDesasignarEmpleado.Name = "btnDesasignarEmpleado";
            btnDesasignarEmpleado.Size = new Size(210, 57);
            btnDesasignarEmpleado.TabIndex = 1;
            btnDesasignarEmpleado.Text = "Desasignar empleado";
            btnDesasignarEmpleado.UseVisualStyleBackColor = true;
            btnDesasignarEmpleado.UseWaitCursor = true;
            btnDesasignarEmpleado.Click += btnDesasignarEmpleado_Click;
            // 
            // dgvEmpleadosAsignados
            // 
            dgvEmpleadosAsignados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleadosAsignados.Location = new Point(6, 37);
            dgvEmpleadosAsignados.MinimumSize = new Size(418, 227);
            dgvEmpleadosAsignados.Name = "dgvEmpleadosAsignados";
            dgvEmpleadosAsignados.RowHeadersWidth = 51;
            dgvEmpleadosAsignados.Size = new Size(418, 299);
            dgvEmpleadosAsignados.TabIndex = 0;
            dgvEmpleadosAsignados.UseWaitCursor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel4.Controls.Add(groupBox2, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(465, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel4.Size = new Size(456, 454);
            tableLayoutPanel4.TabIndex = 3;
            tableLayoutPanel4.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSalirProyectos);
            groupBox2.Controls.Add(btnAsignarEmpleado);
            groupBox2.Controls.Add(dgvEmpleadosDisponibles);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.SteelBlue;
            groupBox2.Location = new Point(13, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(430, 407);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Empleados disponibles";
            groupBox2.UseWaitCursor = true;
            // 
            // btnSalirProyectos
            // 
            btnSalirProyectos.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalirProyectos.Location = new Point(314, 343);
            btnSalirProyectos.Name = "btnSalirProyectos";
            btnSalirProyectos.Size = new Size(110, 57);
            btnSalirProyectos.TabIndex = 3;
            btnSalirProyectos.Text = "Salir";
            btnSalirProyectos.UseVisualStyleBackColor = true;
            btnSalirProyectos.UseWaitCursor = true;
            btnSalirProyectos.Click += CerrarFormulario;
            // 
            // btnAsignarEmpleado
            // 
            btnAsignarEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsignarEmpleado.Location = new Point(6, 343);
            btnAsignarEmpleado.Name = "btnAsignarEmpleado";
            btnAsignarEmpleado.Size = new Size(194, 57);
            btnAsignarEmpleado.TabIndex = 2;
            btnAsignarEmpleado.Text = "Asignar empleado";
            btnAsignarEmpleado.UseVisualStyleBackColor = true;
            btnAsignarEmpleado.UseWaitCursor = true;
            btnAsignarEmpleado.Click += btnAsignarEmpleado_Click;
            // 
            // dgvEmpleadosDisponibles
            // 
            dgvEmpleadosDisponibles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmpleadosDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleadosDisponibles.Location = new Point(6, 37);
            dgvEmpleadosDisponibles.MinimumSize = new Size(418, 227);
            dgvEmpleadosDisponibles.Name = "dgvEmpleadosDisponibles";
            dgvEmpleadosDisponibles.RowHeadersWidth = 51;
            dgvEmpleadosDisponibles.Size = new Size(418, 302);
            dgvEmpleadosDisponibles.TabIndex = 0;
            dgvEmpleadosDisponibles.UseWaitCursor = true;
            // 
            // tlpTitulo
            // 
            tlpTitulo.ColumnCount = 3;
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.ColumnStyles.Add(new ColumnStyle());
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpTitulo.Controls.Add(lblEmpleadoProyecto, 2, 0);
            tlpTitulo.Controls.Add(lblTitulo, 0, 0);
            tlpTitulo.Dock = DockStyle.Fill;
            tlpTitulo.Location = new Point(33, 3);
            tlpTitulo.MinimumSize = new Size(734, 64);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.RowCount = 1;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTitulo.Size = new Size(924, 76);
            tlpTitulo.TabIndex = 3;
            tlpTitulo.UseWaitCursor = true;
            // 
            // lblEmpleadoProyecto
            // 
            lblEmpleadoProyecto.Anchor = AnchorStyles.Left;
            lblEmpleadoProyecto.AutoSize = true;
            lblEmpleadoProyecto.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleadoProyecto.ForeColor = Color.Navy;
            lblEmpleadoProyecto.Location = new Point(465, 22);
            lblEmpleadoProyecto.Name = "lblEmpleadoProyecto";
            lblEmpleadoProyecto.Size = new Size(107, 31);
            lblEmpleadoProyecto.TabIndex = 1;
            lblEmpleadoProyecto.Text = "Proyecto";
            lblEmpleadoProyecto.UseWaitCursor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Left;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Navy;
            lblTitulo.Location = new Point(3, 19);
            lblTitulo.Margin = new Padding(3, 0, 0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(344, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Asignación de empleados";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.UseWaitCursor = true;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tpAsignacionEmpleado);
            tabControl1.Controls.Add(tpAsignacionRol);
            tabControl1.Controls.Add(tpAsignacionTarea);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1008, 628);
            tabControl1.TabIndex = 2;
            tabControl1.UseWaitCursor = true;
            // 
            // FormAsignacionProyecto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1008, 659);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MinimumSize = new Size(1030, 710);
            Name = "FormAsignacionProyecto";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "🔗 Asignaciónes ";
            Load += FormAsignacionEmpleado_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tpAsignacionTarea.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTareasAsignadas).EndInit();
            tableLayoutPanel13.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTareasDisponibles).EndInit();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tpAsignacionRol.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRolesAsignados).EndInit();
            tableLayoutPanel8.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRolesDisponibles).EndInit();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tpAsignacionEmpleado.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosAsignados).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosDisponibles).EndInit();
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsFecha;
        private TabPage tpAsignacionTarea;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel12;
        private GroupBox groupBox5;
        private Button btnDesasignarTarea;
        private DataGridView dgvTareasAsignadas;
        private TableLayoutPanel tableLayoutPanel13;
        private GroupBox groupBox6;
        private Button btnSalirTareas;
        private Button btnAsignarTarea;
        private DataGridView dgvTareasDisponibles;
        private TableLayoutPanel tableLayoutPanel14;
        private Label lblEmpleadoTarea;
        private Label label4;
        private TabPage tpAsignacionRol;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private GroupBox groupBox3;
        private Button btnDesasignarRol;
        private DataGridView dgvRolesAsignados;
        private TableLayoutPanel tableLayoutPanel8;
        private GroupBox groupBox4;
        private Button btnSalirRoles;
        private Button btnAsignarRol;
        private DataGridView dgvRolesDisponibles;
        private TableLayoutPanel tableLayoutPanel9;
        private Label lblEmpleadoRol;
        private Label label2;
        private TabPage tpAsignacionEmpleado;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private Button btnDesasignarEmpleado;
        private DataGridView dgvEmpleadosAsignados;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox2;
        private Button btnSalirProyectos;
        private Button btnAsignarEmpleado;
        private DataGridView dgvEmpleadosDisponibles;
        private TableLayoutPanel tlpTitulo;
        private Label lblEmpleadoProyecto;
        private Label lblTitulo;
        private TabControl tabControl1;
    }
}