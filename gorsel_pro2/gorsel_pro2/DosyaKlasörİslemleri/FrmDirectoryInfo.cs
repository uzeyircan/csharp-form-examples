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


namespace gorsel_pro2.DosyaKlasörİslemleri
{
    public partial class FrmDirectoryInfo : Form
    {
        public FrmDirectoryInfo()
        {
            InitializeComponent();
        }
        string yol = Directory.GetParent(Application.StartupPath).Parent.FullName + "\\DosyaKlasorIslemleri\\Klasorler";
        private void FrmDirectoryInfo_Load(object sender, EventArgs e)
        {
            DirectoryInfo KlasorBilgi = new DirectoryInfo(yol);
            DirectoryInfo[] Klasorler = KlasorBilgi.GetDirectories();
            foreach (var Klasor in Klasorler)
            {
                LsBoxKlasorler.Items.Add(Klasor.Name);
                //Klasörün oluşturulma tarihi ve mevcut klasörün ana klasörü
                listBox1.Items.Add(Klasor.CreationTime + " - " + Klasor.Parent);
            }
        }

        private void BtnAltKlasorOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtKlasorAdi.Text))
            {
                MessageBox.Show("Lütfen klasör adını yazınız");
            }
            else
            {
                DirectoryInfo KlasorlerBilgi = new DirectoryInfo(yol);
                //CreateSubDirectory() Metodu
                //Mevcut klasör altında klasör oluşturma işlemi için kullanıılır.
                KlasorlerBilgi.CreateSubdirectory(TxtKlasorAdi.Text);

                //Klasörleri okuma 
                DirectoryInfo[] Klasorler = KlasorlerBilgi.GetDirectories();
                listBox1.Items.Clear();
                LsBoxKlasorler.Items.Clear();
                foreach (var Klasor in Klasorler)
                {
                    LsBoxKlasorler.Items.Add(Klasor.Name);
                    //Klasörün oluşturulma tarihi ve mevcut klasörün ana klasörü
                    listBox1.Items.Add(Klasor.CreationTime + " - " + Klasor.Parent);
                }
            }
        }
    }
}
