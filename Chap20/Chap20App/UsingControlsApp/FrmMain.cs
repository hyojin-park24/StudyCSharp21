using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingControlsApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var FontsList = FontFamily.Families; // 배열이 됨
            foreach (var font in FontsList)
            {
                CboFont.Items.Add(font.Name);
            }
        }

        private void ChangeFont()
        {
            if (CboFont.SelectedIndex < 0) return; // 선택된 콤보박스에 아무것도 선택안하면 -1임 메서드 탈출함 

            FontStyle style = FontStyle.Regular;
            if (ChkBold.Checked) style |= FontStyle.Bold; // 00000001
            if (ChkItalic.Checked) style |= FontStyle.Italic; // 00000010
            //00000001 | 00000010 = 00000011 (3) = Bold + Italic

            TXTResult.Font = new Font((string)CboFont.SelectedItem, 14, style);
        }
        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void TXTResult_TextChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void CboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PrbDisplay.Value = trackBar1.Value;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
