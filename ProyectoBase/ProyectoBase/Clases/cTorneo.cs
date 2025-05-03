using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace ProyectoBase.Clases
{
    public class cTorneo
    {
        public Int32 Insertar(string Torneo,int Categoria, string Temporada)
        {
            string sql = "insert into Torneo(";
            sql = sql + "Torneo,Categoria,Temporada,Finalizo";
            sql = sql + ")";
            sql = sql + " values (" + "'" + Torneo + "'";
            sql = sql + "," + Categoria.ToString();
            sql = sql + "," + "'" + Temporada + "'";
            sql = sql + ",'N'";
            sql = sql + ")";
            return cDb.EjecutarEscalar(sql);
        }

        public void InsertarEquipoxTroeno(int IdEquipo,int IdTorneo, int? Zona)
        {
            string sql = "insert into EquiposxTorneo(";
            sql = sql + "IdEquipo,IdTorneo,Zona)";
            sql = sql + " Values(" + IdEquipo.ToString();
            sql = sql + "," + IdTorneo.ToString();
            if (Zona != null)
                sql = sql + "," + Zona.ToString();
            else
                sql = sql + ",null";
            sql = sql + ")";
            cDb.ExecutarNonQuery(sql);
        }

        public DataTable GetTorneos()
        {
            //string sql = "select * from Torneo WHERE FINALIZO ='N'";
            string sql = " select  IdTorneo,(Torneo + ' ' + Temporada) as Campeonato ";
            sql = sql + " from Torneo WHERE FINALIZO ='N' ";
            return cDb.ExecuteDataTable(sql);
        }

        public DataTable GetTorneoxId(int IdTorneo)
        {
            string sql = "select * from Torneo ";
            sql = sql + " where IdTorneo =" + IdTorneo.ToString();
            return cDb.ExecuteDataTable(sql);
        }

        public int CargarFechaActual(int IdTorneo)
        {
            int Fecha = 0;
            string sql = "select isnull(max(fecha),0) as fecha from Fixture where IdTorneo=" + IdTorneo.ToString();
            DataTable trdo = cDb.ExecuteDataTable(sql);
            if (trdo.Rows.Count >0)
            {
                Fecha = Convert.ToInt32(trdo.Rows[0]["Fecha"]) + 1; 
            }
            return Fecha;
        }

    }
}
