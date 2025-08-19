using Dominio.ReglasDelNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio_GestionDeEmpleados
{
    public partial class FormDetalleReporteEmpleado : Form
    {
        private ReporteEmpleado reporte;

        public FormDetalleReporteEmpleado(ReporteEmpleado reporteSeleccionado)
        {
            InitializeComponent();
            reporte = reporteSeleccionado;
        }

        private void FormDetalleReporteEmpleado_Load(object sender, EventArgs e)
        {
            if (reporte != null)
            {
                var lista = new List<ReporteEmpleado> { reporte };

                dgvDetalleRepEmpleado.DataSource = lista;

                ConfigurarEstiloGrilla(dgvDetalleRepEmpleado);

                dgvDetalleRepEmpleado.Columns["Id"].Visible = false;
                dgvDetalleRepEmpleado.Columns["FechaGeneracion"].Visible = false;

                dgvDetalleRepEmpleado.Columns["IdEmpleado"].FillWeight = 5;
                dgvDetalleRepEmpleado.Columns["NombreEmpleado"].FillWeight = 17;
                dgvDetalleRepEmpleado.Columns["Categoria"].FillWeight = 13;
                dgvDetalleRepEmpleado.Columns["SalarioActual"].FillWeight = 12;
                dgvDetalleRepEmpleado.Columns["TotalBonos"].FillWeight = 12;
                dgvDetalleRepEmpleado.Columns["ProyectosAsignados"].FillWeight = 18;
                dgvDetalleRepEmpleado.Columns["RolesAsignados"].FillWeight = 15;
                dgvDetalleRepEmpleado.Columns["TareasAsignadas"].FillWeight = 18;

                dgvDetalleRepEmpleado.Columns["Id"].HeaderText = "ID";
                dgvDetalleRepEmpleado.Columns["IdEmpleado"].HeaderText = "Id";
                dgvDetalleRepEmpleado.Columns["NombreEmpleado"].HeaderText = "Nombre";
                dgvDetalleRepEmpleado.Columns["Categoria"].HeaderText = "Categoría";
                dgvDetalleRepEmpleado.Columns["SalarioActual"].HeaderText = "Salario";
                dgvDetalleRepEmpleado.Columns["TotalBonos"].HeaderText = "Bonos";
                dgvDetalleRepEmpleado.Columns["ProyectosAsignados"].HeaderText = "Proyectos";
                dgvDetalleRepEmpleado.Columns["RolesAsignados"].HeaderText = "Roles";
                dgvDetalleRepEmpleado.Columns["TareasAsignadas"].HeaderText = "Tareas";
                dgvDetalleRepEmpleado.Columns["FechaGeneracion"].HeaderText = "Fecha de reporte";
            }
        }


        private void ConfigurarEstiloGrilla(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.BackgroundColor = SystemColors.Window;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgv.EnableHeadersVisualStyles = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
