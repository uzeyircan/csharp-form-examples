namespace gorsel_pro2.DosyaKlasörİslemleri
{
    partial class FrmDirectory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BenKlasorOlustur = new System.Windows.Forms.Button();
            this.BenKlasorAdiDegistir = new System.Windows.Forms.Button();
            this.BenKlasorSil = new System.Windows.Forms.Button();
            this.TxtKlasorAdi = new System.Windows.Forms.TextBox();
            this.LstBoxKlasorBilgi = new System.Windows.Forms.ListBox();
            this.LstBoxKlasorler = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BenKlasorOlustur);
            this.groupBox1.Controls.Add(this.BenKlasorAdiDegistir);
            this.groupBox1.Controls.Add(this.BenKlasorSil);
            this.groupBox1.Controls.Add(this.TxtKlasorAdi);
            this.groupBox1.Controls.Add(this.LstBoxKlasorBilgi);
            this.groupBox1.Controls.Add(this.LstBoxKlasorler);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1184, 594);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "+";
            // 
            // BenKlasorOlustur
            // 
            this.BenKlasorOlustur.Location = new System.Drawing.Point(55, 398);
            this.BenKlasorOlustur.Name = "BenKlasorOlustur";
            this.BenKlasorOlustur.Size = new System.Drawing.Size(102, 23);
            this.BenKlasorOlustur.TabIndex = 5;
            this.BenKlasorOlustur.Text = "Klasör Oluştur";
            this.BenKlasorOlustur.UseVisualStyleBackColor = true;
            this.BenKlasorOlustur.Click += new System.EventHandler(this.BenKlasorOlustur_Click);
            // 
            // BenKlasorAdiDegistir
            // 
            this.BenKlasorAdiDegistir.Location = new System.Drawing.Point(344, 280);
            this.BenKlasorAdiDegistir.Name = "BenKlasorAdiDegistir";
            this.BenKlasorAdiDegistir.Size = new System.Drawing.Size(109, 23);
            this.BenKlasorAdiDegistir.TabIndex = 4;
            this.BenKlasorAdiDegistir.Text = "Klasör Adı Değştir";
            this.BenKlasorAdiDegistir.UseVisualStyleBackColor = true;
            this.BenKlasorAdiDegistir.Click += new System.EventHandler(this.BenKlasorAdiDegistir_Click);
            // 
            // BenKlasorSil
            // 
            this.BenKlasorSil.Location = new System.Drawing.Point(249, 281);
            this.BenKlasorSil.Name = "BenKlasorSil";
            this.BenKlasorSil.Size = new System.Drawing.Size(75, 23);
            this.BenKlasorSil.TabIndex = 3;
            this.BenKlasorSil.Text = "Klasör Sil";
            this.BenKlasorSil.UseVisualStyleBackColor = true;
            this.BenKlasorSil.Click += new System.EventHandler(this.BenKlasorSil_Click);
            // 
            // TxtKlasorAdi
            // 
            this.TxtKlasorAdi.Location = new System.Drawing.Point(55, 283);
            this.TxtKlasorAdi.Name = "TxtKlasorAdi";
            this.TxtKlasorAdi.Size = new System.Drawing.Size(168, 20);
            this.TxtKlasorAdi.TabIndex = 2;
            // 
            // LstBoxKlasorBilgi
            // 
            this.LstBoxKlasorBilgi.FormattingEnabled = true;
            this.LstBoxKlasorBilgi.Location = new System.Drawing.Point(632, 19);
            this.LstBoxKlasorBilgi.Name = "LstBoxKlasorBilgi";
            this.LstBoxKlasorBilgi.Size = new System.Drawing.Size(368, 186);
            this.LstBoxKlasorBilgi.TabIndex = 1;
            // 
            // LstBoxKlasorler
            // 
            this.LstBoxKlasorler.FormattingEnabled = true;
            this.LstBoxKlasorler.Location = new System.Drawing.Point(55, 19);
            this.LstBoxKlasorler.Name = "LstBoxKlasorler";
            this.LstBoxKlasorler.Size = new System.Drawing.Size(368, 186);
            this.LstBoxKlasorler.TabIndex = 0;
            // 
            // FrmDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 618);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDirectory";
            this.Text = "FrmDirectory";
            this.Load += new System.EventHandler(this.FrmDirectory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BenKlasorAdiDegistir;
        private System.Windows.Forms.Button BenKlasorSil;
        private System.Windows.Forms.TextBox TxtKlasorAdi;
        private System.Windows.Forms.ListBox LstBoxKlasorBilgi;
        private System.Windows.Forms.ListBox LstBoxKlasorler;
        private System.Windows.Forms.Button BenKlasorOlustur;
    }
}