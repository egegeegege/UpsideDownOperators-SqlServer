using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpsideDownOperators
{
    public partial class frmYoneticiPanel : Form
    {
        public frmYoneticiPanel()
        {
            InitializeComponent();
        }

        private void btn_personelekle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frmPersonelEkle = new frmPersonelEkle();
            frmPersonelEkle.Show();
        }
    }
}
