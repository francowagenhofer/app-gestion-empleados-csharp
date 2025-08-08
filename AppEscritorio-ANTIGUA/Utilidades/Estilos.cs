using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio_GestiónDeEmpleados.Utilidades
{
    public static class Estilos
    {
        public static Color ColorFondoFormulario = Color.FromKnownColor(KnownColor.InactiveBorder);
        public static Color ColorFondoBoton = Color.LightSteelBlue;
        public static Color ColorHoverBoton = Color.SteelBlue;
        public static Color ColorTextoBoton = Color.Black;
        public static Color ColorTextoHover = Color.White;
        public static Font FuenteBoton = new Font("Segoe UI", 12F, FontStyle.Bold);
        public static Font FuenteTitulo = new Font("Segoe UI", 18F, FontStyle.Bold);

        public static void AplicarEstiloBoton(Button btn)
        {

        }

        public static void AplicarFondoFormulario(Form form)
        {
            form.BackColor = ColorFondoFormulario;
        }

        public static void ActualizarFechaEnToolStripStatusLabel(ToolStripStatusLabel tsFecha)
        {
            tsFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            Timer timer = new Timer();
            timer.Interval = 60000; // 1 minuto
            timer.Tick += (sender, e) =>
            {
                tsFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            };
            timer.Start();
        }

        public static void AplicarEstiloTitulo(Label lbl)
        {
            lbl.Font = FuenteTitulo;
            lbl.BackColor = ColorFondoFormulario;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Padding = new Padding(15);
            lbl.ForeColor = Color.Navy;
        }
    }

}
