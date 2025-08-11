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
    public partial class FormGestionarRol : Form
    {
        private Rol rol;
        private ModoFormulario modo;
        private RolNegocio rolNegocio = new RolNegocio();

        public FormGestionarRol(ModoFormulario modo, Rol rol = null)
        {
            InitializeComponent();
            this.modo = modo;
            this.rol = rol;
        }

        private void FormGestionarRol_Load(object sender, EventArgs e)
        {
            ConfigurarFormularioSegunModo();
        }

        private void ConfigurarFormularioSegunModo()
        {
            switch (modo)
            {
                case ModoFormulario.Agregar:
                    lblTitulo.Text = "Agregar Rol";
                    this.Text = "Agregar Rol";
                    txtId.Visible = false; // ID no se muestra al agregar
                    LimpiarCampos();
                    HabilitarCampos(true);
                    btnGuardar.Visible = true;
                    break;

                case ModoFormulario.Modificar:
                    lblTitulo.Text = "Modificar Rol";
                    this.Text = "Modificar Rol";
                    txtId.Visible = true;
                    CargarDatosRol();
                    HabilitarCampos(true);
                    btnGuardar.Visible = true;
                    break;

                case ModoFormulario.VerDetalle:
                    lblTitulo.Text = "Detalle de Rol";
                    this.Text = "Detalle de Rol";
                    txtId.Visible = true;
                    CargarDatosRol();
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
        }


        private void HabilitarCampos(bool habilitar)
        {
            txtNombre.ReadOnly = !habilitar;
            txtDescripcion.ReadOnly = !habilitar;
            txtId.ReadOnly = true;
        }

        private void CargarDatosRol()
        {
            if (rol == null) return;

            txtId.Text = rol.Id.ToString();
            txtNombre.Text = rol.Nombre;
            txtDescripcion.Text = rol.Descripcion;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            return true;
        }


        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                if (rol == null)
                    rol = new Rol();

                rol.Nombre = txtNombre.Text.Trim();
                rol.Descripcion = txtDescripcion.Text.Trim();

                if (modo == ModoFormulario.Agregar)
                {
                    rolNegocio.CrearRol(rol);
                }
                else if (modo == ModoFormulario.Modificar)
                {
                    rol.Id = int.Parse(txtId.Text);
                    rolNegocio.ModificarRol(rol);
                }

                MessageBox.Show("Rol guardado correctamente.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
