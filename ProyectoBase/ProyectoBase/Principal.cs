using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBase
{
    public partial class Principal : Form
    {
        //nombre del campo id
        public static string CampoIdSecundario;
        //nombre del campo descripcion
        public static string CampoNombreSecundario;
        //nombre de la tabla donde se realiza el grabado
        public static string NombreTablaSecundario;
        public static string NombreLabelSecundario;
        //valor del id que genera al insertar
        public static string CampoIdSecundarioGenerado;
        public static Int32 CodUsuarioLogueado;
        public static string NombreUsuarioLogueado;
        public static string CodigoPrincipalAbm;
        public static string CodigoCorte;
        public static string CodigoSenia;
        public static string CodidoClientePrincipal;
        private int childFormNumber = 0;
        public static string OpcionesdeBusqueda;
        public static string TablaPrincipal;
        public static string OpcionesColumnasGrilla;
        public static string ColumnasVisibles;
        public static string ColumnasAncho;
        public static Boolean EsAdministrador;
        public static Boolean VieneDeCaja;
        

        public Principal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbmBarrio childForm = new FrmAbmBarrio();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fRMaBMeQUIPO frm = new ProyectoBase.fRMaBMeQUIPO();
            frm.Show();
        }

        private void torneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearTorneo frm = new ProyectoBase.FrmCrearTorneo();
            frm.Show();
        }

        private void fixtureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFixture frm = new ProyectoBase.FrmFixture();
            frm.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
        }

        private void cargarResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPartido frm = new ProyectoBase.FrmPartido();
            frm.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTabla frm = new FrmTabla();
            frm.Show();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFixture frm = new FrmFixture();
            frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmTabla frm = new FrmTabla();
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
