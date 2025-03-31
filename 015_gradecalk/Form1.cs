using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015_gradecalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            TextBox[] tities;
            ComboBox[] crds;
            ComboBox[] grds;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "인체의 구조와 기능";
            txt2.Text = "일반수학";
            txt3.Text = "디지털공학및실험";
            txt4.Text = "비주얼 프로그래밍";
            txt5.Text = "설계및기본프로젝트기본";
            txt6.Text = "데이터사이언스";
            txt7.Text = " ";
        }
    }
}
