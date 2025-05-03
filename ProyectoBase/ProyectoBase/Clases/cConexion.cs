using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoBase.Clases
{
    public static  class cConexion
    {
        public static string Cadenacon()
        {
            //*****CASA**********
            string cadena = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=FT;Integrated Security=True";
           // string cadena = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=Copiaft;Integrated Security=True";
            //string cadena = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=PELUQUERIA;Integrated Security=True";
            //   string cadena = "Data Source=PABLO-PC\\SQL;Initial Catalog=PELUQUERIA;Integrated Security=True";

            return cadena;
        }
    }
}
