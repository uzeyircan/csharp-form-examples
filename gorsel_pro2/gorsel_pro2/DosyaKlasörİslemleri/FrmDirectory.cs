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
using System.Security.Cryptography;


namespace gorsel_pro2.DosyaKlasörİslemleri
{
    public partial class FrmDirectory : Form
    {
        public FrmDirectory()
        {
            InitializeComponent();
        }
        string Yol = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        private void FrmDirectory_Load(object sender, EventArgs e)
        {   
            //MessageBox.Show(Application.StartupPath);
            //MessageBox.Show(Directory.GetCurrentDirectory());
            //MessageBox.Show(Yol);
            //Exists() Metodu belirtilen yola göre mevcut klasörün altında bulunan tüm klasörlerin listesini string dizi olarak verir.
            if (Directory.Exists(Yol+"\\DosyaKlasorIslemleri\\Klasorler"))
            {
                string[] Klsorler = Directory.GetDirectories(Yol + "\\DosyaKlasorIslemleri\\Klasorler");
                foreach (var Klasor in Klsorler)
                {
                    LstBoxKlasorler.Items.Add(Klasor);
                }
            }
            //GetCreationTime() Metodu girilen yola göre klasörün oluşturulma tarihini verir.
            //LstBoxKlasorBilgi.Items.Add(Directory.GetCreationTime(Yol+"\\DosyaKlasorIslemleri\\Klasorler"));

            //GetCurrentDirectory() metodu
            //mevcut klasör bilgisini verir
            LstBoxKlasorBilgi.Items.Add(Directory.GetCurrentDirectory());

            //GetFiles() metodu Girilen yola göre klasördeki dosyaları string dizi olarak getirir.Desen girilmeyen.Yanı dosya sorgusu olmayan
            if (Directory.Exists(Yol+ "\\DosyaKlasorIslemleri\\Klasorler"))
            {
                string[] Dosyalar = Directory.GetFiles(Yol + "\\DosyaKlasorIslemleri\\Klasorler");
                foreach (var Dosya in Dosyalar)
                {
                    LstBoxKlasorBilgi.Items.Add(Dosya);
                }
                //Desen Girilen yani dosya sorgusu olan başında D karakterleri olanları getir.
                //string[] Dosyalar = Directory.GetFiles(Yol + "\\DosyaKlasorIslemleri\\Klasorler,"D*"");
                //foreach (var Dosya in Dosyalar)
                //{
                //    LstBoxKlasorBilgi.Items.Add(Dosya);
                //}
            }
            //GetLogicalDrives() Metodu
            //Bilgisayardaki sürücülerin listesini string dizi olarak çevirir.
            string[] Suruculer = Directory.GetLogicalDrives();
            foreach (var surucu in Suruculer)
            {
                LstBoxKlasorBilgi.Items.Add(surucu);
            }
        }

        private void BenKlasorOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtKlasorAdi.Text))
            {
                MessageBox.Show("Lütfen klasör adını yazınız!");
            }
            else
            {
                if (Directory.Exists(Yol+"\\DosyaKlasorIslemleri\\Klasörler"))
                {
                    //CreateDirectory() Metodu belirtilen yola göre girilen isimde klasör oluşturur.
                    Directory.CreateDirectory(Yol + "\\DosyaKlasorIslemleri\\Klasörler\\"+TxtKlasorAdi.Text);
                    MessageBox.Show($"{TxtKlasorAdi.Text} adlı klasör oluşturuldu");
                    LstBoxKlasorler.Items.Clear();
                    string[] Klsorler = Directory.GetDirectories(Yol + "\\DosyaKlasorIslemleri\\Klasörler");
                    foreach (var Klasor in Klsorler)
                    {
                        LstBoxKlasorler.Items.Add(Klasor);
                    }
                }
                else
                {
                    Directory.CreateDirectory(Yol + "\\DosyaKlasorIslemleri\\Klasörler");
                    MessageBox.Show("Klasörler adlı klasör oluşturuldu");
                }
                
            }
        }

        private void BenKlasorSil_Click(object sender, EventArgs e)
        {
            if (LstBoxKlasorler.SelectedIndex>= 0)
            {
                //Delete() Metodu Belirtilen yola göre klasör sile işlemleri yapar

                //Tektek Silme 
                //Directory.Delete(LstBoxKlasorler.SelectedItems.ToString());
                //LstBoxKlasorler.Items.Remove(LstBoxKlasorler.SelectedItem);
                //Çoklu silme 
                for (int i = LstBoxKlasorler.SelectedItems.Count-1; i >=0; i--)
                {
                    Directory.Delete(LstBoxKlasorler.SelectedItems[i].ToString());
                    LstBoxKlasorler.Items.Remove(LstBoxKlasorler.SelectedItems[i]);

                }
            }
        }

        private void BenKlasorAdiDegistir_Click(object sender, EventArgs e)
        {
            //Move Metodu birinci parametre üzerinde islem yapılacak klasör yolu ikinci parametre ismi değiştirilecek klasör veya taşınacak klasörün yolu
            //eğer ikinci parametre aynı klasör içinde değilse taşımma işlemi yapar.Aynı klasör içindeyse isim değiştirme işlmei yapar.
            Directory.Move(LstBoxKlasorler.SelectedItem.ToString(),Yol + "\\DosyaKlasorIslemleri\\Klasörler\\" +TxtKlasorAdi.Text);
            LstBoxKlasorler.Items.Clear();
            string[] Klasorler = Directory.GetDirectories(Yol + "\\DosyaKlasorIslemleri\\Klasörler");
            foreach (var Klasor in Klasorler)
            {
                LstBoxKlasorler.Items.Add(Klasor);
            }

        }
    }
}
