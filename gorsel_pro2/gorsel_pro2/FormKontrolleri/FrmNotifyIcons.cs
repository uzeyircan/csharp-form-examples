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
    public partial class FrmNotifyIcons : Form
    {
        public FrmNotifyIcons()
        {
            InitializeComponent();
        }

        private void FrmNotifyIcons_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void formuAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible=false;
            this.ShowDialog();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
