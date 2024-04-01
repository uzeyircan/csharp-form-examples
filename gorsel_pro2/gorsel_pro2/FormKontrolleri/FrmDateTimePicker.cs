using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorsel_pro2.FormKontrolleri
{
    public partial class FrmDateTimePicker : Form
    {
        public FrmDateTimePicker()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text=dateTimePicker1.Value.ToString();
        }

        DateTimePicker TarihSaat = new DateTimePicker();
        private void FrmDateTimePicker_Load(object sender, EventArgs e)
        {
            DateTimePicker TarihSaat = new DateTimePicker();
            TarihSaat.Format = DateTimePickerFormat.Custom;
            TarihSaat.CustomFormat = "dd.MM.yyyy dddd MMMM HH:mm:ss";
            TarihSaat.Width = 300;
            TarihSaat.MinDate = new DateTime(2023, 1,1);
            TarihSaat.MaxDate = new DateTime(2023, 12, 31);
            TarihSaat.ValueChanged += TarihSaat_ValueChanged;
            Controls.Add(TarihSaat);

        }

        private void TarihSaat_ValueChanged(object sender, EventArgs e)
        {
            //DateTimePicker TarihSaat = (DateTimePicker)sender;
            MessageBox.Show(TarihSaat.Value.ToString());
           
        }
    }
}
