using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ProyectoBase.Clases;
using System.Windows.Forms;

namespace ProyectoBase
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }

        public void Mensaje(string msj)
        {
            MessageBox.Show(msj, cMensaje.Mensaje());
        }
    }
}
