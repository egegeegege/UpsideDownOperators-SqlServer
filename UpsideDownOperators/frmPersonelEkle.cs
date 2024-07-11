using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpsideDownOperators.Orm.Context;
using UpsideDownOperators.Orm.Entity;

namespace UpsideDownOperators
{
    public partial class frmPersonelEkle : Form
    {
        ProjectContext DataBase = new ProjectContext();
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.bmp) | *.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PB_resim.Image = new Bitmap(ofd.FileName);
                FileName.Text = ofd.FileName;
            }
        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            string base64;
            using (Image image = PB_resim.Image.Clone() as Image)
            {
                base64 = ConvertImageToBase64(image);
            }
            UserProperty userProperty = new UserProperty()
            {
                Ad = txt_ad.Text,
                Soyad = txt_soyad.Text,
                TC = txt_tc.Text,
                Gorev = txt_gorev.Text,
                Sifre = txt_sifre.Text,
                Email = txt_email.Text,
                TelefonNo = txt_telefon.Text,
                IseGırısTarihi = txt_isegiristarihi.Text,
                MaasTipi = cmb_maas.Text,
                Adres = txt_adres.Text,
                Aktifmi = false,
                Vesikalık = base64,
                AddDate = DateTime.Now,
            };
            DataBase.UserProperties.Add(userProperty);
            DataBase.SaveChanges();
            MessageBox.Show("Personel Başarıyla Eklenedi");
            this.Hide();
        }
        private string ConvertImageToBase64(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
    }
}
