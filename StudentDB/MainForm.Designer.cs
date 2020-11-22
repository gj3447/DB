namespace StudentDB
{
    partial class MainForm
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
            this.buttonStudent1delete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxStudent1memo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStudent1Gender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStudent1Number = new System.Windows.Forms.TextBox();
            this.textBoxStudent1Name = new System.Windows.Forms.TextBox();
            this.buttonStudent1Save = new System.Windows.Forms.Button();
            this.buttonStudentLoad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonStudent2delete = new System.Windows.Forms.Button();
            this.textBoxStudent2memo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStudent2Gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStudent2Number = new System.Windows.Forms.TextBox();
            this.textBoxStudent2Name = new System.Windows.Forms.TextBox();
            this.buttonStudent2Save = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonStudent3delete = new System.Windows.Forms.Button();
            this.textBoxStudent3memo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStudent3Gender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxStudent3Number = new System.Windows.Forms.TextBox();
            this.textBoxStudent3Name = new System.Windows.Forms.TextBox();
            this.buttonStudent3Save = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxMajorAutoload = new System.Windows.Forms.CheckBox();
            this.checkBoxStudentAutoload = new System.Windows.Forms.CheckBox();
            this.labelStudantAmount = new System.Windows.Forms.Label();
            this.listBoxMajorList = new System.Windows.Forms.ListBox();
            this.buttonMajorAdd = new System.Windows.Forms.Button();
            this.textBoxMajorName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonStudent1delete);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxStudent1memo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxStudent1Gender);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxStudent1Number);
            this.groupBox1.Controls.Add(this.textBoxStudent1Name);
            this.groupBox1.Controls.Add(this.buttonStudent1Save);
            this.groupBox1.Location = new System.Drawing.Point(274, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "학생1";
            // 
            // buttonStudent1delete
            // 
            this.buttonStudent1delete.Location = new System.Drawing.Point(64, 261);
            this.buttonStudent1delete.Name = "buttonStudent1delete";
            this.buttonStudent1delete.Size = new System.Drawing.Size(75, 23);
            this.buttonStudent1delete.TabIndex = 9;
            this.buttonStudent1delete.Text = "삭제";
            this.buttonStudent1delete.UseVisualStyleBackColor = true;
            this.buttonStudent1delete.Click += new System.EventHandler(this.buttonStudent1delete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "memo";
            // 
            // textBoxStudent1memo
            // 
            this.textBoxStudent1memo.Location = new System.Drawing.Point(64, 131);
            this.textBoxStudent1memo.Multiline = true;
            this.textBoxStudent1memo.Name = "textBoxStudent1memo";
            this.textBoxStudent1memo.Size = new System.Drawing.Size(100, 98);
            this.textBoxStudent1memo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "성별";
            // 
            // comboBoxStudent1Gender
            // 
            this.comboBoxStudent1Gender.FormattingEnabled = true;
            this.comboBoxStudent1Gender.Location = new System.Drawing.Point(64, 102);
            this.comboBoxStudent1Gender.Name = "comboBoxStudent1Gender";
            this.comboBoxStudent1Gender.Size = new System.Drawing.Size(100, 23);
            this.comboBoxStudent1Gender.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "학번";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "이름";
            // 
            // textBoxStudent1Number
            // 
            this.textBoxStudent1Number.Location = new System.Drawing.Point(64, 71);
            this.textBoxStudent1Number.Name = "textBoxStudent1Number";
            this.textBoxStudent1Number.Size = new System.Drawing.Size(100, 25);
            this.textBoxStudent1Number.TabIndex = 2;
            // 
            // textBoxStudent1Name
            // 
            this.textBoxStudent1Name.Location = new System.Drawing.Point(64, 40);
            this.textBoxStudent1Name.Name = "textBoxStudent1Name";
            this.textBoxStudent1Name.Size = new System.Drawing.Size(100, 25);
            this.textBoxStudent1Name.TabIndex = 1;
            // 
            // buttonStudent1Save
            // 
            this.buttonStudent1Save.Location = new System.Drawing.Point(64, 235);
            this.buttonStudent1Save.Name = "buttonStudent1Save";
            this.buttonStudent1Save.Size = new System.Drawing.Size(75, 23);
            this.buttonStudent1Save.TabIndex = 0;
            this.buttonStudent1Save.Text = "저장";
            this.buttonStudent1Save.UseVisualStyleBackColor = true;
            this.buttonStudent1Save.Click += new System.EventHandler(this.buttonStudent1Save_Click);
            // 
            // buttonStudentLoad
            // 
            this.buttonStudentLoad.Location = new System.Drawing.Point(29, 30);
            this.buttonStudentLoad.Name = "buttonStudentLoad";
            this.buttonStudentLoad.Size = new System.Drawing.Size(328, 56);
            this.buttonStudentLoad.TabIndex = 0;
            this.buttonStudentLoad.Text = "학생정보 불러오기";
            this.buttonStudentLoad.UseVisualStyleBackColor = true;
            this.buttonStudentLoad.Click += new System.EventHandler(this.buttonStudentLoad_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonStudent2delete);
            this.groupBox2.Controls.Add(this.textBoxStudent2memo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxStudent2Gender);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxStudent2Number);
            this.groupBox2.Controls.Add(this.textBoxStudent2Name);
            this.groupBox2.Controls.Add(this.buttonStudent2Save);
            this.groupBox2.Location = new System.Drawing.Point(492, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 290);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "학생2";
            // 
            // buttonStudent2delete
            // 
            this.buttonStudent2delete.Location = new System.Drawing.Point(64, 261);
            this.buttonStudent2delete.Name = "buttonStudent2delete";
            this.buttonStudent2delete.Size = new System.Drawing.Size(75, 23);
            this.buttonStudent2delete.TabIndex = 10;
            this.buttonStudent2delete.Text = "삭제";
            this.buttonStudent2delete.UseVisualStyleBackColor = true;
            this.buttonStudent2delete.Click += new System.EventHandler(this.buttonStudent2delete_Click);
            // 
            // textBoxStudent2memo
            // 
            this.textBoxStudent2memo.Location = new System.Drawing.Point(64, 134);
            this.textBoxStudent2memo.Multiline = true;
            this.textBoxStudent2memo.Name = "textBoxStudent2memo";
            this.textBoxStudent2memo.Size = new System.Drawing.Size(100, 98);
            this.textBoxStudent2memo.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "memo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "성별";
            // 
            // comboBoxStudent2Gender
            // 
            this.comboBoxStudent2Gender.FormattingEnabled = true;
            this.comboBoxStudent2Gender.Location = new System.Drawing.Point(64, 102);
            this.comboBoxStudent2Gender.Name = "comboBoxStudent2Gender";
            this.comboBoxStudent2Gender.Size = new System.Drawing.Size(100, 23);
            this.comboBoxStudent2Gender.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "학번";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "이름";
            // 
            // textBoxStudent2Number
            // 
            this.textBoxStudent2Number.Location = new System.Drawing.Point(64, 71);
            this.textBoxStudent2Number.Name = "textBoxStudent2Number";
            this.textBoxStudent2Number.Size = new System.Drawing.Size(100, 25);
            this.textBoxStudent2Number.TabIndex = 2;
            // 
            // textBoxStudent2Name
            // 
            this.textBoxStudent2Name.Location = new System.Drawing.Point(64, 40);
            this.textBoxStudent2Name.Name = "textBoxStudent2Name";
            this.textBoxStudent2Name.Size = new System.Drawing.Size(100, 25);
            this.textBoxStudent2Name.TabIndex = 1;
            // 
            // buttonStudent2Save
            // 
            this.buttonStudent2Save.Location = new System.Drawing.Point(64, 235);
            this.buttonStudent2Save.Name = "buttonStudent2Save";
            this.buttonStudent2Save.Size = new System.Drawing.Size(75, 23);
            this.buttonStudent2Save.TabIndex = 0;
            this.buttonStudent2Save.Text = "저장";
            this.buttonStudent2Save.UseVisualStyleBackColor = true;
            this.buttonStudent2Save.Click += new System.EventHandler(this.buttonStudent2Save_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonStudent3delete);
            this.groupBox3.Controls.Add(this.textBoxStudent3memo);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBoxStudent3Gender);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxStudent3Number);
            this.groupBox3.Controls.Add(this.textBoxStudent3Name);
            this.groupBox3.Controls.Add(this.buttonStudent3Save);
            this.groupBox3.Location = new System.Drawing.Point(718, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 290);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "학생3";
            // 
            // buttonStudent3delete
            // 
            this.buttonStudent3delete.Location = new System.Drawing.Point(64, 264);
            this.buttonStudent3delete.Name = "buttonStudent3delete";
            this.buttonStudent3delete.Size = new System.Drawing.Size(75, 23);
            this.buttonStudent3delete.TabIndex = 11;
            this.buttonStudent3delete.Text = "삭제";
            this.buttonStudent3delete.UseVisualStyleBackColor = true;
            this.buttonStudent3delete.Click += new System.EventHandler(this.buttonStudent3delete_Click);
            // 
            // textBoxStudent3memo
            // 
            this.textBoxStudent3memo.Location = new System.Drawing.Point(64, 134);
            this.textBoxStudent3memo.Multiline = true;
            this.textBoxStudent3memo.Name = "textBoxStudent3memo";
            this.textBoxStudent3memo.Size = new System.Drawing.Size(100, 98);
            this.textBoxStudent3memo.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "memo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "성별";
            // 
            // comboBoxStudent3Gender
            // 
            this.comboBoxStudent3Gender.FormattingEnabled = true;
            this.comboBoxStudent3Gender.Location = new System.Drawing.Point(64, 102);
            this.comboBoxStudent3Gender.Name = "comboBoxStudent3Gender";
            this.comboBoxStudent3Gender.Size = new System.Drawing.Size(100, 23);
            this.comboBoxStudent3Gender.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "학번";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "이름";
            // 
            // textBoxStudent3Number
            // 
            this.textBoxStudent3Number.Location = new System.Drawing.Point(64, 71);
            this.textBoxStudent3Number.Name = "textBoxStudent3Number";
            this.textBoxStudent3Number.Size = new System.Drawing.Size(100, 25);
            this.textBoxStudent3Number.TabIndex = 2;
            // 
            // textBoxStudent3Name
            // 
            this.textBoxStudent3Name.Location = new System.Drawing.Point(64, 40);
            this.textBoxStudent3Name.Name = "textBoxStudent3Name";
            this.textBoxStudent3Name.Size = new System.Drawing.Size(100, 25);
            this.textBoxStudent3Name.TabIndex = 1;
            // 
            // buttonStudent3Save
            // 
            this.buttonStudent3Save.Location = new System.Drawing.Point(64, 235);
            this.buttonStudent3Save.Name = "buttonStudent3Save";
            this.buttonStudent3Save.Size = new System.Drawing.Size(75, 23);
            this.buttonStudent3Save.TabIndex = 0;
            this.buttonStudent3Save.Text = "저장";
            this.buttonStudent3Save.UseVisualStyleBackColor = true;
            this.buttonStudent3Save.Click += new System.EventHandler(this.buttonStudent3Save_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxMajorAutoload);
            this.groupBox4.Controls.Add(this.checkBoxStudentAutoload);
            this.groupBox4.Controls.Add(this.labelStudantAmount);
            this.groupBox4.Location = new System.Drawing.Point(381, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(590, 91);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "설정 및 정보";
            // 
            // checkBoxMajorAutoload
            // 
            this.checkBoxMajorAutoload.AutoSize = true;
            this.checkBoxMajorAutoload.Location = new System.Drawing.Point(309, 24);
            this.checkBoxMajorAutoload.Name = "checkBoxMajorAutoload";
            this.checkBoxMajorAutoload.Size = new System.Drawing.Size(219, 19);
            this.checkBoxMajorAutoload.TabIndex = 3;
            this.checkBoxMajorAutoload.Text = "자동으로 학과정보 로드하기";
            this.checkBoxMajorAutoload.UseVisualStyleBackColor = true;
            this.checkBoxMajorAutoload.CheckedChanged += new System.EventHandler(this.checkBoxMajorAutoload_CheckedChanged);
            // 
            // checkBoxStudentAutoload
            // 
            this.checkBoxStudentAutoload.AutoSize = true;
            this.checkBoxStudentAutoload.Location = new System.Drawing.Point(19, 24);
            this.checkBoxStudentAutoload.Name = "checkBoxStudentAutoload";
            this.checkBoxStudentAutoload.Size = new System.Drawing.Size(219, 19);
            this.checkBoxStudentAutoload.TabIndex = 2;
            this.checkBoxStudentAutoload.Text = "자동으로 학생정보 로드하기";
            this.checkBoxStudentAutoload.UseVisualStyleBackColor = true;
            this.checkBoxStudentAutoload.CheckedChanged += new System.EventHandler(this.checkBoxAutoload_CheckedChanged);
            // 
            // labelStudantAmount
            // 
            this.labelStudantAmount.AutoSize = true;
            this.labelStudantAmount.Location = new System.Drawing.Point(16, 60);
            this.labelStudantAmount.Name = "labelStudantAmount";
            this.labelStudantAmount.Size = new System.Drawing.Size(72, 15);
            this.labelStudantAmount.TabIndex = 1;
            this.labelStudantAmount.Text = "학생 수 : ";
            // 
            // listBoxMajorList
            // 
            this.listBoxMajorList.FormattingEnabled = true;
            this.listBoxMajorList.ItemHeight = 15;
            this.listBoxMajorList.Location = new System.Drawing.Point(62, 131);
            this.listBoxMajorList.Name = "listBoxMajorList";
            this.listBoxMajorList.Size = new System.Drawing.Size(157, 184);
            this.listBoxMajorList.TabIndex = 9;
            this.listBoxMajorList.SelectedIndexChanged += new System.EventHandler(this.listBoxMajorList_SelectedIndexChanged);
            // 
            // buttonMajorAdd
            // 
            this.buttonMajorAdd.Location = new System.Drawing.Point(46, 376);
            this.buttonMajorAdd.Name = "buttonMajorAdd";
            this.buttonMajorAdd.Size = new System.Drawing.Size(175, 38);
            this.buttonMajorAdd.TabIndex = 10;
            this.buttonMajorAdd.Text = "전공추가";
            this.buttonMajorAdd.UseVisualStyleBackColor = true;
            this.buttonMajorAdd.Click += new System.EventHandler(this.buttonMajorAdd_Click);
            // 
            // textBoxMajorName
            // 
            this.textBoxMajorName.Location = new System.Drawing.Point(46, 327);
            this.textBoxMajorName.Name = "textBoxMajorName";
            this.textBoxMajorName.Size = new System.Drawing.Size(177, 25);
            this.textBoxMajorName.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.textBoxMajorName);
            this.Controls.Add(this.buttonMajorAdd);
            this.Controls.Add(this.listBoxMajorList);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonStudentLoad);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStudent1Gender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStudent1Number;
        private System.Windows.Forms.TextBox textBoxStudent1Name;
        private System.Windows.Forms.Button buttonStudent1Save;
        private System.Windows.Forms.Button buttonStudentLoad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStudent2Gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStudent2Number;
        private System.Windows.Forms.TextBox textBoxStudent2Name;
        private System.Windows.Forms.Button buttonStudent2Save;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStudent3Gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxStudent3Number;
        private System.Windows.Forms.TextBox textBoxStudent3Name;
        private System.Windows.Forms.Button buttonStudent3Save;
        private System.Windows.Forms.Button buttonStudent1delete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxStudent1memo;
        private System.Windows.Forms.Button buttonStudent2delete;
        private System.Windows.Forms.TextBox textBoxStudent2memo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonStudent3delete;
        private System.Windows.Forms.TextBox textBoxStudent3memo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelStudantAmount;
        private System.Windows.Forms.CheckBox checkBoxStudentAutoload;
        private System.Windows.Forms.ListBox listBoxMajorList;
        private System.Windows.Forms.Button buttonMajorAdd;
        private System.Windows.Forms.TextBox textBoxMajorName;
        private System.Windows.Forms.CheckBox checkBoxMajorAutoload;
    }
}

