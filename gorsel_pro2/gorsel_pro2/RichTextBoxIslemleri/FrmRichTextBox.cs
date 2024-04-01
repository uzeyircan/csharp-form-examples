using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gorsel_pro2.RichTextBox
{
    public partial class FrmRichTextBox : Form
    {
        public FrmRichTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cevap = fontDialog1.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap = colorDialog1.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                string Yol = Directory.GetParent(Application.StartupPath).Parent.FullName + @"\RichTextBoxIslemleri";
                if (comboBox1.SelectedItem.ToString()== ".rtf")
                {
                    richTextBox1.SaveFile(Yol + @"\Deneme" + comboBox1.SelectedItem);
                }
                else
                {
                    richTextBox1.SaveFile(Yol + @"\Deneme" + comboBox1.SelectedItem,RichTextBoxStreamType.PlainText);
                }
                MessageBox.Show("Kayıt Başarılı...");

            }
            else
            {
                MessageBox.Show("Lütfen dosya türünü seçiniz...");

            }
        }

    }
}
