using Dominio.Entidades;
using Dominio.Entidades.Dominio.Entidades;
using Dominio.ReglasDelNegocio;
using Microsoft.VisualBasic;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Negocio
{
    public class ProyectosNegocio
    {
        public List<Proyectos> ListarProyectos()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Proyectos> lista = new List<Proyectos>();

            try
            {
                datos.setearProcedimiento("ListarProyectos");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Proyectos proyecto = new Proyectos();

                    proyecto.Id = (int)datos.Lector["Id"];
                    proyecto.Nombre = (string)datos.Lector["Nombre"];
                    proyecto.FechaInicio = (DateTime)datos.Lector["FechaInicio"];
                    proyecto.FechaFin = (DateTime)datos.Lector["FechaFin"];
                    proyecto.Descripcion = (string)datos.Lector["Descripcion"];
                    proyecto.Presupuesto = (decimal)datos.Lector["Presupuesto"];
                    proyecto.EstadoProyecto = (string)datos.Lector["EstadoProyecto"];
                    proyecto.IsActive = (bool)datos.Lector["IsActive"];

                    lista.Add(proyecto);
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

        public void AgregarProyecto(Proyectos nuevoProyecto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("AgregarProyecto");
                datos.setearParametro("@Nombre", nuevoProyecto.Nombre);
                datos.setearParametro("@Descripcion", nuevoProyecto.Descripcion);
                datos.setearParametro("@FechaInicio", nuevoProyecto.FechaInicio);
                datos.setearParametro("@FechaFin", nuevoProyecto.FechaFin);
                datos.setearParametro("@Presupuesto", nuevoProyecto.Presupuesto);
                datos.setearParametro("@EstadoProyecto", nuevoProyecto.EstadoProyecto);

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

        public void ModificarProyecto(Proyectos proyectoModificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("ModificarProyecto");
                datos.setearParametro("@Id", proyectoModificado.Id);
                datos.setearParametro("@Nombre", proyectoModificado.Nombre);
                datos.setearParametro("@Descripcion", proyectoModificado.Descripcion);
                datos.setearParametro("@FechaInicio", proyectoModificado.FechaInicio);
                datos.setearParametro("@FechaFin", proyectoModificado.FechaFin);
                datos.setearParametro("@Presupuesto", proyectoModificado.Presupuesto);
                datos.setearParametro("@EstadoProyecto", proyectoModificado.EstadoProyecto);
                datos.setearParametro("@IsActive", proyectoModificado.IsActive);

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

        public void EliminarProyecto(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("EliminarProyecto");
                datos.setearParametro("@Id", id);

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

        public void ActualizarEstadoProyecto(int id, bool activo = false)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("ActualizarEstadoProyecto");
                datos.setearParametro("@Id", id);
                datos.setearParametro("@IsActive", activo ? 1 : 0);

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

        public void AsignarEmpleadoAProyecto(int idProyecto, int idEmpleado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("AsignarEmpleadoAProyecto");
                datos.setearParametro("@IdProyecto", idProyecto);
                datos.setearParametro("@IdEmpleado", idEmpleado);

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

        public void DesasignarEmpleadoDeProyecto(int idProyecto, int idEmpleado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("DesasignarEmpleadoDeProyecto");
                datos.setearParametro("@IdProyecto", idProyecto);
                datos.setearParametro("@IdEmpleado", idEmpleado);

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

        public void DesasignarEmpleadoDeTodosLosProyectos(int idEmpleado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("DesasignarEmpleadoDeTodosLosProyectos");
                datos.setearParametro("@IdEmpleado", idEmpleado);

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

        public List<Proyectos> ListarProyectosAsignadosEmpleado(int idEmpleado)
        {
            List<Proyectos> proyectosAsignados = new List<Proyectos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("ListarProyectosAsignadosEmpleado");
                datos.setearParametro("@IdEmpleado", idEmpleado);

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Proyectos proyecto = new Proyectos();
                    proyecto.Id = (int)datos.Lector["ProyectoId"];
                    proyecto.Nombre = datos.Lector["Nombre"] != DBNull.Value ? (string)datos.Lector["Nombre"] : "Nombre no disponible";
                    proyecto.Descripcion = datos.Lector["Descripcion"] != DBNull.Value ? (string)datos.Lector["Descripcion"] : "Descripción no disponible";

                    proyectosAsignados.Add(proyecto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer proyectos asignados: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }

            finally
            {
                datos.cerrarConexion();
            }

            return proyectosAsignados;
        }


    }
}
