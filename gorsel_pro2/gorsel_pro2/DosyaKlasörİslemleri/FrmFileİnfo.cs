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
    public partial class FrmFileİnfo : Form
    {
        public FrmFileİnfo()
        {
            InitializeComponent();
        }
        string Yol = Directory.GetParent(Application.StartupPath).Parent.FullName+@"\DosyaKlasorIslemleri\Klasorler";
        private void FrmFileİnfo_Load(object sender, EventArgs e)
        {
            //Tek dosya üzerinde işlem yapmak istiyorsak
            FileInfo Dosyam = new FileInfo(Yol+@"\Filiz.txt");
            //Belirtilen yolda klasör ile ilgili bilgileri getirir.
            DirectoryInfo Klasor = new DirectoryInfo(Yol);
            //GetFiles() Metodu ile FileInfo[] Sınıfı dizi olarak getirir
            //FileInfo sınıfı ilede dosya ile ilgili tüm bilgilere erişmiş oluruz.
            FileInfo[] Dosyalar = Klasor.GetFiles();
            foreach (var Dosya in Dosyalar)
            {
                //Name Özelliği dosyanın adını verir 
                //Extension özelliği dosyanın uzantısını verir
                //Length özelliği dosyanın boyutunu byte cinsinden verir
                //CreationTime özelliği dosyanın oluşturulma tarihini verir.
                LstBoxDosyalar.Items.Add(Dosya.Name + " - " + Dosya.Extension + " - " + Dosya.Length / 1024 + "Kb" + " - " + Dosya.CreationTime);
            }
        }
    }
}
