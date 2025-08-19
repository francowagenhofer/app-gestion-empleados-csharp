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
using Dominio.ReglasDelNegocio;

namespace AppEscritorio_GestionDeEmpleados
{
    public partial class FormTareas : Form
    {
        private TareasNegocio tareasNegocio = new TareasNegocio();
        private List<Tareas> listaTareas;
        public FormTareas()
        {
            InitializeComponent();
        }
        private void FormTareas_Load(object sender, EventArgs e)
        {
            tsFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString();
            ConfigurarEstiloGrilla();
            CargarTareas();

        }

        private void CargarTareas()
        {
            try
            {
                listaTareas = tareasNegocio.ListarTodasLasTareas();
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ConfigurarEstiloGrilla()
        {
            dgvTareas.RowHeadersVisible = false;
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.MultiSelect = false;
            dgvTareas.ReadOnly = true;

            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTareas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvTareas.AllowUserToResizeRows = false;
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.AllowUserToDeleteRows = false;

            dgvTareas.BackgroundColor = SystemColors.Window;

            dgvTareas.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTareas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvTareas.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvTareas.EnableHeadersVisualStyles = false;
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
            string filtro = tbFiltro.Text.Trim();
            var listaFiltrada = listaTareas;

            if (!string.IsNullOrEmpty(filtro))
            {
                int idFiltro;
                bool esNumero = int.TryParse(filtro, out idFiltro);

                if (esNumero)
                {
                    // Si es número, filtro por Id o por Nombre que contenga el texto
                    listaFiltrada = listaFiltrada
                        .Where(t => t.Id == idFiltro ||
                                    (t.Nombre != null && t.Nombre.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0))
                        .ToList();
                }
                else
                {
                    // Si no es número, filtro solo por Nombre
                    listaFiltrada = listaFiltrada
                        .Where(t => t.Nombre != null && t.Nombre.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();
                }
            }

            dgvTareas.DataSource = null;
            dgvTareas.DataSource = listaFiltrada;

            dgvTareas.Columns["Id"].FillWeight = 5;
            dgvTareas.Columns["Nombre"].FillWeight = 20;
            dgvTareas.Columns["Descripcion"].FillWeight = 30;
            dgvTareas.Columns["FechaInicio"].FillWeight = 15;
            dgvTareas.Columns["FechaFin"].FillWeight = 15;
            dgvTareas.Columns["Estado"].FillWeight = 15;

            dgvTareas.Columns["Id"].Visible = true;
            dgvTareas.Columns["IdTareaProyecto"].Visible = false;
            dgvTareas.Columns["FechaAsignacion"].Visible = false;

            dgvTareas.Columns["Nombre"].HeaderText = "Tarea";
        }

        private Tareas ObtenerTareaSeleccionada()
        {
            if (dgvTareas.CurrentRow != null)
                return dgvTareas.CurrentRow.DataBoundItem as Tareas;
            else
                return null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formGestionar = new FormGestionarTarea(ModoFormulario.Agregar);
            if (formGestionar.ShowDialog() == DialogResult.OK)
                CargarTareas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var seleccionado = ObtenerTareaSeleccionada();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione una tarea para modificar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var formGestionar = new FormGestionarTarea(ModoFormulario.Modificar, seleccionado);
            if (formGestionar.ShowDialog() == DialogResult.OK)
                CargarTareas();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            var seleccionado = ObtenerTareaSeleccionada();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione una tarea para ver detalle.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var formGestionar = new FormGestionarTarea(ModoFormulario.VerDetalle, seleccionado);
            formGestionar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seleccionado = ObtenerTareaSeleccionada();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione una tarea para eliminar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"¿Eliminar tarea {seleccionado.Nombre}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    tareasNegocio.EliminarTarea(seleccionado.Id);
                    CargarTareas();
                }
                catch (InvalidOperationException ex)
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

        private void btnAsignacion_Click(object sender, EventArgs e)
        {

        }
    }
}
