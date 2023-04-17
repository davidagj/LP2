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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção Ctrl+C");
        }

        private void ColarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção Ctrl+V");
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            l objFrm2 = new l();
            objFrm2.MdiParent = this;
            objFrm2.WindowState = FormWindowState.Maximized;
           objFrm2.Show();
        }

        private void CalculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmexercicio3 objFrm3 = new frmexercicio3();
            objFrm3.MdiParent = this;
            objFrm3.WindowState = FormWindowState.Maximized;
            objFrm3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmexercicio4 objFrm3 = new frmexercicio4();
            objFrm3.MdiParent = this;
            objFrm3.WindowState = FormWindowState.Maximized;
            objFrm3.Show();

        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmexercicio5 objFrm3 = new frmexercicio5();
            objFrm3.MdiParent = this;
            objFrm3.WindowState = FormWindowState.Maximized;
            objFrm3.Show();
        }
    }
    
}
