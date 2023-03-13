using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvolume
{
    public partial class Form1 : Form
    {
        double raio;
        double altura;
        double volume;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //double raio;
            if (!double.TryParse(textBox1.Text, out raio))
            {
                MessageBox.Show("raio.inválido");
                textBox1.Focus();
            }
            else if (raio <= 0)
            {
                MessageBox.Show("raio deve ser maior que zero");
                textBox1.Focus();
            }
            //double altura;
            if (!double.TryParse(textBox2.Text, out altura))
            {
                MessageBox.Show("altura inválida");
                textBox2.Focus();
            }

            else if (altura <= 0)
            {
                MessageBox.Show("altura deve ser maior que zero");
                textBox2.Focus();
            }
            //double volume;
            volume = Math.PI * Math.Pow(raio, 2) * altura;
            textBox3.Text = volume.ToString("N2");



            }

        private void TextBox1_Validated(object sender, EventArgs e)
        {
            //double raio;
            if (!double.TryParse(textBox1.Text, out raio))
                MessageBox.Show("raio inválido");
            else if (raio <= 0)
                MessageBox.Show("raio deve ser maior que zero");
        }

        private void TextBox2_Validated(object sender, EventArgs e)
        {
            //double altura;
            if (!double.TryParse(textBox2.Text, out altura))
                MessageBox.Show("altura inválida");
            else if (altura <= 0)
                MessageBox.Show("altura deve ser maior que zero");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
