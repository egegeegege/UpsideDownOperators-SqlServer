using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpsideDownOperators.Orm.Context;
using UpsideDownOperators.Orm.Entity;

namespace UpsideDownOperators
{
    public partial class frmKullanıcıGiris : Form
    {
        ProjectContext db = new ProjectContext();
        string TC = "";
        string Sifre = "";
        int id;
        public frmKullanıcıGiris()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKullanıcıKayıt frmKullanıcıKayıt = new frmKullanıcıKayıt();
            frmKullanıcıKayıt.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<UserProperty> users = new List<UserProperty>();
            users = db.UserProperties.Where(y => y.TC ==txt_tc.Text).ToList();
            foreach (UserProperty user in users)
            {
                TC = user.TC.ToString();
                Sifre = user.Sifre.ToString();
            }
            if (TC == txt_tc.Text)
            {
                if (Sifre == txt_sifre.Text)
                {
                    MessageBox.Show("Başarıyla giriş yaptınız 😊");
                    frmYoneticiPanel frmYoneticiPanel = new frmYoneticiPanel();
                    frmYoneticiPanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifre hatalı");
                }
            }
            else
            {
                MessageBox.Show("TC hatalı");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = cmb_sifre.Checked ? '\0' : '*';
        }

        private void btn_cık_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
