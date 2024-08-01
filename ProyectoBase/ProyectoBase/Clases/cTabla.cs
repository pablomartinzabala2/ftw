using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using TablaDLL;
namespace ProyectoBase.Clases
{
    public  class cTabla
    {
        public DataView GetTablaGeneral(int IdTorneo)
        {
            // string Cadena = cConexion.Cadenacon();
            // DataTable trdo = SqlHelper.ExecuteDataset(Cadena, "TablaLocalGet", IdTorneo).Tables[0];
            // return trdo;
            TablaDLL.Tabla obj = new TablaDLL.Tabla();
            DataView trdo = obj.TablaGral(IdTorneo);
            return trdo;
        }
    }
}
