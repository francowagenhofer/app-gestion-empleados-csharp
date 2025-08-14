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
    public partial class FormGestionarCategoriasYSalarios : Form
    {
        private CategoriaConSalario categoria;
        private ModoFormulario modo;
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        private SalariosNegocio salariosNegocio = new SalariosNegocio();

        public FormGestionarCategoriasYSalarios(ModoFormulario modo, CategoriaConSalario categoria = null)
        {
            InitializeComponent();
            this.modo = modo;
            this.categoria = categoria;
        }

        private void FormGestionarCategoriasYSalarios_Load(object sender, EventArgs e)
        {
            ConfigurarFormularioSegunModo();
        }

        private void ConfigurarFormularioSegunModo()
        {
            switch (modo)
            {
                case ModoFormulario.Agregar:
                    lblTitulo.Text = "Agregar Categoría y Salario";
                    this.Text = "Agregar";
                    txtId.Visible = false;
                    LimpiarCampos();
                    HabilitarCampos(true);
                    btnGuardar.Visible = true;
                    break;
                case ModoFormulario.Modificar:
                    lblTitulo.Text = "Modificar Categoría y Salario";
                    this.Text = "Modificar";
                    txtId.Visible = true;
                    CargarDatosCategoria();
                    HabilitarCampos(true);
                    btnGuardar.Visible = true;
                    break;
                case ModoFormulario.VerDetalle:
                    lblTitulo.Text = "Detalle Categoría y Salario";
                    this.Text = "Detalle";
                    txtId.Visible = true;
                    CargarDatosCategoria();
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
            nupSalario.Value = 0;
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtNombre.ReadOnly = !habilitar;
            txtDescripcion.ReadOnly = !habilitar;
            nupSalario.Enabled = habilitar;
            txtId.ReadOnly = true;
        }

        private void CargarDatosCategoria()
        {
            if (categoria == null) return;

            txtId.Text = categoria.Id.ToString();
            txtNombre.Text = categoria.Nombre;
            txtDescripcion.Text = categoria.Descripcion ?? "";
            nupSalario.Value = categoria.Salario > 0 ? categoria.Salario : 0;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            if (nupSalario.Value <= 0)
            {
                MessageBox.Show("El salario debe ser mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nupSalario.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                if (categoria == null)
                    categoria = new CategoriaConSalario();

                categoria.Nombre = txtNombre.Text.Trim();
                categoria.Descripcion = txtDescripcion.Text.Trim();
                categoria.Salario = nupSalario.Value;

                if (modo == ModoFormulario.Agregar)
                {
                    categoriaNegocio.AgregarCategoria(categoria.Nombre, categoria.Descripcion);

                    var categorias = categoriaNegocio.ListarCategorias();
                    categoria.Id = categorias.Last().Id;

                    salariosNegocio.AgregarSalario(new Salarios
                    {
                        IdCategoria = categoria.Id,
                        Monto = categoria.Salario
                    });
                }
                else if (modo == ModoFormulario.Modificar)
                {
                    categoria.Id = int.Parse(txtId.Text);
                    categoriaNegocio.ModificarCategoria(categoria.Id, categoria.Nombre, categoria.Descripcion);

                    if (categoria.IdSalario > 0)
                    {
                        salariosNegocio.ModificarSalario(new Salarios
                        {
                            Id = categoria.IdSalario,
                            IdCategoria = categoria.Id,
                            Monto = categoria.Salario
                        });
                    }
                    else
                    {
                        salariosNegocio.AgregarSalario(new Salarios
                        {
                            IdCategoria = categoria.Id,
                            Monto = categoria.Salario
                        });
                    }
                }

                MessageBox.Show("Categoría y salario guardados correctamente.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
