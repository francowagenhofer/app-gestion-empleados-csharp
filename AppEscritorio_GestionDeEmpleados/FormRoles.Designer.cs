﻿namespace AppEscritorio_GestionDeEmpleados
{
    partial class FormRoles
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
            tlpMenuEmpleados = new TableLayoutPanel();
            tlpBotones = new TableLayoutPanel();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnVerDetalle = new Button();
            btnSalir = new Button();
            btnEliminar = new Button();
            tlpFiltrar = new TableLayoutPanel();
            tbFiltro = new TextBox();
            tlpTitulo = new TableLayoutPanel();
            lblTitulo = new Label();
            dgvRoles = new DataGridView();
            stEmpleados.SuspendLayout();
            tlpMenuEmpleados.SuspendLayout();
            tlpBotones.SuspendLayout();
            tlpFiltrar.SuspendLayout();
            tlpTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            SuspendLayout();
            // 
            // stEmpleados
            // 
            stEmpleados.ImageScalingSize = new Size(20, 20);
            stEmpleados.Items.AddRange(new ToolStripItem[] { tsFecha });
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
            // tlpMenuEmpleados
            // 
            tlpMenuEmpleados.ColumnCount = 3;
            tlpMenuEmpleados.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tlpMenuEmpleados.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMenuEmpleados.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tlpMenuEmpleados.Controls.Add(tlpBotones, 1, 3);
            tlpMenuEmpleados.Controls.Add(tlpFiltrar, 1, 1);
            tlpMenuEmpleados.Controls.Add(tlpTitulo, 1, 0);
            tlpMenuEmpleados.Controls.Add(dgvRoles, 1, 2);
            tlpMenuEmpleados.Dock = DockStyle.Fill;
            tlpMenuEmpleados.Location = new Point(0, 0);
            tlpMenuEmpleados.MinimumSize = new Size(800, 489);
            tlpMenuEmpleados.Name = "tlpMenuEmpleados";
            tlpMenuEmpleados.RowCount = 5;
            tlpMenuEmpleados.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpMenuEmpleados.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpMenuEmpleados.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tlpMenuEmpleados.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tlpMenuEmpleados.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpMenuEmpleados.Size = new Size(1008, 628);
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
            tlpBotones.Controls.Add(btnModificar, 1, 1);
            tlpBotones.Controls.Add(btnVerDetalle, 2, 1);
            tlpBotones.Controls.Add(btnSalir, 5, 1);
            tlpBotones.Controls.Add(btnEliminar, 3, 1);
            tlpBotones.Dock = DockStyle.Fill;
            tlpBotones.Location = new Point(33, 443);
            tlpBotones.MinimumSize = new Size(734, 107);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 3;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpBotones.Size = new Size(942, 156);
            tlpBotones.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Dock = DockStyle.Fill;
            btnAgregar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.SteelBlue;
            btnAgregar.Location = new Point(15, 35);
            btnAgregar.Margin = new Padding(15);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(126, 86);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Dock = DockStyle.Fill;
            btnModificar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.SteelBlue;
            btnModificar.Location = new Point(171, 35);
            btnModificar.Margin = new Padding(15);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(126, 86);
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
            btnVerDetalle.Location = new Point(327, 35);
            btnVerDetalle.Margin = new Padding(15);
            btnVerDetalle.Name = "btnVerDetalle";
            btnVerDetalle.Size = new Size(126, 86);
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
            btnSalir.Location = new Point(795, 35);
            btnSalir.Margin = new Padding(15);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(132, 86);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.SteelBlue;
            btnEliminar.Location = new Point(483, 35);
            btnEliminar.Margin = new Padding(15);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(126, 86);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // tlpFiltrar
            // 
            tlpFiltrar.ColumnCount = 2;
            tlpFiltrar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.2123146F));
            tlpFiltrar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.7876854F));
            tlpFiltrar.Controls.Add(tbFiltro, 0, 1);
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
            tbFiltro.PlaceholderText = "Buscar por nombre o ID...";
            tbFiltro.Size = new Size(473, 31);
            tbFiltro.TabIndex = 1;
            tbFiltro.TextChanged += tbFiltrar_TextChanged;
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
            lblTitulo.Location = new Point(353, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(234, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Roles";
            // 
            // dgvRoles
            // 
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.AllowUserToDeleteRows = false;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Dock = DockStyle.Fill;
            dgvRoles.Location = new Point(33, 143);
            dgvRoles.MinimumSize = new Size(734, 204);
            dgvRoles.MultiSelect = false;
            dgvRoles.Name = "dgvRoles";
            dgvRoles.ReadOnly = true;
            dgvRoles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRoles.RowHeadersVisible = false;
            dgvRoles.RowHeadersWidth = 51;
            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.Size = new Size(942, 294);
            dgvRoles.TabIndex = 3;
            // 
            // FormRoles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1008, 659);
            Controls.Add(tlpMenuEmpleados);
            Controls.Add(stEmpleados);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MinimumSize = new Size(1030, 710);
            Name = "FormRoles";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "📋 Roles";
            Load += FormRoles_Load;
            stEmpleados.ResumeLayout(false);
            stEmpleados.PerformLayout();
            tlpMenuEmpleados.ResumeLayout(false);
            tlpBotones.ResumeLayout(false);
            tlpFiltrar.ResumeLayout(false);
            tlpFiltrar.PerformLayout();
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip stEmpleados;
        private ToolStripStatusLabel tsFecha;
        private TableLayoutPanel tlpMenuEmpleados;
        private TableLayoutPanel tlpBotones;
        private TableLayoutPanel tlpFiltrar;
        private TableLayoutPanel tlpTitulo;
        private Label lblTitulo;
        private DataGridView dgvRoles;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnVerDetalle;
        private Button btnEliminar;
        private Button btnSalir;
        private TextBox tbFiltro;
    }
}