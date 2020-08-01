using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LBL_Resultado_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Soma_Click(object sender, EventArgs e)
        {
            int n1, n2, result;

            n1 = Convert.ToInt32(TXT_N1.Text);
            n2 = Convert.ToInt32(TXT_N2.Text);
            result = n1 + n2;
            LBL_Resultado.Text = Convert.ToString(result);
        }
    }
}
