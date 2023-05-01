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
    public enum Operaciones
    {
        noDefinida =0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicaion = 4,
        Modulo = 5,
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void leerNumero(string numero)
        {
            unNumero = true;
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
            unNumero = true;
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

        double valor1 = 0;
        double valor2 = 0;
        Operaciones operador = Operaciones.noDefinida;
        bool unNumero = false;

        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)
            {
                
                case Operaciones.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operaciones.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operaciones.Division:
                    if (valor2==0)
                    {
                        MessageBox.Show("No se puede dividir entre cero");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case Operaciones.Multiplicaion:
                    resultado = valor1 * valor2;
                    break;
                case Operaciones.Modulo:
                    resultado = valor1 % valor2;
                    break;
            }

            return resultado;
        }
        private void Obtenervalor(string operador)
        {
            valor1 = Convert.ToDouble(cajaresultado.Text);
            lblhistorial.Text = cajaresultado.Text + operador;
            cajaresultado.Text = "0";
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = Operaciones.Suma;
            Obtenervalor("+");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (valor2==0 && unNumero)
            {
                valor2 = Convert.ToDouble(cajaresultado.Text);
                lblhistorial.Text = valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                unNumero = false;
                cajaresultado.Text = Convert.ToString(resultado);
            }
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operador = Operaciones.Resta;
            Obtenervalor("-");
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            operador = Operaciones.Multiplicaion;
            Obtenervalor("*");
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operador = Operaciones.Division;
            Obtenervalor("/");
        }

        private void btnmodulo_Click(object sender, EventArgs e)
        {
            operador = Operaciones.Modulo;
            Obtenervalor("%");
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            cajaresultado.Text = "0";
            lblhistorial.Text = "";
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (cajaresultado.Text.Length > 1)
            {
                string txtresultado = cajaresultado.Text; 
                
                txtresultado = txtresultado.Substring(0, txtresultado.Length - 1);
                if (txtresultado.Length == 1 && txtresultado.Contains("-"))
                {
                    cajaresultado.Text = "0";
                }
                else
                {
                    cajaresultado.Text = txtresultado;
                }

                
            }
            else
            {
                cajaresultado.Text = "0";
            }
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (cajaresultado.Text.Contains("."))
            {
                return;
            }cajaresultado.Text += ".";
        }
    }
}
