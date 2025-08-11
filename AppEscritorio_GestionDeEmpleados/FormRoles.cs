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
    public partial class FormRoles : Form
    {
        private RolNegocio rolNegocio = new RolNegocio();
        private List<Rol> listaRoles;
        public FormRoles()
        {
            InitializeComponent();
        }
        private void FormRoles_Load(object sender, EventArgs e)
        {
            tsFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString();
            ConfigurarEstiloGrilla();
            CargarRoles();

        }

        private void CargarRoles()
        {
            try
            {
                listaRoles = rolNegocio.ListarRoles();
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConfigurarEstiloGrilla()
        {
            dgvRoles.RowHeadersVisible = false;
            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.MultiSelect = false;
            dgvRoles.ReadOnly = true;

            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvRoles.AllowUserToResizeRows = false;
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.AllowUserToDeleteRows = false;

            dgvRoles.BackgroundColor = SystemColors.Window;

            dgvRoles.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvRoles.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvRoles.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvRoles.EnableHeadersVisualStyles = false;
        }

        private void tbFiltrar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            string filtro = tbFiltro.Text.Trim();
            var listaFiltrada = listaRoles;

            if (!string.IsNullOrEmpty(filtro))
            {
                int idFiltro;
                bool esNumero = int.TryParse(filtro, out idFiltro);

                if (esNumero)
                {
                    listaFiltrada = listaFiltrada
                        .Where(r => r.Id == idFiltro ||
                                    (r.Nombre != null && r.Nombre.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0) ||
                                    (r.Descripcion != null && r.Descripcion.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0))
                        .ToList();
                }
                else
                {
                    listaFiltrada = listaFiltrada
                        .Where(r => (r.Nombre != null && r.Nombre.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0) ||
                                    (r.Descripcion != null && r.Descripcion.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0))
                        .ToList();
                }
            }

            dgvRoles.DataSource = null;
            dgvRoles.DataSource = listaFiltrada;

            dgvRoles.Columns["Id"].FillWeight = 10;
            dgvRoles.Columns["Nombre"].FillWeight = 20;
            dgvRoles.Columns["Descripcion"].FillWeight = 70;

            // Ocultar o modificar columnas si querés
            dgvRoles.Columns["Id"].Visible = true;

            dgvRoles.Columns["Nombre"].HeaderText = "Rol";

        }

        private Rol ObtenerRolSeleccionado()
        {
            if (dgvRoles.CurrentRow != null)
                return dgvRoles.CurrentRow.DataBoundItem as Rol;
            else
                return null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formGestionarRol = new FormGestionarRol(ModoFormulario.Agregar);
            if (formGestionarRol.ShowDialog() == DialogResult.OK)
                CargarRoles();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Rol seleccionado = ObtenerRolSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un rol para modificar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var formGestionarRol = new FormGestionarRol(ModoFormulario.Modificar, seleccionado);
            if (formGestionarRol.ShowDialog() == DialogResult.OK)
                CargarRoles();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            Rol seleccionado = ObtenerRolSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un rol para ver detalle.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var formGestionarRol = new FormGestionarRol(ModoFormulario.VerDetalle, seleccionado);
            formGestionarRol.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Rol seleccionado = ObtenerRolSeleccionado();
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un rol para eliminar.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"¿Eliminar rol {seleccionado.Nombre}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    rolNegocio.EliminarRol(seleccionado.Id);
                    CargarRoles();
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

    }
}
