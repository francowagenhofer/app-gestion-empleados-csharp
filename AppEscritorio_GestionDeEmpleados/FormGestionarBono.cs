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
    public partial class FormGestionarBono : Form
    {
        private Bonos bono;
        private ModoFormulario modo;
        private BonosNegocio bonoNegocio = new BonosNegocio();

        public FormGestionarBono(ModoFormulario modo, Bonos bono = null)
        {
            InitializeComponent();
            this.modo = modo;
            this.bono = bono;
        }

        private void FormGestionarBono_Load(object sender, EventArgs e)
        {
            ConfigurarFormularioSegunModo();
        }

        private void ConfigurarFormularioSegunModo()
        {
            switch (modo)
            {
                case ModoFormulario.Agregar:
                    lblTitulo.Text = "Agregar Bono";
                    this.Text = "Agregar";
                    txtId.Visible = false;
                    LimpiarCampos();
                    HabilitarCampos(true);
                    btnGuardar.Visible = true;
                    break;

                case ModoFormulario.Modificar:
                    lblTitulo.Text = "Modificar Bono";
                    this.Text = "Modificar";
                    txtId.Visible = true;
                    CargarDatosBono();
                    HabilitarCampos(true);
                    btnGuardar.Visible = true;
                    break;

                case ModoFormulario.VerDetalle:
                    lblTitulo.Text = "Detalle de Bono";
                    this.Text = "Detalle";
                    txtId.Visible = true;
                    CargarDatosBono();
                    HabilitarCampos(false);
                    btnGuardar.Visible = false;
                    break;
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            nudMonto.Value = 0;
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtNombre.ReadOnly = !habilitar;
            nudMonto.Enabled = habilitar;
            txtId.ReadOnly = true;
        }

        private void CargarDatosBono()
        {
            if (bono == null) return;

            txtId.Text = bono.Id.ToString();
            txtNombre.Text = bono.Nombre;
            nudMonto.Value = bono.Monto;
            //nudMonto.Value = bono.Monto > 0 ? bono.Monto : 0;


        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (nudMonto.Value <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudMonto.Focus();
                return false;
            }

            return true;
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

            if (!ValidarCampos()) return;

            try
            {
                if (bono == null)
                    bono = new Bonos();

                bono.Nombre = txtNombre.Text.Trim();
                bono.Monto = nudMonto.Value;

                if (modo == ModoFormulario.Agregar)
                {
                    bonoNegocio.AgregarBono(bono);
                }
                else if (modo == ModoFormulario.Modificar)
                {
                    bono.Id = int.Parse(txtId.Text);
                    bonoNegocio.ModificarBono(bono);
                }

                MessageBox.Show("Bono guardado correctamente.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
