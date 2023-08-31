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
    public partial class FrmPartido : FrmBase
    {
        cFunciones fun;
        public FrmPartido()
        {
            InitializeComponent();
        }

        private void FrmPartido_Load(object sender, EventArgs e)
        {
            fun = new Clases.cFunciones();
            cTorneo torneo = new cTorneo();
            DataTable trdo = torneo.GetTorneos();
            fun.LlenarComboDatatable (cmbtorneo, trdo, "Campeonato", "IdTorneo");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbtorneo.SelectedIndex <1)
            {
                MessageBox.Show("Debe seleccionar un torneo");
                return;
            }

            if (txtFecha.Text =="")
            {
                MessageBox.Show("Debe ingresar una fecha ");
                return;
            }

            int IdTorneo = Convert.ToInt32(cmbtorneo.SelectedValue);
            int Fecha = Convert.ToInt32(txtFecha.Text);
            cFixture fix = new cFixture();
            DataTable trdo = fix.GetFixturexFecha(IdTorneo, Fecha);
            Grilla.DataSource = trdo;
            fun.AnchoColumnas(Grilla, "10;25;10;25;10;20");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string sql = "";
            int IdPartido = 0;
            int b = 0;
            int gl = 0, gv = 0, dif = 0;
            int pl = 0, pv = 0, GanoL = 0, GanoV = 0;
            int EmpateL = 0, EmpateV = 0, PerdioL = 0, PerdioV = 0;
            string FechaPartido = "";
            for (int i = 0; i < Grilla.Rows.Count - 1; i++)
            {
                IdPartido = Convert.ToInt32(Grilla.Rows[i].Cells[0].Value);
                if (Grilla.Rows[i].Cells[5].Value.ToString ()!="")
                {
                    b = 1;
                    gl = Convert.ToInt32(Grilla.Rows[i].Cells[2].Value.ToString());
                    gv = Convert.ToInt32(Grilla.Rows[i].Cells[4].Value.ToString());
                    FechaPartido = Grilla.Rows[i].Cells[5].Value.ToString();
                    dif = gl - gv;
                    if (dif >0)
                    {
                        pl = 3;
                        pv = 0;
                        GanoL = 1;
                        GanoV = 0;
                        EmpateL = 0;
                        EmpateV = 0;
                        PerdioL = 0;
                        PerdioV = 1;
                    }
                    if (dif <0)
                    {
                        pl = 0;
                        pv = 3;
                        GanoL = 0;
                        GanoV = 1;
                        EmpateL = 0;
                        EmpateV = 0;
                        PerdioL = 1;
                        PerdioV = 0;
                    }

                    if (dif ==0)
                    {
                        pl = 1;
                        pv = 1;
                        GanoL = 0;
                        GanoV = 0;
                        EmpateL = 1;
                        EmpateV = 1;
                        PerdioL = 0;
                        PerdioV = 0;
                    }

                    sql = "update fixture";
                    sql = sql + " set gl=" + gl.ToString();
                    sql = sql + ",gv =" + gv.ToString();
                    sql = sql + ",pl=" + pl.ToString();
                    sql = sql + ",pv =" + pv.ToString();
                    sql = sql + ",GanoL =" + GanoL.ToString();
                    sql = sql + ",GanoV =" + GanoV.ToString();
                    sql = sql + ",EmpateL =" + EmpateL.ToString();
                    sql = sql + ",EmpateV =" + EmpateV.ToString();
                    sql = sql + ",PerdioL =" + PerdioL.ToString();
                    sql = sql + ",PerdioV =" + PerdioV.ToString();
                    sql = sql + ",FechaPartido=" + "'" + FechaPartido.ToString() + "'";
                    sql = sql + ", jugo=1";
                    sql = sql + " where idpartido=" + IdPartido.ToString();
                    cDb.ExecutarNonQuery(sql);
                }
            }
            if (b ==1)
            {
                MessageBox.Show("Datos grabados correctamente");
            }
        }
    }
}
