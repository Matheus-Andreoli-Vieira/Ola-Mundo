using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class FRM_Main : Form
    {
        public FRM_Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Executar_Click(object sender, EventArgs e)
        {
            int a, b, c;

            a = Convert.ToInt32(TXT_1.Text);
            b = Convert.ToInt32(TXT_2.Text);
            c = Convert.ToInt32(TXT_3.Text);

            if( (a<b+c) && (b<a+c) && (c<a+b) )
            {
                MessageBox.Show("Representam os lados de um Triângulo.");
            }
            else
                MessageBox.Show("Não Representam os lados de um Triângulo.");
        }
    }
}
