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
using Negocio;
using Dominio.Entidades.Dominio.Entidades;
using Dominio.Entidades;
using AppEscritorio_GestionDeEmpleados;

namespace AppEscritorio_GestionDeEmpleados
{
    public partial class FormReportes : Form
    {
        private ReportesNegocio reportesNegocio = new ReportesNegocio();
        private EmpleadoNegocio negocioEmpleados = new EmpleadoNegocio();
        private ProyectosNegocio negocioProyectos = new ProyectosNegocio();

        private List<ReporteEmpleado> listaRepEmpleados;
        private List<ReporteProyecto> listaRepProyectos;
        private List<ReporteFinanzas> listaRepFinanzas;
        private List<Empleado> listaEmpleados;
        private List<Proyectos> listaProyectos;

        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            tsFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString();

            ConfigurarEstiloGrilla(dgvReporteEmpleados);
            ConfigurarEstiloGrilla(dgvReporteProyectos);
            ConfigurarEstiloGrilla(dgvReporteFinanzas);
            ConfigurarEstiloGrilla(dgvEmpleado);
            ConfigurarEstiloGrilla(dgvProyecto);

            CargarReporteEmpleados();
            CargarReporteProyectos();
            CargarReporteFinanzas();
            CargarListaEmpleados();
            CargarListaProyectos();
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

        // ******* Reporte Empleados ********** //

        private void EstiloColumnasFiltroEmpleado()
        {
            dgvEmpleado.Columns["Id"].HeaderText = "ID";
            dgvEmpleado.Columns["Nombre"].HeaderText = "Nombre";
            dgvEmpleado.Columns["Apellido"].HeaderText = "Apellido";
            dgvEmpleado.Columns["NombreCategoria"].HeaderText = "Categoría";

            dgvEmpleado.Columns["Id"].FillWeight = 10;
            dgvEmpleado.Columns["Nombre"].FillWeight = 30;
            dgvEmpleado.Columns["Apellido"].FillWeight = 30;
            dgvEmpleado.Columns["NombreCategoria"].FillWeight = 30;

            dgvEmpleado.Columns["Id"].Visible = false;
            dgvEmpleado.Columns["IsActive"].Visible = false;
            dgvEmpleado.Columns["FechaNacimiento"].Visible = false;
            dgvEmpleado.Columns["DNI"].Visible = false;
            dgvEmpleado.Columns["Imagen"].Visible = false;
            dgvEmpleado.Columns["FechaIngreso"].Visible = false;
            dgvEmpleado.Columns["MontoSalario"].Visible = false;
            dgvEmpleado.Columns["Salario"].Visible = false;
            dgvEmpleado.Columns["Categoria"].Visible = false;
        }

        private void CargarListaEmpleados()
        {
            listaEmpleados = negocioEmpleados.ListarEmpleados();
            dgvEmpleado.DataSource = listaEmpleados;

            EstiloColumnasFiltroEmpleado();
        }

