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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tsFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados form = new FormEmpleados();
            form.ShowDialog();
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            FormProyectos form = new FormProyectos();
            form.ShowDialog();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            FormOperaciones form = new FormOperaciones();
            form.ShowDialog();
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes form = new FormReportes();
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
