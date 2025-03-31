namespace _005_bmiFORM
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
            this.btnbmi = new System.Windows.Forms.Button();
            this.lblh = new System.Windows.Forms.Label();
            this.lblw = new System.Windows.Forms.Label();
            this.lblbmi = new System.Windows.Forms.Label();
            this.txtw = new System.Windows.Forms.TextBox();
            this.txth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnbmi
            // 
            this.btnbmi.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnbmi.Location = new System.Drawing.Point(409, 260);
            this.btnbmi.Name = "btnbmi";
            this.btnbmi.Size = new System.Drawing.Size(142, 48);
            this.btnbmi.TabIndex = 0;
            this.btnbmi.Text = "BMI 계산 ";
            this.btnbmi.UseVisualStyleBackColor = true;
            this.btnbmi.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblh
            // 
            this.lblh.AutoSize = true;
            this.lblh.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblh.Location = new System.Drawing.Point(189, 118);
            this.lblh.Name = "lblh";
            this.lblh.Size = new System.Drawing.Size(101, 38);
            this.lblh.TabIndex = 1;
            this.lblh.Text = "키(cm)";
            this.lblh.Click += new System.EventHandler(this.lblh_Click);
            // 
            // lblw
            // 
            this.lblw.AutoSize = true;
            this.lblw.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblw.Location = new System.Drawing.Point(189, 191);
            this.lblw.Name = "lblw";
            this.lblw.Size = new System.Drawing.Size(122, 38);
            this.lblw.TabIndex = 2;
            this.lblw.Text = "체중(kg)";
            // 
            // lblbmi
            // 
            this.lblbmi.AutoSize = true;
            this.lblbmi.Location = new System.Drawing.Point(368, 349);
            this.lblbmi.Name = "lblbmi";
            this.lblbmi.Size = new System.Drawing.Size(0, 18);
            this.lblbmi.TabIndex = 3;
            // 
            // txtw
            // 
            this.txtw.Location = new System.Drawing.Point(354, 201);
            this.txtw.Name = "txtw";
            this.txtw.Size = new System.Drawing.Size(197, 28);
            this.txtw.TabIndex = 4;
            // 
            // txth
            // 
            this.txth.Location = new System.Drawing.Point(354, 118);
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(197, 28);
            this.txth.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txth);
            this.Controls.Add(this.txtw);
            this.Controls.Add(this.lblbmi);
            this.Controls.Add(this.lblw);
            this.Controls.Add(this.lblh);
            this.Controls.Add(this.btnbmi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbmi;
        private System.Windows.Forms.Label lblh;
        private System.Windows.Forms.Label lblw;
        private System.Windows.Forms.Label lblbmi;
        private System.Windows.Forms.TextBox txtw;
        private System.Windows.Forms.TextBox txth;
    }
}

