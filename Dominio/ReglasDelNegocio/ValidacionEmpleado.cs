using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ReglasDelNegocio
{
    public static class ValidacionEmpleado // no se porque estatic. preguntar...
    {
        public static bool ValidarEmpleado(Empleado empleado)
        {
            if (string.IsNullOrWhiteSpace(empleado.Nombre) ||
                string.IsNullOrWhiteSpace(empleado.Apellido) ||
                empleado.Edad <= 0 ||
                empleado.SalarioBase <= 0)
            {
                return false;
            }
            return true;
        }

    }
}
