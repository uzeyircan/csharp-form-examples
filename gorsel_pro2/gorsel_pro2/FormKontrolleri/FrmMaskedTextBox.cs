using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorsel_pro2.FormKontrolleri
{
    public partial class FrmMaskedTextBox : Form
    {
        public FrmMaskedTextBox()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //MaskInputRejected Olayı textboca veri girişi bittiği zaman çalışan olaydır.
            //İstenilen format dışında karakter girildiğinde de bu olay tetiklenir.
            MessageBox.Show(maskedTextBox1.Text);

        }

        private void FrmMaskedTextBox_Load(object sender, EventArgs e)
        {
            MaskedTextBox TxtTcno = new MaskedTextBox();
            TxtTcno.Mask = "99999999999";
            TxtTcno.Location=new Point(12,50);
            TxtTcno.MaskInputRejected += TxtTcno_MaskInputRejected;
            Controls.Add(TxtTcno);
        }

        private void TxtTcno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Lütfen geçerli bir tc no girin...");
        }


    }
}
