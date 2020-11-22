namespace BasicFile
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
            this.buttonFilestreamwright = new System.Windows.Forms.Button();
            this.buttonFilestreamread = new System.Windows.Forms.Button();
            this.buttonstreamwright = new System.Windows.Forms.Button();
            this.buttonstreamread = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonFilestreamwright
            // 
            this.buttonFilestreamwright.Location = new System.Drawing.Point(84, 64);
            this.buttonFilestreamwright.Name = "buttonFilestreamwright";
            this.buttonFilestreamwright.Size = new System.Drawing.Size(158, 38);
            this.buttonFilestreamwright.TabIndex = 0;
            this.buttonFilestreamwright.Text = "File Wright";
            this.buttonFilestreamwright.UseVisualStyleBackColor = true;
            this.buttonFilestreamwright.Click += new System.EventHandler(this.button_binary_write_click);
            // 
            // buttonFilestreamread
            // 
            this.buttonFilestreamread.Location = new System.Drawing.Point(467, 64);
            this.buttonFilestreamread.Name = "buttonFilestreamread";
            this.buttonFilestreamread.Size = new System.Drawing.Size(158, 38);
            this.buttonFilestreamread.TabIndex = 1;
            this.buttonFilestreamread.Text = "File Read";
            this.buttonFilestreamread.UseVisualStyleBackColor = true;
            this.buttonFilestreamread.Click += new System.EventHandler(this.button_binary_read_click);
            // 
            // buttonstreamwright
            // 
            this.buttonstreamwright.Location = new System.Drawing.Point(84, 184);
            this.buttonstreamwright.Name = "buttonstreamwright";
            this.buttonstreamwright.Size = new System.Drawing.Size(158, 38);
            this.buttonstreamwright.TabIndex = 2;
            this.buttonstreamwright.Text = "Stream Wright";
            this.buttonstreamwright.UseVisualStyleBackColor = true;
            this.buttonstreamwright.Click += new System.EventHandler(this.buttonstreamwright_Click);
            // 
            // buttonstreamread
            // 
            this.buttonstreamread.Location = new System.Drawing.Point(467, 184);
            this.buttonstreamread.Name = "buttonstreamread";
            this.buttonstreamread.Size = new System.Drawing.Size(158, 38);
            this.buttonstreamread.TabIndex = 3;
            this.buttonstreamread.Text = "Stream read";
            this.buttonstreamread.UseVisualStyleBackColor = true;
            this.buttonstreamread.Click += new System.EventHandler(this.buttonstreamread_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 246);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(534, 179);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonstreamread);
            this.Controls.Add(this.buttonstreamwright);
            this.Controls.Add(this.buttonFilestreamread);
            this.Controls.Add(this.buttonFilestreamwright);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFilestreamwright;
        private System.Windows.Forms.Button buttonFilestreamread;
        private System.Windows.Forms.Button buttonstreamwright;
        private System.Windows.Forms.Button buttonstreamread;
        private System.Windows.Forms.TextBox textBox1;
    }
}

