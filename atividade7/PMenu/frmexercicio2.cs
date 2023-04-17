using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
   
    public partial class l : Form
    {
        public l()
        {
            InitializeComponent();
        }

        private void Frmexercicio2_Load(object sender, EventArgs e)
        {
            
        }

        private void Btncomparar_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtpalavra1.Text, txtpalavra2.Text, true) == 0)
                MessageBox.Show("São iguais");
            else

            {
                MessageBox.Show("São diferentes");
            }
        }

        private void Btnempurra_Click(object sender, EventArgs e)
        {
            int metade = txtpalavra2.Text.Length/2;
            txtpalavra2.Text = txtpalavra2.Text.Substring(0, metade) +
                txtpalavra1.Text +
                txtpalavra2.Text.Substring(metade, txtpalavra2.Text.Length - metade);
        }

        private void Btnempurra2_Click(object sender, EventArgs e)
        {
            int metade = txtpalavra1.Text.Length / 2;
            txtpalavra2.Text= txtpalavra1.Text.Insert(metade,"**");
        }
    }
}
