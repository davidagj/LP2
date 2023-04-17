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
    public partial class frmexercicio4 : Form
    {
        public frmexercicio4()
        {
            InitializeComponent();
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (var i = 0; i < rchTexto.Text.Length; i++)
            {
                if (char.IsNumber(rchTexto.Text[i]))
                    contador += 1;
            }

            MessageBox.Show("A quantidade de números é: " + contador);
        }

        private void btnLetras_Click(object sender, EventArgs e)
        {
            int cont = 0;
            foreach (char c in rchTexto.Text)
            {
                if (char.IsLetter(c))
                    cont++;
            }
            MessageBox.Show("A quantidade de letras é: " + cont);

        }

        private void btnEspaço_Click(object sender, EventArgs e)
        {
            int cont = 0;
            while (cont < rchTexto.Text.Length)
            {
                if (char.IsWhiteSpace(rchTexto.Text[cont]))
                {
                    MessageBox.Show("O primeiro espaço em branco está na posição: " + cont);
                    break;
                }

                else
                    cont++;
            }


        }
    }
}
