using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pclasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void BtnInstanciar1_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalario.Text);
            if (rdnHome1.Checked)
                objMensalista.HomeOffice = 'S';
            else
                objMensalista.HomeOffice = 'N';



            MessageBox.Show("Matricula: " + objMensalista.Matricula + "\n" + "Nome: " + objMensalista.NomeEmpregado + "\n" + "Data Entrada: " 
                + objMensalista.DataEntradaEmpresa.ToShortDateString() +
                "\n" + "Salario bruto: " + objMensalista.SalarioBruto().ToString("N2") + "\n" + "tempo Empresa(dias): " + objMensalista.TempoTrabalho() + '\n' 
                + objMensalista.VerificHome() );


        }

        private void BtnInstanciar2_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(Convert.ToInt32(txtMatricula.Text), txtNome.Text, Convert.ToDateTime(txtData.Text), Convert.ToDouble(txtSalario.Text));


            MessageBox.Show("Matricula: " + objMensalista.Matricula + "\n" + "Nome: " + objMensalista.NomeEmpregado + "\n" + "Data Entrada: "
                + objMensalista.DataEntradaEmpresa.ToShortDateString() +
                "\n" + "Salario bruto: " + objMensalista.SalarioBruto().ToString("N2") + "\n" + "tempo Empresa(dias): " + objMensalista.TempoTrabalho() + '\n'
                + objMensalista.VerificHome());


        }
    }
}
