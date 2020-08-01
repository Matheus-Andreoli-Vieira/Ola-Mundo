using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Calcular_Click(object sender, EventArgs e)
        {
            int md1, md2, md3, md4, MF;
            md1 = Convert.ToInt32(TXT_MD1.Text);
            md2 = Convert.ToInt32(TXT_MD2.Text);
            md3 = Convert.ToInt32(TXT_MD3.Text);
            md4 = Convert.ToInt32(TXT_MD4.Text);
            MF = (md1 + md2 + md3 + md4) / 4;
            if(MF==10)
            {
                MessageBox.Show("Desempenho Extraordinário – Conceito A");
            }
            else if(MF<10 && MF>=9)
            {
                MessageBox.Show("Desempenho Expert – Conceito A-");
            }
            else if(MF<9 && MF>=8)
            {
                MessageBox.Show("Desempenho Ótimo – Conceito B +");
            }
            else if(MF<8 && MF>=7)
            {
                MessageBox.Show("Desempenho Bom – Conceito B -"); 
            }
            else if(MF<7 && MF>=6)
            {
                MessageBox.Show("Desempenho satisfatório– Conceito C");
            }
            else if (MF<6)
            {
                MessageBox.Show("Reprovado.");
            }
        }

        private void TXT_MD1_Leave(object sender, EventArgs e)
        {
            int n1;
            n1 = Convert.ToInt32(TXT_MD1.Text);
            if(n1<0 || n1 > 10)
            {
                MessageBox.Show("Digite um nota em 0 e 10");
                TXT_MD1.Focus();
            }
        }

        private void TXT_MD2_Leave(object sender, EventArgs e)
        {
            int n2;
            n2 = Convert.ToInt32(TXT_MD2.Text);
            if (n2 < 0 || n2 > 10)
            {
                MessageBox.Show("Digite um nota em 0 e 10");
                TXT_MD2.Focus();
            }
        }

        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
