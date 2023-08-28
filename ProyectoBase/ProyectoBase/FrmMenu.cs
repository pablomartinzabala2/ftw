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
    public partial class FrmMenu : FrmBase
    {
        cFunciones fun;
        DataTable tb2;
        DataTable tb1;
        int Orden = 0;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void CargarTorneo()
        {  
            cTorneo torneo = new cTorneo();
            DataTable trdo = torneo.GetTorneos();
            fun.LlenarComboDatatable(cmbtorneo, trdo, "Campeonato", "IdTorneo");
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            fun = new Clases.cFunciones();
            Inicio();
        }

        private void Inicio()
        {
            CargarTorneo();
            cItem item = new cItem();
            tb1 = item.GetItem();
            grilla1.DataSource = tb1;
            tb2 = new DataTable();
            tb2 = fun.CrearTabla("IdTorneo;Item;Texto;Value;Redirect;Orden");
        }

        private void grilla1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdTorneo = Convert.ToInt32(cmbtorneo.SelectedValue);
            string Texto = "";
            int Value = 0;
            string Redirect = "";
            int NroItem = 0;
      

            NroItem = Convert.ToInt32 (grilla1.CurrentRow.Cells[0].Value);
            Texto = grilla1.CurrentRow.Cells[1].Value.ToString();
            Value = Convert.ToInt32(grilla1.CurrentRow.Cells[0].Value);
            Redirect = grilla1.CurrentRow.Cells[3].Value.ToString();

            for (int i =0;i<tb1.Rows.Count;i++)
            {
                if (tb1.Rows[i]["NroItem"].ToString ()==NroItem.ToString ())
                {
                    Orden = Orden + 1;
                    DataRow fila = tb2.NewRow();
                    fila["IdTorneo"] = IdTorneo;
                    fila["item"] = Convert.ToInt32 (tb1.Rows[i]["NroItem"]);
                    fila["Texto"] = tb1.Rows[i]["Texto"].ToString();
                    fila["Value"] = tb1.Rows[i]["Value"].ToString();
                    fila["Redirect"] = tb1.Rows[i]["Redirect"].ToString();
                    fila["Orden"] = Orden;
                    tb2.Rows.Add(fila);
                    Grilla2.DataSource = tb2;
                }
            }
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            cItem item = new cItem();
            int IdTorneo = 0;
            int Item = 0;
            string Texto = "";
            int  Value = 0;
            int Orden = 0;
            string Redirect = "";
            int b = 0;
            for (int i = 0; i < tb2.Rows.Count; i++)
            {
                IdTorneo = Convert.ToInt32(tb2.Rows[i]["IdTorneo"]);
                Item = Convert.ToInt32(tb2.Rows[i]["Item"]);
                Texto = tb2.Rows[i]["Texto"].ToString();
                Value = Convert.ToInt32 (tb2.Rows[i]["Value"].ToString());
                Redirect = tb2.Rows[i]["Redirect"].ToString();
                Orden = Convert.ToInt32(tb2.Rows[i]["Orden"]);
                item.Insertar(IdTorneo, Item, Texto, Redirect, Value, Orden);
                b = 1;
            }
            if (b==1)
            {
                MessageBox.Show("Datos grabados correctamente ");
            }
        }
    }
}
