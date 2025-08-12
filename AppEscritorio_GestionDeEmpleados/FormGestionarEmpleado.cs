using Dominio.Entidades;
using Dominio.ReglasDelNegocio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio_GestionDeEmpleados
{
    public enum ModoFormulario
    {
        Agregar,
        Modificar,
        VerDetalle
    }
    public partial class FormGestionarEmpleado : Form
    {
        private Empleado empleado;
        private OpenFileDialog archivo = null;
        private ModoFormulario modo;
        private EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
        private List<CategoriaConSalario> categorias;

        public FormGestionarEmpleado(ModoFormulario modo, Empleado empleado = null)
        {
            InitializeComponent();
            this.modo = modo;
            this.empleado = empleado;
        }

        private void FormGestionarEmpleado_Load(object sender, EventArgs e)
        {
            CargarEstados();
            CargarCategorias();
            ConfigurarFormularioSegunModo();
        }

        private void CargarEstados()
        {
            cbEstado.Items.Clear();
            cbEstado.Items.AddRange(new string[] { "Activo", "Inactivo" });
            cbEstado.SelectedIndex = 0;
            txtId.Enabled = false;
        }

        private void CargarCategorias()
        {
            try
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                categorias = categoriaNegocio.ListarCategoriasConSalario();

                cbCategoria.DataSource = categorias;
                cbCategoria.DisplayMember = "Nombre";
                cbCategoria.ValueMember = "Id";
                //cbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }
        private void ConfigurarFormularioSegunModo()
        {
            switch (modo)
            {
                case ModoFormulario.Agregar:
                    lblTitulo.Text = "Agregar Empleado";
                    this.Text = "Agregar Empleado";
                    LimpiarCampos();
                    dtpFechaIngreso.Value = DateTime.Now;
                    HabilitarCampos(true);
                    btnGuardar.Visible = true;
                    break;

                case ModoFormulario.Modificar:
                    lblTitulo.Text = "Modificar Empleado";
                    this.Text = "Modificar Empleado";
                    CargarDatosEmpleado();
                    HabilitarCampos(true);
                    btnGuardar.Visible = true;
                    break;

                case ModoFormulario.VerDetalle:
                    lblTitulo.Text = "Información de Empleado";
                    this.Text = "Detalle de Empleado";
                    CargarDatosEmpleado();
                    HabilitarCampos(false);
                    btnGuardar.Visible = false;
                    break;
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            dtpFechaIngreso.Value = DateTime.Now;
            cbCategoria.SelectedIndex = -1;
            txtSalario.Text = "";
            cbEstado.SelectedIndex = 0;
            tbUrlImagen.Text = "";
            pbImagen.Image = null;
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtNombre.ReadOnly = !habilitar;
            txtApellido.ReadOnly = !habilitar;
            txtDNI.ReadOnly = !habilitar;
            dtpFechaNacimiento.Enabled = habilitar;
            dtpFechaIngreso.Enabled = false;
            cbCategoria.Enabled = habilitar;
            txtSalario.ReadOnly = true;
            cbEstado.Enabled = habilitar;
            tbUrlImagen.ReadOnly = !habilitar;
            btnBuscarImagen.Enabled = habilitar;
        }

        private void CargarDatosEmpleado()
        {
            if (empleado == null) return;

            txtId.Text = empleado.Id.ToString();
            txtNombre.Text = empleado.Nombre;
            txtApellido.Text = empleado.Apellido;
            txtDNI.Text = empleado.DNI;
            dtpFechaNacimiento.Value = empleado.FechaNacimiento;
            dtpFechaIngreso.Value = empleado.FechaIngreso;

            if (empleado.Categoria != 0 && categorias.Any(c => c.Id == empleado.Categoria))
                cbCategoria.SelectedValue = empleado.Categoria;

            txtSalario.Text = empleado.MontoSalario.ToString("N2");

            if (empleado.IsActive)
                cbEstado.SelectedIndex = 0;
            else if (cbEstado.Items.Count > 1)
                cbEstado.SelectedIndex = 1;

            tbUrlImagen.Text = empleado.Imagen;
            CargarImagen(empleado.Imagen);

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            var catSeleccionada = cbCategoria.SelectedItem as CategoriaConSalario;
            txtSalario.Text = catSeleccionada != null ? catSeleccionada.Salario.ToString("N2") : "";
        }

        private void tbImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(tbUrlImagen.Text);
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbImagen.Load(imagen);
            }
            catch
            {
                pbImagen.Load("https://www.pulsecarshalton.co.uk/wp-content/uploads/2016/08/jk-placeholder-image.jpg");
            }
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "Archivos de imagen|*.jpg;*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                tbUrlImagen.Text = archivo.FileName;
                CargarImagen(archivo.FileName);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("El DNI es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return false;
            }
            if (cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCategoria.Focus();
                return false;
            }

            return true;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                if (empleado == null)
                    empleado = new Empleado();

                empleado.Nombre = txtNombre.Text.Trim();
                empleado.Apellido = txtApellido.Text.Trim();
                empleado.DNI = txtDNI.Text.Trim();
                empleado.FechaNacimiento = dtpFechaNacimiento.Value;
                empleado.FechaIngreso = dtpFechaIngreso.Value;
                empleado.Categoria = (int)(cbCategoria.SelectedValue ?? 0);

                var catSeleccionada = categorias.FirstOrDefault(c => c.Id == empleado.Categoria);
                if (catSeleccionada == null || catSeleccionada.IdSalario == 0)
                {
                    MessageBox.Show("Debe seleccionar una categoría válida con salario asociado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                empleado.MontoSalario = catSeleccionada.Salario;
                empleado.Salario = catSeleccionada.IdSalario;
                empleado.IsActive = cbEstado.SelectedIndex == 0;
                empleado.Imagen = tbUrlImagen.Text.Trim();

                if (modo == ModoFormulario.Agregar)
                {
                    if (empleadoNegocio.ValidarDNI(empleado.DNI))
                    {
                        MessageBox.Show("El DNI ya está registrado, ingrese otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (archivo != null && !empleado.Imagen.ToUpper().Contains("HTTP"))
                {
                    string carpetaDestino = ConfigurationManager.AppSettings["images-folder"];
                    string destino = Path.Combine(carpetaDestino, archivo.SafeFileName);

                    File.Copy(archivo.FileName, destino, true);
                    empleado.Imagen = destino;
                }

                if (modo == ModoFormulario.Modificar)
                    empleadoNegocio.ModificarEmpleado(empleado);
                else
                    empleadoNegocio.AgregarEmpleado(empleado);

                MessageBox.Show("Empleado guardado correctamente.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Close();
        }

        private void tlpTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
