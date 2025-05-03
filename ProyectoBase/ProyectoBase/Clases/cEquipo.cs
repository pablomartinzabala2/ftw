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

        public DataTable GetEquipoxTorneo(int IDTorneo)
        {
            string sql = "select e.* ";
            sql = sql + " from Equipo e, EquiposxTorneo et ";
            sql = sql + " where e.IdEquipo = et.IdEquipo ";
            sql = sql + " and et.IdTorneo=" + IDTorneo.ToString();
            sql = sql + " order by Equipo ";
            return cDb.ExecuteDataTable(sql);
        }

        public string GeNombretEquipoxId(int IdEquipo)
        {
            string Nombre = "";
            string sql = "select equipo from equipo ";
            sql = sql + " where IdEquipo=" + IdEquipo.ToString();
            DataTable trdo = cDb.ExecuteDataTable(sql);
            if (trdo.Rows.Count >0)
            {
                Nombre = trdo.Rows[0]["Equipo"].ToString(); 
            }
            return Nombre;
        }
    }
}
