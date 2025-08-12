using Dominio.ReglasDelNegocio;
using Negocio;
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
    public partial class FormOperaciones : Form
    {
        private List<CategoriaConSalario> listaCategorias;
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        public FormOperaciones()
        {
            InitializeComponent();
        }

        private void FormOperaciones_Load(object sender, EventArgs e)
        {
            tsFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString();

            ConfigurarEstiloGrilla();
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
                listaCategorias = categoriaNegocio.ListarCategoriasConSalario();
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        private void ConfigurarEstiloGrilla()
        {
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.MultiSelect = false;
            dgvCategorias.ReadOnly = true;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.BackgroundColor = SystemColors.Window;

            dgvCategorias.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvCategorias.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCategorias.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvCategorias.EnableHeadersVisualStyles = false;
        }

        private void AplicarFiltros()
        {
            string filtro = txtFiltroCategoria.Text.Trim().ToUpper();
            var listaFiltrada = listaCategorias;

            if (!string.IsNullOrEmpty(filtro))
            {
                listaFiltrada = listaFiltrada.Where(c =>
                    (c.Nombre != null && c.Nombre.ToUpper().Contains(filtro)) ||
                    (c.Descripcion != null && c.Descripcion.ToUpper().Contains(filtro)) ||
                    c.Id.ToString().Contains(filtro) ||
                    c.Salario.ToString("0.##").Contains(filtro)
                ).ToList();
            }

            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = listaFiltrada;

            if (dgvCategorias.Columns.Contains("Id"))
                dgvCategorias.Columns["Id"].Visible = true;
            if (dgvCategorias.Columns.Contains("IdSalario"))
                dgvCategorias.Columns["IdSalario"].Visible = false;

            dgvCategorias.Columns["Id"].FillWeight = 5;
            dgvCategorias.Columns["Nombre"].FillWeight = 20;
            dgvCategorias.Columns["Descripcion"].FillWeight = 55;
            dgvCategorias.Columns["Salario"].FillWeight = 20;
        }

        private CategoriaConSalario ObtenerCategoriaSeleccionada()
        {
            return dgvCategorias.CurrentRow?.DataBoundItem as CategoriaConSalario;
        }

        private void txtFiltroCategoria_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            var formGestionar = new FormGestionarCategoriasYSalarios(ModoFormulario.Agregar);
            if (formGestionar.ShowDialog() == DialogResult.OK)
                CargarCategorias();
        }
        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            var seleccionada = ObtenerCategoriaSeleccionada();
            if (seleccionada == null)
            {
                MessageBox.Show("Seleccione una categoría para modificar.");
                return;
            }

            var formGestionar = new FormGestionarCategoriasYSalarios(ModoFormulario.Modificar, seleccionada);
            if (formGestionar.ShowDialog() == DialogResult.OK)
                CargarCategorias();
        }

        private void btnVerDetalleCategoria_Click(object sender, EventArgs e)
        {
            var seleccionada = ObtenerCategoriaSeleccionada();
            if (seleccionada == null)
            {
                MessageBox.Show("Seleccione una categoría para ver detalle.");
                return;
            }

            var formGestionar = new FormGestionarCategoriasYSalarios(ModoFormulario.VerDetalle, seleccionada);
            formGestionar.ShowDialog();
        }


        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            var seleccionada = ObtenerCategoriaSeleccionada();
            if (seleccionada == null)
            {
                MessageBox.Show("Seleccione una categoría para eliminar.");
                return;
            }

            if (MessageBox.Show($"¿Eliminar categoría '{seleccionada.Nombre}'?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    categoriaNegocio.EliminarCategoria(seleccionada.Id);
                    CargarCategorias();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void btnSalirCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
