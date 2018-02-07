using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CheckBoxV.Checked = RichTextBoxEx1.VerticalWriting;
            switch (RichTextBoxEx1.ReadOnly)
            {
                case YYProject.RichEdit.RTBReadOnlyMode.Not:
                    RadioButtonNotRO.Checked = true;
                    break;
                case YYProject.RichEdit.RTBReadOnlyMode.Normal:
                    RadioButtonRON.Checked = true;
                    break;
                case YYProject.RichEdit.RTBReadOnlyMode.ViewOnly:
                    RadioButtonROV.Checked = true;
                    break;
            }
            RichTextBoxEx1.SelectAll();
            var paraSp = RichTextBoxEx1.SelectionParaSpacing;
            NumericUpDownBf.Value = paraSp.Before;
            NumericUpDownAf.Value = paraSp.After;
            var lineSp = RichTextBoxEx1.SelectionLineSpacing;
            NumericUpDownSp.Value = lineSp.Spacing;
            ComboBoxRule.SelectedIndex = (Int32)lineSp.Rule;
            switch (lineSp.Rule)
            {
                case YYProject.RichEdit.RTBLineSpacingRule.Single:
                    LabelSpace.Text = "(Ignored.)";
                    break;
                case YYProject.RichEdit.RTBLineSpacingRule.OneAndHalf:
                    LabelSpace.Text = "(Ignored.)";
                    break;
                case YYProject.RichEdit.RTBLineSpacingRule.Double:
                    LabelSpace.Text = "(Ignored.)";
                    break;
                case YYProject.RichEdit.RTBLineSpacingRule.CustomMin:
                    LabelSpace.Text = "Ignored if less than Single, otherwise, in twips";
                    break;
                case YYProject.RichEdit.RTBLineSpacingRule.CustomExactly:
                    LabelSpace.Text = "twips";
                    break;
                case YYProject.RichEdit.RTBLineSpacingRule.CustomMultiple:
                    LabelSpace.Text = "lines";
                    break;
            }
            RichTextBoxEx1.Select(0, 0);
        }

        private void CheckBoxV_CheckedChanged(object sender, EventArgs e)
        {
            RichTextBoxEx1.VerticalWriting= CheckBoxV.Checked;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonNotRO.Checked == true)
            {
                RichTextBoxEx1.ReadOnly = YYProject.RichEdit.RTBReadOnlyMode.Not;
            }
            if (RadioButtonRON.Checked == true)
            {
                RichTextBoxEx1.ReadOnly = YYProject.RichEdit.RTBReadOnlyMode.Normal;
            }
            if (RadioButtonROV.Checked == true)
            {
                RichTextBoxEx1.ReadOnly = YYProject.RichEdit.RTBReadOnlyMode.ViewOnly;
            }

        }

        private void NumericUpDownParaSpacing_ValueChanged(object sender, EventArgs e)
        {
            RichTextBoxEx1.SelectAll();
            RichTextBoxEx1.SelectionParaSpacing = new YYProject.RichEdit.RTBParaSpacing((Int32)NumericUpDownBf.Value, (Int32)NumericUpDownAf.Value);
            RichTextBoxEx1.Select(0, 0);
        }

     
        private void LineSpacing_Changed(object sender, EventArgs e)
        {
            RichTextBoxEx1.SelectAll();
            var lineSp = new YYProject.RichEdit.RTBLineSpacing((Int32)NumericUpDownSp.Value,(YYProject.RichEdit.RTBLineSpacingRule)ComboBoxRule.SelectedIndex);
            RichTextBoxEx1.SelectionLineSpacing = lineSp;
            RichTextBoxEx1.Select(0, 0);
            switch (lineSp.Rule)
            {
                case YYProject.RichEdit.RTBLineSpacingRule.Single:
                    LabelSpace.Text = "(Ignored.)";
                    break;
                case YYProject.RichEdit.RTBLineSpacingRule.OneAndHalf:
                    LabelSpace.Text = "(Ignored.)";
                    break;
                case YYProject.RichEdit.RTBLineSpacingRule.Double:
                    LabelSpace.Text = "(Ignored.)";
                    break;
                case YYProject.RichEdit.RTBLineSpacingRule.CustomMin:
                    LabelSpace.Text = "Ignored if less than Single, otherwise, in twips";
                    break;
                case YYProject.RichEdit.RTBLineSpacingRule.CustomExactly:
                    LabelSpace.Text = "twips";
                    break;
                case YYProject.RichEdit.RTBLineSpacingRule.CustomMultiple:
                    LabelSpace.Text = "value/20 = lines";
                    break;
            }
        }

     
    }
}
