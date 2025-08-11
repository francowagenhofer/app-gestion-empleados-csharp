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
using Dominio.Entidades.Dominio.Entidades;

namespace AppEscritorio_GestionDeEmpleados
{
    public partial class FormProyectos : Form
    {
        private List<Proyectos> listaProyectos;
        private ProyectosNegocio proyectosNegocio = new ProyectosNegocio();
        public FormProyectos()
        {
            InitializeComponent();
        }
        private void FormProyectos_Load(object sender, EventArgs e)
        {
            tsFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString();

            ConfigurarEstiloGrilla();
            CargarEmpleados();

        }

        private void CargarEmpleados()
        {
            try
            {
                listaProyectos = proyectosNegocio.ListarProyectos();
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proyectos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            bool soloActivos = cbActivo.Checked;

            var listaFiltrada = listaProyectos;

            if (soloActivos)
                listaFiltrada = listaFiltrada.Where(p => p.IsActive).ToList();

            if (!string.IsNullOrEmpty(filtro))
            {
                int idFiltro;
                bool esNumero = int.TryParse(filtro, out idFiltro);

                if (esNumero)
                {
                    listaFiltrada = listaFiltrada.Where(p =>
                        p.Id == idFiltro ||
                        (p.Nombre != null && p.Nombre.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0) ||
                        (p.Descripcion != null && p.Descripcion.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0)
                    ).ToList();
                }
                else
                {
                    listaFiltrada = listaFiltrada.Where(p =>
                        (p.Nombre != null && p.Nombre.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0) ||
                        (p.Descripcion != null && p.Descripcion.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0)
                    ).ToList();
                }
            }

            dgvProyectos.DataSource = null;
            dgvProyectos.DataSource = listaFiltrada;

            modificarColumnas();
        }

        private void modificarColumnas()
        {
            // Ajustar columnas: oculta o cambia pesos si querés
            dgvProyectos.Columns["Id"].FillWeight = 5;
            dgvProyectos.Columns["Nombre"].FillWeight = 17;
            dgvProyectos.Columns["Descripcion"].FillWeight = 38;
            dgvProyectos.Columns["Presupuesto"].FillWeight = 15;
            dgvProyectos.Columns["EstadoProyecto"].FillWeight = 15;
            dgvProyectos.Columns["IsActive"].FillWeight = 10;

            // Ocultar columnas
            dgvProyectos.Columns["Id"].Visible = true;
            dgvProyectos.Columns["FechaInicio"].Visible = false;
            dgvProyectos.Columns["FechaFin"].Visible = false;

            // Modificar texto de columnas
            dgvProyectos.Columns["IsActive"].HeaderText = "Activo";
            dgvProyectos.Columns["Nombre"].HeaderText = "Proyecto";

        }

        private void ConfigurarEstiloGrilla()
        {
            dgvProyectos.RowHeadersVisible = false;
            dgvProyectos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProyectos.MultiSelect = false;
            dgvProyectos.ReadOnly = true;

            dgvProyectos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProyectos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvProyectos.AllowUserToResizeRows = false;
            dgvProyectos.AllowUserToAddRows = false;
            dgvProyectos.AllowUserToDeleteRows = false;

            dgvProyectos.BackgroundColor = SystemColors.Window;

            dgvProyectos.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvProyectos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvProyectos.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvProyectos.EnableHeadersVisualStyles = false;
        }

        private Proyectos ObtenerProyectoSeleccionado()
        {
            if (dgvProyectos.CurrentRow != null)
                return dgvProyectos.CurrentRow.DataBoundItem as Proyectos;
            else
                return null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //var formGestionarProyecto = new FormGestionarProyecto(ModoFormulario.Agregar);
            //if (formGestionarProyecto.ShowDialog() == DialogResult.OK)
            //    CargarProyectos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        //    Proyectos seleccionado = ObtenerProyectoSeleccionado();
        //    if (seleccionado == null)
        //    {
        //        MessageBox.Show("Seleccione un proyecto para modificar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    var formGestionarProyecto = new FormGestionarProyecto(ModoFormulario.Modificar, seleccionado);
        //    if (formGestionarProyecto.ShowDialog() == DialogResult.OK)
        //        CargarProyectos();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            //Proyectos seleccionado = ObtenerProyectoSeleccionado();
            //if (seleccionado == null)
            //{
            //    MessageBox.Show("Seleccione un proyecto para ver detalle.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //var formGestionarProyecto = new FormGestionarProyecto(ModoFormulario.VerDetalle, seleccionado);
            //formGestionarProyecto.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Proyectos seleccionado = ObtenerProyectoSeleccionado();
            //if (seleccionado == null)
            //{
            //    MessageBox.Show("Seleccione un proyecto para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //if (MessageBox.Show($"¿Eliminar proyecto {seleccionado.Nombre}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    try
            //    {
            //        proyectosNegocio.EliminarProyecto(seleccionado.Id);
            //        CargarProyectos();
            //    }
            //    catch (InvalidOperationException ex)
            //    {
            //        MessageBox.Show(ex.Message, "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAsignaciones_Click(object sender, EventArgs e)
        {
        }
    }
}
