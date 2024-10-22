using Dominio.ReglasDelNegocio;
using negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dominio.Entidades.Dominio.Entidades;
using Dominio.Entidades;

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

        public Tareas ObtenerInformacionTarea(int idTarea)
        {
            AccesoDatos datos = new AccesoDatos();
            Tareas tarea = null;

            try
            {
                datos.setearProcedimiento("ObtenerInformacionTarea");
                datos.setearParametro("@IdTarea", idTarea);
                datos.ejecutarLectura();

                List<Empleado> empleadosAsignados = new List<Empleado>();
                HashSet<Proyectos> proyectosAsignados = new HashSet<Proyectos>(new ProyectosComparer());

                while (datos.Lector.Read())
                {
                    if (tarea == null)
                    {
                        tarea = new Tareas
                        {
                            Id = (int)datos.Lector["TareaId"],
                            Nombre = (string)datos.Lector["TareaNombre"],
                            Descripcion = (string)datos.Lector["TareaDescripcion"]
                        };
                    }

                    if (datos.Lector["ProyectoId"] != DBNull.Value)
                    {
                        Proyectos proyecto = new Proyectos
                        {
                            Id = (int)datos.Lector["ProyectoId"],
                            Nombre = (string)datos.Lector["ProyectoNombre"]
                        };
                        proyectosAsignados.Add(proyecto); // Usa HashSet para evitar duplicados
                    }

                    if (datos.Lector["EmpleadoId"] != DBNull.Value)
                    {
                        Empleado empleado = new Empleado
                        {
                            Id = (int)datos.Lector["EmpleadoId"],
                            Nombre = (string)datos.Lector["EmpleadoNombre"],
                            Apellido = (string)datos.Lector["EmpleadoApellido"]
                        };
                        empleadosAsignados.Add(empleado);
                    }
                }

                if (tarea != null)
                {
                    tarea.EmpleadosAsignados = empleadosAsignados;
                    tarea.ProyectosAsignados = proyectosAsignados.ToList(); // Convertir de HashSet a List
                }

                return tarea;
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

        public void AsignarTareaAProyecto(int idTarea, int idProyecto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("AsignarTareaAProyecto"); 
                datos.setearParametro("@IdTarea", idTarea);
                datos.setearParametro("@IdProyecto", idProyecto);
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

        public void AsignarTareaAEmpleadoEnProyecto(int idTareaProyecto, int idEmpleado, int idProyecto, DateTime fechaAsignacion)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("AsignarTareaAEmpleadoEnProyecto");
                datos.setearParametro("@IdTareaProyecto", idTareaProyecto); 
                datos.setearParametro("@IdEmpleado", idEmpleado);
                datos.setearParametro("@IdProyecto", idProyecto);
                datos.setearParametro("@FechaAsignacion", fechaAsignacion);
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

        public bool VerificarAsignacionTareaEmpleado(int idTarea, int idEmpleado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("VerificarAsignacionTareaEmpleado");
                datos.setearParametro("@IdTarea", idTarea);
                datos.setearParametro("@IdEmpleado", idEmpleado);
                datos.ejecutarLectura();

                return datos.Lector.Read(); 
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

        public void DesignarTareaAProyecto(int idTarea, int idProyecto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("DesasignarTareaDeProyecto");
                datos.setearParametro("@IdTarea", idTarea);
                datos.setearParametro("@IdProyecto", idProyecto);
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

        public void DesasignarTareaDeEmpleado(int idEmpleado, int idTareaProyecto) 
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("DesasignarTareaDeEmpleadoEnProyecto");
                datos.setearParametro("@IdTareaProyecto", idTareaProyecto);
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

        public List<Tareas> ListarTareasAsignadasAProyecto(int idProyecto)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Tareas> tareas = new List<Tareas>();

            try
            {
                datos.setearProcedimiento("ListarTareasAsignadasAProyecto");
                datos.setearParametro("@IdProyecto", idProyecto);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Tareas tarea = new Tareas();

                    tarea.Id = (int)datos.Lector["IdTarea"];
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

        public List<Empleado> ListarEmpleadosAsignadosATarea(int idTarea, int idProyecto)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Empleado> empleados = new List<Empleado>();

            try
            {
                datos.setearProcedimiento("ListarEmpleadosAsignadosATarea");
                datos.setearParametro("@IdTarea", idTarea);
                datos.setearParametro("@IdProyecto", idProyecto);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Empleado empleado = new Empleado();

                    empleado.Id = (int)datos.Lector["Id"];
                    empleado.Nombre = (string)datos.Lector["Nombre"];
                    empleado.Apellido = (string)datos.Lector["Apellido"];

                    empleados.Add(empleado);
                }

                return empleados;
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

    public class ProyectosComparer : IEqualityComparer<Proyectos>
    {
        public bool Equals(Proyectos x, Proyectos y)
        {
            return x.Id == y.Id; 
        }

        public int GetHashCode(Proyectos obj)
        {
            return obj.Id.GetHashCode(); 
        }
    }

}
