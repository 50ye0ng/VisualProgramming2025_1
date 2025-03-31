using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string password = txtPassword.Text;

            if (id == "abcd" && password == "1234")
            {
                lblResult.Text = "로그인 성공";
            }
            else
            {
                lblResult.Text = "로그인 실패";
            }
        }
    }
}
