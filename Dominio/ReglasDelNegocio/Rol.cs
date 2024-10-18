using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ReglasDelNegocio
{
    public class Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }


        //// Constructor vacío
        //public Rol() { }

        //// Constructor con parámetros
        //public Rol(int id, string nombre, string descripcion)
        //{
        //    Id = id;
        //    Nombre = nombre;
        //    Descripcion = descripcion;
        //}

        //// Método para mostrar la información del rol (opcional)
        //public override string ToString()
        //{
        //    return $"Id: {Id}, Nombre: {Nombre}, Descripción: {Descripcion}";
        //}
    }

}
