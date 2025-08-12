using Dominio.ReglasDelNegocio;
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
        // Devuelve categorías con salario (LEFT JOIN)
        public List<CategoriaConSalario> ListarCategoriasConSalario()
        {
            AccesoDatos datos = new AccesoDatos();
            List<CategoriaConSalario> lista = new List<CategoriaConSalario>();
            try
            {
                string consulta = @"
                    SELECT c.Id, c.Nombre, c.Descripcion,
                           ISNULL(s.Id, 0) AS IdSalario,
                           ISNULL(s.Monto, 0) AS Monto
                    FROM Categorias c
                    LEFT JOIN Salarios s ON s.IdCategoria = c.Id";
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    lista.Add(new CategoriaConSalario()
                    {
                        Id = (int)datos.Lector["Id"],
                        Nombre = datos.Lector["Nombre"] != DBNull.Value ? (string)datos.Lector["Nombre"] : "",
                        Descripcion = datos.Lector["Descripcion"] != DBNull.Value ? (string)datos.Lector["Descripcion"] : "",
                        Salario = Convert.ToDecimal(datos.Lector["Monto"]),
                        IdSalario = Convert.ToInt32(datos.Lector["IdSalario"])
                    });
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Categorias> ListarCategorias()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Categorias> lista = new List<Categorias>();
            try
            {
                string consulta = "SELECT Id, Nombre, Descripcion FROM Categorias";
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    lista.Add(new Categorias()
                    {
                        Id = (int)datos.Lector["Id"],
                        Nombre = datos.Lector["Nombre"] != DBNull.Value ? (string)datos.Lector["Nombre"] : "",
                        Descripcion = datos.Lector["Descripcion"] != DBNull.Value ? (string)datos.Lector["Descripcion"] : ""
                    });
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        // Obtener una sola categoría por id
        public Categorias ObtenerCategoria(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            Categorias cat = null;
            try
            {
                datos.setearConsulta("SELECT Id, Nombre, Descripcion FROM Categorias WHERE Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    cat = new Categorias()
                    {
                        Id = (int)datos.Lector["Id"],
                        Nombre = datos.Lector["Nombre"] != DBNull.Value ? (string)datos.Lector["Nombre"] : "",
                        Descripcion = datos.Lector["Descripcion"] != DBNull.Value ? (string)datos.Lector["Descripcion"] : ""
                    };
                }
                return cat;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        // Agregar una categoría
        public void AgregarCategoria(string nombre, string descripcion)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO Categorias (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)");
                datos.setearParametro("@Nombre", nombre ?? (object)DBNull.Value);
                datos.setearParametro("@Descripcion", descripcion ?? (object)DBNull.Value);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        // Modificar una categoría
        public void ModificarCategoria(int id, string nombre, string descripcion)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE Categorias SET Nombre = @Nombre, Descripcion = @Descripcion WHERE Id = @Id");
                datos.setearParametro("@Id", id);
                datos.setearParametro("@Nombre", nombre ?? (object)DBNull.Value);
                datos.setearParametro("@Descripcion", descripcion ?? (object)DBNull.Value);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        // Resolver y terminar este punto
        public void EliminarCategoria(int idCategoria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Verificar empleados asignados
                datos.setearConsulta("SELECT COUNT(*) AS Cant FROM Empleados WHERE IdCategoria = @Id");
                datos.LimpiarParametros();
                datos.setearParametro("@Id", idCategoria);
                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {
                    int cant = Convert.ToInt32(datos.Lector["Cant"]);
                    if (cant > 0)
                        throw new InvalidOperationException("No se puede eliminar la categoría porque hay empleados asignados a ella.");
                }
                datos.cerrarConexion();

                // Eliminar salarios asociados
                datos.setearConsulta("DELETE FROM Salarios WHERE IdCategoria = @Id");
                datos.LimpiarParametros();
                datos.setearParametro("@Id", idCategoria);
                datos.ejecutarAccion();
                datos.cerrarConexion();

                // Eliminar categoría
                datos.setearConsulta("DELETE FROM Categorias WHERE Id = @Id");
                datos.LimpiarParametros();
                datos.setearParametro("@Id", idCategoria);
                datos.ejecutarAccion();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


    }
}