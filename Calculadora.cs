using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        //variables
        int numeroOne = 0, numeroTwo = 0, resultado = 0; 
        string operador="";

        //funciones

        private void Operaciones()
        {
            switch (operador)
            {
                case "/":
                    resultado = numeroOne / numeroTwo;
                    txtCalculadora.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = numeroOne * numeroTwo;
                    txtCalculadora.Text = resultado.ToString();
                    break;
                case "+":
                    resultado = numeroOne + numeroTwo;
                    txtCalculadora.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = numeroOne - numeroTwo;
                    txtCalculadora.Text = resultado.ToString();
                    break;
            }
        }
        private void Limpiar()
        {
            txtCalculadora.Text = "";
        }

        private void AsignacionNum()
        {
            if (numeroOne == 0)
            {
                numeroOne = Convert.ToInt32(txtCalculadora.Text);
            }
            else
            {
                numeroTwo = Convert.ToInt32(txtCalculadora.Text);
            }
        }
        private void btnNueve_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "9";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "8";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "7";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "6";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "5";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "4";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "3";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "2";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "1";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtCalculadora.Text += ",";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            AsignacionNum();
            operador = "/";
            Limpiar();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            AsignacionNum();
            operador = "*";
            Limpiar();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            AsignacionNum();
            operador = "-";
            Limpiar();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            AsignacionNum();
            operador = "+";
            Limpiar();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            AsignacionNum();
            Operaciones();
            numeroOne = Convert.ToInt32(txtCalculadora.Text);
        }
    }
}
