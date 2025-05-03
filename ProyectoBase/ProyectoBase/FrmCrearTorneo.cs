using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyectoBase.Clases;
using TablaDLL;

namespace ProyectoBase
{
    public partial class FrmCrearTorneo : FrmBase
    {
        cFunciones fun;
        public FrmCrearTorneo()
        {
            InitializeComponent();
        }

        private void Inicializar()
        {
            fun.LlenarCombo(cmbcategoria, "Categoria", "Descripcion", "IdCategoria");
            //cargamos la zona
            DataTable tbZona = fun.CrearTabla("CodZona;Nombre");
            tbZona = fun.AgregarFilas(tbZona, "1;1");
            tbZona = fun.AgregarFilas(tbZona, "2;2");
            fun.LlenarComboDatatable(cmbZona, tbZona, "Nombre", "CodZona");
        }

        private void FrmCrearTorneo_Load(object sender, EventArgs e)
        {
            fun = new cFunciones();
            Inicializar();
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            if (cmbcategoria.SelectedIndex<1)
            {
                MessageBox.Show("Debe seleccionar un elemento ");
                return;
            }
            int IdCategoria = Convert.ToInt32(cmbcategoria.SelectedValue);
            CargarEquipos(IdCategoria);
        }

        private void CargarEquipos(int Idcategoria)
        {
            cFunciones fun = new Clases.cFunciones();
            cEquipo equipo = new cEquipo();
            DataTable trdo = equipo.GetEquiposxCategoria(Idcategoria);
            Grilla1.DataSource = trdo;
            fun.AnchoColumnas(Grilla1, "0;100");
         //   Grilla1.Columns[0].Width = 50;
         //   Grilla1.Columns[1].Width = 150;
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            cFunciones fun = new cFunciones();
            int i = 0;
            int idequipo = 0;
            int Zona = 0;
            string Equipo = "";
            if (cmbZona.SelectedIndex > 0)
                Zona = Convert.ToInt32(cmbZona.SelectedValue);
            for (i=0;i<Grilla1.Rows.Count-1;i++)
            {
                idequipo = Convert.ToInt32(Grilla1.Rows[i].Cells[0].Value );
                Equipo = Grilla1.Rows[i].Cells[1].Value.ToString();
                Grilla2.Rows.Add(idequipo, Equipo, Zona);
            } 
            txtcantidad.Text = (Grilla2.Rows.Count - 1).ToString();
            // Grilla2.Columns[0].Width = 50;
            // Grilla2.Columns[1].Width = 150;
            fun.AnchoColumnas(Grilla2, "0;100");
            Grilla2.Columns[1].HeaderText = "Equipo"; 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txttorneo.Text=="")
            {
                MessageBox.Show("Debe ingresar un tornoe ");
                return;
            }
            cTorneo Torneo = new cTorneo();
            string NombreTorneo = txttorneo.Text;
            int IdCategoria = Convert.ToInt32(cmbcategoria.SelectedValue);
            string Temporada = txttemporada.Text;
            int IdTorneo = Torneo.Insertar(NombreTorneo, IdCategoria, Temporada);
            int IdEquipo = 0;
            int? Zona = null;
            int zn = 0;
            for (int i=0;i<Grilla2.Rows.Count-1;i++)
            {
                IdEquipo = Convert.ToInt32(Grilla2.Rows[i].Cells[0].Value);
                zn = Convert.ToInt32(Grilla2.Rows[i].Cells[2].Value);
                if (zn ==0)
                {
                    Zona = null;
                }
                else
                {
                    Zona = zn;
                }
                Torneo.InsertarEquipoxTroeno(IdEquipo, IdTorneo, Zona);
            }
            MessageBox.Show("Datos grabados correctamente ");
            txttorneo.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
              
          //  idequipo = Convert.ToInt32(Grilla1.Rows[i].Cells[0].Value);
          //  Equipo = Grilla1.Rows[i].Cells[1].Value.ToString();
            Int32 IdEquipo = Convert.ToInt32(Grilla1.CurrentRow.Cells[0].Value);
            string Equipo = Grilla1.CurrentRow.Cells[1].Value.ToString();
            int Zona = 0;
            if (cmbZona.SelectedIndex > 0)
                Zona = Convert.ToInt32(cmbZona.SelectedValue);

            Grilla2.Rows.Add(IdEquipo, Equipo, Zona);
            txtcantidad.Text = (Grilla2.Rows.Count - 1).ToString();
            // Grilla2.Columns[0].Width = 50;
            // Grilla2.Columns[1].Width = 150;
            fun.AnchoColumnas(Grilla2, "0;100");
            Grilla2.Columns[1].HeaderText = "Equipo";
        }
    }
}
