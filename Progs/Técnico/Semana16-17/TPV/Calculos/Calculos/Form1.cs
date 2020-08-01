using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos
{
    public partial class Form1 : Form
    {
        double n1, n2, calculo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            converter();
            calculo = n1 + n2;
            exibir(calculo);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            converter();
            calculo = n1 - n2;
            exibir(calculo);
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            converter();
            calculo = n1 / n2;
            exibir(calculo);
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            converter();
            calculo = n1 * n2;
            exibir(calculo);
        }

        private void btn_rest_Click(object sender, EventArgs e)
        {
            converter();
            calculo = n1 % n2;
            exibir(calculo);
        }

        private void converter()
        {
            try
            {
                n1 = double.Parse(txt_n1.Text);
                n2 = double.Parse(txt_n2.Text);
            }
            catch(Exception erro)
            {
                MessageBox.Show("Não foi possível converter, erro = " + erro);
            }
        }
        private void exibir(double vl)
        {
            try
            {
                txt_res.Text = vl.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível converter, erro = " + erro);
            }
        }
    }
}
