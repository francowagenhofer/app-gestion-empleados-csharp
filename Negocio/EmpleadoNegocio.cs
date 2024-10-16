using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public List<Empleado> ListarEmpleados()
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
                    aux.FechaNacimiento = (DateTime)datos.Lector["FechaNacimiento"];

                    if (!(datos.Lector["DNI"] is DBNull))
                        aux.DNI = (string)datos.Lector["DNI"];

                    if (!(datos.Lector["Imagen"] is DBNull))
                        aux.Imagen = (string)datos.Lector["Imagen"];

                    aux.FechaIngreso = (DateTime)datos.Lector["FechaIngreso"];
                    aux.IsActive = (bool)datos.Lector["IsActive"];

                    if (!(datos.Lector["NombreCategoria"] is DBNull))
                        aux.NombreCategoria = (string)datos.Lector["NombreCategoria"];

                    if (!(datos.Lector["MontoSalario"] is DBNull))
                        aux.MontoSalario = (decimal)datos.Lector["MontoSalario"];

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

        public void AgregarEmpleado(Empleado agregarEmpleado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("AgregarEmpleado");  // Tengo que modificar el Stored Procedure
                datos.setearParametro("@Nombre", agregarEmpleado.Nombre);
                datos.setearParametro("@Apellido", agregarEmpleado.Apellido);
                datos.setearParametro("@FechaNacimiento", agregarEmpleado.FechaNacimiento);
                datos.setearParametro("@DNI", agregarEmpleado.DNI);
                datos.setearParametro("@Imagen", agregarEmpleado.Imagen);
                datos.setearParametro("@FechaIngreso", agregarEmpleado.FechaIngreso);
                datos.setearParametro("@IdCategoria", agregarEmpleado.Categoria);
                datos.setearParametro("@IdSalario", agregarEmpleado.Salario); 
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
        
        public bool ValidarDNI(string dni)
        {
            // Acceso a datos para verificar si el DNI ya está registrado
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Configurar el procedimiento almacenado o consulta para buscar el DNI
                datos.setearConsulta("SELECT COUNT(*) FROM Empleados WHERE DNI = @DNI");
                datos.setearParametro("@DNI", dni);

                // Ejecutar la consulta y obtener el resultado
                int conteo = (int)datos.ejecutarEscalar();
                return conteo > 0; // Si el conteo es mayor a 0, el DNI ya está registrado
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar el DNI", ex);
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
                datos.setearParametro("@IdSalario", modificarEmpleado.Salario); 
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

        public void ActualizarEstadoEmpleado(int id, bool activo = false)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("ActualizarEstadoEmpleado");
                datos.setearParametro("@Id", id);
                datos.setearParametro("@IsActive", activo ? 1 : 0);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el estado del empleado.", ex);
            }
        }
   
        public List<Empleado> ListarEmpleadosAsignados(int idProyecto)
        {
            List<Empleado> empleadosAsignados = new List<Empleado>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("ListarEmpleadosAsignadosAlProyecto");
                datos.setearParametro("@IdProyecto", idProyecto);

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Empleado empleado = new Empleado();
                    empleado.Id = (int)datos.Lector["Id"];
                    empleado.Nombre = (string)datos.Lector["Nombre"];
                    empleado.Apellido = (string)datos.Lector["Apellido"];
                    empleadosAsignados.Add(empleado);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return empleadosAsignados;
        }

    }
}
