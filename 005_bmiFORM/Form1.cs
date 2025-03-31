using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_bmiFORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = double.Parse(txth.Text);
            double weight = double.Parse(txtw.Text);
            double bmi = weight / (height / 100 * height / 100);
            lblbmi.Text = "BMI = " + bmi;  //lblbmi.Text = string.Format("당신의 BMI = {0:F1}, bmi") => bmi가 소수점 한자리까지 나타냄
        }

        private void lblh_Click(object sender, EventArgs e)
        {

        }
    }
}
