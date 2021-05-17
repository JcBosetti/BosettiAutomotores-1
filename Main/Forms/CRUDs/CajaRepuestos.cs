using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AAA.Parte_Bruno
{
    public partial class CajaRepuestos : Form
    {
        public CajaRepuestos()
        {
            InitializeComponent();
        }

        private void panelEmpresa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEstanteria_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txt_idcaja.Text = "";
            txtid_estanteria.Text = "";
        }

        private void labelPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
