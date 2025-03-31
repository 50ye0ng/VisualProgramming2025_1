using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006 _bmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double height = double.Parse(txth.Text) / 100; // cm -> m 변환
                double weight = double.Parse(txtw.Text);
                double bmi = weight / (height * height);
                lbl.Text = "BMI = " + bmi;

                string category = "";
                Color categoryColor = Color.White;

                if (bmi < 20)
                {
                    category = "저체중";
                    categoryColor = Color.Blue;
                }
                else if (bmi < 25)
                {
                    category = "정상체중";
                    categoryColor = Color.Green;
                }
                else if (bmi < 30)
                {
                    category = "경도비만";
                    categoryColor = Color.Yellow;
                }
                else if (bmi < 40)
                {
                    category = "비만";
                    categoryColor = Color.Orange;
                }
                else
                {
                    category = "고도비만";
                    categoryColor = Color.Red;
                }

                label3.Text = "판정: {category}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("올바른 숫자를 입력하세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(777, 658);
            this.Name = "Form1";
            this.ResumeLayout(false);

    }
}
}
