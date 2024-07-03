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
    public partial class frmKullanıcıKayıt : Form
    {
        ProjectContext DataBase = new ProjectContext();
        public frmKullanıcıKayıt()
        {
            InitializeComponent();
        }

        private void btn_cık_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            List<UserProperty> Userp = new List<UserProperty>();
            Userp = DataBase.UserProperties.ToList();
            bool kullanıcıVar = false;
            foreach (UserProperty p in Userp)
            {
                if (p.TC == txt_tc.Text)
                {
                    kullanıcıVar = true;
                }
            }
            if (kullanıcıVar)
            {
                MessageBox.Show("Bu TC' ye göre zaten kayıtlı bir hesap var");
            }
            else
            {
                UserProperty user = new UserProperty()
                {

                    TC = txt_tc.Text,
                    Sifre = txt_sifre.Text,
                    Ad = txt_ad.Text,
                    Soyad = txt_soyad.Text,
                    TelefonNo = txt_telefon.Text,
                    Adres = txt_adres.Text,
                    Email = txt_email.Text,
                    Gorev = txt_gorev.Text,
                    IseGırısTarihi = txt_isegiristarihi.Text,
                    MaasTipi = txt_maastipi.Text,
                    Aktifmi = true,
                    AddDate = DateTime.Today,

                };
                DataBase.UserProperties.Add(user);
                DataBase.SaveChanges();
                MessageBox.Show("kayıt oluşturuldu");
                frmKullanıcıGiris frmKullanıcıGiris = new frmKullanıcıGiris();
                frmKullanıcıGiris.Show();
                this.Hide();

            }
        }
    }
}
