using Dominio.ReglasDelNegocio;
using Negocio;
using System.Data;

namespace AppEscritorio_GestionDeEmpleados
{
    public partial class FormOperaciones : Form
    {
        private List<CategoriaConSalario> listaCategorias;
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        private List<Bonos> listaBonos;
        private BonosNegocio bonosNegocio = new BonosNegocio();

        public FormOperaciones()
        {
            InitializeComponent();
        }

        private void FormOperaciones_Load(object sender, EventArgs e)
        {
            tsFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString();

            ConfigurarEstiloGrilla();
            CargarCategorias();

            ConfigurarEstiloGrillaBonos();
            CargarBonos();
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



        // -------------------------------------------------------------------------------------- //

        private void CargarBonos()
        {
            try
            {
                listaBonos = bonosNegocio.ListarBonos();
                AplicarFiltrosBonos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar bonos: " + ex.Message);
            }
        }

        private void AplicarFiltrosBonos()
        {
            string filtro = txtFiltrobonos.Text.Trim().ToUpper();
            var listaFiltrada = listaBonos;

            if (!string.IsNullOrEmpty(filtro))
            {
                listaFiltrada = listaFiltrada.Where(b =>
                    (b.Nombre != null && b.Nombre.ToUpper().Contains(filtro)) ||
                    b.Id.ToString().Contains(filtro) ||
                    b.Monto.ToString("0.##").Contains(filtro)
                ).ToList();
            }

            dgvBonos.DataSource = null;
            dgvBonos.DataSource = listaFiltrada;

            if (dgvBonos.Columns.Contains("Id"))
                dgvBonos.Columns["Id"].Visible = true;
            if (dgvBonos.Columns.Contains("FechaAsignacion"))
                dgvBonos.Columns["FechaAsignacion"].Visible = false;

            dgvBonos.Columns["Id"].FillWeight = 15;
            dgvBonos.Columns["Nombre"].FillWeight = 45;
            dgvBonos.Columns["Monto"].FillWeight = 40;
        }

        private void ConfigurarEstiloGrillaBonos()
        {
            dgvBonos.RowHeadersVisible = false;
            dgvBonos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBonos.MultiSelect = false;
            dgvBonos.ReadOnly = true;
            dgvBonos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBonos.AllowUserToAddRows = false;
            dgvBonos.AllowUserToDeleteRows = false;
            dgvBonos.BackgroundColor = SystemColors.Window;

            dgvBonos.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvBonos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvBonos.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvBonos.EnableHeadersVisualStyles = false;
        }

        private Bonos ObtenerBonoSeleccionado()
        {
            return dgvBonos.CurrentRow?.DataBoundItem as Bonos;
        }

        private void txtFiltrobonos_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltrosBonos();
        }

        private void btnAgregarBono_Click(object sender, EventArgs e)
        {
            var formGestionar = new FormGestionarBono(ModoFormulario.Agregar);
            if (formGestionar.ShowDialog() == DialogResult.OK)
                CargarBonos();
        }

        private void btnModificarBono_Click(object sender, EventArgs e)
        {
            var seleccionado = ObtenerBonoSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un bono para modificar.");
                return;
            }

            var formGestionar = new FormGestionarBono(ModoFormulario.Modificar, seleccionado);
            if (formGestionar.ShowDialog() == DialogResult.OK)
                CargarBonos();
        }

        private void btnVerDetalleBono_Click(object sender, EventArgs e)
        {
            var seleccionado = ObtenerBonoSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un bono para ver detalle.");
                return;
            }

            var formGestionar = new FormGestionarBono(ModoFormulario.VerDetalle, seleccionado);
            formGestionar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var seleccionado = ObtenerBonoSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un bono para eliminar.");
                return;
            }

            if (MessageBox.Show($"¿Eliminar bono '{seleccionado.Nombre}'?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bonosNegocio.EliminarBono(seleccionado.Id);
                    CargarBonos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void btnSalirBono_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
