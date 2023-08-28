using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoBase.Clases
{
    public class cEquipo
    {
       public DataTable GetEquiposxCategoria(int IdCategoria)
        {
            string sql = "select idequipo,equipo from equipo where categoria=" + IdCategoria.ToString();
            sql = sql + " order by Equipo ";
            return cDb.ExecuteDataTable(sql);
        }

        public DataTable GetEquipoxCategoria(int IdCategoria)
        {
            string sql = "select * from Equipo where Categoria=" + IdCategoria.ToString();
            sql = sql + " order by Equipo ";
            return cDb.ExecuteDataTable(sql);
        }
    }
}
