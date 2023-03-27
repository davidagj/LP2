using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imc
{
    public partial class Form1 : Form
    {
        double peso, altura, icm;

        private void TxtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPeso_Validated(object sender, EventArgs e)
        {
            if(!double.TryParse(txtPeso.Text, out peso))
                MessageBox.Show("Numero invalido");
            else if(peso<0)
                MessageBox.Show("Numero invalido");
        }

        private void TxtAltura_Validated(object sender, EventArgs e)
        {

            if (!double.TryParse(txtPeso.Text, out altura))
                MessageBox.Show("Numero invalido");
            else if (altura < 0)
                MessageBox.Show("Numero invalido");
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtICM.Clear();
            txtPeso.Clear();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPeso.Text, out peso) && (double.TryParse(txtAltura.Text, out altura)))
            {
                icm = peso / Math.Pow(altura, 2);
                //icm = peso /(altura * altura);
                icm = Math.Round(icm, 1);
                txtICM.Text = icm.ToString();
            }
            if (icm < 18.5){ 
            MessageBox.Show("Grau de obesidade igual a 0, magreza");
        }
            else if (icm < 25){
                MessageBox.Show("Grau de obesidade igual a 0, normal");
            }
            else if (icm < 30){
                MessageBox.Show("Grau de obesidade igual a 1,sobrepeso");
            }
            else if (icm< 40)
            {
                MessageBox.Show("Grau de obesidade igual a 2, Obesidade");

            }
            else  {
                MessageBox.Show("Grau de obesidade igual a 3 , obesidade grave \e");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
