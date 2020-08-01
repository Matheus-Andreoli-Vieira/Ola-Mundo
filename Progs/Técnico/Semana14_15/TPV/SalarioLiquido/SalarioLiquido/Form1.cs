using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarioLiquido
{
    public partial class SalarioLiquido : Form
    {
        public SalarioLiquido()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BTN_3_Click(object sender, EventArgs e)
        {
            String texto = "Deseja sair do Programa Salário Líquido?";
            String tit = "++++++++++Finalizando++++++++++";
            if(MessageBox.Show(texto, tit, 
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BTN_1_Click(object sender, EventArgs e)
        {
            double hora, trab, percent, sal;
            try
            {
                hora = double.Parse(TXT_1.Text);
                trab = double.Parse(TXT_2.Text);
                percent = double.Parse(TXT_3.Text);
                sal = (hora * trab) - (hora * trab * percent / 100);
                sal = Math.Round(sal, 2);
                LBL_4.Text = "R$" + sal.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "*******ERRO!!!*******",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                TXT_1.Text = "";
                TXT_2.Text = "";
                TXT_3.Text = "";
                LBL_4.Text = "";
            }
        }

        private void BTN_2_Click(object sender, EventArgs e)
        {
            TXT_1.Text = "";
            TXT_2.Text = "";
            TXT_3.Text = "";
            LBL_4.Text = "";
            TXT_1.Focus();
        }

        private void SalarioLiquido_Load(object sender, EventArgs e)
        {

        }
    }
}
