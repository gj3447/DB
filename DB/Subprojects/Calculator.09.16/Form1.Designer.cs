namespace Calculator._09._16
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxComboCalc = new System.Windows.Forms.GroupBox();
            this.Comboboxcalc = new System.Windows.Forms.Button();
            this.comboBoxOp = new System.Windows.Forms.ComboBox();
            this.textBoxComboboxresult = new System.Windows.Forms.TextBox();
            this.textBoxcomboboxOp2 = new System.Windows.Forms.TextBox();
            this.textBoxcomboboxOp1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxRadio = new System.Windows.Forms.GroupBox();
            this.radioButtonplus = new System.Windows.Forms.RadioButton();
            this.textBoxradiobox1 = new System.Windows.Forms.TextBox();
            this.textBoxradiobox2 = new System.Windows.Forms.TextBox();
            this.radioButtonminus = new System.Windows.Forms.RadioButton();
            this.buttonRadioCalculate = new System.Windows.Forms.Button();
            this.radioresault = new System.Windows.Forms.TextBox();
            this.radioButtonmultyple = new System.Windows.Forms.RadioButton();
            this.radioButtonslice = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxComboCalc.SuspendLayout();
            this.groupBoxRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxComboCalc
            // 
            this.groupBoxComboCalc.Controls.Add(this.Comboboxcalc);
            this.groupBoxComboCalc.Controls.Add(this.comboBoxOp);
            this.groupBoxComboCalc.Controls.Add(this.textBoxComboboxresult);
            this.groupBoxComboCalc.Controls.Add(this.textBoxcomboboxOp2);
            this.groupBoxComboCalc.Controls.Add(this.textBoxcomboboxOp1);
            this.groupBoxComboCalc.Controls.Add(this.label4);
            this.groupBoxComboCalc.Controls.Add(this.label3);
            this.groupBoxComboCalc.Controls.Add(this.label2);
            this.groupBoxComboCalc.Controls.Add(this.label1);
            this.groupBoxComboCalc.Location = new System.Drawing.Point(43, 43);
            this.groupBoxComboCalc.Name = "groupBoxComboCalc";
            this.groupBoxComboCalc.Size = new System.Drawing.Size(710, 167);
            this.groupBoxComboCalc.TabIndex = 0;
            this.groupBoxComboCalc.TabStop = false;
            this.groupBoxComboCalc.Text = "groupBox based Combobox";
            // 
            // Comboboxcalc
            // 
            this.Comboboxcalc.Location = new System.Drawing.Point(457, 70);
            this.Comboboxcalc.Name = "Comboboxcalc";
            this.Comboboxcalc.Size = new System.Drawing.Size(75, 23);
            this.Comboboxcalc.TabIndex = 8;
            this.Comboboxcalc.Text = "Calculate";
            this.Comboboxcalc.UseVisualStyleBackColor = true;
            this.Comboboxcalc.Click += new System.EventHandler(this.Comboboxcalc_Click);
            // 
            // comboBoxOp
            // 
            this.comboBoxOp.FormattingEnabled = true;
            this.comboBoxOp.Location = new System.Drawing.Point(163, 71);
            this.comboBoxOp.Name = "comboBoxOp";
            this.comboBoxOp.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOp.TabIndex = 7;
            // 
            // textBoxComboboxresult
            // 
            this.textBoxComboboxresult.Location = new System.Drawing.Point(557, 69);
            this.textBoxComboboxresult.Name = "textBoxComboboxresult";
            this.textBoxComboboxresult.Size = new System.Drawing.Size(100, 25);
            this.textBoxComboboxresult.TabIndex = 6;
            // 
            // textBoxcomboboxOp2
            // 
            this.textBoxcomboboxOp2.Location = new System.Drawing.Point(325, 69);
            this.textBoxcomboboxOp2.Name = "textBoxcomboboxOp2";
            this.textBoxcomboboxOp2.Size = new System.Drawing.Size(100, 25);
            this.textBoxcomboboxOp2.TabIndex = 5;
            // 
            // textBoxcomboboxOp1
            // 
            this.textBoxcomboboxOp1.Location = new System.Drawing.Point(17, 69);
            this.textBoxcomboboxOp1.Name = "textBoxcomboboxOp1";
            this.textBoxcomboboxOp1.Size = new System.Drawing.Size(100, 25);
            this.textBoxcomboboxOp1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "resault";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operand 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand 1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBoxRadio
            // 
            this.groupBoxRadio.Controls.Add(this.radioButton1);
            this.groupBoxRadio.Controls.Add(this.radioButtonslice);
            this.groupBoxRadio.Controls.Add(this.radioButtonmultyple);
            this.groupBoxRadio.Controls.Add(this.radioresault);
            this.groupBoxRadio.Controls.Add(this.buttonRadioCalculate);
            this.groupBoxRadio.Controls.Add(this.radioButtonminus);
            this.groupBoxRadio.Controls.Add(this.textBoxradiobox2);
            this.groupBoxRadio.Controls.Add(this.textBoxradiobox1);
            this.groupBoxRadio.Controls.Add(this.radioButtonplus);
            this.groupBoxRadio.Location = new System.Drawing.Point(43, 266);
            this.groupBoxRadio.Name = "groupBoxRadio";
            this.groupBoxRadio.Size = new System.Drawing.Size(710, 172);
            this.groupBoxRadio.TabIndex = 1;
            this.groupBoxRadio.TabStop = false;
            this.groupBoxRadio.Text = "groupBox base Radio";
            // 
            // radioButtonplus
            // 
            this.radioButtonplus.AutoSize = true;
            this.radioButtonplus.Location = new System.Drawing.Point(173, 24);
            this.radioButtonplus.Name = "radioButtonplus";
            this.radioButtonplus.Size = new System.Drawing.Size(36, 19);
            this.radioButtonplus.TabIndex = 0;
            this.radioButtonplus.TabStop = true;
            this.radioButtonplus.Text = "+";
            this.radioButtonplus.UseVisualStyleBackColor = true;
            this.radioButtonplus.CheckedChanged += new System.EventHandler(this.radioButtonplus_CheckedChanged);
            // 
            // textBoxradiobox1
            // 
            this.textBoxradiobox1.Location = new System.Drawing.Point(17, 52);
            this.textBoxradiobox1.Name = "textBoxradiobox1";
            this.textBoxradiobox1.Size = new System.Drawing.Size(100, 25);
            this.textBoxradiobox1.TabIndex = 9;
            // 
            // textBoxradiobox2
            // 
            this.textBoxradiobox2.Location = new System.Drawing.Point(325, 52);
            this.textBoxradiobox2.Name = "textBoxradiobox2";
            this.textBoxradiobox2.Size = new System.Drawing.Size(100, 25);
            this.textBoxradiobox2.TabIndex = 10;
            // 
            // radioButtonminus
            // 
            this.radioButtonminus.AutoSize = true;
            this.radioButtonminus.Location = new System.Drawing.Point(173, 49);
            this.radioButtonminus.Name = "radioButtonminus";
            this.radioButtonminus.Size = new System.Drawing.Size(36, 19);
            this.radioButtonminus.TabIndex = 11;
            this.radioButtonminus.TabStop = true;
            this.radioButtonminus.Text = "-";
            this.radioButtonminus.UseVisualStyleBackColor = true;
            this.radioButtonminus.CheckedChanged += new System.EventHandler(this.radioButtonminus_CheckedChanged);
            // 
            // buttonRadioCalculate
            // 
            this.buttonRadioCalculate.Location = new System.Drawing.Point(457, 54);
            this.buttonRadioCalculate.Name = "buttonRadioCalculate";
            this.buttonRadioCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonRadioCalculate.TabIndex = 9;
            this.buttonRadioCalculate.Text = "Calculate";
            this.buttonRadioCalculate.UseVisualStyleBackColor = true;
            this.buttonRadioCalculate.Click += new System.EventHandler(this.buttonRadioCalculate_Click);
            // 
            // radioresault
            // 
            this.radioresault.Location = new System.Drawing.Point(557, 52);
            this.radioresault.Name = "radioresault";
            this.radioresault.Size = new System.Drawing.Size(100, 25);
            this.radioresault.TabIndex = 9;
            // 
            // radioButtonmultyple
            // 
            this.radioButtonmultyple.AutoSize = true;
            this.radioButtonmultyple.Location = new System.Drawing.Point(173, 74);
            this.radioButtonmultyple.Name = "radioButtonmultyple";
            this.radioButtonmultyple.Size = new System.Drawing.Size(35, 19);
            this.radioButtonmultyple.TabIndex = 12;
            this.radioButtonmultyple.TabStop = true;
            this.radioButtonmultyple.Text = "*";
            this.radioButtonmultyple.UseVisualStyleBackColor = true;
            this.radioButtonmultyple.CheckedChanged += new System.EventHandler(this.radioButtonmultyple_CheckedChanged);
            // 
            // radioButtonslice
            // 
            this.radioButtonslice.AutoSize = true;
            this.radioButtonslice.Location = new System.Drawing.Point(173, 103);
            this.radioButtonslice.Name = "radioButtonslice";
            this.radioButtonslice.Size = new System.Drawing.Size(34, 19);
            this.radioButtonslice.TabIndex = 13;
            this.radioButtonslice.TabStop = true;
            this.radioButtonslice.Text = "/";
            this.radioButtonslice.UseVisualStyleBackColor = true;
            this.radioButtonslice.CheckedChanged += new System.EventHandler(this.radioButtonslice_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(173, 128);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 19);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "^";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxRadio);
            this.Controls.Add(this.groupBoxComboCalc);
            this.Name = "Form1";
            this.Text = "Calculate";
            this.groupBoxComboCalc.ResumeLayout(false);
            this.groupBoxComboCalc.PerformLayout();
            this.groupBoxRadio.ResumeLayout(false);
            this.groupBoxRadio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxComboCalc;
        private System.Windows.Forms.Button Comboboxcalc;
        private System.Windows.Forms.ComboBox comboBoxOp;
        private System.Windows.Forms.TextBox textBoxComboboxresult;
        private System.Windows.Forms.TextBox textBoxcomboboxOp2;
        private System.Windows.Forms.TextBox textBoxcomboboxOp1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBoxRadio;
        private System.Windows.Forms.RadioButton radioButtonplus;
        private System.Windows.Forms.RadioButton radioButtonminus;
        private System.Windows.Forms.TextBox textBoxradiobox2;
        private System.Windows.Forms.TextBox textBoxradiobox1;
        private System.Windows.Forms.RadioButton radioButtonmultyple;
        private System.Windows.Forms.TextBox radioresault;
        private System.Windows.Forms.Button buttonRadioCalculate;
        private System.Windows.Forms.RadioButton radioButtonslice;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

