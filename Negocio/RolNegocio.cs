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
        // Roles 
        // - lista de roles por proyecto 
        // - crear rol 
        // - modificar rol
        // - modificar rol
        // - asignar rol 
        // - desasignar rol

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

        public List<Rol> ListarRolesDeEmpleadosEnProyecto(int idProyecto)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Rol> roles = new List<Rol>();
            try
            {
                datos.setearProcedimiento("ListarRolesDeEmpleadosEnProyecto");
                datos.setearParametro("@IdProyecto", idProyecto);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Rol rol = new Rol();
                    rol.Id = (int)datos.Lector["IdRol"];
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
                datos.setearParametro("@Id", idRol);
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

        public void AsignarRolAEmpleado(int idEmpleado, int idRol)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("AsignarRolAEmpleado");
                datos.setearParametro("@IdEmpleado", idEmpleado);
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

        public void DesasignarRolDeEmpleado(int idEmpleado, int idRol)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("DesasignarRolDeEmpleado");
                datos.setearParametro("@IdEmpleado", idEmpleado);
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


    }

}
