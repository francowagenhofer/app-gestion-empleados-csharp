using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.ReglasDelNegocio;
using Dominio.Entidades.Dominio.Entidades;
using negocio;

namespace Negocio
{
    public class ReportesNegocio
    {
        // METODOS DE REPORTE DE EMPLEADOS

        public List<ReporteEmpleado> ObtenerReportesEmpleados()
        {
            AccesoDatos datos = new AccesoDatos();
            List<ReporteEmpleado> lista = new List<ReporteEmpleado>();

            try
            {
                datos.setearProcedimiento("ObtenerReportesEmpleados");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    ReporteEmpleado aux = new ReporteEmpleado();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.IdEmpleado = (int)datos.Lector["IdEmpleado"];
                    aux.NombreEmpleado = (string)datos.Lector["NombreEmpleado"];
                    aux.Categoria = (string)datos.Lector["Categoria"];

                    aux.SalarioActual = datos.Lector["SalarioActual"] != DBNull.Value ? (decimal)datos.Lector["SalarioActual"] : 0m;
                    aux.TotalBonos = datos.Lector["TotalBonos"] != DBNull.Value ? (decimal)datos.Lector["TotalBonos"] : 0m;

                    aux.ProyectosAsignados = datos.Lector["ProyectosAsignados"] != DBNull.Value ? (string)datos.Lector["ProyectosAsignados"] : "";
                    aux.RolesAsignados = datos.Lector["RolesAsignados"] != DBNull.Value ? (string)datos.Lector["RolesAsignados"] : "";
                    aux.TareasAsignadas = datos.Lector["TareasAsignadas"] != DBNull.Value ? (string)datos.Lector["TareasAsignadas"] : "";

                    aux.FechaGeneracion = (DateTime)datos.Lector["FechaGeneracion"];

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

        public void GenerarReporteEmpleados(ReporteEmpleado nuevoReporte)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("GenerarReporteEmpleado");
                datos.setearParametro("@IdEmpleado", nuevoReporte.IdEmpleado);
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

        public void ModificarReporteEmpleados(ReporteEmpleado reporteModificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("ModificarReporteEmpleados");
                datos.setearParametro("@Id", reporteModificado.Id);
                datos.setearParametro("@IdEmpleado", reporteModificado.IdEmpleado);
                datos.setearParametro("@NombreEmpleado", reporteModificado.NombreEmpleado);
                datos.setearParametro("@Categoria", reporteModificado.Categoria);
                datos.setearParametro("@SalarioActual", reporteModificado.SalarioActual);
                datos.setearParametro("@TotalBonos", reporteModificado.TotalBonos);
                datos.setearParametro("@ProyectosAsignados", reporteModificado.ProyectosAsignados);
                datos.setearParametro("@RolesAsignados", reporteModificado.RolesAsignados);
                datos.setearParametro("@TareasAsignadas", reporteModificado.TareasAsignadas);
                datos.setearParametro("@FechaGeneracion", reporteModificado.FechaGeneracion);

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

        public void EliminarReporteEmpleados(int idReporte)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("EliminarReporteEmpleados");
                datos.setearParametro("@Id", idReporte);

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

        // ------------------------------------------------------------------------------------------------------------- // 
        // METODOS DE REPORTE DE PROYECTOS

        public List<ReporteProyecto> ObtenerReportesProyectos()
        {
            AccesoDatos datos = new AccesoDatos();
            List<ReporteProyecto> lista = new List<ReporteProyecto>();

            try
            {
                datos.setearProcedimiento("ObtenerReportesProyectos");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    ReporteProyecto aux = new ReporteProyecto();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.IdProyecto = (int)datos.Lector["IdProyecto"];
                    aux.NombreProyecto = (string)datos.Lector["NombreProyecto"];

                    aux.Presupuesto = datos.Lector["Presupuesto"] != DBNull.Value ? (decimal)datos.Lector["Presupuesto"] : 0m;
                    aux.TiempoEstimado = datos.Lector["TiempoEstimado"] != DBNull.Value ? (decimal)datos.Lector["TiempoEstimado"] : 0m;

                    aux.EstadoProyecto = datos.Lector["EstadoProyecto"] != DBNull.Value ? (string)datos.Lector["EstadoProyecto"] : "";
                    aux.AsignacionesEmpleados = datos.Lector["AsignacionesEmpleados"] != DBNull.Value ? (string)datos.Lector["AsignacionesEmpleados"] : "";
                    aux.TareasAsignadas = datos.Lector["TareasAsignadas"] != DBNull.Value ? (string)datos.Lector["TareasAsignadas"] : "";
                    aux.RolesAsignados = datos.Lector["RolesAsignados"] != DBNull.Value ? (string)datos.Lector["RolesAsignados"] : "";

                    aux.FechaGeneracion = datos.Lector["FechaGeneracion"] != DBNull.Value ? (DateTime)datos.Lector["FechaGeneracion"] : DateTime.MinValue;

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

        public void GenerarReporteProyectos(ReporteProyecto nuevoReporte)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("GenerarReporteProyecto");
                datos.setearParametro("@IdProyecto", nuevoReporte.IdProyecto);
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

        public void ModificarReporteProyectos(ReporteProyecto reporteModificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("ModificarReporteProyectos");
                datos.setearParametro("@Id", reporteModificado.Id);
                datos.setearParametro("@IdProyecto", reporteModificado.IdProyecto);
                datos.setearParametro("@NombreProyecto", reporteModificado.NombreProyecto);
                datos.setearParametro("@Presupuesto", reporteModificado.Presupuesto);
                datos.setearParametro("@EstadoProyecto", reporteModificado.EstadoProyecto);
                datos.setearParametro("@AsignacionesEmpleados", reporteModificado.AsignacionesEmpleados);
                datos.setearParametro("@TareasAsignadas", reporteModificado.TareasAsignadas);
                datos.setearParametro("@RolesAsignados", reporteModificado.RolesAsignados);
                datos.setearParametro("@TiempoEstimado", reporteModificado.TiempoEstimado);
                datos.setearParametro("@FechaGeneracion", reporteModificado.FechaGeneracion);

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

        public void EliminarReporteProyectos(int idReporte)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("EliminarReporteProyectos");
                datos.setearParametro("@Id", idReporte);

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


        // ------------------------------------------------------------------------------------------------------------- // 
        // METODOS DE REPORTES FINANCIEROS

        public List<ReporteFinanzas> ObtenerReportesFinanzas()
        {
            AccesoDatos datos = new AccesoDatos();
            List<ReporteFinanzas> lista = new List<ReporteFinanzas>();

            try
            {
                datos.setearProcedimiento("ObtenerReportesFinanzas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    ReporteFinanzas aux = new ReporteFinanzas();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.TotalSalarios = datos.Lector["TotalSalarios"] != DBNull.Value ? (decimal)datos.Lector["TotalSalarios"] : 0m;
                    aux.TotalBonos = datos.Lector["TotalBonos"] != DBNull.Value ? (decimal)datos.Lector["TotalBonos"] : 0m;
                    aux.TotalPresupuestosProyectos = datos.Lector["TotalPresupuestosProyectos"] != DBNull.Value ? (decimal)datos.Lector["TotalPresupuestosProyectos"] : 0m;
                    aux.TotalGastos = datos.Lector["TotalGastos"] != DBNull.Value ? (decimal)datos.Lector["TotalGastos"] : 0m;
                    aux.FechaGeneracion = (DateTime)datos.Lector["FechaGeneracion"];

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

        public void GenerarReporteFinanzas(ReporteFinanzas nuevoReporte)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("GenerarReporteFinanzas");
                //datos.setearParametro("@TotalSalarios", nuevoReporte.TotalSalarios);
                //datos.setearParametro("@TotalBonos", nuevoReporte.TotalBonos);
                //datos.setearParametro("@TotalPresupuestosProyectos", nuevoReporte.TotalPresupuestosProyectos);
                //datos.setearParametro("@TotalGastos", nuevoReporte.TotalGastos);
                //datos.setearParametro("@FechaGeneracion", nuevoReporte.FechaGeneracion);
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

        public void ModificarReporteFinanzas(ReporteFinanzas reporteModificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("ModificarReporteFinanzas");
                datos.setearParametro("@Id", reporteModificado.Id);
                datos.setearParametro("@TotalSalarios", reporteModificado.TotalSalarios);
                datos.setearParametro("@TotalBonos", reporteModificado.TotalBonos);
                datos.setearParametro("@TotalPresupuestosProyectos", reporteModificado.TotalPresupuestosProyectos);
                //datos.setearParametro("@TotalGastos", reporteModificado.TotalGastos);
                datos.setearParametro("@FechaGeneracion", reporteModificado.FechaGeneracion);

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

        public void EliminarReporteFinanzas(int idReporte)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("EliminarReporteFinanzas");
                datos.setearParametro("@Id", idReporte);

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
