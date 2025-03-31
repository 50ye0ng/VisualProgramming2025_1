using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _013_RaidioButton
{
    public partial class btnsubmit : Form
    {
        public btnsubmit()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            if (korea.Checked)
                result += "국적 : 대한민국\n";
            else if (chaina.Checked)
                result += "국적 : 중국\n";
            else if (japan.Checked)
                result += "국적 : 일본\n";
            else if (radioButton4.Checked)
                result += "국적 : 그 외 국가\n";

            if (checkedRB == rbMale)
                result += "성별 : 남성";
            else if (checkedRB == rbFeMale)
                result += "성별 : 여성";

            MessageBox.Show(result)
        }
    }
}
