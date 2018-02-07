namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RichTextBoxEx1 = new YYProject.RichEdit.RichTextBoxEx();
            this.CheckBoxV = new System.Windows.Forms.CheckBox();
            this.RadioButtonRON = new System.Windows.Forms.RadioButton();
            this.RadioButtonROV = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericUpDownBf = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumericUpDownAf = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumericUpDownSp = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboBoxRule = new System.Windows.Forms.ComboBox();
            this.LabelSpace = new System.Windows.Forms.Label();
            this.RadioButtonNotRO = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownBf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownAf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSp)).BeginInit();
            this.SuspendLayout();
            // 
            // RichTextBoxEx1
            // 
            this.RichTextBoxEx1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxEx1.Location = new System.Drawing.Point(12, 12);
            this.RichTextBoxEx1.Name = "RichTextBoxEx1";
            this.RichTextBoxEx1.Size = new System.Drawing.Size(520, 379);
            this.RichTextBoxEx1.TabIndex = 0;
            this.RichTextBoxEx1.Text = resources.GetString("RichTextBoxEx1.Text");
            // 
            // CheckBoxV
            // 
            this.CheckBoxV.AutoSize = true;
            this.CheckBoxV.Location = new System.Drawing.Point(12, 409);
            this.CheckBoxV.Name = "CheckBoxV";
            this.CheckBoxV.Size = new System.Drawing.Size(126, 16);
            this.CheckBoxV.TabIndex = 1;
            this.CheckBoxV.Text = "Vertical writting";
            this.CheckBoxV.UseVisualStyleBackColor = true;
            this.CheckBoxV.CheckedChanged += new System.EventHandler(this.CheckBoxV_CheckedChanged);
            // 
            // RadioButtonRON
            // 
            this.RadioButtonRON.AutoSize = true;
            this.RadioButtonRON.Location = new System.Drawing.Point(269, 408);
            this.RadioButtonRON.Name = "RadioButtonRON";
            this.RadioButtonRON.Size = new System.Drawing.Size(113, 16);
            this.RadioButtonRON.TabIndex = 2;
            this.RadioButtonRON.Text = "ReadOnly-Normal";
            this.RadioButtonRON.UseVisualStyleBackColor = true;
            this.RadioButtonRON.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // RadioButtonROV
            // 
            this.RadioButtonROV.AutoSize = true;
            this.RadioButtonROV.Location = new System.Drawing.Point(419, 408);
            this.RadioButtonROV.Name = "RadioButtonROV";
            this.RadioButtonROV.Size = new System.Drawing.Size(125, 16);
            this.RadioButtonROV.TabIndex = 3;
            this.RadioButtonROV.Text = "ReadOnly-ViewOnly";
            this.RadioButtonROV.UseVisualStyleBackColor = true;
            this.RadioButtonROV.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paragraph Spacing";
            // 
            // NumericUpDownBf
            // 
            this.NumericUpDownBf.Location = new System.Drawing.Point(177, 448);
            this.NumericUpDownBf.Name = "NumericUpDownBf";
            this.NumericUpDownBf.Size = new System.Drawing.Size(56, 21);
            this.NumericUpDownBf.TabIndex = 5;
            this.NumericUpDownBf.ValueChanged += new System.EventHandler(this.NumericUpDownParaSpacing_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Before";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "After";
            // 
            // NumericUpDownAf
            // 
            this.NumericUpDownAf.Location = new System.Drawing.Point(447, 450);
            this.NumericUpDownAf.Name = "NumericUpDownAf";
            this.NumericUpDownAf.Size = new System.Drawing.Size(56, 21);
            this.NumericUpDownAf.TabIndex = 8;
            this.NumericUpDownAf.ValueChanged += new System.EventHandler(this.NumericUpDownParaSpacing_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Line Spacing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "twips";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "twips";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Space";
            // 
            // NumericUpDownSp
            // 
            this.NumericUpDownSp.Location = new System.Drawing.Point(177, 475);
            this.NumericUpDownSp.Name = "NumericUpDownSp";
            this.NumericUpDownSp.Size = new System.Drawing.Size(56, 21);
            this.NumericUpDownSp.TabIndex = 13;
            this.NumericUpDownSp.ValueChanged += new System.EventHandler(this.LineSpacing_Changed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "Rule";
            // 
            // ComboBoxRule
            // 
            this.ComboBoxRule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRule.FormattingEnabled = true;
            this.ComboBoxRule.Items.AddRange(new object[] {
            "Single",
            "OneAndHalf",
            "Double",
            "CustomMin",
            "CustomExactly",
            "CustomMultiple"});
            this.ComboBoxRule.Location = new System.Drawing.Point(446, 476);
            this.ComboBoxRule.Name = "ComboBoxRule";
            this.ComboBoxRule.Size = new System.Drawing.Size(98, 20);
            this.ComboBoxRule.TabIndex = 15;
            this.ComboBoxRule.SelectedIndexChanged += new System.EventHandler(this.LineSpacing_Changed);
            // 
            // LabelSpace
            // 
            this.LabelSpace.Location = new System.Drawing.Point(239, 475);
            this.LabelSpace.Name = "LabelSpace";
            this.LabelSpace.Size = new System.Drawing.Size(143, 48);
            this.LabelSpace.TabIndex = 16;
            this.LabelSpace.Text = "LabelSpace";
            // 
            // RadioButtonNotRO
            // 
            this.RadioButtonNotRO.AutoSize = true;
            this.RadioButtonNotRO.Location = new System.Drawing.Point(153, 409);
            this.RadioButtonNotRO.Name = "RadioButtonNotRO";
            this.RadioButtonNotRO.Size = new System.Drawing.Size(95, 16);
            this.RadioButtonNotRO.TabIndex = 17;
            this.RadioButtonNotRO.Text = "ReadOnly-Not";
            this.RadioButtonNotRO.UseVisualStyleBackColor = true;
            this.RadioButtonNotRO.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 532);
            this.Controls.Add(this.RadioButtonNotRO);
            this.Controls.Add(this.LabelSpace);
            this.Controls.Add(this.ComboBoxRule);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NumericUpDownSp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumericUpDownAf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumericUpDownBf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RadioButtonROV);
            this.Controls.Add(this.RadioButtonRON);
            this.Controls.Add(this.CheckBoxV);
            this.Controls.Add(this.RichTextBoxEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Demo";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownBf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownAf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private YYProject.RichEdit.RichTextBoxEx RichTextBoxEx1;
        private System.Windows.Forms.CheckBox CheckBoxV;
        private System.Windows.Forms.RadioButton RadioButtonRON;
        private System.Windows.Forms.RadioButton RadioButtonROV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericUpDownBf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumericUpDownAf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NumericUpDownSp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboBoxRule;
        private System.Windows.Forms.Label LabelSpace;
        private System.Windows.Forms.RadioButton RadioButtonNotRO;
    }
}

