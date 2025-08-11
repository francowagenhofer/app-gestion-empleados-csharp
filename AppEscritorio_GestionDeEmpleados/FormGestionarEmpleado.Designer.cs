namespace AppEscritorio_GestionDeEmpleados
{
    partial class FormGestionarEmpleado
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
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            tableLayoutPanel8 = new TableLayoutPanel();
            tbUrlImagen = new TextBox();
            lblFoto = new Label();
            pbImagen = new PictureBox();
            btnBuscarImagen = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            cbEstado = new ComboBox();
            lblEstado = new Label();
            lblId = new Label();
            lblSalario = new Label();
            lblNombre = new Label();
            label1 = new Label();
            lblApellido = new Label();
            label2 = new Label();
            lblDNI = new Label();
            txtId = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            label5 = new Label();
            cbCategoria = new ComboBox();
            txtSalario = new TextBox();
            dtpFechaIngreso = new DateTimePicker();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            tlpFondo.SuspendLayout();
            tlpTitulo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            statusStrip1.Size = new Size(1008, 31);
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
            tlpFondo.MinimumSize = new Size(862, 489);
            tlpFondo.Name = "tlpFondo";
            tlpFondo.RowCount = 3;
            tlpFondo.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3873243F));
            tlpFondo.RowStyles.Add(new RowStyle(SizeType.Percent, 89.61268F));
            tlpFondo.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpFondo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFondo.Size = new Size(1008, 595);
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
            tlpTitulo.Size = new Size(942, 52);
            tlpTitulo.TabIndex = 0;
            tlpTitulo.Paint += tlpTitulo_Paint;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Navy;
            lblTitulo.Location = new Point(424, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(94, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.56213F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.43787F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(33, 61);
            tableLayoutPanel1.MinimumSize = new Size(796, 375);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 442F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(942, 500);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(432, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 99.99999F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(501, 494);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.Padding = new Padding(3);
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 67.42268F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 1.64948452F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 30.72165F));
            tableLayoutPanel7.Size = new Size(495, 488);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.2440948F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.7559052F));
            tableLayoutPanel6.Controls.Add(btnCancelar, 1, 0);
            tableLayoutPanel6.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(6, 338);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(483, 144);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.SteelBlue;
            btnCancelar.Location = new Point(258, 30);
            btnCancelar.Margin = new Padding(30);
            btnCancelar.MinimumSize = new Size(171, 41);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(195, 84);
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
            btnGuardar.Location = new Point(30, 30);
            btnGuardar.Margin = new Padding(30);
            btnGuardar.MinimumSize = new Size(170, 41);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 84);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Agregar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.756757F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.15315F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.8648653F));
            tableLayoutPanel8.Controls.Add(tbUrlImagen, 1, 2);
            tableLayoutPanel8.Controls.Add(lblFoto, 1, 0);
            tableLayoutPanel8.Controls.Add(pbImagen, 1, 1);
            tableLayoutPanel8.Controls.Add(btnBuscarImagen, 2, 2);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(6, 6);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 242F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel8.Size = new Size(483, 319);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // tbUrlImagen
            // 
            tbUrlImagen.BorderStyle = BorderStyle.FixedSingle;
            tbUrlImagen.Dock = DockStyle.Fill;
            tbUrlImagen.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUrlImagen.Location = new Point(35, 287);
            tbUrlImagen.Name = "tbUrlImagen";
            tbUrlImagen.PlaceholderText = "Insertar URL Imagen";
            tbUrlImagen.Size = new Size(372, 31);
            tbUrlImagen.TabIndex = 0;
            tbUrlImagen.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Dock = DockStyle.Fill;
            lblFoto.FlatStyle = FlatStyle.Flat;
            lblFoto.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoto.ForeColor = Color.Navy;
            lblFoto.Location = new Point(32, 0);
            lblFoto.Margin = new Padding(0);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(378, 42);
            lblFoto.TabIndex = 0;
            lblFoto.Text = "Imagen de Perfil";
            lblFoto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbImagen
            // 
            pbImagen.BorderStyle = BorderStyle.FixedSingle;
            pbImagen.Dock = DockStyle.Fill;
            pbImagen.Location = new Point(35, 45);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(372, 236);
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagen.TabIndex = 1;
            pbImagen.TabStop = false;
            // 
            // btnBuscarImagen
            // 
            btnBuscarImagen.Dock = DockStyle.Fill;
            btnBuscarImagen.Location = new Point(410, 284);
            btnBuscarImagen.Margin = new Padding(0, 0, 3, 0);
            btnBuscarImagen.Name = "btnBuscarImagen";
            btnBuscarImagen.Size = new Size(70, 35);
            btnBuscarImagen.TabIndex = 1;
            btnBuscarImagen.Text = "+";
            btnBuscarImagen.UseVisualStyleBackColor = true;
            btnBuscarImagen.Click += btnBuscarImagen_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Left;
            tableLayoutPanel5.Location = new Point(8, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(418, 494);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.1738243F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.82618F));
            tableLayoutPanel2.Controls.Add(cbEstado, 1, 8);
            tableLayoutPanel2.Controls.Add(lblEstado, 0, 8);
            tableLayoutPanel2.Controls.Add(lblId, 0, 0);
            tableLayoutPanel2.Controls.Add(lblSalario, 0, 7);
            tableLayoutPanel2.Controls.Add(lblNombre, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 6);
            tableLayoutPanel2.Controls.Add(lblApellido, 0, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 5);
            tableLayoutPanel2.Controls.Add(lblDNI, 0, 3);
            tableLayoutPanel2.Controls.Add(txtId, 1, 0);
            tableLayoutPanel2.Controls.Add(txtApellido, 1, 2);
            tableLayoutPanel2.Controls.Add(txtDNI, 1, 3);
            tableLayoutPanel2.Controls.Add(txtNombre, 1, 1);
            tableLayoutPanel2.Controls.Add(dtpFechaNacimiento, 1, 4);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(cbCategoria, 1, 6);
            tableLayoutPanel2.Controls.Add(txtSalario, 1, 7);
            tableLayoutPanel2.Controls.Add(dtpFechaIngreso, 1, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(412, 488);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // cbEstado
            // 
            cbEstado.Anchor = AnchorStyles.Left;
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(147, 446);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(179, 28);
            cbEstado.TabIndex = 6;
            // 
            // lblEstado
            // 
            lblEstado.Anchor = AnchorStyles.Right;
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(62, 440);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(79, 40);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado de actividad:";
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(113, 17);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblSalario
            // 
            lblSalario.Anchor = AnchorStyles.Right;
            lblSalario.AutoSize = true;
            lblSalario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalario.Location = new Point(81, 395);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(60, 20);
            lblSalario.TabIndex = 1;
            lblSalario.Text = "Salario:";
            lblSalario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(71, 71);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(70, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 341);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Categoría:";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.Right;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(71, 125);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(70, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 287);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 4;
            label2.Text = "Fecha de ingreso:";
            // 
            // lblDNI
            // 
            lblDNI.Anchor = AnchorStyles.Right;
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDNI.Location = new Point(101, 179);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(40, 20);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI:";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Left;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(147, 13);
            txtId.Name = "txtId";
            txtId.Size = new Size(106, 27);
            txtId.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Left;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Location = new Point(147, 121);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(175, 27);
            txtApellido.TabIndex = 7;
            // 
            // txtDNI
            // 
            txtDNI.Anchor = AnchorStyles.Left;
            txtDNI.BorderStyle = BorderStyle.FixedSingle;
            txtDNI.Location = new Point(147, 175);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(175, 27);
            txtDNI.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(147, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 27);
            txtNombre.TabIndex = 6;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Anchor = AnchorStyles.Left;
            dtpFechaNacimiento.Location = new Point(147, 229);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(262, 27);
            dtpFechaNacimiento.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(52, 223);
            label5.Name = "label5";
            label5.Size = new Size(89, 40);
            label5.TabIndex = 4;
            label5.Text = "Fecha de nacimiento:";
            // 
            // cbCategoria
            // 
            cbCategoria.Anchor = AnchorStyles.Left;
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(147, 337);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(179, 28);
            cbCategoria.TabIndex = 5;
            cbCategoria.SelectedIndexChanged += cbCategoria_SelectedIndexChanged;
            // 
            // txtSalario
            // 
            txtSalario.Anchor = AnchorStyles.Left;
            txtSalario.BorderStyle = BorderStyle.FixedSingle;
            txtSalario.Location = new Point(147, 391);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(179, 27);
            txtSalario.TabIndex = 7;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Anchor = AnchorStyles.Left;
            dtpFechaIngreso.Location = new Point(147, 283);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(262, 27);
            dtpFechaIngreso.TabIndex = 8;
            // 
            // FormGestionarEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1008, 659);
            Controls.Add(tlpFondo);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1030, 710);
            Name = "FormGestionarEmpleado";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "👤 Gestionar empleado";
            Load += FormGestionarEmpleado_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tlpFondo.ResumeLayout(false);
            tlpTitulo.ResumeLayout(false);
            tlpTitulo.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private TextBox tbUrlImagen;
        private Button btnBuscarImagen;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox cbEstado;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtSalario;
        private Label lblEstado;
        private Label lblId;
        private Label lblSalario;
        private Label lblNombre;
        private Label label1;
        private Label lblApellido;
        private Label label2;
        private Label lblDNI;
        private TextBox txtId;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private DateTimePicker dtpFechaNacimiento;
        private Label label5;
        private DateTimePicker dtpFechaIngreso;
        private ComboBox cbCategoria;
        private Label lblFoto;
        private PictureBox pbImagen;
        private Label label3;
    }
}