using Dominio.Entidades.Dominio.Entidades;
using Dominio.Entidades;
using Dominio.ReglasDelNegocio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class RolNegocio
    {
        public List<Rol> ListarRoles()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Rol> roles = new List<Rol>();
            try
            {
                datos.setearProcedimiento("ListarTodosLosRoles");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Rol rol = new Rol();
                    rol.Id = (int)datos.Lector["Id"];
                    rol.Nombre = (string)datos.Lector["Nombre"];
                    rol.Descripcion = (string)datos.Lector["Descripcion"];
                    roles.Add(rol);
                }

                return roles;
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

        public Rol ObtenerInformacionRol(int idRol)
        {
            AccesoDatos datos = new AccesoDatos();
            Rol rol = null;

            try
            {
                datos.setearProcedimiento("ObtenerInformacionRol");
                datos.setearParametro("@IdRol", idRol);
                datos.ejecutarLectura();

                List<Empleado> empleadosAsignados = new List<Empleado>();
                HashSet<Proyectos> proyectosAsignados = new HashSet<Proyectos>(new ProyectosComparer());

                while (datos.Lector.Read())
                {
                    if (rol == null)
                    {
                        rol = new Rol
                        {
                            Id = (int)datos.Lector["RolId"],
                            Nombre = (string)datos.Lector["RolNombre"],
                            Descripcion = (string)datos.Lector["RolDescripcion"]
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

                if (rol != null)
                {
                    rol.EmpleadosAsignados = empleadosAsignados;
                    rol.ProyectosAsignados = proyectosAsignados.ToList(); // Convertir de HashSet a List
                }

                return rol;
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

        public void CrearRol(Rol rol)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("CrearRol");
                datos.setearParametro("@Nombre", rol.Nombre);
                datos.setearParametro("@Descripcion", rol.Descripcion);
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

        public void ModificarRol(Rol rol)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("ModificarRol");
                datos.setearParametro("@Id", rol.Id);
                datos.setearParametro("@Nombre", rol.Nombre);
                datos.setearParametro("@Descripcion", rol.Descripcion);
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

        public void EliminarRol(int idRol)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("EliminarRol");
                datos.setearParametro("@IdRol", idRol);
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

        public void AsignarRolAEmpleadoEnProyecto(int idEmpleado, int idRol, int idProyecto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("AsignarRolAEmpleadoEnProyecto");
                datos.setearParametro("@IdEmpleado", idEmpleado);
                datos.setearParametro("@IdRol", idRol);
                datos.setearParametro("@IdProyecto", idProyecto);
                datos.setearParametro("@FechaAsignacion", DateTime.Now);

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

        public void DesasignarRolDeEmpleadoEnProyecto(int idEmpleado, int idRol, int idProyecto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("DesasignarRolDeEmpleadoEnProyecto");
                datos.setearParametro("@IdEmpleado", idEmpleado);
                datos.setearParametro("@IdRol", idRol);
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


        //public List<Rol> ListarRolesDeEmpleadosEnProyecto(int idProyecto)
        //{
        //    AccesoDatos datos = new AccesoDatos();
        //    List<Rol> roles = new List<Rol>();
        //    try
        //    {
        //        datos.setearProcedimiento("ListarRolesDeEmpleadosEnProyecto");
        //        datos.setearParametro("@IdProyecto", idProyecto);
        //        datos.ejecutarLectura();

        //        while (datos.Lector.Read())
        //        {
        //            Rol rol = new Rol();
        //            rol.Id = (int)datos.Lector["IdRol"];
        //            rol.Nombre = (string)datos.Lector["Nombre"];
        //            rol.Descripcion = (string)datos.Lector["Descripcion"];
        //            roles.Add(rol);
        //        }

        //        return roles;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}

        public List<Rol> ListarRolesAsignadosPorEmpleadoYProyecto(int idEmpleado, int idProyecto)
        {
            List<Rol> lista = new List<Rol>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("ListarRolesAsignadosDeEmpleadoPorProyecto");
                datos.setearParametro("@IdEmpleado", idEmpleado);
                datos.setearParametro("@IdProyecto", idProyecto);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    lista.Add(new Rol
                    {
                        Id = (int)datos.Lector["IdRol"],
                        Nombre = datos.Lector["NombreRol"].ToString()
                    });
                }
            }
            finally
            {
                datos.cerrarConexion();
            }

            return lista;
        }

        public List<Rol> ListarRolesDisponiblesParaAsignarPorEmpleadoYProyecto(int idEmpleado, int idProyecto)
        {
            List<Rol> lista = new List<Rol>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("ListarRolesDisponiblesParaAsignarPorEmpleadoYProyecto");
                datos.setearParametro("@IdEmpleado", idEmpleado);
                datos.setearParametro("@IdProyecto", idProyecto);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    lista.Add(new Rol
                    {
                        Id = (int)datos.Lector["IdRol"],
                        Nombre = datos.Lector["NombreRol"].ToString()
                    });
                }
            }
            finally
            {
                datos.cerrarConexion();
            }

            return lista;
        }

    }
}