        private void CargarReporteEmpleados()
        {
            try
            {
                listaRepEmpleados = reportesNegocio.ObtenerReportesEmpleados();
                AplicarFiltrosRepEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFiltrarRepEmpleado_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltrosRepEmpleados();
        }

        private void txtFiltrarEmpleado_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltrarEmpleado.Text.Trim();
            var listaFiltrada = listaEmpleados;

            if (!string.IsNullOrEmpty(filtro))
                listaFiltrada = listaFiltrada
                    .Where(x => x.Nombre.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

            dgvEmpleado.DataSource = null;
            dgvEmpleado.DataSource = listaFiltrada;

            EstiloColumnasFiltroEmpleado();
        }

        private void AplicarFiltrosRepEmpleados()
        {
            string filtro = txtFiltrarRepEmpleado.Text.Trim();
            var listaFiltrada = listaRepEmpleados;

            if (!string.IsNullOrEmpty(filtro))
            {
                listaFiltrada = listaFiltrada
                    .Where(r =>
                        r.NombreEmpleado != null &&
                        r.NombreEmpleado.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0
                    )
                    .ToList();
            }

            dgvReporteEmpleados.DataSource = null;
            dgvReporteEmpleados.DataSource = listaFiltrada;

            dgvReporteEmpleados.Columns["Id"].Visible = true;
            dgvReporteEmpleados.Columns["IdEmpleado"].Visible = false;
            dgvReporteEmpleados.Columns["TareasAsignadas"].Visible = false;
            dgvReporteEmpleados.Columns["SalarioActual"].Visible = false;
            dgvReporteEmpleados.Columns["TotalBonos"].Visible = false;
            dgvReporteEmpleados.Columns["ProyectosAsignados"].Visible = false;
            dgvReporteEmpleados.Columns["RolesAsignados"].Visible = false;

            dgvReporteEmpleados.Columns["Id"].FillWeight = 10;
            dgvReporteEmpleados.Columns["NombreEmpleado"].FillWeight = 40;
            dgvReporteEmpleados.Columns["Categoria"].FillWeight = 25;
            dgvReporteEmpleados.Columns["FechaGeneracion"].FillWeight = 25;

            dgvReporteEmpleados.Columns["NombreEmpleado"].HeaderText = "Empleado";
            //dgvReporteEmpleados.Columns["FechaGeneracion"].HeaderText = "Fecha de reporte";
            dgvReporteEmpleados.Columns["FechaGeneracion"].HeaderText = "Fecha";

        }

        private ReporteEmpleado ObtenerRepEmpleadoSeleccionado()
        {
            return dgvReporteEmpleados.CurrentRow?.DataBoundItem as ReporteEmpleado;
        }

        private void btnAgregarRepEempleado_Click(object sender, EventArgs e)
        {
            var seleccionado = dgvEmpleado.CurrentRow?.DataBoundItem as Empleado;
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado para generar el reporte.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var reporte = new ReporteEmpleado
            {
                IdEmpleado = seleccionado.Id
            };

            reportesNegocio.GenerarReporteEmpleados(reporte);
            CargarReporteEmpleados();
        }

        private void btnVerDetalleRepEmpleado_Click(object sender, EventArgs e)
        {
            var seleccionado = ObtenerRepEmpleadoSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("seleccione un reporte.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var form = new FormDetalleReporteEmpleado(seleccionado);
            form.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seleccionado = ObtenerRepEmpleadoSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un reporte.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"¿Eliminar reporte {seleccionado.Id}?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    reportesNegocio.EliminarReporteEmpleados(seleccionado.Id);
                    CargarReporteEmpleados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        // ******* Reporte Proyectos ********** //
       
        private void EstiloColumnasFiltroProyecto()
        {
            dgvProyecto.Columns["Id"].HeaderText = "ID";
            dgvProyecto.Columns["Id"].FillWeight = 20;
            dgvProyecto.Columns["Nombre"].HeaderText = "Proyecto";
            dgvProyecto.Columns["Nombre"].FillWeight = 40;
            dgvProyecto.Columns["EstadoProyecto"].HeaderText = "Estado";
            dgvProyecto.Columns["EstadoProyecto"].FillWeight = 40;

            dgvProyecto.Columns["Id"].Visible = false;
            dgvProyecto.Columns["IsActive"].Visible = false;
            dgvProyecto.Columns["Descripcion"].Visible = false;
            dgvProyecto.Columns["FechaInicio"].Visible = false;
            dgvProyecto.Columns["FechaFin"].Visible = false;
            dgvProyecto.Columns["Presupuesto"].Visible = false;
        }

        private void CargarListaProyectos()
        {
            listaProyectos = negocioProyectos.ListarProyectos();
            dgvProyecto.DataSource = listaProyectos;

            EstiloColumnasFiltroProyecto();
        }
     
        private void CargarReporteProyectos()
        {
            try
            {
                listaRepProyectos = reportesNegocio.ObtenerReportesProyectos();
                AplicarFiltrosRepProyectos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFiltrarRepProyectos_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltrosRepProyectos();
        }

        private void txtFiltrarProyecto_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltrarProyecto.Text.Trim();
            var listaFiltrada = listaProyectos;

            if (!string.IsNullOrEmpty(filtro))
                listaFiltrada = listaFiltrada
                    .Where(x => x.Nombre.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

            dgvProyecto.DataSource = null;
            dgvProyecto.DataSource = listaFiltrada;

            EstiloColumnasFiltroProyecto();
        }
     
        private void AplicarFiltrosRepProyectos()
        {
            string filtro = txtFiltrarRepProyectos.Text.Trim();
            var listaFiltrada = listaRepProyectos;

            if (!string.IsNullOrEmpty(filtro))
            {
                listaFiltrada = listaFiltrada
                    .Where(r =>
                        r.NombreProyecto != null &&
                        r.NombreProyecto.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0
                    )
                    .ToList();
            }

            dgvReporteProyectos.DataSource = null;
            dgvReporteProyectos.DataSource = listaFiltrada;

            // Configuración de columnas
            dgvReporteProyectos.Columns["Id"].Visible = true;
            dgvReporteProyectos.Columns["IdProyecto"].Visible = false;
            dgvReporteProyectos.Columns["Presupuesto"].Visible = false;
            dgvReporteProyectos.Columns["AsignacionesEmpleados"].Visible = false;
            dgvReporteProyectos.Columns["TareasAsignadas"].Visible = false;
            dgvReporteProyectos.Columns["TiempoEstimado"].Visible = false;
            dgvReporteProyectos.Columns["RolesAsignados"].Visible = false;

            dgvReporteProyectos.Columns["Id"].FillWeight = 10;
            dgvReporteProyectos.Columns["NombreProyecto"].FillWeight = 30;
            dgvReporteProyectos.Columns["EstadoProyecto"].FillWeight = 30;
            dgvReporteProyectos.Columns["FechaGeneracion"].FillWeight = 30;

            dgvReporteProyectos.Columns["Id"].HeaderText = "Id";
            dgvReporteProyectos.Columns["NombreProyecto"].HeaderText = "Proyecto";
            dgvReporteProyectos.Columns["Presupuesto"].HeaderText = "Presupuesto";
            dgvReporteProyectos.Columns["EstadoProyecto"].HeaderText = "Estado";
            dgvReporteProyectos.Columns["AsignacionesEmpleados"].HeaderText = "Empleados";
            dgvReporteProyectos.Columns["TareasAsignadas"].HeaderText = "Tareas";
            dgvReporteProyectos.Columns["RolesAsignados"].HeaderText = "Roles";
            dgvReporteProyectos.Columns["TiempoEstimado"].HeaderText = "Tiempo Estimado";
            //dgvReporteProyectos.Columns["FechaGeneracion"].HeaderText = "Fecha de reporte";
            dgvReporteProyectos.Columns["FechaGeneracion"].HeaderText = "Fecha";

        }

        private ReporteProyecto ObtenerRepProyectoSeleccionado()
        {
            return dgvReporteProyectos.CurrentRow?.DataBoundItem as ReporteProyecto;
        }

        private void btnAgregarRepProyectos_Click(object sender, EventArgs e)
        {
            var seleccionado = dgvProyecto.CurrentRow?.DataBoundItem as Proyectos;
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un proyecto para generar el reporte.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var reporte = new ReporteProyecto
            {
                IdProyecto = seleccionado.Id
            };

            reportesNegocio.GenerarReporteProyectos(reporte);
            CargarReporteProyectos();
        }


        private void btnVerDetalleRepProyectos_Click(object sender, EventArgs e)
        {
            var seleccionado = ObtenerRepProyectoSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un reporte.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var form = new FormDetalleReporteProyecto(seleccionado);
            form.ShowDialog();
        }

        private void btnEliminarRepProyectos_Click(object sender, EventArgs e)
        {
            var seleccionado = ObtenerRepProyectoSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un reporte.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"¿Eliminar reporte {seleccionado.Id}?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    reportesNegocio.EliminarReporteProyectos(seleccionado.Id);
                    CargarReporteProyectos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        // ******* Reporte Finanzas ********** //

        private void CargarReporteFinanzas()
        {
            try
            {
                listaRepFinanzas = reportesNegocio.ObtenerReportesFinanzas();
                AplicarFiltrosRepFinanzas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFiltrarRepFinanzas_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltrosRepFinanzas();
        }

        private void AplicarFiltrosRepFinanzas()
        {
            string filtro = txtFiltrarRepFinanzas.Text.Trim();
            var listaFiltrada = listaRepFinanzas;

            if (!string.IsNullOrEmpty(filtro))
            {
                listaFiltrada = listaFiltrada
                    .Where(r =>
                        r.FechaGeneracion.ToString("dd/MM/yyyy").Contains(filtro)
                    )
                    .ToList();
            }

            dgvReporteFinanzas.DataSource = null;
            dgvReporteFinanzas.DataSource = listaFiltrada;

            dgvReporteFinanzas.Columns["Id"].FillWeight = 10;
            dgvReporteFinanzas.Columns["Id"].Visible = true;
            dgvReporteFinanzas.Columns["TotalSalarios"].FillWeight = 18;
            dgvReporteFinanzas.Columns["TotalSalarios"].Visible = true;
            dgvReporteFinanzas.Columns["TotalBonos"].FillWeight = 18;
            dgvReporteFinanzas.Columns["TotalBonos"].Visible = true;
            dgvReporteFinanzas.Columns["TotalPresupuestosProyectos"].FillWeight = 18;
            dgvReporteFinanzas.Columns["TotalGastos"].FillWeight = 18;
            dgvReporteFinanzas.Columns["FechaGeneracion"].FillWeight = 18;
            dgvReporteFinanzas.Columns["Id"].HeaderText = "ID";
            dgvReporteFinanzas.Columns["TotalSalarios"].HeaderText = "Salarios";
            dgvReporteFinanzas.Columns["TotalBonos"].HeaderText = "Bonos";
            dgvReporteFinanzas.Columns["TotalPresupuestosProyectos"].HeaderText = "Presupuestos";
            dgvReporteFinanzas.Columns["TotalGastos"].HeaderText = "Gastos totales";
            dgvReporteFinanzas.Columns["FechaGeneracion"].HeaderText = "Fecha";
        }

        private ReporteFinanzas ObtenerRepFinanzaSeleccionado()
        {
            return dgvReporteFinanzas.CurrentRow?.DataBoundItem as ReporteFinanzas;
        }

        private void btnAgregarRepFinanzas_Click(object sender, EventArgs e)
        {
            var reporte = new ReporteFinanzas();
            reportesNegocio.GenerarReporteFinanzas(reporte);
            CargarReporteFinanzas();
        }

        private void btnEliminarRepFinanzas_Click(object sender, EventArgs e)
        {
            var seleccionado = ObtenerRepFinanzaSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un reporte.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"¿Eliminar reporte de ID nro: {seleccionado.Id}?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    reportesNegocio.EliminarReporteFinanzas(seleccionado.Id);
                    CargarReporteFinanzas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }


        // ******************* //

        private void CerrarFormulario(object sender, EventArgs e)
        {
            Close();
        }

    }
}