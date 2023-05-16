using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PCotacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnex_Click(object sender, EventArgs e)
        {
            float[,] matriz = new float[7, 3];
            string auxiliar = "";
            float mediaG=0, media1=0, media2=0, media3=0, media4=0, media5=0, media6=0, media7=0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    auxiliar = Interaction.InputBox(" digite o valor do notebook " , " Entrada de dados ");
                    if (!float.TryParse(auxiliar, out matriz[i, j]) || matriz[i,j]<0)
                    {
                        MessageBox.Show("Valor invalido , digite novamente");
                        i--;
                        j--;
                    }
                }
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lstbS.Items.Add(" Notebook "+ (i+1) + " loja "+ (j+1)+ " R$ "+ matriz[i,j]);
                   
                        mediaG += matriz[i, j];
                    media1 += matriz[0, j];
                    media2 += matriz[1, j];
                    media3 += matriz[2, j];
                    media4 += matriz[3, j];
                    media5 += matriz[4, j];
                    media6 += matriz[5, j];
                    media7 += matriz[6, j];

                }
            }
            mediaG = mediaG / 21;
            media1 = media1 / 3;
            media2 = media2 / 3;
            media3 = media3 / 3;
            media4 = media4 / 3;
            media5 = media5 / 3;
            media6 = media6 / 3;
            media7 = media7 / 3;
            lstbS.Items.Add("Media computadores "+ mediaG);
            lstbS.Items.Add("Media notebook 1 " +"media "+ media1);
            lstbS.Items.Add("Media notebook 2 " + "media " + media2);
            lstbS.Items.Add("Media notebook 3 " + "media " + media3);
            lstbS.Items.Add("Media notebook 4 " + "media " + media4);
            lstbS.Items.Add("Media notebook 5 " + "media " + media5);
            lstbS.Items.Add("Media notebook 6 " + "media " + media6);
            lstbS.Items.Add("Media notebook 7 " + "media " + media7);
            
        }
        private void LstbS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
