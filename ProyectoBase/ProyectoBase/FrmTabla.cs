using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyectoBase.Clases;
namespace ProyectoBase
{
    public partial class FrmTabla : FrmBase
    {
        public FrmTabla()
        {
            InitializeComponent();
        }

        private void FrmTabla_Load(object sender, EventArgs e)
        {
            cTabla tabla = new Clases.cTabla();
            DataView trdo = tabla.GetTablaGeneral(9);

        }
    }
}
