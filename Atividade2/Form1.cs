using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalc
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado; //globais
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtNúmero2_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNúmero2.Text, out numero2))
            {
                MessageBox.Show("Número 2 inválido!");
                // txtNum1.Focus();
            }
        }
        
        

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNumero1.Text, out numero1)) && (double.TryParse(txtNúmero2.Text, out numero2)))
            {
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString();

            }
            else
                MessageBox.Show("Números Inválidos!!");
        }

        private void BtnSubtrai_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNumero1.Text, out numero1)) && (double.TryParse(txtNúmero2.Text, out numero2)))
            {
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString();

            }
            else
                MessageBox.Show("Números Inválidos!!");
        }

        private void BtnMultiplica_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNumero1.Text, out numero1)) && (double.TryParse(txtNúmero2.Text, out numero2)))
            {
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString();

            }
            else
                MessageBox.Show("Números Inválidos!!");
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNumero1.Text, out numero1)) && (double.TryParse(txtNúmero2.Text, out numero2)))
            {
                if (numero2 == 0)
                    MessageBox.Show("Número 2 deve ser diferente de 0!");
                else
                {
                    resultado = numero1 / numero2;
                    txtResultado.Text = resultado.ToString();
                }
            }
            else
                MessageBox.Show("Números Inválidos!!");
            

        }

        private void BtnLimpa_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNúmero2.Clear();
            txtResultado.Clear();
            //ou a opção abaixo:
            //txtNumero1.Text = "";
            //txtNúmero2.Text = "";
            //txtResultado = "";
            //ou a opção abaixo:
            //txtNumero1.Text = String.Empty;
            //txtNúmero2.Text = String.Empty;
            //txtResultado = String.Empty;
        }

        private void TxtNumero1_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumero1.Text,out numero1))
            {
                MessageBox.Show("Número 1 inválido!");
                // txtNum1.Focus();
            }
        }
    }
}
