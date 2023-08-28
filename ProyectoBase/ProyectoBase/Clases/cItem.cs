using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace ProyectoBase.Clases
{
    public class cItem
    {
        string sql = "";
        public DataTable GetItem()
        {
            sql = "select * from Item ";
            return cDb.ExecuteDataTable(sql);
        }

        public void Insertar(int IdTorneo,int Item,string Texto,
            string Redirect, int Value,int Orden)
        {
            sql = "insert into menu(IdTorneo,Item,Texto,Redirect,Value,Orden)";
            sql = sql + " values (" + IdTorneo.ToString();
            sql = sql + "," + Item.ToString();
            sql = sql + "," + "'" + Texto + "'";
            sql = sql + "," + "'" + Redirect + "'";
            sql = sql + "," + Value.ToString();
            sql = sql + "," + Orden.ToString();
            sql = sql + ")";
            cDb.ExecutarNonQuery(sql);
        }
    }
}
