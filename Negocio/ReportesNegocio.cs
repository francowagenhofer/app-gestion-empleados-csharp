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

        // REPORTE EMPLEADO

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
                    aux.SalarioActual = (decimal)datos.Lector["SalarioActual"];
                    aux.TotalBonos = (decimal)datos.Lector["TotalBonos"];
                    aux.ProyectosAsignados = (string)datos.Lector["ProyectosAsignados"];
                    aux.RolesAsignados = (string)datos.Lector["RolesAsignados"];
                    aux.TareasAsignadas = (string)datos.Lector["TareasAsignadas"];
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
                datos.setearProcedimiento("GenerarReporteEmpleados");
                datos.setearParametro("@IdEmpleado", nuevoReporte.IdEmpleado);
                datos.setearParametro("@NombreEmpleado", nuevoReporte.NombreEmpleado);
                datos.setearParametro("@Categoria", nuevoReporte.Categoria);
                datos.setearParametro("@SalarioActual", nuevoReporte.SalarioActual);
                datos.setearParametro("@TotalBonos", nuevoReporte.TotalBonos);
                datos.setearParametro("@ProyectosAsignados", nuevoReporte.ProyectosAsignados);
                datos.setearParametro("@RolesAsignados", nuevoReporte.RolesAsignados);
                datos.setearParametro("@TareasAsignadas", nuevoReporte.TareasAsignadas);
                datos.setearParametro("@FechaGeneracion", nuevoReporte.FechaGeneracion);

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

        // REPORTE PROYECTOS

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
                    aux.Presupuesto = (decimal)datos.Lector["Presupuesto"];
                    aux.EstadoProyecto = (string)datos.Lector["EstadoProyecto"];
                    aux.AsignacionesEmpleados = (string)datos.Lector["AsignacionesEmpleados"];
                    aux.TareasAsignadas = (string)datos.Lector["TareasAsignadas"];
                    aux.RolesAsignados = (string)datos.Lector["RolesAsignados"];
                    aux.TiempoEstimado = (decimal)datos.Lector["TiempoEstimado"];
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

        public void GenerarReporteProyectos(ReporteProyecto nuevoReporte)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("GenerarReporteProyectos");
                datos.setearParametro("@IdProyecto", nuevoReporte.IdProyecto);
                datos.setearParametro("@NombreProyecto", nuevoReporte.NombreProyecto);
                datos.setearParametro("@Presupuesto", nuevoReporte.Presupuesto);
                datos.setearParametro("@EstadoProyecto", nuevoReporte.EstadoProyecto);
                datos.setearParametro("@AsignacionesEmpleados", nuevoReporte.AsignacionesEmpleados);
                datos.setearParametro("@TareasAsignadas", nuevoReporte.TareasAsignadas);
                datos.setearParametro("@RolesAsignados", nuevoReporte.RolesAsignados);
                datos.setearParametro("@TiempoEstimado", nuevoReporte.TiempoEstimado);
                datos.setearParametro("@FechaGeneracion", nuevoReporte.FechaGeneracion);

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

        // REPORTE FINANCIERO

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
                    aux.TotalSalarios = (decimal)datos.Lector["TotalSalarios"];
                    aux.TotalBonos = (decimal)datos.Lector["TotalBonos"];
                    aux.TotalPresupuestosProyectos = (decimal)datos.Lector["TotalPresupuestosProyectos"];
                    aux.TotalGastos = (decimal)datos.Lector["TotalGastos"];
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
                datos.setearParametro("@TotalSalarios", nuevoReporte.TotalSalarios);
                datos.setearParametro("@TotalBonos", nuevoReporte.TotalBonos);
                datos.setearParametro("@TotalPresupuestosProyectos", nuevoReporte.TotalPresupuestosProyectos);
                datos.setearParametro("@TotalGastos", nuevoReporte.TotalGastos);
                datos.setearParametro("@FechaGeneracion", nuevoReporte.FechaGeneracion);

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
                datos.setearParametro("@TotalGastos", reporteModificado.TotalGastos);
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
