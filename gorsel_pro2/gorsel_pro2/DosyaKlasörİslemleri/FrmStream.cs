using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp01.DosyaKlasorIslemleri
{
    public partial class FrmStream : Form
    {

        public FrmStream()
        {
            InitializeComponent();
        }

        string Yol = Directory.GetParent(Application.StartupPath).Parent.FullName + @"\DosyaKlasorIslemleri\Klasorler";

        private void FrmStream_Load(object sender, EventArgs e)
        {
            string[] Dosyalar = Directory.GetFiles(Yol);
            foreach (var Dosya in Dosyalar)
                LstBoxDosyalar.Items.Add(Dosya);

        }

        private void BtnDosyayaYaz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDosyaYazOku.Text))
                MessageBox.Show("Lütfen dosyaya yazılacak yazıyı yazınız!");
            else if (LstBoxDosyalar.SelectedIndex < 0)
                MessageBox.Show("Lütfen dosyayı seçiniz!");
            else
            {
                // StreamWriter Sınıfı
                // Dosyalara metin yazma işlemi için kullanılmaktadır.
                StreamWriter streamWriter = new StreamWriter(LstBoxDosyalar.SelectedItem.ToString());
                streamWriter.WriteLine(TxtDosyaYazOku.Text);

                // Kaydet ve dosyayı kapat.
                streamWriter.Close();

                // Dosya bilgisini RAM'den temizler
                streamWriter.Dispose();
            }
        }

        private void BtnDosyadanOku_Click(object sender, EventArgs e)
        {
            if (LstBoxDosyalar.SelectedIndex < 0)
                MessageBox.Show("Lütfen dosyayı seçiniz!");
            else
            {
                // StreamReader Sınıfı
                // Belirtilen yolda bulunan dosyadan metin okuma işlemi için kullanılır.
                StreamReader Sr = new StreamReader(LstBoxDosyalar.SelectedItem.ToString());

                // ReadToEnd() Metodu
                // Dosyada bulunan tüm metni okuyarak string olarak geri çevirir.
                TxtDosyaYazOku.Text = Sr.ReadToEnd();

                // Dosyayı kapat
                Sr.Close();

                // Dosyayı RAM'den temizler
                Sr.Dispose();
            }
        }

        private void BtnMetinOku_Click(object sender, EventArgs e)
        {
            LstBoxMetinOkuma.Items.Clear();

            if (LstBoxDosyalar.SelectedIndex < 0)
                MessageBox.Show("Lütfen dosyayı seçiniz!");
            else
            {
                // StreamReader Sınıfı
                // Belirtilen yolda bulunan dosyadan metin okuma işlemi için kullanılır.
                StreamReader Sr = new StreamReader(LstBoxDosyalar.SelectedItem.ToString());

                // EndOfStream Özelliği
                // Metindeki tüm yazı okunana kadar True değerini çevirir
                // yoksa False değerini çevirir.
                while (!Sr.EndOfStream)
                    // ReadLine Metodu
                    // Dosyadaki metinleri satır satır okuma işlemi yapar.
                    LstBoxMetinOkuma.Items.Add(Sr.ReadLine());

                // Dosyayı kapat
                Sr.Close();

                // Dosyayı RAM'den temizler
                Sr.Dispose();
            }
        }
    }
}
