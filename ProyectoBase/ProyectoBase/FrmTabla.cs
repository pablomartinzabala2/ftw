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
        cFunciones fun;
        public FrmTabla()
        {
            InitializeComponent();
        }

        private void FrmTabla_Load(object sender, EventArgs e)
        {
            fun = new Clases.cFunciones();
            CargarTorneo();          
        }

        private void CargarTablaxTorneo(int IdTorneo)
        {
            cTabla tabla = new Clases.cTabla();
            DataView trdo = tabla.GetTablaGeneral(IdTorneo);
            Grilla.DataSource = trdo;
            string Col = "8;0;28;8;8;8;8;8;8;8;8";
            fun.AnchoColumnas(Grilla, Col);
        }

        private void CargarTorneo()
        {
            cTorneo torneo = new cTorneo();
            DataTable trdo = torneo.GetTorneos();
            fun.LlenarComboDatatable(cmbTorneo, trdo, "Campeonato", "IdTorneo");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCargarEquipos_Click(object sender, EventArgs e)
        {
            if (cmbTorneo.SelectedIndex < 1)
            {
                MessageBox.Show("Debe seleccionar un torneo ");
                return;
            }

            int IdTorneo = Convert.ToInt32(cmbTorneo.SelectedValue);
            CargarTablaxTorneo(IdTorneo);
        }
    }
}
