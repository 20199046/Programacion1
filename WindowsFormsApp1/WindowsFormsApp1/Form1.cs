using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblFechaDeNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void TxtFechaDeNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DtpNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Salario = 1000;
            double LimiteI = 578.53;
            double CuotaF = 11.11;
            double Seguro, Impuesto, Gastogeneral, Total;

            try
            {
                Salario = int.Parse(TxtSalario.Text);
            }
            catch
            {

            }
            
            
            
            
            /*SalarioOb = int.Parse(TxtSalario.Text);
            Impuesto = double.Parse(TxtImpuesto.Text);
            Gastogeneral = double.Parse(TxtGastoG.Text);
            Total = int.Parse(TxtTotal.Text);

            Seguro = SalarioOb * 3 / 100;
            Impuesto = SalarioOb - LimiteI * 5 / 100 + CuotaF;

            TxtSalario.Text = Seguro.ToString();
            TxtImpuesto.Text = Impuesto.ToString();*/
        }

        private void LblImpuesto_Click(object sender, EventArgs e)
        {

        }
    }
}
