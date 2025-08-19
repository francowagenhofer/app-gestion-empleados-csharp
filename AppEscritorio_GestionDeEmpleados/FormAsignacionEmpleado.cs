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
    public partial class FormAsignacionEmpleado : Form
    {
        private int _idEmpleado;
        private int idProyectoSeleccionado;
        private int idProyectoTareasSeleccionado;

        private ProyectosNegocio proyectosNegocio = new ProyectosNegocio();
        private RolNegocio rolNegocio = new RolNegocio();
        private TareasNegocio tareaNegocio = new TareasNegocio();
        private BonosNegocio bonoNegocio = new BonosNegocio();
        private EmpleadoNegocio negocio = new EmpleadoNegocio();

        public FormAsignacionEmpleado(int idEmpleado)
        {
            InitializeComponent();
            _idEmpleado = idEmpleado;
        }

        private void FormAsignacionEmpleado_Load(object sender, EventArgs e)
        {

            Empleado emp = negocio.ListarEmpleados().FirstOrDefault(e => e.Id == _idEmpleado);

            if (emp != null)
            {
                string nombreCompleto = $"{emp.Nombre} {emp.Apellido}";
                lblEmpleadoProyecto.Text = $"Empleado: {nombreCompleto}";
                lblEmpleadoRol.Text = $"Empleado: {nombreCompleto}";
                lblEmpleadoTarea.Text = $"Empleado: {nombreCompleto}";
                lblEmpleadoBono.Text = $"Empleado: {nombreCompleto}";
            }

            // Asignación de proyectos
            CargarProyectos();

            ConfigurarEstiloGrilla(dgvProyectosAsignados);
            ConfigurarEstiloGrilla(dgvProyectosDisponibles);
            OcultarColumnasProyectos(dgvProyectosAsignados);
            OcultarColumnasProyectos(dgvProyectosDisponibles);

            // Asignación de roles
            CargarProyectosAsignados();
            comboProyectosAsignados.SelectedIndex = -1;
            ConfigurarEstiloGrilla(dgvRolesAsignados);
            ConfigurarEstiloGrilla(dgvRolesDisponibles);

            // Asignaciòn de Tareas
            CargarProyectosParaTareas();
            cbProyectosTareas.SelectedIndex = -1;
            ConfigurarEstiloGrilla(dgvTareasAsignadas);
            ConfigurarEstiloGrilla(dgvTareasDisponibles);


            // Asignación de bonos
            CargarBonos();
            ConfigurarEstiloGrilla(dgvBonosAsignados);
            ConfigurarEstiloGrilla(dgvBonosDisponibles);
            OcultarColumnasBonosAsignados(dgvBonosAsignados);
            OcultarColumnasBonosDisponibles(dgvBonosDisponibles);
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

        // -----------------------------------------------------------------------------------------------//
        public static void OcultarColumnasProyectos(DataGridView dgv)
        {
            if (dgv.Columns.Contains("Id"))
                dgv.Columns["Id"].Visible = true;
            if (dgv.Columns.Contains("FechaInicio"))
                dgv.Columns["FechaInicio"].Visible = false;
            if (dgv.Columns.Contains("FechaFin"))
                dgv.Columns["FechaFin"].Visible = false;
            if (dgv.Columns.Contains("Presupuesto"))
                dgv.Columns["Presupuesto"].Visible = false;
            if (dgv.Columns.Contains("Descripcion"))
                dgv.Columns["Descripcion"].Visible = false;
            if (dgv.Columns.Contains("IsActive"))
                dgv.Columns["IsActive"].Visible = false;
            if (dgv.Columns.Contains("EstadoProyecto")) dgv.Columns["EstadoProyecto"].Visible = true;

            if (dgv.Columns.Contains("EstadoProyecto")) dgv.Columns["EstadoProyecto"].HeaderText = "Estado";

            if (dgv.Columns.Contains("Id")) dgv.Columns["Id"].FillWeight = 10;
            if (dgv.Columns.Contains("Nombre")) dgv.Columns["Nombre"].FillWeight = 45;
            if (dgv.Columns.Contains("EstadoProyecto")) dgv.Columns["EstadoProyecto"].FillWeight = 45;
        }

        private void CargarProyectos()
        {
            dgvProyectosAsignados.DataSource = proyectosNegocio.ListarProyectosAsignadosEmpleado(_idEmpleado);
            dgvProyectosDisponibles.DataSource = proyectosNegocio.ListarProyectosDisponiblesEmpleado(_idEmpleado);
        }


        private void btnDesasignarProyecto_Click(object sender, EventArgs e)
        {
            if (dgvProyectosAsignados.CurrentRow != null)
            {
                var proyecto = (Proyectos)dgvProyectosAsignados.CurrentRow.DataBoundItem;
                proyectosNegocio.DesasignarEmpleadoDeProyecto(proyecto.Id, _idEmpleado);
                CargarProyectos();
            }
        }

        private void btnAsignarProyecto_Click(object sender, EventArgs e)
        {
            if (dgvProyectosDisponibles.CurrentRow != null)
            {
                var proyecto = (Proyectos)dgvProyectosDisponibles.CurrentRow.DataBoundItem;
                proyectosNegocio.AsignarEmpleadoAProyecto(proyecto.Id, _idEmpleado);
                CargarProyectos();
            }
        }

        // -----------------------------------------------------------------------------------------------//

        private void CargarProyectosAsignados()
        {
            var proyectos = proyectosNegocio.ListarProyectosAsignadosEmpleado(_idEmpleado);

            if (proyectos == null || proyectos.Count == 0)
            {
                comboProyectosAsignados.DataSource = new List<Proyectos>
                {
                    new Proyectos { Id = 0, Nombre = "No hay proyectos asignados" }
                };
                comboProyectosAsignados.DisplayMember = "Nombre";
                comboProyectosAsignados.ValueMember = "Id";
                comboProyectosAsignados.Enabled = false; // Deshabilitar si no hay proyectos
            }
            else
            {
                comboProyectosAsignados.DataSource = proyectos;
                comboProyectosAsignados.DisplayMember = "Nombre";
                comboProyectosAsignados.ValueMember = "Id";
                comboProyectosAsignados.Enabled = true;
            }

        }

        private void comboProyectosAsignados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboProyectosAsignados.SelectedValue != null && int.TryParse(comboProyectosAsignados.SelectedValue.ToString(), out int idProyecto))
            {
                idProyectoSeleccionado = idProyecto;

                dgvRolesAsignados.DataSource = rolNegocio.ListarRolesAsignadosPorEmpleadoYProyecto(_idEmpleado, idProyectoSeleccionado);
                dgvRolesDisponibles.DataSource = rolNegocio.ListarRolesDisponiblesParaAsignarPorEmpleadoYProyecto(_idEmpleado, idProyectoSeleccionado);

                if (dgvRolesAsignados.Columns.Contains("Nombre"))
                    dgvRolesAsignados.Columns["Nombre"].HeaderText = "Rol";
                if (dgvRolesDisponibles.Columns.Contains("Nombre"))
                    dgvRolesDisponibles.Columns["Nombre"].HeaderText = "Rol";

            }
        }

        private void btnDesasignarRol_Click(object sender, EventArgs e)
        {
            if (dgvRolesAsignados.CurrentRow != null)
            {
                var rol = (Rol)dgvRolesAsignados.CurrentRow.DataBoundItem;
                rolNegocio.DesasignarRolDeEmpleadoEnProyecto(_idEmpleado, rol.Id, idProyectoSeleccionado);
                comboProyectosAsignados_SelectedIndexChanged(null, null);
            }
        }

        private void btnAsignarRol_Click(object sender, EventArgs e)
        {
            if (dgvRolesDisponibles.CurrentRow != null)
            {
                var rol = (Rol)dgvRolesDisponibles.CurrentRow.DataBoundItem;
                rolNegocio.AsignarRolAEmpleadoEnProyecto(_idEmpleado, rol.Id, idProyectoSeleccionado);
                comboProyectosAsignados_SelectedIndexChanged(null, null);
            }
        }

        // -----------------------------------------------------------------------------------------------//

        private void CargarProyectosParaTareas()
        {
            var proyectos = proyectosNegocio.ListarProyectosAsignadosEmpleado(_idEmpleado);

            if (proyectos == null || proyectos.Count == 0)
            {
                cbProyectosTareas.DataSource = new List<Proyectos>
        {
            new Proyectos { Id = 0, Nombre = "No hay proyectos asignados" }
        };
                cbProyectosTareas.DisplayMember = "Nombre";
                cbProyectosTareas.ValueMember = "Id";
                cbProyectosTareas.Enabled = false;
            }
            else
            {
                cbProyectosTareas.DataSource = proyectos;
                cbProyectosTareas.DisplayMember = "Nombre";
                cbProyectosTareas.ValueMember = "Id";
                cbProyectosTareas.SelectedIndex = -1;
                cbProyectosTareas.Enabled = true;
            }
        }

        private void cbProyectosTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProyectosTareas.SelectedValue != null && int.TryParse(cbProyectosTareas.SelectedValue.ToString(), out int idProyecto))
            {
                idProyectoTareasSeleccionado = idProyecto;
                dgvTareasAsignadas.DataSource = tareaNegocio.ListarTareasAsignadasPorEmpleadoYProyecto(_idEmpleado, idProyectoTareasSeleccionado);

                ConfigurarColumnasTareasAsignadas(dgvTareasAsignadas);

                dgvTareasDisponibles.DataSource = tareaNegocio.ListarTareasDisponiblesParaAsignarPorEmpleadoYProyecto(_idEmpleado, idProyectoTareasSeleccionado);
                ConfigurarColumnasTareasDisponibles(dgvTareasDisponibles);
            }
        }

        public static void ConfigurarColumnasTareasAsignadas(DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
                col.Visible = false; // ocultamos todas
            if (dgv.Columns.Contains("Nombre")) { dgv.Columns["Nombre"].Visible = true; dgv.Columns["Nombre"].HeaderText = "Tarea"; dgv.Columns["Nombre"].FillWeight = 60; }
            if (dgv.Columns.Contains("FechaAsignacion")) { dgv.Columns["FechaAsignacion"].Visible = true; dgv.Columns["FechaAsignacion"].HeaderText = "Fecha asignada"; dgv.Columns["FechaAsignacion"].FillWeight = 40; }
        }
        public static void ConfigurarColumnasTareasDisponibles(DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns) col.Visible = false;
            if (dgv.Columns.Contains("Nombre"))
            {
                dgv.Columns["Nombre"].Visible = true;
                dgv.Columns["Nombre"].HeaderText = "Tarea";

            }
        }

        private void btnDesasignarTarea_Click(object sender, EventArgs e)
        {
            if (dgvTareasAsignadas.CurrentRow?.DataBoundItem is Tareas tarea && tarea.IdTareaProyecto > 0)
            {
                tareaNegocio.DesasignarTareaDeEmpleadoEnProyecto(tarea.IdTareaProyecto, _idEmpleado);
                cbProyectosTareas_SelectedIndexChanged(null, null);
            }
        }

        private void btnAsignarTarea_Click(object sender, EventArgs e)
        {
            if (dgvTareasDisponibles.CurrentRow != null)
            {
                var tarea = (Tareas)dgvTareasDisponibles.CurrentRow.DataBoundItem;
                tareaNegocio.AsignarTareaAEmpleadoEnProyecto(
                    tarea.IdTareaProyecto,
                    _idEmpleado,
                    idProyectoTareasSeleccionado,
                    DateTime.Now
                );
                cbProyectosTareas_SelectedIndexChanged(null, null);
            }
        }

        // -----------------------------------------------------------------------------------------------//
        private void CargarBonos()
        {
            dgvBonosAsignados.DataSource = bonoNegocio.ListarBonosAsignadosEmpleado(_idEmpleado);
            dgvBonosDisponibles.DataSource = bonoNegocio.ListarBonosDisponiblesEmpleado(_idEmpleado);
        }

        public static void OcultarColumnasBonosAsignados(DataGridView dgv)
        {
            if (dgv.Columns.Contains("Id")) dgv.Columns["Id"].Visible = false;
            if (dgv.Columns.Contains("FechaAsignacion")) dgv.Columns["FechaAsignacion"].Visible = true;

            if (dgv.Columns.Contains("Nombre")) dgv.Columns["Nombre"].HeaderText = "Bono";
            if (dgv.Columns.Contains("FechaAsignacion")) dgv.Columns["FechaAsignacion"].HeaderText = "Fecha";

            if (dgv.Columns.Contains("Id")) dgv.Columns["Id"].FillWeight = 7;
            if (dgv.Columns.Contains("Nombre")) dgv.Columns["Nombre"].FillWeight = 50;
            if (dgv.Columns.Contains("Monto")) dgv.Columns["Monto"].FillWeight = 20;
            if (dgv.Columns.Contains("FechaAsignacion")) dgv.Columns["FechaAsignacion"].FillWeight = 30;
        }

        public static void OcultarColumnasBonosDisponibles(DataGridView dgv)
        {
            if (dgv.Columns.Contains("Id")) dgv.Columns["Id"].Visible = false;
            if (dgv.Columns.Contains("FechaAsignacion")) dgv.Columns["FechaAsignacion"].Visible = false;

            if (dgv.Columns.Contains("Nombre")) dgv.Columns["Nombre"].HeaderText = "Bono";

            if (dgv.Columns.Contains("Id")) dgv.Columns["Id"].FillWeight = 10;
            if (dgv.Columns.Contains("Nombre")) dgv.Columns["Nombre"].FillWeight = 60;
            if (dgv.Columns.Contains("Monto")) dgv.Columns["Monto"].FillWeight = 30;
        }


        private void btnDesasignarBono_Click(object sender, EventArgs e)
        {
            if (dgvBonosAsignados.CurrentRow != null)
            {
                var bono = (Bonos)dgvBonosAsignados.CurrentRow.DataBoundItem;
                bonoNegocio.DesasignarBonoDeEmpleado(_idEmpleado, bono.Id);
                CargarBonos();
            }
        }

        private void btnAsignarBono_Click(object sender, EventArgs e)
        {
            if (dgvBonosDisponibles.CurrentRow != null)
            {
                var bono = (Bonos)dgvBonosDisponibles.CurrentRow.DataBoundItem;
                bonoNegocio.AsignarBonoAEmpleado(_idEmpleado, bono.Id, DateTime.Now);
                CargarBonos();
            }
        }

        // -----------------------------------------------------------------------------------------------//

        private void CerrarFormulario(object sender, EventArgs e)
        {
            Close();
        }
    }
}
