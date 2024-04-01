namespace WindowsFormsApp01.DosyaKlasorIslemleri
{
    partial class FrmStream
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
            this.LstBoxMetinOkuma = new System.Windows.Forms.ListBox();
            this.TxtDosyaYazOku = new System.Windows.Forms.TextBox();
            this.BtnDosyayaYaz = new System.Windows.Forms.Button();
            this.BtnDosyadanOku = new System.Windows.Forms.Button();
            this.BtnMetinOku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstBoxDosyalar
            // 
            this.LstBoxDosyalar.FormattingEnabled = true;
            this.LstBoxDosyalar.Location = new System.Drawing.Point(152, 26);
            this.LstBoxDosyalar.Name = "LstBoxDosyalar";
            this.LstBoxDosyalar.Size = new System.Drawing.Size(504, 147);
            this.LstBoxDosyalar.TabIndex = 0;
            // 
            // LstBoxMetinOkuma
            // 
            this.LstBoxMetinOkuma.FormattingEnabled = true;
            this.LstBoxMetinOkuma.Location = new System.Drawing.Point(485, 206);
            this.LstBoxMetinOkuma.Name = "LstBoxMetinOkuma";
            this.LstBoxMetinOkuma.Size = new System.Drawing.Size(171, 147);
            this.LstBoxMetinOkuma.TabIndex = 1;
            // 
            // TxtDosyaYazOku
            // 
            this.TxtDosyaYazOku.Location = new System.Drawing.Point(162, 206);
            this.TxtDosyaYazOku.Multiline = true;
            this.TxtDosyaYazOku.Name = "TxtDosyaYazOku";
            this.TxtDosyaYazOku.Size = new System.Drawing.Size(170, 147);
            this.TxtDosyaYazOku.TabIndex = 2;
            // 
            // BtnDosyayaYaz
            // 
            this.BtnDosyayaYaz.Location = new System.Drawing.Point(152, 388);
            this.BtnDosyayaYaz.Name = "BtnDosyayaYaz";
            this.BtnDosyayaYaz.Size = new System.Drawing.Size(75, 23);
            this.BtnDosyayaYaz.TabIndex = 3;
            this.BtnDosyayaYaz.Text = "DosyaYaz";
            this.BtnDosyayaYaz.UseVisualStyleBackColor = true;
            // 
            // BtnDosyadanOku
            // 
            this.BtnDosyadanOku.Location = new System.Drawing.Point(257, 388);
            this.BtnDosyadanOku.Name = "BtnDosyadanOku";
            this.BtnDosyadanOku.Size = new System.Drawing.Size(94, 23);
            this.BtnDosyadanOku.TabIndex = 4;
            this.BtnDosyadanOku.Text = "DosyadanOku";
            this.BtnDosyadanOku.UseVisualStyleBackColor = true;
            // 
            // BtnMetinOku
            // 
            this.BtnMetinOku.Location = new System.Drawing.Point(372, 388);
            this.BtnMetinOku.Name = "BtnMetinOku";
            this.BtnMetinOku.Size = new System.Drawing.Size(82, 23);
            this.BtnMetinOku.TabIndex = 5;
            this.BtnMetinOku.Text = "MetinOku";
            this.BtnMetinOku.UseVisualStyleBackColor = true;
            // 
            // FrmStream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMetinOku);
            this.Controls.Add(this.BtnDosyadanOku);
            this.Controls.Add(this.BtnDosyayaYaz);
            this.Controls.Add(this.TxtDosyaYazOku);
            this.Controls.Add(this.LstBoxMetinOkuma);
            this.Controls.Add(this.LstBoxDosyalar);
            this.Name = "FrmStream";
            this.Text = "FrmStream";
            this.Load += new System.EventHandler(this.FrmStream_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstBoxDosyalar;
        private System.Windows.Forms.ListBox LstBoxMetinOkuma;
        private System.Windows.Forms.TextBox TxtDosyaYazOku;
        private System.Windows.Forms.Button BtnDosyayaYaz;
        private System.Windows.Forms.Button BtnDosyadanOku;
        private System.Windows.Forms.Button BtnMetinOku;
    }
}