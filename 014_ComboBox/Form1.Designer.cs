﻿namespace _014_ComboBox
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ㅅㅌㅅ = new System.Windows.Forms.Label();
            this.txtkor = new System.Windows.Forms.TextBox();
            this.txtmat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txteng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtavg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txteng);
            this.groupBox1.Controls.Add(this.txtmat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ㅅㅌㅅ);
            this.groupBox1.Controls.Add(this.txtkor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성적입력";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtavg);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtsum);
            this.groupBox2.Location = new System.Drawing.Point(389, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            // 
            // ㅅㅌㅅ
            // 
            this.ㅅㅌㅅ.AutoSize = true;
            this.ㅅㅌㅅ.Location = new System.Drawing.Point(32, 38);
            this.ㅅㅌㅅ.Name = "ㅅㅌㅅ";
            this.ㅅㅌㅅ.Size = new System.Drawing.Size(44, 18);
            this.ㅅㅌㅅ.TabIndex = 2;
            this.ㅅㅌㅅ.Text = "국어";
            // 
            // txtkor
            // 
            this.txtkor.Location = new System.Drawing.Point(109, 35);
            this.txtkor.Name = "txtkor";
            this.txtkor.Size = new System.Drawing.Size(162, 28);
            this.txtkor.TabIndex = 3;
            // 
            // txtmat
            // 
            this.txtmat.Location = new System.Drawing.Point(109, 87);
            this.txtmat.Name = "txtmat";
            this.txtmat.Size = new System.Drawing.Size(162, 28);
            this.txtmat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "수학";
            // 
            // txteng
            // 
            this.txteng.Location = new System.Drawing.Point(109, 138);
            this.txteng.Name = "txteng";
            this.txteng.Size = new System.Drawing.Size(162, 28);
            this.txteng.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "영어";
            // 
            // txtavg
            // 
            this.txtavg.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtavg.Location = new System.Drawing.Point(117, 95);
            this.txtavg.Name = "txtavg";
            this.txtavg.Size = new System.Drawing.Size(162, 28);
            this.txtavg.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "총점";
            // 
            // txtsum
            // 
            this.txtsum.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtsum.Location = new System.Drawing.Point(117, 43);
            this.txtsum.Name = "txtsum";
            this.txtsum.Size = new System.Drawing.Size(162, 28);
            this.txtsum.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "평균";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "계산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ㅅㅌㅅ;
        private System.Windows.Forms.TextBox txtkor;
        private System.Windows.Forms.TextBox txtmat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txteng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtavg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsum;
        private System.Windows.Forms.Button button1;
    }
}

