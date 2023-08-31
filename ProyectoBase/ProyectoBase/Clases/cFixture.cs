using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace ProyectoBase.Clases
{
    public class cFixture
    {
        public void Grabar(int IdTorneo,int Fecha,
            int IdLocal,int IdVisitante)
        {
            string sql = "";
            sql = "Insert into Fixture(Idtorneo,Fecha,IdLocal,IdVisitante,jugo)";
            sql = sql + " Values(" + IdTorneo.ToString();
            sql = sql + "," + Fecha.ToString();
            sql = sql + "," + IdLocal.ToString();
            sql = sql + "," + IdVisitante.ToString();
            sql = sql + ",0";
            sql = sql + ")";
            cDb.ExecutarNonQuery(sql);
        }

        public DataTable GetFixturexFecha(int IdTorneo, int Fecha)
        {
            string sql = "";
            sql = "select f.idpartido, l.equipo,f.gl, v.equipo, f.gv,f.fechaPartido";
            sql = sql + " from dbo.Fixture f,equipo l,equipo v,torneo t";
            sql = sql + " where(f.idlocal = l.idequipo)";
            sql = sql + " and f.idvisitante = v.idequipo";
            sql = sql + " and f.idtorneo=t.idtorneo";
            sql = sql + " and f.idtorneo=" + IdTorneo.ToString();
            sql = sql + " and f.fecha=" + Fecha.ToString();
            return cDb.ExecuteDataTable(sql);
        }
    }
}
