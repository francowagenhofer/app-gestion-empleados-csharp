using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.ReglasDelNegocio;
using negocio;

namespace Negocio
{
    public class BonosNegocio
    {
        public List<Bonos> ListarBonos()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Bonos> lista = new List<Bonos>();

            try
            {
                datos.setearProcedimiento("ListarBonos");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Bonos bono = new Bonos();
                    bono.Id = (int)datos.Lector["Id"];
                    bono.Nombre = datos.Lector["Nombre"].ToString();
                    bono.Monto = (decimal)datos.Lector["Monto"];

                    lista.Add(bono);
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

        public void ModificarBono(Bonos bonoModificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("ModificarBono");
                datos.setearParametro("@Id", bonoModificado.Id);
                datos.setearParametro("@Monto", bonoModificado.Monto);
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

        public void AgregarBono(Bonos nuevoBono)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("AgregarBono");
                datos.setearParametro("@Nombre", nuevoBono.Nombre);
                datos.setearParametro("@Monto", nuevoBono.Monto);
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

        public void EliminarBono(int idBono)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("EliminarBono");
                datos.setearParametro("@Id", idBono);
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

        public void AsignarBonoAEmpleado(int idEmpleado, int idTipoBono, DateTime fechaAsignacion)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("AsignarBonoAEmpleado");
                datos.setearParametro("@IdEmpleado", idEmpleado);
                datos.setearParametro("@IdTipoBono", idTipoBono);
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
       
        public void DesasignarBonoDeEmpleado(int idEmpleado, int idTipoBono)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("DesasignarBonoDeEmpleado");
                datos.setearParametro("@IdEmpleado", idEmpleado);
                datos.setearParametro("@IdTipoBono", idTipoBono);

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

        public List<Bonos> ListarBonosAsignadosEmpleado(int idEmpleado)
        {
            List<Bonos> bonosAsignados = new List<Bonos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("ListarBonosAsignadosEmpleado");
                datos.setearParametro("@IdEmpleado", idEmpleado); 

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Bonos bono = new Bonos();
                    bono.Id = (int)datos.Lector["BonoId"]; 
                    bono.Nombre = datos.Lector["Nombre"] != DBNull.Value ? (string)datos.Lector["Nombre"] : "Nombre no disponible";
                    bono.Monto = datos.Lector["Monto"] != DBNull.Value ? (decimal)datos.Lector["Monto"] : 0;
                    bono.FechaAsignacion = datos.Lector["FechaAsignacion"] != DBNull.Value ? (DateTime)datos.Lector["FechaAsignacion"] : DateTime.MinValue;

                    bonosAsignados.Add(bono);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer bonos asignados: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }
            finally
            {
                datos.cerrarConexion();
            }

            return bonosAsignados;
        }

    }
}