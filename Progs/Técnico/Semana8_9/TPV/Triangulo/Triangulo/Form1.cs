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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Calcular_Click(object sender, EventArgs e)
        {
            int l1, l2, l3, result;
            l1 = Convert.ToInt32(TXT_1.Text);
            l2 = Convert.ToInt32(TXT_2.Text);
            l3 = Convert.ToInt32(TXT_3.Text);

            if(l1==l2 && l1==l3)
            {
                MessageBox.Show("O triângulo é equilátero.");
            }
            else if(l1==l2 && l1!=l3 || l2==l3 && l2!=l1 || l3==l1 && l3!=l2)
            {
                MessageBox.Show("O triângulo é isósceles.");
            }
            else if(l1!=l2 && l2!=l3 && l3!=l1)
            {
                MessageBox.Show("O triângulo é escaleno.");
            }
        }
    }
}
