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
    public partial class frmPersonelDetay : Form
    {
        internal int id;
        internal string kid;
        internal string base64Image;

        ProjectContext db = new ProjectContext();

        public frmPersonelDetay()
        {
            InitializeComponent();
        }

        private void frmPersonelDetay_Load(object sender, EventArgs e)
        {
            List<UserProperty> users = new List<UserProperty>();
            users = db.UserProperties.Where(a => a.ID == id).ToList();

            foreach (var user in users) 
            {
                lbl_ad.Text=user.Ad.ToString();
                lbl_soyad.Text=user.Soyad.ToString();
                lbl_email.Text=user.Email.ToString();
                lbl_sifre.Text=user.Sifre.ToString();
                lbl_telefon.Text=user.TelefonNo.ToString();
                lbl_Tc.Text=user.TC.ToString();
                lbl_gorev.Text=user.Gorev.ToString();
                lbl_giristarihi.Text=user.IseGırısTarihi.ToString();
                lbl_maasTipi.Text=user.MaasTipi.ToString();
                lbl_adres.Text=user.Adres.ToString();
                pb_UserResim.Image = ConvertBase64ToImage(user.Vesikalık);
            }
        }
        private Image ConvertBase64ToImage(string imageUrl)
        {
            byte[] imageBytes = Convert.FromBase64String(imageUrl);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }
    }
}
