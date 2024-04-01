using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gorsel_pro2.DosyaKlasörİslemleri;
using gorsel_pro2.FormKontrolleri;
using gorsel_pro2.RichTextBox;
using gorsel_pro2.VeriTabanı_İşlemleri;
using WindowsFormsApp01.DosyaKlasorIslemleri;

namespace gorsel_pro2
{
    public partial class Frmkonular : Form
    {
        public Frmkonular()
        {
            InitializeComponent();
        }

        private void Frmkonular_Load(object sender, EventArgs e)
        {
            TreeView treeana = new TreeView();
            treeana.Width = 300;
            treeana.Height = 300;
            treeana.Location = new Point(10,10);
            treeana.NodeMouseClick += Treeana_NodeMouseClick;

            //Konular Düğümü
            TreeNode Konular = new TreeNode("Konular");
            //Form Kontrolleri
            TreeNode FormKontrolleri = new TreeNode("Form Kontrolleri");
            FormKontrolleri.Nodes.Add("MaskedTextBox","MaskedTextBox Kontrolü");
            FormKontrolleri.Nodes.Add("DateTimePicker", "DateTimePicker");
            FormKontrolleri.Nodes.Add("DamaTahtasi", "Dama Tahtası Uygulaması");
            FormKontrolleri.Nodes.Add("NotifyIcons", "NotifyIcons");
            Konular.Nodes.Add(FormKontrolleri);
            treeana.Nodes.Add(Konular);
            

            TreeNode Dosyaislemleri = new TreeNode("Dosya İşlemleri");
            Dosyaislemleri.Nodes.Add("DirectoryInfo", "İnfo");
            Dosyaislemleri.Nodes.Add("FileSınıfı", "File Sınıfı");
            Dosyaislemleri.Nodes.Add("Directory", "Directory Uygulaması");
            Dosyaislemleri.Nodes.Add("Fileİnfo", "File İnfo");
            Dosyaislemleri.Nodes.Add("StreamReaderWriter", "StreamReader ve StreamWriter");
            Konular.Nodes.Add(Dosyaislemleri);
            treeana.ExpandAll();

            TreeNode RichTextBox = new TreeNode("RichTextBox");
            RichTextBox.Nodes.Add("RichTextBox", "RichTextBox");
            Konular.Nodes.Add(RichTextBox);

            TreeNode VeriTabanı = new TreeNode("VeriTabanı");
            VeriTabanı.Nodes.Add("VeriTabanı", "Veri Tabanı");
            Konular.Nodes.Add(VeriTabanı);
            treeana.ExpandAll();
            Controls.Add(treeana);

        }

        private void Treeana_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch(e.Node.Name) 
            {
                case "MaskedTextBox":
                    FrmMaskedTextBox MaskedTextBoxFormu = new FrmMaskedTextBox();
                    MaskedTextBoxFormu.ShowDialog();
                    break;
                case "DateTimePicker":
                    FrmDateTimePicker DateTimePickerFormu = new FrmDateTimePicker();
                    DateTimePickerFormu.ShowDialog();
                    break;
                case "DamaTahtasi":
                    FrmDamaTahtasi DamaTahtasiFormu = new FrmDamaTahtasi();
                    DamaTahtasiFormu.ShowDialog();
                    break;
                case "Directory":
                    FrmDirectory directoryformu = new FrmDirectory();
                    directoryformu.ShowDialog();
                    break;
                case "FileSınıfı":
                    FrmFile fileformu = new FrmFile();
                    fileformu.ShowDialog();
                    break;
                case "DirectoryInfo":
                    FrmDirectoryInfo infoformu = new FrmDirectoryInfo();
                    infoformu.ShowDialog();
                    break;
                case "Fileİnfo":
                    FrmFileİnfo fileinfoformu = new FrmFileİnfo();
                    fileinfoformu.ShowDialog();
                    break;
                case "StreamReaderWriter":
                    FrmStream frmstreamformu = new FrmStream();
                    frmstreamformu.ShowDialog();
                    break;
                case "NotifyIcons":
                    FrmNotifyIcons frmnotifyformu = new FrmNotifyIcons();
                    frmnotifyformu.ShowDialog();
                    break;
                case "RichTextBox":
                    FrmRichTextBox frmrichtextformu = new FrmRichTextBox();
                    frmrichtextformu.ShowDialog();
                    break;
                case "VeriTabanı":
                    FrmVeriTabani FrmVeriTabaniFormu = new FrmVeriTabani();
                    FrmVeriTabaniFormu.ShowDialog();
                    break;
                default:
                    break;

            }
        }
    }
}
