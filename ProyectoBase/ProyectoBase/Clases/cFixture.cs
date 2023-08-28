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
    }
}
