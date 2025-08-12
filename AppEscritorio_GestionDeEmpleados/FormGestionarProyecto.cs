using Dominio.Entidades;
using Dominio.Entidades.Dominio.Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio_GestionDeEmpleados
{
    public partial class FormGestionarProyecto : Form
    {
        private Proyectos proyecto;
        private ModoFormulario modo;
        private ProyectosNegocio proyectosNegocio = new ProyectosNegocio();

        public FormGestionarProyecto(ModoFormulario modo, Proyectos proyecto = null)
        {
            InitializeComponent();
            this.modo = modo;
            this.proyecto = proyecto;
        }

        private void FormGestionarProyecto_Load(object sender, EventArgs e)
        {
            CargarEstadosProyecto();
            CargarEstadosActividad();
            ConfigurarFormularioSegunModo();


        }



        private void CargarEstadosActividad()
        {
            cbEstado.Items.Clear();
            cbEstado.Items.AddRange(new string[] { "Activo", "Inactivo" });
            cbEstado.SelectedIndex = 0;
            txtId.Enabled = false;
        }

        private void CargarEstadosProyecto()
        {
            cbEstadoProyecto.Items.Clear();
            cbEstadoProyecto.Items.AddRange(new string[] { "Pendiente", "En progreso", "Finalizado", "Cancelado" });
            cbEstadoProyecto.SelectedIndex = 0;
        }

        private void ConfigurarFormularioSegunModo()
        {
            switch (modo)
            {
                case ModoFormulario.Agregar:
                    lblTitulo.Text = "Agregar Proyecto";
                    this.Text = "Agregar Proyecto";
                    LimpiarCampos();
                    HabilitarCampos(true);
                    btnGuardar.Visible = true;
                    btnCancelar.Visible = true;
                    break;

                case ModoFormulario.Modificar:
                    lblTitulo.Text = "Modificar Proyecto";
                    this.Text = "Modificar Proyecto";
                    CargarDatosProyecto();
                    HabilitarCampos(true);
                    btnGuardar.Visible = true;
                    btnCancelar.Visible = true;
                    break;

                case ModoFormulario.VerDetalle:
                    lblTitulo.Text = "Detalle de Proyecto";
                    this.Text = "Detalle de Proyecto";
                    CargarDatosProyecto();
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
            txtPresupuesto.Text = "";
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            cbEstado.SelectedIndex = 0;
            cbEstadoProyecto.SelectedIndex = 0;
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtNombre.ReadOnly = !habilitar;
            txtDescripcion.ReadOnly = !habilitar;
            txtPresupuesto.ReadOnly = !habilitar;
            dtpFechaInicio.Enabled = habilitar;
            dtpFechaFin.Enabled = habilitar;
            cbEstado.Enabled = habilitar;
            cbEstadoProyecto.Enabled = habilitar;
            txtId.ReadOnly = true;
        }

        private void CargarDatosProyecto()
        {
            if (proyecto == null) return;

            txtId.Text = proyecto.Id.ToString();
            txtNombre.Text = proyecto.Nombre;
            txtDescripcion.Text = proyecto.Descripcion;
            txtPresupuesto.Text = proyecto.Presupuesto.ToString("N2");

            dtpFechaInicio.Value = proyecto.FechaInicio != DateTime.MinValue ? proyecto.FechaInicio : DateTime.Now;
            dtpFechaFin.Value = proyecto.FechaFin != DateTime.MinValue ? proyecto.FechaFin : DateTime.Now;

            cbEstado.SelectedIndex = proyecto.IsActive ? 0 : 1;

            if (!string.IsNullOrEmpty(proyecto.EstadoProyecto))
            {
                int idx = cbEstadoProyecto.Items.IndexOf(proyecto.EstadoProyecto);
                cbEstadoProyecto.SelectedIndex = idx >= 0 ? idx : 0;
            }
            else
            {
                cbEstadoProyecto.SelectedIndex = 0;
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del proyecto es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPresupuesto.Text, out decimal presupuesto) || presupuesto < 0)
            {
                MessageBox.Show("El presupuesto debe ser un número válido y positivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPresupuesto.Focus();
                return false;
            }

            if (cbEstadoProyecto.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un estado para el proyecto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbEstadoProyecto.Focus();
                return false;
            }

            if (dtpFechaInicio.Value > dtpFechaFin.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha fin.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaInicio.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                if (proyecto == null)
                    proyecto = new Proyectos();

                proyecto.Nombre = txtNombre.Text.Trim();
                proyecto.Descripcion = txtDescripcion.Text.Trim();
                proyecto.Presupuesto = decimal.Parse(txtPresupuesto.Text.Trim());
                proyecto.FechaInicio = dtpFechaInicio.Value;
                proyecto.FechaFin = dtpFechaFin.Value;
                proyecto.EstadoProyecto = cbEstadoProyecto.Text;
                proyecto.IsActive = cbEstado.SelectedIndex == 0;

                if (modo == ModoFormulario.Agregar)
                {
                    proyectosNegocio.AgregarProyecto(proyecto);
                }
                else if (modo == ModoFormulario.Modificar)
                {
                    proyecto.Id = int.Parse(txtId.Text);
                    proyectosNegocio.ModificarProyecto(proyecto);
                }

                MessageBox.Show("Proyecto guardado correctamente.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar proyecto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
