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
    public partial class FrmDamaTahtasi : Form
    {
        public FrmDamaTahtasi()
        {
            InitializeComponent();
        }

        private void FrmDamaTahtasi_Load(object sender, EventArgs e)
        {
            Button[,] btn = new Button[8, 8];
            int Top = 0;
            int Left = 0;
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    Button BtnTas = new Button();
                    btn[i, j] = BtnTas;
                    btn[i, j].Width = 50;
                    btn[i, j].Height = 50;
                    btn[i, j].Left = Left;
                    btn[i, j].Top = Top;
                    Left += 50;
                    if ((i+j)%2==0)
                    {
                        btn[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        btn[i, j].BackColor = Color.White;
                    }
                    Controls.Add(btn[i, j]);

                }
                Left = 0;
                Top += 50;
            }

        }
    }
}
