using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void leerNumero(string numero)
        {
            if (cajaresultado.Text == "0" && cajaresultado.Text != null)
            {
                cajaresultado.Text = numero;
            }
            else
            {
                cajaresultado.Text += numero;
            }
        }

        private void Btncero_Click(object sender, EventArgs e)
        {
            if (cajaresultado.Text == "0")
            {
                return;
            }
            else
            {
                cajaresultado.Text += "0";
            }
            
        }

        private void btnuno_Click(object sender, EventArgs e)
        {
            leerNumero("1");
        }

        private void btndos_Click(object sender, EventArgs e)
        {
            leerNumero("2");
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            leerNumero("3");
        }

        private void btncuatro_Click(object sender, EventArgs e)
        {
            leerNumero("4");

        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            leerNumero("5");
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            leerNumero("6");
        }

        private void btnsiete_Click(object sender, EventArgs e)
        {
            leerNumero("7");
        }

        private void btnocho_Click(object sender, EventArgs e)
        {
            leerNumero("8");
        }

        private void btnnueve_Click(object sender, EventArgs e)
        {
            leerNumero("9");
        }
    }
}
