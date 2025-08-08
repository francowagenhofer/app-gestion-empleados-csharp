using Dominio.Entidades;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<CategoriaConSalario> ListarCategoriasConSalario()
        {
            AccesoDatos datos = new AccesoDatos();
            List<CategoriaConSalario> lista = new List<CategoriaConSalario>();
            try
            {
                string consulta = @"
          SELECT c.Id, c.Nombre, ISNULL(s.Id, 0) AS IdSalario, ISNULL(s.Monto, 0) AS Monto 
          FROM Categorias c 
          LEFT JOIN Salarios s ON s.IdCategoria = c.Id";
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    lista.Add(new CategoriaConSalario()
                    {
                        Id = (int)datos.Lector["Id"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Salario = (decimal)datos.Lector["Monto"],
                        IdSalario = (int)datos.Lector["IdSalario"]
                    });
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


        public void AgregarCategoria(string nombre, string descripcion)
        {
            // Implementar SP o consulta para insertar
        }

        public void ModificarCategoria(int id, string nombre, string descripcion)
        {
            // Implementar SP o consulta para actualizar
        }

        public void AgregarSalario(int idCategoria, decimal monto)
        {
            // Usar el SP AgregarSalario que ya tenés
        }

        public void ModificarSalario(int id, int idCategoria, decimal monto)
        {
            // Usar el SP ModificarSalario que ya tenés
        }
    }
}
