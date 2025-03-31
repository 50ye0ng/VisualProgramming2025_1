namespace _008_messagebox
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
            this.lblname = new System.Windows.Forms.Label();
            this.btnclik = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(164, 185);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(62, 18);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "이름 : ";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnclik
            // 
            this.btnclik.Location = new System.Drawing.Point(510, 185);
            this.btnclik.Name = "btnclik";
            this.btnclik.Size = new System.Drawing.Size(100, 28);
            this.btnclik.TabIndex = 1;
            this.btnclik.Text = "클릭";
            this.btnclik.UseVisualStyleBackColor = true;
            this.btnclik.Click += new System.EventHandler(this.btnclik_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(261, 182);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(188, 28);
            this.txtname.TabIndex = 2;
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Location = new System.Drawing.Point(329, 262);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(0, 18);
            this.lblGreeting.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnclik);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnclik;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblGreeting;
    }
}

