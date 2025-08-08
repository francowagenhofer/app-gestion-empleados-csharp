using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppEscritorio_GestiónDeEmpleados.Utilidades;


namespace AppEscritorio_GestiónDeEmpleados
{
    public partial class FormEmpleados : Form
    {

        //private List<Empleado> listaEmpleados;

        public FormEmpleados()
        {
            InitializeComponent();
            InicializarEstilos();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            Estilos.ActualizarFechaEnToolStripStatusLabel(tsFecha);
            //CargarEmpleados();
        }

        private void InicializarEstilos()
        {
            Estilos.AplicarFondoFormulario(this);
            Estilos.AplicarEstiloTitulo(lblTitulo);
        }

        //private void CargarEmpleados()
        //{
        //    EmpleadoNegocio negocio = new EmpleadoNegocio();
        //    try
        //    {
        //        listaEmpleados = negocio.ListarEmpleados();
        //        dgvEmpleados.DataSource = null;
        //        dgvEmpleados.DataSource = listaEmpleados;
        //        OcultarColumnas();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al listar empleados: " + ex.Message);
        //    }
        //}

        //private void OcultarColumnas()
        //{
        //    // Ocultar columnas que no quieras mostrar
        //    dgvEmpleados.Columns["Id"].Visible = false;
        //    dgvEmpleados.Columns["Imagen"].Visible = false;
        //    dgvEmpleados.Columns["NombreCategoria"].Visible = false;
        //    dgvEmpleados.Columns["MontoSalario"].Visible = false;
        //    // Agrega o quita columnas según necesites mostrar
        //}

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvEmpleados.CurrentRow != null)
            //{
            //    Empleado seleccionado = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
            //    // Si querés mostrar imagen u otros detalles en controles aparte, acá podes hacerlo
            //    // Ejemplo: pictureBoxEmpleado.Image = Image.FromFile(seleccionado.Imagen);
            //}
        }

        // Aquí pueden ir otros métodos, eventos para filtrar, agregar, modificar, etc.




        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
        private void btnEstado_Click(object sender, EventArgs e)
        {

        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            //string filtro = txtFiltroRapido.Text.Trim().ToUpper();
            //List<Empleado> listaFiltrada;

            //if (filtro.Length >= 2)
            //{
            //    listaFiltrada = listaEmpleados.FindAll(x =>
            //        x.Nombre.ToUpper().Contains(filtro) ||
            //        x.Apellido.ToUpper().Contains(filtro) ||
            //        x.DNI.ToUpper().Contains(filtro) ||
            //        x.Email.ToUpper().Contains(filtro)
            //    );
            //}
            //else
            //{
            //    listaFiltrada = listaEmpleados;
            //}

            //// Filtro adicional: Mostrar solo activos
            //if (chkSoloActivos.Checked)
            //{
            //    listaFiltrada = listaFiltrada.FindAll(x => x.Estado == true);
            //}

            //dgvEmpleados.DataSource = null;
            //dgvEmpleados.DataSource = listaFiltrada;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void cbActivos_CheckedChanged(object sender, EventArgs e)
        {
            //txtFiltroRapido_TextChanged(sender, e); // Reutiliza el mismo filtro
        }


    }
}
