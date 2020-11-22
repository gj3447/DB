using System.Collections.Generic;

namespace MarketBrowser
{
    partial class MainFrom
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
            this.buttonOpenCSV = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.listBoxCulum = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearchReasult = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenCSV
            // 
            this.buttonOpenCSV.Location = new System.Drawing.Point(29, 32);
            this.buttonOpenCSV.Name = "buttonOpenCSV";
            this.buttonOpenCSV.Size = new System.Drawing.Size(104, 38);
            this.buttonOpenCSV.TabIndex = 0;
            this.buttonOpenCSV.Text = "CSV 열기";
            this.buttonOpenCSV.UseVisualStyleBackColor = true;
            this.buttonOpenCSV.Click += new System.EventHandler(this.buttonOpenCSV_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDisplay.Location = new System.Drawing.Point(668, 277);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(279, 234);
            this.textBoxDisplay.TabIndex = 1;
            // 
            // listBoxCulum
            // 
            this.listBoxCulum.FormattingEnabled = true;
            this.listBoxCulum.ItemHeight = 15;
            this.listBoxCulum.Location = new System.Drawing.Point(29, 106);
            this.listBoxCulum.Name = "listBoxCulum";
            this.listBoxCulum.Size = new System.Drawing.Size(160, 379);
            this.listBoxCulum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "컬럼 헤더 리스트";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(233, 106);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 25);
            this.textBoxSearch.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(233, 161);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "검색할 단어";
            // 
            // textBoxSearchReasult
            // 
            this.textBoxSearchReasult.Location = new System.Drawing.Point(359, 78);
            this.textBoxSearchReasult.Multiline = true;
            this.textBoxSearchReasult.Name = "textBoxSearchReasult";
            this.textBoxSearchReasult.Size = new System.Drawing.Size(267, 432);
            this.textBoxSearchReasult.TabIndex = 7;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(471, 32);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 8;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 541);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxSearchReasult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCulum);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.buttonOpenCSV);
            this.Name = "MainFrom";
            this.Text = "전통시장 검색기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenCSV;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.ListBox listBoxCulum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearchReasult;
        List<List<string>> m_data;
        private System.Windows.Forms.Button buttonInsert;
    }
}

