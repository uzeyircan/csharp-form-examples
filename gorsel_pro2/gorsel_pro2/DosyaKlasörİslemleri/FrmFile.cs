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
    public partial class FrmFile : Form
    {
        public FrmFile()
        {
            InitializeComponent();
        }
        string Yol = Directory.GetParent(Application.StartupPath).Parent.FullName+@"\DosyaKlasorIslemleri\Klasorler";
        private void FrmFile_Load(object sender, EventArgs e)
        {
            string[] Dosyalar = Directory.GetFiles(Yol);
            foreach (var Dosya in Dosyalar)
            {
                LstBoxDosyalar.Items.Add(Dosya);
            }
        }

        private void BtnDosyaOluştur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDosyaAdi.Text))
            {
                MessageBox.Show("Lütfen dosya adını yazınızé");

            }
            else if (CmBoxUzantilar.SelectedIndex<0)
            {
                MessageBox.Show("Lütfen dosya uzantısıı seçiniz!");
            }
            else
            {
                //Create() modu belirtilen klasör içinde dosya oluşturma işlemi  için kullanılır. Hangi uzantı seçilmişse o uzantıda dosya oluşturur.
                File.Create(Yol + @"\" + TxtDosyaAdi.Text + CmBoxUzantilar.SelectedItem.ToString());
                MessageBox.Show($"{TxtDosyaAdi.Text}{CmBoxUzantilar.SelectedItem}" + $"Adli dosyanız oluşturuldu");
                //eklenen dosyaları eş zamanlı okumak için

                LstBoxDosyalar.Items.Clear();
                string[] Dosyalar = Directory.GetFiles(Yol);
                foreach (var dosya in Dosyalar)
                {
                    LstBoxDosyalar.Items.Add(dosya);
                }
            }
        }

        private void BtnDosyaAdiDeğiştir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDosyaAdi.Text))
            {
                MessageBox.Show("Lütfen dosya adını yazınız");
            }
            else if (CmBoxUzantilar.SelectedIndex<0)
            {
                MessageBox.Show("Lütfen dosya uzantısını seçiniz!");
            }
            //Exists() metodu
            //Belirtilen yola bakarak dosyanın olup olmadıgını kontrol eder.Eğer dosya var ise true döner yok ise false döner
            else if (!File.Exists(LstBoxDosyalar.SelectedItem.ToString()))
            {
                MessageBox.Show("Belirtilen yolda dosa bulunamadı!");

            }
            else
            {
                //Move () Metodu
                //Girilen ilk yol mevcut dosya yolu, girilen ikinci yol ise dosyanın taşınacak yolu veya dosyanın bulundugu klasör yolu aynı ise dosyanın isminin değiştirilmesini sağlar.
                File.Move(LstBoxDosyalar.SelectedItem.ToString(), Yol + @"\" + TxtDosyaAdi.Text + CmBoxUzantilar.SelectedItem.ToString());

                MessageBox.Show($"{LstBoxDosyalar.SelectedItem} adli dosyanız" + $"{TxtDosyaAdi.Text}{CmBoxUzantilar.SelectedItem}" + "olarak değiştirildi");
                //Güncellenen dosyaları eş zamanlı okumak için 
                LstBoxDosyalar.Items.Clear();
                string[] Dosyalar = Directory.GetFiles(Yol);
                foreach(var Dosya in Dosyalar)
                {
                    LstBoxDosyalar.Items.Add(Dosya);
                }
            }
        }

        private void BtnDosyaSil_Click(object sender, EventArgs e)
        {

            if (LstBoxDosyalar.SelectedIndex<0)
            {
                MessageBox.Show("Lütfen silinecek dosyayu seçiniz!");
            }
            else
            {
                //Delete () Metodu Belirtilen yolda bulunan doyayı silme işi yapar.
                File.Delete(LstBoxDosyalar.SelectedItems.ToString());
                MessageBox.Show($"{LstBoxDosyalar.SelectedItem} adlı dosyanız silindi...");
                LstBoxDosyalar.Items.Remove(LstBoxDosyalar.SelectedItem);

            }

        }

        private void BtnDosyaKopyala_Click(object sender, EventArgs e)
        {
            if (LstBoxDosyalar.SelectedIndex<0)
            {
                MessageBox.Show("Lütfen kopyanacak dosyayı seçiniz!");

            }
            else
            {
                //copy() metodu dosya kopyalama işlemi için kullanılır. İlk girilen yol mevcut dosya yolu, ikinci girilen yol ise dosyanın kopyalanacağı yoldur.
                File.Copy(LstBoxDosyalar.SelectedItem.ToString(),Yol+@"\Zeynep\"+TxtDosyaAdi.Text+CmBoxUzantilar.SelectedItem.ToString());
                MessageBox.Show("Seçtiğiniz dosya kopyalandı");
            }
        }

        private void BtnDosyayaYaz_Click(object sender, EventArgs e)
        {

            if (LstBoxDosyalar.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen üzerine yazıyazılacak dosyayı seçiniz!");

            }
            else
            {
                //AppendAllText Metodu
                //Belirtilen yolda bulunan dosyaya gönderilen tüm yazıları yazmak için kullanılır.
                File.AppendAllText(LstBoxDosyalar.SelectedItem.ToString(), TxtDosyaYazOku.Text);
                MessageBox.Show("Girdiğiniz yazılar dosyaya yazıldı.");

            }
        }

        private void BtnDosyadanOku_Click(object sender, EventArgs e)
        {
            if (LstBoxDosyalar.SelectedIndex<0)
            {
                MessageBox.Show("Lütfen okunacak dosyayı seçiniz");

            }
            else
            {
                //ReadAllText() Metodu dosyada bulunan tüm metni okuyup geriye string olarak çevirir.
                TxtDosyaYazOku.Text = File.ReadAllText(LstBoxDosyalar.SelectedItem.ToString());
            }
        }

        private void BtnMetinOku_Click(object sender, EventArgs e)
        {
            if (LstBoxDosyalar.SelectedIndex<0)
            {
                MessageBox.Show("Lütfen okunacak dosyayı seçiniz!");
            }
            else
            {
                //readalllines() Metodu
                // Dosyada bulunan metni satırlar halinde okuyuğ geriye string[] dizi olarak çevirir.
                string[] Satirlar = File.ReadAllLines(LstBoxDosyalar.SelectedItem.ToString());
                foreach (string Satir in Satirlar) 
                {
                    LstBoxMetinOkuma.Items.Add(Satirlar);
                }
            }
        }
    }
}
