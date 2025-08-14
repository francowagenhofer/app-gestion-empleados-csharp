namespace AppEscritorio_GestionDeEmpleados
{
    partial class FormGestionarTarea
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
            menuStrip1 = new MenuStrip();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblTitulo = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblID = new Label();
            lblNombre = new Label();
            lblDescripcion = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            tbEstado = new TextBox();
            lblFechaInicio = new Label();
            lblFechaFin = new Label();
            lblEstado = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnGuardar = new Button();
            btnCancelar = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 549);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(548, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(548, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(548, 525);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lblTitulo, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(57, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(432, 95);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Navy;
            lblTitulo.Location = new Point(169, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(94, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(57, 104);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel3.Size = new Size(432, 398);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel4.Controls.Add(lblID, 0, 0);
            tableLayoutPanel4.Controls.Add(lblNombre, 0, 1);
            tableLayoutPanel4.Controls.Add(lblDescripcion, 0, 2);
            tableLayoutPanel4.Controls.Add(txtId, 1, 0);
            tableLayoutPanel4.Controls.Add(txtNombre, 1, 1);
            tableLayoutPanel4.Controls.Add(txtDescripcion, 1, 2);
            tableLayoutPanel4.Controls.Add(dtpFechaInicio, 1, 3);
            tableLayoutPanel4.Controls.Add(dtpFechaFin, 1, 4);
            tableLayoutPanel4.Controls.Add(tbEstado, 1, 5);
            tableLayoutPanel4.Controls.Add(lblFechaInicio, 0, 3);
            tableLayoutPanel4.Controls.Add(lblFechaFin, 0, 4);
            tableLayoutPanel4.Controls.Add(lblEstado, 0, 5);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666718F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel4.Size = new Size(426, 327);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.Anchor = AnchorStyles.Right;
            lblID.AutoSize = true;
            lblID.Location = new Point(76, 17);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(36, 71);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.Right;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(13, 125);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(90, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Left;
            txtId.Location = new Point(109, 13);
            txtId.Name = "txtId";
            txtId.Size = new Size(128, 27);
            txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left;
            txtNombre.Location = new Point(109, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(302, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(109, 111);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(302, 48);
            txtDescripcion.TabIndex = 5;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Anchor = AnchorStyles.Left;
            dtpFechaInicio.Location = new Point(109, 175);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(302, 27);
            dtpFechaInicio.TabIndex = 6;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Anchor = AnchorStyles.Left;
            dtpFechaFin.Location = new Point(109, 229);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(302, 27);
            dtpFechaFin.TabIndex = 7;
            // 
            // tbEstado
            // 
            tbEstado.Anchor = AnchorStyles.Left;
            tbEstado.Location = new Point(109, 285);
            tbEstado.Name = "tbEstado";
            tbEstado.Size = new Size(125, 27);
            tbEstado.TabIndex = 8;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.Anchor = AnchorStyles.Right;
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(31, 169);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(72, 40);
            lblFechaInicio.TabIndex = 9;
            lblFechaInicio.Text = "Fecha de inicio:";
            // 
            // lblFechaFin
            // 
            lblFechaFin.Anchor = AnchorStyles.Right;
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(15, 223);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(88, 40);
            lblFechaFin.TabIndex = 10;
            lblFechaFin.Text = "Fecha de finalización:";
            // 
            // lblEstado
            // 
            lblEstado.Anchor = AnchorStyles.Right;
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(46, 288);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "Estado:";
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel5.Controls.Add(btnCancelar, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 336);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(426, 59);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Dock = DockStyle.Fill;
            btnGuardar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.SteelBlue;
            btnGuardar.Location = new Point(5, 5);
            btnGuardar.Margin = new Padding(5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(203, 49);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.SteelBlue;
            btnCancelar.Location = new Point(218, 5);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(203, 49);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // FormGestionarTarea
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(548, 571);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(550, 450);
            Name = "FormGestionarTarea";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "📌 Gestionar Tarea";
            Load += FormGestionarTarea_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblID;
        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnGuardar;
        private Button btnCancelar;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private TextBox tbEstado;
        private Label lblFechaInicio;
        private Label lblFechaFin;
        private Label lblEstado;
    }
}