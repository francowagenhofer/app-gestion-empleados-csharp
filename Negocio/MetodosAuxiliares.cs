using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MetodosAuxiliares // Esta clase podria estar en la logica de la app.
    {
        public static string LeerDato(string campo, string valorPorDefecto = "")
        {
            Console.Write($"{campo}{(valorPorDefecto != "" ? $" (actual: {valorPorDefecto})" : "")}: ");
            return Console.ReadLine();
        }

        public static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.Write("\nPresiona Enter para continuar. ");
            Console.ReadLine();
        }

    }
}
