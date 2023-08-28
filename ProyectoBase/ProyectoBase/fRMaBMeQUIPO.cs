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
    public partial class fRMaBMeQUIPO : FrmBase
    {
        cFunciones fun;
        public fRMaBMeQUIPO()
        {
            InitializeComponent();
        }

        private void fRMaBMeQUIPO_Load(object sender, EventArgs e)
        {
            Botonera(1);
            Grupo.Enabled = false;
            fun = new Clases.cFunciones();
            fun.LlenarCombo(cmb_Categoria, "Categoria", "Descripcion", "IdCategoria");
        }

        private void Botonera(int Jugada)
        {
            switch (Jugada)
            {
                //estado inicial
                case 1:
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;

                    break;
                case 2:
                    btnNuevo.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;

                    break;
                case 3:
                    //viene del buscador
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;


                    break;
            }


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Botonera(2);
            Clases.cFunciones fun = new Clases.cFunciones();
            fun.LimpiarGenerico(this);
            txtCodigo.Text = "";
            Grupo.Enabled = true;
            txt_Equipo.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {  
            if (txt_Equipo.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre para continuar", Clases.cMensaje.Mensaje());
                return;
            }

            Clases.cFunciones fun = new Clases.cFunciones();


            if (txtCodigo.Text == "")
                fun.GuardarNuevoGenerico(this, "Equipo");
            else
                fun.ModificarGenerico(this, "Equipo", "IdEquipo", txtCodigo.Text);
            MessageBox.Show("Datos grabados Correctamente", Clases.cMensaje.Mensaje());
            Botonera(1);
            fun.LimpiarGenerico(this);
            txtCodigo.Text = "";
            Grupo.Enabled = false;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //nombre de los camposa buscar, se llaman igual que en la base de datos
            //exepcional para este abm
            Principal.CodigoSenia = "1";
            Principal.OpcionesdeBusqueda = "Equipo";
            //nombre de la tabla, 
            Principal.TablaPrincipal = "Equipo";

            Principal.OpcionesColumnasGrilla = "IdEquipo;Equipo";
            Principal.ColumnasVisibles = "0;1";
            Principal.ColumnasAncho = "0;580";
            FrmBuscadorGenerico form = new FrmBuscadorGenerico();
            form.FormClosing += new FormClosingEventHandler(form_FormClosing);
            form.ShowDialog();

        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clases.cFunciones fun = new Clases.cFunciones();
            //CargarJugador(Convert.ToInt32(PRINCIPAL.CDOGIO_JUGADOR));
            if (Principal.CodigoPrincipalAbm != null)
            {
                if (Principal.CodigoPrincipalAbm != "")
                {
                    Botonera(3);
                    txtCodigo.Text = Principal.CodigoPrincipalAbm.ToString();

                    if (Principal.CodigoPrincipalAbm != "")
                        fun.CargarControles(this, "Equipo", "IdEquipo", txtCodigo.Text);
                    Grupo.Enabled = false;
                    //return;
                }

            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Botonera(2);
            Grupo.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
