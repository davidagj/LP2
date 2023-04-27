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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void BtnInstanciar1_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalario.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNhoras.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtFalta.Text);
            if (rdnHome1.Checked)
                objHorista.HomeOffice = 'S';
            else
                objHorista.HomeOffice = 'N';

            MessageBox.Show("Matricula: " + objHorista.Matricula + "\n" + "Nome: " + objHorista.NomeEmpregado + "\n" + "Data Entrada: "
               + objHorista.DataEntradaEmpresa.ToShortDateString() +
               "\n" + "Salario bruto: " + objHorista.SalarioBruto().ToString("N2") + "\n" + "tempo Empresa(dias): " + objHorista.TempoTrabalho() + '\n'
               + objHorista.VerificHome());




        }
    }
}
