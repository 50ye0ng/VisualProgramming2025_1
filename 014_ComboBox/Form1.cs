using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _014_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = double.Parse(txtkor.Text)
                + double.Parse(txtmat.Text)
                + double.Parse(txteng.Text);

            double avg = sum / 3;

            txtsum.Text = sum.ToString("#.##");
            txtavg.Text = avg.ToString("#.##");
        }
    }
}
