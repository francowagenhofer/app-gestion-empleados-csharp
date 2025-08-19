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
    public partial class FormDetalleReporteProyecto : Form
    {
        private ReporteProyecto reporte; 

        public FormDetalleReporteProyecto(ReporteProyecto reporteSeleccionado)
        {
            InitializeComponent();
            reporte = reporteSeleccionado;
        }

        private void FormDetalleReporteEmpleado_Load(object sender, EventArgs e)
        {
            if (reporte != null)
            {
                var lista = new List<ReporteProyecto> { reporte };

                dgvDetalleRepProyecto.DataSource = lista;

                ConfigurarEstiloGrilla(dgvDetalleRepProyecto);

                dgvDetalleRepProyecto.Columns["Id"].Visible = false;
                dgvDetalleRepProyecto.Columns["FechaGeneracion"].Visible= false;

                dgvDetalleRepProyecto.Columns["IdProyecto"].FillWeight = 5;
                dgvDetalleRepProyecto.Columns["NombreProyecto"].FillWeight = 15;
                dgvDetalleRepProyecto.Columns["Presupuesto"].FillWeight = 15;
                dgvDetalleRepProyecto.Columns["EstadoProyecto"].FillWeight = 15;
                dgvDetalleRepProyecto.Columns["AsignacionesEmpleados"].FillWeight = 15;
                dgvDetalleRepProyecto.Columns["TareasAsignadas"].FillWeight = 15;
                dgvDetalleRepProyecto.Columns["RolesAsignados"].FillWeight = 15;
                dgvDetalleRepProyecto.Columns["TiempoEstimado"].FillWeight = 15;

                dgvDetalleRepProyecto.Columns["IdProyecto"].HeaderText = "Id";
                dgvDetalleRepProyecto.Columns["NombreProyecto"].HeaderText = "Proyecto";
                dgvDetalleRepProyecto.Columns["EstadoProyecto"].HeaderText = "Estado";
                dgvDetalleRepProyecto.Columns["AsignacionesEmpleados"].HeaderText = "Empleados";
                dgvDetalleRepProyecto.Columns["TareasAsignadas"].HeaderText = "Tareas";
                dgvDetalleRepProyecto.Columns["RolesAsignados"].HeaderText = "Roles";
                dgvDetalleRepProyecto.Columns["TiempoEstimado"].HeaderText = "Tiempo Estimado";
                dgvDetalleRepProyecto.Columns["FechaGeneracion"].HeaderText = "Fecha de reporte";
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
