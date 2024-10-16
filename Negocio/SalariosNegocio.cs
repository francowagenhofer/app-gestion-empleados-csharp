using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.ReglasDelNegocio;
using negocio;
using Dominio.Entidades.Dominio.Entidades;

namespace Negocio
{
    public class SalariosNegocio
    {
        public List<Salarios> ListarSalarios()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Salarios> lista = new List<Salarios>();

            try
            {
                datos.setearProcedimiento("ListarSalarios");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Salarios salario = new Salarios();

                    salario.Id = (int)datos.Lector["Id"];
                    salario.Monto = (decimal)datos.Lector["Monto"];
                    salario.IdCategoria = (int)datos.Lector["IdCategoria"];
                    salario.NombreCategoria = datos.Lector["NombreCategoria"].ToString();

                    lista.Add(salario);
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

        public void ModificarSalario(Salarios salarioModificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("ModificarSalario");
                datos.setearParametro("@Id", salarioModificado.Id);
                datos.setearParametro("@IdCategoria", salarioModificado.IdCategoria);
                datos.setearParametro("@Monto", salarioModificado.Monto);
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

        public void AgregarSalario(Salarios nuevoSalario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("AgregarSalario");
                datos.setearParametro("@IdCategoria", nuevoSalario.IdCategoria);
                datos.setearParametro("@Monto", nuevoSalario.Monto);
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

        public void EliminarSalario(int idSalario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("EliminarSalario");
                datos.setearParametro("@Id", idSalario);
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