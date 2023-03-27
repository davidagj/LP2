using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade4
{
    public partial class Form1 : Form
    {
        double LadoA, LadoB, LadoC;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtLadoB_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLadoB.Text, out LadoB))
                MessageBox.Show("numero invalido");
            else if (LadoB < 0)
                MessageBox.Show("Numero invalido");
        }

        private void txtLadoC_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLadoC.Text, out LadoC))
                MessageBox.Show("numero invalido");
            else if (LadoC < 0)
                MessageBox.Show("numero invalido");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if ((LadoA < (LadoB + LadoC)) && (LadoA > Math.Abs(LadoB - LadoC)) &&
                 (LadoB < (LadoA + LadoC)) && (LadoB > Math.Abs(LadoA - LadoC)) &&
                 (LadoC < (LadoB + LadoA)) && (LadoC > Math.Abs(LadoB - LadoA)) &&
                 (LadoA == LadoB) && (LadoB == LadoC))
            {
                MessageBox.Show("É triângulo,e é equilátero");
            }
            else if ((LadoA < (LadoB + LadoC)) && (LadoA > Math.Abs(LadoB - LadoC)) &&
                (LadoB < (LadoA + LadoC)) && (LadoB > Math.Abs(LadoA - LadoC)) &&
                (LadoC < (LadoB + LadoA)) && (LadoC > Math.Abs(LadoB - LadoA)) &&
                (LadoA == LadoB) || (LadoA == LadoC) || (LadoB == LadoC))
            {
                MessageBox.Show("É triângulo,e é isósceles");
            }
            else
            {
                MessageBox.Show("É triângulo,e é escaleno");
            }
        }
            private void btnLimpar_Click(object sender, EventArgs e)
            {
                txtLadoA.Clear();
                txtLadoB.Clear();
                txtLadoC.Clear();
                
            }

            private void txtLadoA_Validated(object sender, EventArgs e)
            {
                if (!double.TryParse(txtLadoA.Text, out LadoA))
                    MessageBox.Show("Numero invalido");
                else if (LadoA < 0) ;
                MessageBox.Show("numero invalido");
            }
        }
    
}    