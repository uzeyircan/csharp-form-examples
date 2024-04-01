namespace gorsel_pro2.DosyaKlasörİslemleri
{
    partial class FrmDirectoryInfo
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
            this.LsBoxKlasorler = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TxtKlasorAdi = new System.Windows.Forms.TextBox();
            this.BtnAltKlasorOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LsBoxKlasorler
            // 
            this.LsBoxKlasorler.FormattingEnabled = true;
            this.LsBoxKlasorler.Location = new System.Drawing.Point(35, 39);
            this.LsBoxKlasorler.Name = "LsBoxKlasorler";
            this.LsBoxKlasorler.Size = new System.Drawing.Size(120, 95);
            this.LsBoxKlasorler.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(301, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // TxtKlasorAdi
            // 
            this.TxtKlasorAdi.Location = new System.Drawing.Point(548, 52);
            this.TxtKlasorAdi.Name = "TxtKlasorAdi";
            this.TxtKlasorAdi.Size = new System.Drawing.Size(151, 20);
            this.TxtKlasorAdi.TabIndex = 2;
            // 
            // BtnAltKlasorOlustur
            // 
            this.BtnAltKlasorOlustur.Location = new System.Drawing.Point(548, 111);
            this.BtnAltKlasorOlustur.Name = "BtnAltKlasorOlustur";
            this.BtnAltKlasorOlustur.Size = new System.Drawing.Size(151, 23);
            this.BtnAltKlasorOlustur.TabIndex = 3;
            this.BtnAltKlasorOlustur.Text = "Alt Klasör Oluştur";
            this.BtnAltKlasorOlustur.UseVisualStyleBackColor = true;
            this.BtnAltKlasorOlustur.Click += new System.EventHandler(this.BtnAltKlasorOlustur_Click);
            // 
            // FrmDirectoryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 270);
            this.Controls.Add(this.BtnAltKlasorOlustur);
            this.Controls.Add(this.TxtKlasorAdi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.LsBoxKlasorler);
            this.Name = "FrmDirectoryInfo";
            this.Text = "FrmDirectoryInfo";
            this.Load += new System.EventHandler(this.FrmDirectoryInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LsBoxKlasorler;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox TxtKlasorAdi;
        private System.Windows.Forms.Button BtnAltKlasorOlustur;
    }
}