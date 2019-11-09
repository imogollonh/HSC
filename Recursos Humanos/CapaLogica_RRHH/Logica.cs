﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos_RRHH;
using System.Data;
using System.Data.Odbc;


namespace CapaLogica_RRHH
{
   public class Logica
    {
        sentencias sn = new sentencias();
        public string siguiente(string tabla,string campo)
        {
            string llave = sn.obtenerfinal(tabla, campo);
            return llave;
        }
        public void nuevoQuery(String query)//trasporta el query de la capa de disenio a Datos
        {
            sn.ejecutarQuery(query);
        }
        //   ***** INICIO DE LOGICA INTEGRACION *******

        public OdbcDataReader ConsultaLogicaResultado(string cod)
        {
            return sn.ConsultaResultadoBanco(cod);
        }

        public DataTable ConsultaLogicaGrafica(string cod)
        {
            OdbcDataAdapter dtaGrafica = sn.ConsultaGrafica(cod);
            DataTable grafica = new DataTable();
            dtaGrafica.Fill(grafica);
            return grafica;
        }

        public OdbcDataReader ConsultaLogicaDesempeño(string cod)
        {
            return sn.ConsultaDesempeñoEmpleado(cod);
        }

        public DataTable ConsultaLogicaGraficaDesempeño(string cod)
        {
            OdbcDataAdapter dtaGrafica = sn.ConsultaGraficaDesempeño(cod);
            DataTable grafica = new DataTable();
            dtaGrafica.Fill(grafica);
            return grafica;
        }
        /*
                public DataTable ConsultaLogicaGraficaAsistencia(string nom)
                {
                    OdbcDataAdapter dtaGrafica = sn.ConsultaGraficaAsistencias(nom);
                    DataTable grafica = new DataTable();
                    dtaGrafica.Fill(grafica);
                    return grafica;
                }*/
        public OdbcDataReader ConsultaLogicaGraficaAsistencia(string nom)
        {
            return sn.ConsultaGraficaAsistencias2(nom);
        }

        public OdbcDataReader ConsultaLogicaEmpleados()
        {
            return sn.ConsultaEmpleados();
        }

        public OdbcDataReader ConsultaLogicaEmpleadoFiltro(string nom)
        {
            return sn.ConsultaEmpleadoFiltro(nom);
        }

        public OdbcDataReader ConsultaLogicaPerfiles()
        {
            return sn.ConsultaPerfil();
        }

        public OdbcDataReader ConsultaLogicaPerfilesFiltro(string nom)
        {
            return sn.ConsultaPerfilFiltro(nom);
        }

        public OdbcDataReader ConsultaLogicaMedios()
        {
            return sn.ConsultaMedio();
        }

        public OdbcDataReader ConsultaLogicaMediosFiltro(string nom)
        {
            return sn.ConsultaMedioFiltro(nom);
        }
        //Reporte
        public OdbcDataReader ConsultaLogicaReporteEncabezado()
        {
            return sn.ConsultaReporteEncabezado();
        }

        public OdbcDataReader ConsultaLogicaReporteEncabezadoFiltro(string id)
        {
            return sn.ConsultaReporteEncabezadoFiltro(id);
        }

        public OdbcDataReader ConsultaLogicaReporteDetalle()
        {
            return sn.ConsultaReporteDetalle();
        }

        public OdbcDataReader ConsultaLogicaReporteDetalleFiltro(string id)
        {
            return sn.ConsultaReporteDetalleFiltro(id);
        }

        /*INSERT*/
        public OdbcDataReader InsertarReporteEnca(string reporte, string idEmpleado, string idPuesto, string fecha, string tipo, string medio)
        {   //(string reporte, string idEmpleado, string idPuesto, string fecha, string tipo, string medio)
            return sn.InsertarReporEncabezado(reporte, idEmpleado, idPuesto, fecha, tipo,medio);
        }

        public OdbcDataReader InsertarReporteDeta(string cod, string primaria, string secundaria, string bachi, string eU, string gU, string cE, string dC, string sueldo)
        {   //(string cod, string primaria, string secundaria, string bachi, string eU, string gU, string cE, string dC, string sueldo)
            return sn.InsertarReporDetalle(cod, primaria,secundaria, bachi, eU, gU, cE, dC, sueldo);
        }

    }
}
