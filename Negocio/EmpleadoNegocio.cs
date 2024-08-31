using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Dominio.ReglasDelNegocio;

namespace Negocio
{
    public class EmpleadoNegocio
    {

        //-------------------------------------------------------------------------------------------------------------------------------//

        // Todavia no tiene mucha funcionalidad esta clase pero mas adelante va a servir para conectar los metodos a la Base de datos 
        
        // y de ahi poder replicar en cada proyecto con la logica correspondiente.
 
        //-------------------------------------------------------------------------------------------------------------------------------//


        // tendria que tener un metodo Listar ...

        //public static List<Empleado> ObtenerListaEmpleados() // Método para obtener la lista de empleados  // no se bien para que sirve
        //{
        //    // Retorna la lista de empleados (de alguna fuente de datos, como una lista almacenada o base de datos)
        //    return listaDeEmpleados;  // Esta lista sería mantenida en el sistema
        //}

        public static void AgregarEmpleado(List<Empleado> empleados, Empleado empleado) // Método para agregar un empleado a la lista
        {
            empleados.Add(empleado);  // Solo agrega el empleado a la lista
        }

        public static void ModificarEmpleado(Empleado empleado, string nuevoNombre, string nuevoApellido, int nuevaEdad, decimal nuevoSalario) // Método para modificar un empleado ya existente
        {
            empleado.Nombre = nuevoNombre;
            empleado.Apellido = nuevoApellido;
            empleado.Edad = nuevaEdad;
            empleado.SalarioBase = nuevoSalario;
        }

        public static void EliminarEmpleado(List<Empleado> empleados, int indice) // Método para eliminar un empleado de la lista
        {
            empleados.RemoveAt(indice);  // Elimina el empleado por índice
        }
    }

}