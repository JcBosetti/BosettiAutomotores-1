using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AAA.Parte_Bruno
{
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }

        private void labelCaja_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {

        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtid_categoria.Text = "";
            txtDescripcion.Text = "";
        }
       
    }
}
