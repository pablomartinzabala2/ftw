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
    
    public partial class FrmFixture : FrmBase
    {  /// <summary>
    /// inicio
    /// </summary>
        int local=0;
        cFunciones fun;
        DataTable tbEquipo;
        DataTable tbLocales;
        DataTable tbVisitantes;
        public FrmFixture()
        {
            InitializeComponent();
        }

        private void FrmFixture_Load(object sender, EventArgs e)
        {
            fun = new Clases.cFunciones();
            CargarTorneo();
            tbEquipo = new DataTable();
            tbEquipo.Columns.Add("IdEquipo");
            tbEquipo.Columns.Add("Nombre");

            tbLocales = new DataTable();
            tbLocales.Columns.Add("IdEquipo");
            tbLocales.Columns.Add("Nombre");

            tbVisitantes = new DataTable();
            tbVisitantes.Columns.Add("IdEquipo");
            tbVisitantes.Columns.Add("Nombre");

        }

        private void CargarTorneo()
        {
            cTorneo torneo = new cTorneo();
            DataTable trdo = torneo.GetTorneos();
            fun.LlenarComboDatatable(cmbTorneo, trdo, "Campeonato", "IdTorneo");
        }

        private void btnCargarEquipos_Click(object sender, EventArgs e)
        {
            CargarEquipos();
        }

        private void CargarEquipos()
        {
            cFunciones fun = new cFunciones();
            tbEquipo.Rows.Clear();
            int IdTorneo = Convert.ToInt32(cmbTorneo.SelectedValue);
            int Categoria = GetCategoria(Convert.ToInt32(cmbTorneo.SelectedValue));
            cEquipo equipo = new Clases.cEquipo();
         //   DataTable trdo = equipo.GetEquipoxCategoria(Categoria);
            DataTable trdo = equipo.GetEquipoxTorneo(IdTorneo);
            
            int IdEquipo = 0;
            string Nombre = "";
            for (int i = 0; i < trdo.Rows.Count; i++)
            {
                IdEquipo = Convert.ToInt32(trdo.Rows[i]["IdEquipo"]);
                Nombre = trdo.Rows[i]["Equipo"].ToString();
                DataRow r = tbEquipo.NewRow();
                r[0] = IdEquipo;
                r[1] = Nombre;
                tbEquipo.Rows.Add(r);
            }
            Grilla.DataSource = tbEquipo;
            fun.AnchoColumnas(Grilla, "0;100");
            DataTable tbTodos = equipo.GetEquipoxCategoria(Categoria);
            fun.LlenarComboDatatable  (cmbEquipo, tbTodos, "equipo", "IdEquipo");
           // Grilla.Columns[0].Visible = false;
            CargarFecha();
        }

        private void CargarFecha()
        {
            int IdTorneo = Convert.ToInt32(cmbTorneo.SelectedValue);
            cTorneo torneo = new Clases.cTorneo();
            int fecha = torneo.CargarFechaActual(IdTorneo);
            txtFecha.Text = fecha.ToString();
        }


        private int GetCategoria(int IdTorneo)
        {
            int Categoria = 0;
            cTorneo torneo = new cTorneo();
            DataTable tb = torneo.GetTorneoxId(IdTorneo);
            if (tb.Rows.Count >0)
            {
                Categoria = Convert.ToInt32(tb.Rows[0]["Categoria"].ToString());
            }
            return Categoria;
        }

        private void Grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cFunciones fun = new cFunciones();
            string IdEquipo = "";
            string Equipo = "";
            IdEquipo = Grilla.CurrentRow.Cells[0].Value.ToString();
            Equipo = Grilla.CurrentRow.Cells[1].Value.ToString();
            if (local ==0)
            {
                string Val = IdEquipo + ";" + Equipo;
                tbLocales = fun.AgregarFilas(tbLocales,Val);
                GrillaLocal.DataSource = tbLocales;
                fun.AnchoColumnas(GrillaLocal, "0;100");
                
                local = 1;
            }
            else
            {
                string Val = IdEquipo + ";" + Equipo;
                tbVisitantes = fun.AgregarFilas(tbVisitantes, Val);
                GrillaVisitante.DataSource = tbVisitantes;
               // GrillaVisitante.Columns[0].Visible = false;
                fun.AnchoColumnas(GrillaVisitante, "0;100");
                local = 0;
            }

            for (int i=0;i<tbEquipo.Rows.Count;i++)
            {
                if (tbEquipo.Rows[i]["IdEquipo"].ToString ()==IdEquipo)
                {
                    tbEquipo.Rows[i].Delete();
                    tbEquipo.AcceptChanges();
                    Grilla.DataSource = tbEquipo; 
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            /*
            if (tbEquipo.Rows.Count >0)
            {
                MessageBox.Show("Debe seleccionar todos los equipos ");
                return;
            }
            */
            cFixture fixture = new cFixture();
            int IdTorneo = 0;
            int Fecha = 0;
            IdTorneo = Convert.ToInt32(cmbTorneo.SelectedValue);
            Fecha = Convert.ToInt32(txtFecha.Text);
            int IdLocal = 0, IdVisitante = 0;
            int b = 0;
            for (int i = 0; i < tbLocales.Rows.Count; i++)
            {
                IdLocal = Convert.ToInt32(tbLocales.Rows[i]["IdEquipo"]);
                IdVisitante = Convert.ToInt32(tbVisitantes.Rows[i]["IdEquipo"]);
                fixture.Grabar(IdTorneo, Fecha, IdLocal, IdVisitante);
                b = 1;
            }

            if (b ==1)
            {
                local = 0;
                MessageBox.Show("Datos grabados correctamente ");
                CargarFecha();
                tbEquipo.Rows.Clear();
                tbLocales.Rows.Clear();
                tbVisitantes.Rows.Clear();
                CargarEquipos();
            }
        }

        private void Grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            cFunciones fun = new cFunciones();
            string IdEquipo = "";
            string Equipo = "";
            string Val = "";

            if (GrillaLocal.Rows.Count >0)
            {
                IdEquipo = GrillaLocal.CurrentRow.Cells[0].Value.ToString();
                Equipo = GrillaLocal.CurrentRow.Cells[1].Value.ToString();
                Val = IdEquipo + ";" + Equipo;
                fun.AgregarFilas(tbEquipo, Val);

                for (int i = 0; i < tbLocales.Rows.Count; i++)
                {
                    if (tbLocales.Rows[i]["IdEquipo"].ToString() == IdEquipo)
                    {
                        tbLocales.Rows[i].Delete();
                        tbLocales.AcceptChanges();
                        GrillaLocal.DataSource = tbLocales;
                    }
                }
            }

        }

        private void btnAnularVisitante_Click(object sender, EventArgs e)
        {
            cFunciones fun = new cFunciones();
            string IdEquipo = "";
            string Equipo = "";
            string Val = "";

            if (GrillaVisitante.Rows.Count > 0)
            {
                IdEquipo = GrillaVisitante.CurrentRow.Cells[0].Value.ToString();
                Equipo = GrillaVisitante.CurrentRow.Cells[1].Value.ToString();
                Val = IdEquipo + ";" + Equipo;
                fun.AgregarFilas(tbEquipo, Val);

                for (int i = 0; i < GrillaVisitante.Rows.Count; i++)
                {
                    if (tbVisitantes.Rows[i]["IdEquipo"].ToString() == IdEquipo)
                    {
                        tbVisitantes.Rows[i].Delete();
                        tbVisitantes.AcceptChanges();
                        GrillaVisitante.DataSource = tbVisitantes;
                    }
                }
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        { //adfd
            cFunciones fun = new cFunciones();
            tbEquipo.Rows.Clear();
            int IdTorneo = Convert.ToInt32(cmbTorneo.SelectedValue);
            int Categoria = GetCategoria(Convert.ToInt32(cmbTorneo.SelectedValue));
            cEquipo equipo = new Clases.cEquipo();
               DataTable trdo = equipo.GetEquipoxCategoria(Categoria);
          //  DataTable trdo = equipo.GetEquipoxTorneo(IdTorneo);
            int IdEquipo = 0;
            string Nombre = "";
            for (int i = 0; i < trdo.Rows.Count; i++)
            {
                IdEquipo = Convert.ToInt32(trdo.Rows[i]["IdEquipo"]);
                Nombre = trdo.Rows[i]["Equipo"].ToString();
                DataRow r = tbEquipo.NewRow();
                r[0] = IdEquipo;
                r[1] = Nombre;
                tbEquipo.Rows.Add(r);
            }
            Grilla.DataSource = tbEquipo;
            fun.AnchoColumnas(Grilla, "0;100");
            // Grilla.Columns[0].Visible = false;
            CargarFecha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cFunciones fun = new cFunciones();
            cEquipo eq = new cEquipo();
            int  IdEquipo = 0;
            string Equipo = "";
            IdEquipo = Convert.ToInt32(cmbEquipo.SelectedValue);
            Equipo = eq.GeNombretEquipoxId(IdEquipo);
            if (local == 0)
            {
                string Val = IdEquipo + ";" + Equipo;
                tbLocales = fun.AgregarFilas(tbLocales, Val);
                GrillaLocal.DataSource = tbLocales;
                fun.AnchoColumnas(GrillaLocal, "0;100");

                local = 1;
            }
            else
            {
                string Val = IdEquipo + ";" + Equipo;
                tbVisitantes = fun.AgregarFilas(tbVisitantes, Val);
                GrillaVisitante.DataSource = tbVisitantes;
                // GrillaVisitante.Columns[0].Visible = false;
                fun.AnchoColumnas(GrillaVisitante, "0;100");
                local = 0;
            }

            for (int i = 0; i < tbEquipo.Rows.Count; i++)
            {
                if (tbEquipo.Rows[i]["IdEquipo"].ToString() == IdEquipo.ToString ())
                {
                    tbEquipo.Rows[i].Delete();
                    tbEquipo.AcceptChanges();
                    Grilla.DataSource = tbEquipo;
                }
            }

        }
    }
}
