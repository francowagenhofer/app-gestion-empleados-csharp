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
using Dominio.Entidades;

namespace AppEscritorio_GestionDeEmpleados
{
    public partial class FormEmpleados : Form
    {
        private List<Empleado> listaEmpleados;
        private EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
        public FormEmpleados()
        {
            InitializeComponent();
        }
        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            ConfigurarEstiloGrilla();
            CargarEmpleados();

        }

        private void CargarEmpleados()
        {
            EmpleadoNegocio negocio = new EmpleadoNegocio();
            try
            {
                listaEmpleados = negocio.ListarEmpleados();
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ocultarColumnas()
        {
            // Ocultar columnas
            dgvEmpleados.Columns["Id"].Visible = false;
            dgvEmpleados.Columns["FechaIngreso"].Visible = false;
            dgvEmpleados.Columns["FechaNacimiento"].Visible = false;
            dgvEmpleados.Columns["DNI"].Visible = true;
            dgvEmpleados.Columns["Imagen"].Visible = false;
            dgvEmpleados.Columns["MontoSalario"].Visible = false;
            dgvEmpleados.Columns["Categoria"].Visible = false;
            dgvEmpleados.Columns["Salario"].Visible = false;

            // Modificar texto de columnas
            dgvEmpleados.Columns["FechaIngreso"].HeaderText = "Ingreso";
            dgvEmpleados.Columns["NombreCategoria"].HeaderText = "Categoría";
            dgvEmpleados.Columns["MontoSalario"].HeaderText = "Salario";
            dgvEmpleados.Columns["IsActive"].HeaderText = "Activo";
        }

        private void ConfigurarEstiloGrilla()
        {
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.ReadOnly = true;

            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvEmpleados.AllowUserToResizeRows = false;
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;

            dgvEmpleados.BackgroundColor = SystemColors.Window;

            dgvEmpleados.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvEmpleados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvEmpleados.EnableHeadersVisualStyles = false;
        }

        private void tbFiltrar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cbActivo_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            string filtro = tbFiltro.Text.Trim().ToUpper();
            bool soloActivos = cbActivo.Checked;

            var listaFiltrada = listaEmpleados;

            if (soloActivos)
                listaFiltrada = listaFiltrada.Where(e => e.IsActive).ToList();

            if (filtro.Length >= 1)
            {
                listaFiltrada = listaFiltrada.Where(x =>
                    x.Nombre.ToUpper().Contains(filtro) ||
                    x.Apellido.ToUpper().Contains(filtro) ||
                    x.NombreCategoria.ToUpper().Contains(filtro) ||
                    x.DNI.ToUpper().Contains(filtro)
                ).ToList();
            }

            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = listaFiltrada;
            ocultarColumnas();
        }
        
        private Empleado ObtenerEmpleadoSeleccionado()
        {
            if (dgvEmpleados.CurrentRow != null)
                return dgvEmpleados.CurrentRow.DataBoundItem as Empleado;
            else
                return null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formGestionar = new FormGestionarEmpleado(ModoFormulario.Agregar);
            if (formGestionar.ShowDialog() == DialogResult.OK)
                CargarEmpleados();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Empleado seleccionado = ObtenerEmpleadoSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado para modificar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var formGestionar = new FormGestionarEmpleado(ModoFormulario.Modificar, seleccionado);
            if (formGestionar.ShowDialog() == DialogResult.OK)
                CargarEmpleados();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            Empleado seleccionado = ObtenerEmpleadoSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado para ver detalle.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var formGestionar = new FormGestionarEmpleado(ModoFormulario.VerDetalle, seleccionado);
            formGestionar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Empleado seleccionado = ObtenerEmpleadoSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado para eliminar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"¿Eliminar empleado {seleccionado.Nombre} {seleccionado.Apellido}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    empleadoNegocio.EliminarEmpleado(seleccionado.Id);
                    CargarEmpleados();
                }
                catch (InvalidOperationException ex) // para el error de dependencias
                {
                    MessageBox.Show(ex.Message, "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
