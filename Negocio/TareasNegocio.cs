using Dominio.ReglasDelNegocio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Negocio
{
    public class TareasNegocio
    {
        public List<Tareas> ListarTodasLasTareas()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Tareas> tareas = new List<Tareas>();

            try
            {
                datos.setearProcedimiento("ListarTodasLasTareas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Tareas tarea = new Tareas();
                    tarea.Id = (int)datos.Lector["Id"];
                    tarea.IdProyecto = (int)datos.Lector["IdProyecto"];
                    tarea.Nombre = (string)datos.Lector["Nombre"];
                    tarea.Descripcion = (string)datos.Lector["Descripcion"];
                    tarea.FechaInicio = (DateTime)datos.Lector["FechaInicio"];
                    tarea.FechaFin = (DateTime)datos.Lector["FechaFin"];
                    tarea.Estado = (string)datos.Lector["Estado"];
                    tareas.Add(tarea);
                }

                return tareas;
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

        public List<Tareas> ListarTareasPorProyecto(int idProyecto)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Tareas> tareas = new List<Tareas>();
            try
            {
                datos.setearProcedimiento("ListarTareasPorProyecto");
                datos.setearParametro("@IdProyecto", idProyecto);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Tareas tarea = new Tareas();
                    tarea.Id = (int)datos.Lector["Id"];
                    tarea.Nombre = (string)datos.Lector["Nombre"];
                    tarea.Descripcion = (string)datos.Lector["Descripcion"];
                    tarea.FechaInicio = (DateTime)datos.Lector["FechaInicio"];
                    tarea.FechaFin = (DateTime)datos.Lector["FechaFin"];
                    tarea.Estado = (string)datos.Lector["Estado"];
                    tareas.Add(tarea);
                }

                return tareas;
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

        public void AgregarTarea(Tareas nuevaTarea)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("AgregarTarea");
                datos.setearParametro("@IdProyecto", nuevaTarea.IdProyecto);
                datos.setearParametro("@Nombre", nuevaTarea.Nombre);
                datos.setearParametro("@Descripcion", nuevaTarea.Descripcion);
                datos.setearParametro("@FechaInicio", nuevaTarea.FechaInicio);
                datos.setearParametro("@FechaFin", nuevaTarea.FechaFin);
                datos.setearParametro("@Estado", nuevaTarea.Estado);

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

        public void ModificarTarea(Tareas tarea)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("ModificarTarea");
                datos.setearParametro("@IdTarea", tarea.Id);
                datos.setearParametro("@Nombre", tarea.Nombre);
                datos.setearParametro("@Descripcion", tarea.Descripcion);
                datos.setearParametro("@FechaInicio", tarea.FechaInicio);
                datos.setearParametro("@FechaFin", tarea.FechaFin);
                datos.setearParametro("@Estado", tarea.Estado);

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

        public void EliminarTarea(int idTarea)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("EliminarTarea");
                datos.setearParametro("@IdTarea", idTarea);

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

        public void AsignarTareaAEmpleado(int idTarea, int idEmpleado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("AsignarTareaAEmpleado");
                datos.setearParametro("@IdTarea", idTarea);
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

        public void DesasignarTareaDeEmpleado(int idTarea, int idEmpleado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("DesasignarTareaDeEmpleado");
                datos.setearParametro("@IdTarea", idTarea);
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

    }
}
