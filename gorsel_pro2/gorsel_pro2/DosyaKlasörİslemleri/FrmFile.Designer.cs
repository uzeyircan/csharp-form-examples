namespace gorsel_pro2.DosyaKlasörİslemleri
{
    partial class FrmFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LstBoxDosyalar = new System.Windows.Forms.ListBox();
            this.TxtDosyaAdi = new System.Windows.Forms.TextBox();
            this.CmBoxUzantilar = new System.Windows.Forms.ComboBox();
            this.BtnDosyaAdiDeğiştir = new System.Windows.Forms.Button();
            this.BtnDosyaOluştur = new System.Windows.Forms.Button();
            this.BtnDosyaSil = new System.Windows.Forms.Button();
            this.BtnDosyaKopyala = new System.Windows.Forms.Button();
            this.TxtDosyaYazOku = new System.Windows.Forms.TextBox();
            this.LstBoxMetinOkuma = new System.Windows.Forms.ListBox();
            this.BtnDosyayaYaz = new System.Windows.Forms.Button();
            this.BtnDosyadanOku = new System.Windows.Forms.Button();
            this.BtnMetinOku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstBoxDosyalar
            // 
            this.LstBoxDosyalar.FormattingEnabled = true;
            this.LstBoxDosyalar.Location = new System.Drawing.Point(12, 12);
            this.LstBoxDosyalar.Name = "LstBoxDosyalar";
            this.LstBoxDosyalar.Size = new System.Drawing.Size(483, 160);
            this.LstBoxDosyalar.TabIndex = 0;
            // 
            // TxtDosyaAdi
            // 
            this.TxtDosyaAdi.Location = new System.Drawing.Point(29, 190);
            this.TxtDosyaAdi.Name = "TxtDosyaAdi";
            this.TxtDosyaAdi.Size = new System.Drawing.Size(113, 20);
            this.TxtDosyaAdi.TabIndex = 1;
            // 
            // CmBoxUzantilar
            // 
            this.CmBoxUzantilar.FormattingEnabled = true;
            this.CmBoxUzantilar.Items.AddRange(new object[] {
            ".txt",
            ".docx",
            ".xlsx",
            ".pptx"});
            this.CmBoxUzantilar.Location = new System.Drawing.Point(29, 242);
            this.CmBoxUzantilar.Name = "CmBoxUzantilar";
            this.CmBoxUzantilar.Size = new System.Drawing.Size(121, 21);
            this.CmBoxUzantilar.TabIndex = 3;
            // 
            // BtnDosyaAdiDeğiştir
            // 
            this.BtnDosyaAdiDeğiştir.Location = new System.Drawing.Point(211, 300);
            this.BtnDosyaAdiDeğiştir.Name = "BtnDosyaAdiDeğiştir";
            this.BtnDosyaAdiDeğiştir.Size = new System.Drawing.Size(176, 23);
            this.BtnDosyaAdiDeğiştir.TabIndex = 4;
            this.BtnDosyaAdiDeğiştir.Text = "Dosya Adı değiştir";
            this.BtnDosyaAdiDeğiştir.UseVisualStyleBackColor = true;
            this.BtnDosyaAdiDeğiştir.Click += new System.EventHandler(this.BtnDosyaAdiDeğiştir_Click);
            // 
            // BtnDosyaOluştur
            // 
            this.BtnDosyaOluştur.Location = new System.Drawing.Point(29, 300);
            this.BtnDosyaOluştur.Name = "BtnDosyaOluştur";
            this.BtnDosyaOluştur.Size = new System.Drawing.Size(113, 23);
            this.BtnDosyaOluştur.TabIndex = 5;
            this.BtnDosyaOluştur.Text = "Dosya oluştur";
            this.BtnDosyaOluştur.UseVisualStyleBackColor = true;
            this.BtnDosyaOluştur.Click += new System.EventHandler(this.BtnDosyaOluştur_Click);
            // 
            // BtnDosyaSil
            // 
            this.BtnDosyaSil.Location = new System.Drawing.Point(472, 300);
            this.BtnDosyaSil.Name = "BtnDosyaSil";
            this.BtnDosyaSil.Size = new System.Drawing.Size(111, 23);
            this.BtnDosyaSil.TabIndex = 6;
            this.BtnDosyaSil.Text = "Dosya Sil";
            this.BtnDosyaSil.UseVisualStyleBackColor = true;
            this.BtnDosyaSil.Click += new System.EventHandler(this.BtnDosyaSil_Click);
            // 
            // BtnDosyaKopyala
            // 
            this.BtnDosyaKopyala.Location = new System.Drawing.Point(662, 300);
            this.BtnDosyaKopyala.Name = "BtnDosyaKopyala";
            this.BtnDosyaKopyala.Size = new System.Drawing.Size(130, 23);
            this.BtnDosyaKopyala.TabIndex = 7;
            this.BtnDosyaKopyala.Text = "Dosya Kopyala";
            this.BtnDosyaKopyala.UseVisualStyleBackColor = true;
            this.BtnDosyaKopyala.Click += new System.EventHandler(this.BtnDosyaKopyala_Click);
            // 
            // TxtDosyaYazOku
            // 
            this.TxtDosyaYazOku.Location = new System.Drawing.Point(710, 12);
            this.TxtDosyaYazOku.Multiline = true;
            this.TxtDosyaYazOku.Name = "TxtDosyaYazOku";
            this.TxtDosyaYazOku.Size = new System.Drawing.Size(244, 72);
            this.TxtDosyaYazOku.TabIndex = 8;
            // 
            // LstBoxMetinOkuma
            // 
            this.LstBoxMetinOkuma.FormattingEnabled = true;
            this.LstBoxMetinOkuma.Location = new System.Drawing.Point(710, 99);
            this.LstBoxMetinOkuma.Name = "LstBoxMetinOkuma";
            this.LstBoxMetinOkuma.Size = new System.Drawing.Size(244, 173);
            this.LstBoxMetinOkuma.TabIndex = 9;
            // 
            // BtnDosyayaYaz
            // 
            this.BtnDosyayaYaz.Location = new System.Drawing.Point(846, 300);
            this.BtnDosyayaYaz.Name = "BtnDosyayaYaz";
            this.BtnDosyayaYaz.Size = new System.Drawing.Size(108, 23);
            this.BtnDosyayaYaz.TabIndex = 10;
            this.BtnDosyayaYaz.Text = "Dosyaya Yaz";
            this.BtnDosyayaYaz.UseVisualStyleBackColor = true;
            this.BtnDosyayaYaz.Click += new System.EventHandler(this.BtnDosyayaYaz_Click);
            // 
            // BtnDosyadanOku
            // 
            this.BtnDosyadanOku.Location = new System.Drawing.Point(814, 363);
            this.BtnDosyadanOku.Name = "BtnDosyadanOku";
            this.BtnDosyadanOku.Size = new System.Drawing.Size(114, 23);
            this.BtnDosyadanOku.TabIndex = 11;
            this.BtnDosyadanOku.Text = "Dosyadan oku";
            this.BtnDosyadanOku.UseVisualStyleBackColor = true;
            this.BtnDosyadanOku.Click += new System.EventHandler(this.BtnDosyadanOku_Click);
            // 
            // BtnMetinOku
            // 
            this.BtnMetinOku.Location = new System.Drawing.Point(680, 363);
            this.BtnMetinOku.Name = "BtnMetinOku";
            this.BtnMetinOku.Size = new System.Drawing.Size(112, 23);
            this.BtnMetinOku.TabIndex = 12;
            this.BtnMetinOku.Text = "Metin oku";
            this.BtnMetinOku.UseVisualStyleBackColor = true;
            this.BtnMetinOku.Click += new System.EventHandler(this.BtnMetinOku_Click);
            // 
            // FrmFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.BtnMetinOku);
            this.Controls.Add(this.BtnDosyadanOku);
            this.Controls.Add(this.BtnDosyayaYaz);
            this.Controls.Add(this.LstBoxMetinOkuma);
            this.Controls.Add(this.TxtDosyaYazOku);
            this.Controls.Add(this.BtnDosyaKopyala);
            this.Controls.Add(this.BtnDosyaSil);
            this.Controls.Add(this.BtnDosyaOluştur);
            this.Controls.Add(this.BtnDosyaAdiDeğiştir);
            this.Controls.Add(this.CmBoxUzantilar);
            this.Controls.Add(this.TxtDosyaAdi);
            this.Controls.Add(this.LstBoxDosyalar);
            this.Name = "FrmFile";
            this.Text = "FrmFile";
            this.Load += new System.EventHandler(this.FrmFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstBoxDosyalar;
        private System.Windows.Forms.TextBox TxtDosyaAdi;
        private System.Windows.Forms.ComboBox CmBoxUzantilar;
        private System.Windows.Forms.Button BtnDosyaAdiDeğiştir;
        private System.Windows.Forms.Button BtnDosyaOluştur;
        private System.Windows.Forms.Button BtnDosyaSil;
        private System.Windows.Forms.Button BtnDosyaKopyala;
        private System.Windows.Forms.TextBox TxtDosyaYazOku;
        private System.Windows.Forms.ListBox LstBoxMetinOkuma;
        private System.Windows.Forms.Button BtnDosyayaYaz;
        private System.Windows.Forms.Button BtnDosyadanOku;
        private System.Windows.Forms.Button BtnMetinOku;
    }
}