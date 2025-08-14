using Dominio.Entidades;
using Dominio.Entidades.Dominio.Entidades;
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
    public partial class FormAsignacionProyecto : Form
    {
        private int _idProyecto;

        //private int idEmpleadoSeleccionado;
        //private int idProyectoTareasSeleccionado;

        private ProyectosNegocio proyectosNegocio = new ProyectosNegocio();
        private RolNegocio rolNegocio = new RolNegocio();
        private TareasNegocio tareaNegocio = new TareasNegocio();
        private EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();

        public FormAsignacionProyecto(int idProyecto)
        {
            InitializeComponent();
            _idProyecto = idProyecto;
        }

        private void FormAsignacionEmpleado_Load(object sender, EventArgs e)
        {
            var proyecto = proyectosNegocio.ListarProyectos().FirstOrDefault(p => p.Id == _idProyecto);
            if (proyecto != null)
            {
                lblEmpleadoProyecto.Text = $"Proyecto: {proyecto.Nombre}";
                lblEmpleadoRol.Text = $"Proyecto: {proyecto.Nombre}";
                lblEmpleadoTarea.Text = $"Proyecto: {proyecto.Nombre}";
            }

            // Configuración de grillas
            ConfigurarEstiloGrilla(dgvEmpleadosAsignados);
            ConfigurarEstiloGrilla(dgvEmpleadosDisponibles);
            //ConfigurarEstiloGrilla(dgvRolesAsignados);
            //ConfigurarEstiloGrilla(dgvRolesDisponibles);
            //ConfigurarEstiloGrilla(dgvTareasAsignadas);
            //ConfigurarEstiloGrilla(dgvTareasDisponibles);

            // Cargar datos del proyecto
            CargarEmpleados();
            //CargarRoles();
            //CargarTareas();
        }

        public static void ConfigurarEstiloGrilla(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.BackgroundColor = SystemColors.Window;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgv.EnableHeadersVisualStyles = false;
        }

        // ------------------ EMPLEADOS ------------------

        private void CargarEmpleados()
        {
            dgvEmpleadosAsignados.DataSource = empleadoNegocio.ListarEmpleadosAsignados(_idProyecto);
            dgvEmpleadosDisponibles.DataSource = empleadoNegocio.ListarEmpleadosDisponiblesParaAsignarAProyecto(_idProyecto);

            ConfigurarColumnasEmpleadosAsignados(dgvEmpleadosAsignados);
            ConfigurarColumnasEmpleadosDisponibles(dgvEmpleadosDisponibles);
        }

        public static void ConfigurarColumnasEmpleadosAsignados(DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns) col.Visible = false;

            if (dgv.Columns.Contains("Id")) { dgv.Columns["Id"].Visible = true; dgv.Columns["Id"].FillWeight = 10; dgv.Columns["Id"].HeaderText = "ID"; }
            if (dgv.Columns.Contains("Nombre")) dgv.Columns["Nombre"].Visible = true;
            if (dgv.Columns.Contains("Apellido")) dgv.Columns["Apellido"].Visible = true; dgv.Columns["Apellido"].HeaderText = "Apellido"; dgv.Columns["Apellido"].FillWeight = 40;
            if (dgv.Columns.Contains("Nombre")) dgv.Columns["Nombre"].FillWeight = 30;
            if (dgv.Columns.Contains("NombreCategoria")) { dgv.Columns["NombreCategoria"].Visible = true; dgv.Columns["NombreCategoria"].HeaderText = "Categoría"; dgv.Columns["NombreCategoria"].FillWeight = 20; }
            if (dgv.Columns.Contains("IsActive")) { dgv.Columns["IsActive"].Visible = true; dgv.Columns["IsActive"].HeaderText = "Activo"; dgv.Columns["IsActive"].FillWeight = 10; }
        }

        public static void ConfigurarColumnasEmpleadosDisponibles(DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns) col.Visible = false;

            if (dgv.Columns.Contains("Id")) { dgv.Columns["Id"].Visible = true; dgv.Columns["Id"].FillWeight = 10; dgv.Columns["Id"].HeaderText = "ID"; }
            if (dgv.Columns.Contains("Nombre")) dgv.Columns["Nombre"].Visible = true; dgv.Columns["Nombre"].FillWeight = 45;
            if (dgv.Columns.Contains("Apellido")) { dgv.Columns["Apellido"].Visible = true; dgv.Columns["Apellido"].HeaderText = "Apellido"; dgv.Columns["Apellido"].FillWeight = 45; }
        }

        private void btnAsignarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleadosDisponibles.CurrentRow?.DataBoundItem is Empleado emp)
            {
                proyectosNegocio.AsignarEmpleadoAProyecto(emp.Id, _idProyecto);
                CargarEmpleados();
            }
        }
        private void btnDesasignarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleadosAsignados.CurrentRow?.DataBoundItem is Empleado emp)
            {
                proyectosNegocio.DesasignarEmpleadoDeProyecto(emp.Id, _idProyecto);
                CargarEmpleados();
            }
        }

        // ------------------ ROLES ------------------

        //private void CargarRoles()
        //{
        //    dgvRolesAsignados.DataSource = rolNegocio.ListarRolesAsignadosAProyecto(_idProyecto);
        //    dgvRolesDisponibles.DataSource = rolNegocio.ListarRolesDisponiblesParaAsignarAProyecto(_idProyecto);

        //    ConfigurarColumnasRolesAsignados(dgvRolesAsignados);
        //    ConfigurarColumnasRolesDisponibles(dgvRolesDisponibles);
        //}

        //public static void ConfigurarColumnasRolesAsignados(DataGridView dgv)
        //{
        //    foreach (DataGridViewColumn col in dgv.Columns) col.Visible = false;

        //    if (dgv.Columns.Contains("Id")) { dgv.Columns["Id"].Visible = true; dgv.Columns["Id"].FillWeight = 10; dgv.Columns["Id"].HeaderText = "ID"; }
        //    if (dgv.Columns.Contains("Nombre")) { dgv.Columns["Nombre"].Visible = true; dgv.Columns["Nombre"].HeaderText = "Rol"; dgv.Columns["Nombre"].FillWeight = 45; }
        //    if (dgv.Columns.Contains("Descripcion")) { dgv.Columns["Descripcion"].Visible = true; dgv.Columns["Descripcion"].HeaderText = "Descripción"; dgv.Columns["Descripcion"].FillWeight = 45; }
        //}

        //public static void ConfigurarColumnasRolesDisponibles(DataGridView dgv)
        //{
        //    foreach (DataGridViewColumn col in dgv.Columns) col.Visible = false;

        //    if (dgv.Columns.Contains("Id")) { dgv.Columns["Id"].Visible = true; dgv.Columns["Id"].FillWeight = 10; dgv.Columns["Id"].HeaderText = "ID"; }
        //    if (dgv.Columns.Contains("Nombre")) { dgv.Columns["Nombre"].Visible = true; dgv.Columns["Nombre"].HeaderText = "Rol"; dgv.Columns["Nombre"].FillWeight = 80; }
        //}


        private void btnAsignarRol_Click(object sender, EventArgs e)
        {
            //if (dgvRolesDisponibles.CurrentRow?.DataBoundItem is Rol rol)
            //{
            //    rolNegocio.AsignarRolAProyecto(rol.Id, _idProyecto);
            //    CargarRoles();
            //}
        }
        private void btnDesasignarRol_Click(object sender, EventArgs e)
        {
            //if (dgvRolesAsignados.CurrentRow?.DataBoundItem is Rol rol)
            //{
            //    rolNegocio.DesasignarRolDeProyecto(rol.Id, _idProyecto);
            //    CargarRoles();
            //}
        }

        // ------------------ TAREAS ------------------

        //private void CargarTareas()
        //{
        //    dgvTareasAsignadas.DataSource = tareaNegocio.ListarTareasAsignadasAProyecto(_idProyecto);
        //    dgvTareasDisponibles.DataSource = tareaNegocio.ListarTareasDisponiblesParaAsignarAProyecto(_idProyecto);

        //    ConfigurarColumnasTareasAsignadas(dgvTareasAsignadas);
        //    ConfigurarColumnasTareasDisponibles(dgvTareasDisponibles);
        //}

        //public static void ConfigurarColumnasTareasAsignadas(DataGridView dgv)
        //{
        //    foreach (DataGridViewColumn col in dgv.Columns) col.Visible = false;

        //    if (dgv.Columns.Contains("Nombre")) { dgv.Columns["Nombre"].Visible = true; dgv.Columns["Nombre"].HeaderText = "Tarea"; dgv.Columns["Nombre"].FillWeight = 60; }
        //    if (dgv.Columns.Contains("FechaAsignacion")) { dgv.Columns["FechaAsignacion"].Visible = true; dgv.Columns["FechaAsignacion"].HeaderText = "Fecha asignada"; dgv.Columns["FechaAsignacion"].FillWeight = 40; }
        //    if (dgv.Columns.Contains("Estado")) { dgv.Columns["Estado"].Visible = true; dgv.Columns["Estado"].HeaderText = "Estado"; dgv.Columns["Estado"].FillWeight = 20; }
        //}

        //public static void ConfigurarColumnasTareasDisponibles(DataGridView dgv)
        //{
        //    foreach (DataGridViewColumn col in dgv.Columns) col.Visible = false;

        //    if (dgv.Columns.Contains("Nombre")) { dgv.Columns["Nombre"].Visible = true; dgv.Columns["Nombre"].HeaderText = "Tarea"; dgv.Columns["Nombre"].FillWeight = 100; }
        //}

        private void btnAsignarTarea_Click(object sender, EventArgs e)
        {
            //if (dgvTareasDisponibles.CurrentRow?.DataBoundItem is Tareas tarea)
            //{
            //    tareaNegocio.AsignarTareaAProyecto(tarea.Id, _idProyecto, DateTime.Now);
            //    CargarTareas();
            //}
        }

        private void btnDesasignarTarea_Click(object sender, EventArgs e)
        {
            //if (dgvTareasAsignadas.CurrentRow?.DataBoundItem is Tareas tarea)
            //{
            //    tareaNegocio.DesasignarTareaDeProyecto(tarea.Id, _idProyecto);
            //    CargarTareas();
            //}
        }

        // -----------------------------------------------------------------------------------------------//

        private void CerrarFormulario(object sender, EventArgs e)
        {
            Close();
        }

    }
}
