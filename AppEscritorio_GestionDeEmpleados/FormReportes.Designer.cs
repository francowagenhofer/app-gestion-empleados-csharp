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
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblReporteEmpleado = new Label();
            tpReporteProyectos = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            tpReporteFinanzas = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            label2 = new Label();
            statusStrip1.SuspendLayout();
            tcReportes.SuspendLayout();
            tpReporteEmpleados.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tpReporteProyectos.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tpReporteFinanzas.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsFecha });
            statusStrip1.Location = new Point(0, 632);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1082, 31);
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
            tcReportes.Size = new Size(1082, 632);
            tcReportes.TabIndex = 2;
            // 
            // tpReporteEmpleados
            // 
            tpReporteEmpleados.BorderStyle = BorderStyle.Fixed3D;
            tpReporteEmpleados.Controls.Add(tableLayoutPanel2);
            tpReporteEmpleados.Location = new Point(4, 40);
            tpReporteEmpleados.Name = "tpReporteEmpleados";
            tpReporteEmpleados.Padding = new Padding(3);
            tpReporteEmpleados.Size = new Size(1074, 588);
            tpReporteEmpleados.TabIndex = 0;
            tpReporteEmpleados.Text = "Empleados";
            tpReporteEmpleados.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlLight;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel2.ForeColor = SystemColors.ControlText;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1064, 578);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblReporteEmpleado, 1, 1);
            tableLayoutPanel1.Location = new Point(23, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(1018, 90);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblReporteEmpleado
            // 
            lblReporteEmpleado.AutoSize = true;
            lblReporteEmpleado.Dock = DockStyle.Fill;
            lblReporteEmpleado.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReporteEmpleado.ForeColor = Color.Navy;
            lblReporteEmpleado.Location = new Point(353, 15);
            lblReporteEmpleado.Name = "lblReporteEmpleado";
            lblReporteEmpleado.Size = new Size(311, 60);
            lblReporteEmpleado.TabIndex = 0;
            lblReporteEmpleado.Text = "Reporte de Empleados";
            lblReporteEmpleado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tpReporteProyectos
            // 
            tpReporteProyectos.BorderStyle = BorderStyle.Fixed3D;
            tpReporteProyectos.Controls.Add(tableLayoutPanel3);
            tpReporteProyectos.Location = new Point(4, 40);
            tpReporteProyectos.Name = "tpReporteProyectos";
            tpReporteProyectos.Padding = new Padding(3);
            tpReporteProyectos.Size = new Size(1074, 588);
            tpReporteProyectos.TabIndex = 1;
            tpReporteProyectos.Text = "Proyectos";
            tpReporteProyectos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = SystemColors.ControlLight;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 92F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1064, 578);
            tableLayoutPanel3.TabIndex = 1;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label1, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel4.Location = new Point(23, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.Size = new Size(1018, 86);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(360, 14);
            label1.Name = "label1";
            label1.Size = new Size(297, 57);
            label1.TabIndex = 0;
            label1.Text = "Reporte de Proyectos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            tpReporteFinanzas.Click += tpReporteFinanzas_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = SystemColors.ControlLight;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel5.ForeColor = SystemColors.ControlText;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(1064, 578);
            tableLayoutPanel5.TabIndex = 1;
            tableLayoutPanel5.Paint += tableLayoutPanel5_Paint;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label2, 1, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(23, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.Size = new Size(1018, 90);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(368, 15);
            label2.Name = "label2";
            label2.Size = new Size(281, 60);
            label2.TabIndex = 0;
            label2.Text = "Reporte de Finanzas";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1082, 663);
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tpReporteProyectos.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tpReporteFinanzas.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lblReporteEmpleado;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label2;
    }
}