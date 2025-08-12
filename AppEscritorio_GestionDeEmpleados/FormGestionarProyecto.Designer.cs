namespace AppEscritorio_GestionDeEmpleados
{
    partial class FormGestionarProyecto
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
            tsEstado = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            manualDeInformaciónToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            informaciónDeSistemaToolStripMenuItem = new ToolStripMenuItem();
            tlpFondo = new TableLayoutPanel();
            tlpTitulo = new TableLayoutPanel();
            lblTitulo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblEstado = new Label();
            lblId = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            dtpFechaInicio = new DateTimePicker();
            label5 = new Label();
            dtpFechaFin = new DateTimePicker();
            txtPresupuesto = new TextBox();
            lblPresupuesto = new Label();
            label1 = new Label();
            cbEstado = new ComboBox();
            cbEstadoProyecto = new ComboBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            tlpFondo.SuspendLayout();
            tlpTitulo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.Control;
            statusStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsFecha, tsEstado });
            statusStrip1.Location = new Point(0, 628);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(578, 31);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsFecha
            // 
            tsFecha.Name = "tsFecha";
            tsFecha.Size = new Size(57, 25);
            tsFecha.Text = "Fecha";
            // 
            // tsEstado
            // 
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
            menuStrip1.Size = new Size(578, 33);
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
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manualDeInformaciónToolStripMenuItem });
            ayudaToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(77, 29);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeInformaciónToolStripMenuItem
            // 
            manualDeInformaciónToolStripMenuItem.Name = "manualDeInformaciónToolStripMenuItem";
            manualDeInformaciónToolStripMenuItem.Size = new Size(244, 30);
            manualDeInformaciónToolStripMenuItem.Text = "Manual de usuario";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informaciónDeSistemaToolStripMenuItem });
            acercaDeToolStripMenuItem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(103, 29);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // informaciónDeSistemaToolStripMenuItem
            // 
            informaciónDeSistemaToolStripMenuItem.Name = "informaciónDeSistemaToolStripMenuItem";
            informaciónDeSistemaToolStripMenuItem.Size = new Size(284, 30);
            informaciónDeSistemaToolStripMenuItem.Text = "Información de sistema";
            // 
            // tlpFondo
            // 
            tlpFondo.ColumnCount = 3;
            tlpFondo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tlpFondo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFondo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tlpFondo.Controls.Add(tlpTitulo, 1, 0);
            tlpFondo.Controls.Add(tableLayoutPanel1, 1, 1);
            tlpFondo.Dock = DockStyle.Fill;
            tlpFondo.Location = new Point(0, 33);
            tlpFondo.Name = "tlpFondo";
            tlpFondo.RowCount = 3;
            tlpFondo.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3873243F));
            tlpFondo.RowStyles.Add(new RowStyle(SizeType.Percent, 89.61268F));
            tlpFondo.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpFondo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFondo.Size = new Size(578, 595);
            tlpFondo.TabIndex = 2;
            // 
            // tlpTitulo
            // 
            tlpTitulo.ColumnCount = 3;
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.ColumnStyles.Add(new ColumnStyle());
            tlpTitulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTitulo.Controls.Add(lblTitulo, 1, 0);
            tlpTitulo.Dock = DockStyle.Fill;
            tlpTitulo.Location = new Point(33, 3);
            tlpTitulo.Name = "tlpTitulo";
            tlpTitulo.RowCount = 1;
            tlpTitulo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTitulo.Size = new Size(512, 52);
            tlpTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Navy;
            lblTitulo.Location = new Point(209, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(94, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.9093883F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94.17799F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.91262126F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(33, 61);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.63158F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.368421F));
            tableLayoutPanel1.Size = new Size(512, 500);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.9831924F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.01681F));
            tableLayoutPanel2.Controls.Add(lblEstado, 0, 7);
            tableLayoutPanel2.Controls.Add(lblId, 0, 0);
            tableLayoutPanel2.Controls.Add(lblNombre, 0, 1);
            tableLayoutPanel2.Controls.Add(lblApellido, 0, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 4);
            tableLayoutPanel2.Controls.Add(txtId, 1, 0);
            tableLayoutPanel2.Controls.Add(txtDescripcion, 1, 2);
            tableLayoutPanel2.Controls.Add(txtNombre, 1, 1);
            tableLayoutPanel2.Controls.Add(dtpFechaInicio, 1, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 3);
            tableLayoutPanel2.Controls.Add(dtpFechaFin, 1, 4);
            tableLayoutPanel2.Controls.Add(txtPresupuesto, 1, 5);
            tableLayoutPanel2.Controls.Add(lblPresupuesto, 0, 5);
            tableLayoutPanel2.Controls.Add(label1, 0, 6);
            tableLayoutPanel2.Controls.Add(cbEstado, 1, 6);
            tableLayoutPanel2.Controls.Add(cbEstadoProyecto, 1, 7);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(17, 23);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5000019F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5000019F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4999981F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5000019F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.499999F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(476, 367);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblEstado
            // 
            lblEstado.Anchor = AnchorStyles.Right;
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(9, 331);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(145, 20);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado de actividad:";
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(126, 12);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(80, 57);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(74, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Proyecto:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.Right;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(61, 102);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(93, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Descripción:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 192);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 4;
            label2.Text = "Fecha de fin:";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Left;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(160, 9);
            txtId.Name = "txtId";
            txtId.Size = new Size(106, 27);
            txtId.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Dock = DockStyle.Fill;
            txtDescripcion.Location = new Point(160, 93);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(313, 39);
            txtDescripcion.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(160, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 27);
            txtNombre.TabIndex = 6;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Anchor = AnchorStyles.Left;
            dtpFechaInicio.Location = new Point(160, 144);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(295, 27);
            dtpFechaInicio.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 147);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 4;
            label5.Text = "Fecha de inicio:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Anchor = AnchorStyles.Left;
            dtpFechaFin.Location = new Point(160, 189);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(295, 27);
            dtpFechaFin.TabIndex = 8;
            // 
            // txtPresupuesto
            // 
            txtPresupuesto.Anchor = AnchorStyles.Left;
            txtPresupuesto.BorderStyle = BorderStyle.FixedSingle;
            txtPresupuesto.Location = new Point(160, 234);
            txtPresupuesto.Name = "txtPresupuesto";
            txtPresupuesto.Size = new Size(179, 27);
            txtPresupuesto.TabIndex = 7;
            // 
            // lblPresupuesto
            // 
            lblPresupuesto.Anchor = AnchorStyles.Right;
            lblPresupuesto.AutoSize = true;
            lblPresupuesto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPresupuesto.Location = new Point(57, 237);
            lblPresupuesto.Name = "lblPresupuesto";
            lblPresupuesto.Size = new Size(97, 20);
            lblPresupuesto.TabIndex = 1;
            lblPresupuesto.Text = "Presupuesto:";
            lblPresupuesto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 282);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 0;
            label1.Text = "Evolución/Estado:";
            // 
            // cbEstado
            // 
            cbEstado.Anchor = AnchorStyles.Left;
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(160, 278);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(179, 28);
            cbEstado.TabIndex = 6;
            // 
            // cbEstadoProyecto
            // 
            cbEstadoProyecto.Anchor = AnchorStyles.Left;
            cbEstadoProyecto.FormattingEnabled = true;
            cbEstadoProyecto.Location = new Point(160, 327);
            cbEstadoProyecto.Name = "cbEstadoProyecto";
            cbEstadoProyecto.Size = new Size(179, 28);
            cbEstadoProyecto.TabIndex = 10;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.5054245F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.4945755F));
            tableLayoutPanel6.Controls.Add(btnCancelar, 1, 0);
            tableLayoutPanel6.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel6.Location = new Point(17, 396);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(476, 91);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.SteelBlue;
            btnCancelar.Location = new Point(241, 15);
            btnCancelar.Margin = new Padding(15);
            btnCancelar.MinimumSize = new Size(171, 41);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(220, 61);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Dock = DockStyle.Fill;
            btnGuardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.SteelBlue;
            btnGuardar.Location = new Point(15, 15);
            btnGuardar.Margin = new Padding(15);
            btnGuardar.MinimumSize = new Size(170, 41);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(196, 61);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Agregar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // FormGestionarProyecto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(578, 659);
            Controls.Add(tlpFondo);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(600, 710);
            Name = "FormGestionarProyecto";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "📁 Gestionar proyecto";
            Load += FormGestionarProyecto_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tlpFondo.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem manualDeInformaciónToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem informaciónDeSistemaToolStripMenuItem;
        private ToolStripStatusLabel tsFecha;
        private ToolStripStatusLabel tsEstado;
        private TableLayoutPanel tlpFondo;
        private TableLayoutPanel tlpTitulo;
        private Label lblTitulo;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox cbEstado;
        private Label lblEstado;
        private Label lblId;
        private Label lblNombre;
        private Label lblApellido;
        private Label label2;
        private TextBox txtId;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private DateTimePicker dtpFechaInicio;
        private Label label5;
        private DateTimePicker dtpFechaFin;
        private TextBox txtPresupuesto;
        private Label lblPresupuesto;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox cbEstadoProyecto;
    }
}