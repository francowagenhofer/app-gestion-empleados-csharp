namespace AppEscritorio_GestiónDeEmpleados
{
    partial class FormEmpleados
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
            this.typEmpleados = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stFecha = new System.Windows.Forms.StatusStrip();
            this.tsFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlpFondo = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tlpFiltro = new System.Windows.Forms.TableLayoutPanel();
            this.cbActivos = new System.Windows.Forms.CheckBox();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.typEmpleados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.stFecha.SuspendLayout();
            this.tlpFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.tlpBotones.SuspendLayout();
            this.tlpFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // typEmpleados
            // 
            this.typEmpleados.ColumnCount = 3;
            this.typEmpleados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.typEmpleados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.typEmpleados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.typEmpleados.Controls.Add(this.lblTitulo, 1, 0);
            this.typEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typEmpleados.Location = new System.Drawing.Point(0, 0);
            this.typEmpleados.Name = "typEmpleados";
            this.typEmpleados.RowCount = 1;
            this.typEmpleados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.typEmpleados.Size = new System.Drawing.Size(782, 111);
            this.typEmpleados.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Location = new System.Drawing.Point(237, 36);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(307, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestión de empleados";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.typEmpleados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 111);
            this.panel1.TabIndex = 1;
            // 
            // stFecha
            // 
            this.stFecha.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stFecha.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFecha,
            this.tsEstado});
            this.stFecha.Location = new System.Drawing.Point(0, 622);
            this.stFecha.Name = "stFecha";
            this.stFecha.Size = new System.Drawing.Size(782, 31);
            this.stFecha.TabIndex = 2;
            this.stFecha.Text = "Fecha";
            // 
            // tsFecha
            // 
            this.tsFecha.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsFecha.Name = "tsFecha";
            this.tsFecha.Size = new System.Drawing.Size(57, 25);
            this.tsFecha.Text = "Fecha";
            // 
            // tsEstado
            // 
            this.tsEstado.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsEstado.Name = "tsEstado";
            this.tsEstado.Size = new System.Drawing.Size(66, 25);
            this.tsEstado.Text = "Estado";
            // 
            // tlpFondo
            // 
            this.tlpFondo.ColumnCount = 3;
            this.tlpFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFondo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpFondo.Controls.Add(this.dgvEmpleados, 1, 1);
            this.tlpFondo.Controls.Add(this.tlpBotones, 1, 2);
            this.tlpFondo.Controls.Add(this.tlpFiltro, 1, 0);
            this.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFondo.Location = new System.Drawing.Point(0, 111);
            this.tlpFondo.Name = "tlpFondo";
            this.tlpFondo.RowCount = 3;
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.27869F));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.29508F));
            this.tlpFondo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.42623F));
            this.tlpFondo.Size = new System.Drawing.Size(782, 511);
            this.tlpFondo.TabIndex = 3;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpleados.Location = new System.Drawing.Point(28, 121);
            this.dgvEmpleados.MinimumSize = new System.Drawing.Size(600, 300);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(726, 300);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 5;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBotones.Controls.Add(this.btnAgregar, 0, 1);
            this.tlpBotones.Controls.Add(this.btnModificar, 1, 1);
            this.tlpBotones.Controls.Add(this.btnEliminar, 2, 1);
            this.tlpBotones.Controls.Add(this.btnEstado, 3, 1);
            this.tlpBotones.Controls.Add(this.btnCerrar, 4, 1);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotones.Location = new System.Drawing.Point(28, 388);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 3;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBotones.Size = new System.Drawing.Size(726, 120);
            this.tlpBotones.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(20, 40);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(20);
            this.btnAgregar.MaximumSize = new System.Drawing.Size(125, 64);
            this.btnAgregar.MinimumSize = new System.Drawing.Size(125, 64);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 64);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(165, 40);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(20);
            this.btnModificar.MaximumSize = new System.Drawing.Size(125, 64);
            this.btnModificar.MinimumSize = new System.Drawing.Size(125, 64);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(125, 64);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(310, 40);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(20);
            this.btnEliminar.MaximumSize = new System.Drawing.Size(125, 64);
            this.btnEliminar.MinimumSize = new System.Drawing.Size(125, 64);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 64);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEstado
            // 
            this.btnEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.Location = new System.Drawing.Point(455, 40);
            this.btnEstado.Margin = new System.Windows.Forms.Padding(20);
            this.btnEstado.MaximumSize = new System.Drawing.Size(125, 64);
            this.btnEstado.MinimumSize = new System.Drawing.Size(125, 64);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(125, 64);
            this.btnEstado.TabIndex = 3;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(600, 40);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(20);
            this.btnCerrar.MaximumSize = new System.Drawing.Size(126, 64);
            this.btnCerrar.MinimumSize = new System.Drawing.Size(126, 64);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(126, 64);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tlpFiltro
            // 
            this.tlpFiltro.ColumnCount = 2;
            this.tlpFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.26876F));
            this.tlpFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.73124F));
            this.tlpFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFiltro.Controls.Add(this.cbActivos, 1, 1);
            this.tlpFiltro.Controls.Add(this.tbBuscar, 0, 1);
            this.tlpFiltro.Location = new System.Drawing.Point(28, 3);
            this.tlpFiltro.Name = "tlpFiltro";
            this.tlpFiltro.RowCount = 3;
            this.tlpFiltro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpFiltro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpFiltro.Size = new System.Drawing.Size(726, 112);
            this.tlpFiltro.TabIndex = 2;
            // 
            // cbActivos
            // 
            this.cbActivos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbActivos.AutoSize = true;
            this.cbActivos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActivos.Location = new System.Drawing.Point(396, 41);
            this.cbActivos.Margin = new System.Windows.Forms.Padding(10);
            this.cbActivos.MinimumSize = new System.Drawing.Size(211, 32);
            this.cbActivos.Name = "cbActivos";
            this.cbActivos.Padding = new System.Windows.Forms.Padding(3);
            this.cbActivos.Size = new System.Drawing.Size(217, 32);
            this.cbActivos.TabIndex = 1;
            this.cbActivos.Text = "Mostrar solo activos";
            this.cbActivos.UseVisualStyleBackColor = true;
            this.cbActivos.CheckedChanged += new System.EventHandler(this.cbActivos_CheckedChanged);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.Location = new System.Drawing.Point(3, 41);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(3, 10, 0, 10);
            this.tbBuscar.MaximumSize = new System.Drawing.Size(500, 34);
            this.tbBuscar.MinimumSize = new System.Drawing.Size(400, 34);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(400, 34);
            this.tbBuscar.TabIndex = 3;
            this.tbBuscar.Text = "Buscar por nombre, apellido o DNI...";
            this.tbBuscar.TextChanged += new System.EventHandler(this.tbBuscar_TextChanged);
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.tlpFondo);
            this.Controls.Add(this.stFecha);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "FormEmpleados";
            this.Text = "Gestión de empleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            this.typEmpleados.ResumeLayout(false);
            this.typEmpleados.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.stFecha.ResumeLayout(false);
            this.stFecha.PerformLayout();
            this.tlpFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.tlpBotones.ResumeLayout(false);
            this.tlpFiltro.ResumeLayout(false);
            this.tlpFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel typEmpleados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.StatusStrip stFecha;
        private System.Windows.Forms.ToolStripStatusLabel tsFecha;
        private System.Windows.Forms.TableLayoutPanel tlpFondo;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ToolStripStatusLabel tsEstado;
        private System.Windows.Forms.TableLayoutPanel tlpFiltro;
        private System.Windows.Forms.CheckBox cbActivos;
        private System.Windows.Forms.TextBox tbBuscar;
    }
}