namespace _010_Lables
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
            this.btnlaphael = new System.Windows.Forms.Button();
            this.lblartist = new System.Windows.Forms.Label();
            this.lblart = new System.Windows.Forms.Label();
            this.btndavinchi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlaphael
            // 
            this.btnlaphael.Location = new System.Drawing.Point(39, 34);
            this.btnlaphael.Name = "btnlaphael";
            this.btnlaphael.Size = new System.Drawing.Size(216, 52);
            this.btnlaphael.TabIndex = 0;
            this.btnlaphael.Text = "라파엘로 아테네 학당";
            this.btnlaphael.UseVisualStyleBackColor = true;
            this.btnlaphael.Click += new System.EventHandler(this.btnlaphael_Click);
            // 
            // lblartist
            // 
            this.lblartist.AutoSize = true;
            this.lblartist.Location = new System.Drawing.Point(57, 134);
            this.lblartist.Name = "lblartist";
            this.lblartist.Size = new System.Drawing.Size(0, 18);
            this.lblartist.TabIndex = 1;
            // 
            // lblart
            // 
            this.lblart.Location = new System.Drawing.Point(57, 194);
            this.lblart.Name = "lblart";
            this.lblart.Size = new System.Drawing.Size(693, 228);
            this.lblart.TabIndex = 2;
            // 
            // btndavinchi
            // 
            this.btndavinchi.Location = new System.Drawing.Point(320, 34);
            this.btndavinchi.Name = "btndavinchi";
            this.btndavinchi.Size = new System.Drawing.Size(216, 52);
            this.btndavinchi.TabIndex = 3;
            this.btndavinchi.Text = "다빈치 모나리자";
            this.btndavinchi.UseVisualStyleBackColor = true;
            this.btndavinchi.Click += new System.EventHandler(this.btndavinchi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndavinchi);
            this.Controls.Add(this.lblart);
            this.Controls.Add(this.lblartist);
            this.Controls.Add(this.btnlaphael);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlaphael;
        private System.Windows.Forms.Label lblartist;
        private System.Windows.Forms.Label lblart;
        private System.Windows.Forms.Button btndavinchi;
    }
}

