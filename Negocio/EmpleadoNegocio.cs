using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Interfaces;
using Dominio.ReglasDelNegocio;
using negocio;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using System.Text.RegularExpressions;

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



        // listar Empleados
        public List<Empleado> listarArticulos() // puedo mostrar cuantos empleados estan activos o eso en un reporte ....
        {
            AccesoDatos datos = new AccesoDatos();
            List<Empleado> lista = new List<Empleado>();

            try
            {

                datos.setearProcedimiento("ListarEmpleados");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Empleado aux = new Empleado();

                    aux.Id = (int)datos.Lector["Id"];

                    aux.Nombre = (string)datos.Lector["Nombre"];

                    aux.Apellido = (string)datos.Lector["Apellido"];

                    aux.FechaNacimiento= (DateTime)datos.Lector["FechaNacimiento"];

                    if (!(datos.Lector["DNI"] is DBNull))
                        aux.DNI = (int)datos.Lector["DNI"];

                    if (!(datos.Lector["Imagen"] is DBNull))
                        aux.Imagen = (string)datos.Lector["Imagen"];

                    aux.FechaIngreso = (DateTime)datos.Lector["FechaIngreso"];

                    aux.Categoria = (int)datos.Lector["Cargo"]; 
                     
                    aux.IsActive = (bool)datos.Lector["IsActive"]; 
                    //aux.IsActive = bool.Parse(datos.Lector["IsActive"].ToString());


                    if (!(datos.Lector["SalarioBase"] is DBNull))
                        aux.SalarioBase = (decimal)datos.Lector["SalarioBase"];


                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        public void AgregarEmpleado(Empleado agregarEmpleado) // Método para agregar un empleado a la lista
        {
            //empleados.Add(empleado);  // Solo agrega el empleado a la lista

            AccesoDatos datos = new AccesoDatos();
            try
            {
                //(@Nombre, @Apellido, @FechaNacimiento, @DNI, @Imagen, @FechaIngreso, @IdCategoria, @IdAsignacionSalario, @IsActive);

                datos.setearProcedimiento("AgregarEmpleado");
                datos.setearParametro("@Nombre", agregarEmpleado.Nombre);
                datos.setearParametro("@Apellido", agregarEmpleado.Apellido);
                datos.setearParametro("@FechaNacimiento", agregarEmpleado.FechaNacimiento);
                datos.setearParametro("@DNI", agregarEmpleado.DNI);
                datos.setearParametro("@Imagen", agregarEmpleado.Imagen);
                datos.setearParametro("@FechaIngreso", agregarEmpleado.FechaIngreso);
                datos.setearParametro("@IdCategoria", agregarEmpleado.Categoria);
                datos.setearParametro("@IdAsignacionSalario", agregarEmpleado.SalarioBase);
                datos.setearParametro("@IsActive", agregarEmpleado.IsActive);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }



        public void ModificarEmpleado(Empleado modificarEmpleado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("ModificarEmpleado");
                datos.setearParametro("@Nombre", modificarEmpleado.Nombre);
                datos.setearParametro("@Apellido", modificarEmpleado.Apellido);
                datos.setearParametro("@FechaNacimiento", modificarEmpleado.FechaNacimiento);
                datos.setearParametro("@DNI", modificarEmpleado.DNI);
                datos.setearParametro("@Imagen", modificarEmpleado.Imagen);
                datos.setearParametro("@FechaIngreso", modificarEmpleado.FechaIngreso);
                datos.setearParametro("@IdCategoria", modificarEmpleado.Categoria);
                datos.setearParametro("@IdAsignacionSalario", modificarEmpleado.SalarioBase);
                datos.setearParametro("@IsActive", modificarEmpleado.IsActive);
                datos.setearParametro("@Id", modificarEmpleado.Id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }



        public void EliminarEmpleado(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //datos.setearConsulta("delete from Empleados where id = @id");
                datos.setearProcedimiento("EliminarEmpleado");
                datos.setearParametro("@Id", id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        // Metodo para activar y desactivar empleado

        //public void IsActive (int id, bool activo = false)
        //{
        //    AccesoDatos datos = new AccesoDatos();
        //    try
        //    {
        //        datos.setearConsulta("update Empleados set IsActive = @IsActive Where Id = @Id");
        //        datos.setearParametro("@Id", id);
        //        datos.setearParametro("@IsActive", activo);
        //        datos.ejecutarAccion();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


    }

}