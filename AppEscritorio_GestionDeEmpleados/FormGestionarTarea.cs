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
    public partial class FormGestionarTarea : Form
    {
        private Tareas tarea;
        private ModoFormulario modo;
        private TareasNegocio tareasNegocio = new TareasNegocio();

        public FormGestionarTarea(ModoFormulario modo, Tareas tarea = null)
        {
            InitializeComponent();
            this.modo = modo;
            this.tarea = tarea;
        }

        private void FormGestionarTarea_Load(object sender, EventArgs e)
        {
            ConfigurarFormularioSegunModo();
        }

        private void ConfigurarFormularioSegunModo()
        {
            switch (modo)
            {
                case ModoFormulario.Agregar:
                    lblTitulo.Text = "Agregar Tarea";
                    this.Text = "Agregar Tarea";
                    txtId.Visible = false; // Id no se muestra al agregar
                    LimpiarCampos();
                    HabilitarCampos(true);
                    btnGuardar.Visible = true;
                    break;

                case ModoFormulario.Modificar:
                    lblTitulo.Text = "Modificar Tarea";
                    this.Text = "Modificar Tarea";
                    txtId.Visible = true;
                    CargarDatosTarea();
                    HabilitarCampos(true);
                    btnGuardar.Visible = true;
                    break;

                case ModoFormulario.VerDetalle:
                    lblTitulo.Text = "Detalle de Tarea";
                    this.Text = "Detalle de Tarea";
                    txtId.Visible = true;
                    CargarDatosTarea();
                    HabilitarCampos(false);
                    btnGuardar.Visible = false;
                    break;
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaInicio.Checked = false;
            dtpFechaFin.Value = DateTime.Now;
            dtpFechaFin.Checked = false;
            tbEstado.Text = "";
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtNombre.ReadOnly = !habilitar;
            txtDescripcion.ReadOnly = !habilitar;
            dtpFechaInicio.Enabled = habilitar;
            dtpFechaFin.Enabled = habilitar;
            tbEstado.ReadOnly = !habilitar;
            txtId.ReadOnly = true; // Id siempre readonly
        }

        private void CargarDatosTarea()
        {
            if (tarea == null) return;

            txtId.Text = tarea.Id.ToString();
            txtNombre.Text = tarea.Nombre;
            txtDescripcion.Text = tarea.Descripcion;

            if (tarea.FechaInicio.HasValue)
            {
                dtpFechaInicio.Value = tarea.FechaInicio.Value;
                dtpFechaInicio.Checked = true;
            }
            else
            {
                dtpFechaInicio.Checked = false;
            }

            if (tarea.FechaFin.HasValue)
            {
                dtpFechaFin.Value = tarea.FechaFin.Value;
                dtpFechaFin.Checked = true;
            }
            else
            {
                dtpFechaFin.Checked = false;
            }
            tbEstado.Text = tarea.Estado;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            DateTime minSqlDate = new DateTime(1753, 1, 1);

            if (dtpFechaInicio.Checked)
            {
                if (dtpFechaInicio.Value < minSqlDate)
                {
                    MessageBox.Show("La fecha de inicio debe ser igual o posterior a 01/01/1753.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpFechaInicio.Focus();
                    return false;
                }
            }

            if (dtpFechaFin.Checked)
            {
                if (dtpFechaFin.Value < minSqlDate)
                {
                    MessageBox.Show("La fecha de fin debe ser igual o posterior a 01/01/1753.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpFechaFin.Focus();
                    return false;
                }
            }

            if (dtpFechaInicio.Checked && dtpFechaFin.Checked && dtpFechaInicio.Value > dtpFechaFin.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha fin.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaInicio.Focus();
                return false;
            }

            return true;
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                if (tarea == null)
                    tarea = new Tareas();

                tarea.Nombre = txtNombre.Text.Trim();
                tarea.Descripcion = txtDescripcion.Text.Trim();

                tarea.FechaInicio = dtpFechaInicio.Checked ? dtpFechaInicio.Value.Date : (DateTime?)null;
                tarea.FechaFin = dtpFechaFin.Checked ? dtpFechaFin.Value.Date : (DateTime?)null;

                tarea.Estado = tbEstado.Text.Trim();

                if (modo == ModoFormulario.Agregar)
                {
                    tareasNegocio.AgregarTarea(tarea);
                }
                else if (modo == ModoFormulario.Modificar)
                {
                    tarea.Id = int.Parse(txtId.Text);
                    tareasNegocio.ModificarTarea(tarea);
                }

                MessageBox.Show("Tarea guardada correctamente.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
