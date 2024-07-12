using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpsideDownOperators.Orm.Context;

namespace UpsideDownOperators
{
    public partial class FrmCalısanlaraBak : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public string kid;
        public int id;
        public string ImageBase64;
        ProjectContext db = new ProjectContext();
        public FrmCalısanlaraBak()
        {
            InitializeComponent();
        }

        void verigetir()
        {
            baglanti = new SqlConnection("Server=.;Initial Catalog=UpsideDownOperators;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM UserProperties", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgv_PersonelListesi.DataSource = tablo;
            baglanti.Close();
        }

        private void FrmCalısanlaraBak_Load(object sender, EventArgs e)
        {
            verigetir();
            dgv_PersonelListesi.DefaultCellStyle.BackColor = Color.LightBlue;
            dgv_PersonelListesi.DefaultCellStyle.ForeColor = Color.Black;
            dgv_PersonelListesi.DefaultCellStyle.Font = new Font("Arial", 10);

            dgv_PersonelListesi.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
            dgv_PersonelListesi.Columns[0].HeaderCell.Style.ForeColor = Color.White;

            dgv_PersonelListesi.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dgv_PersonelListesi.EnableHeadersVisualStyles = false;

            dgv_PersonelListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dgv_PersonelListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmPersonelDetay frmPersonelDetay = new frmPersonelDetay();
            frmPersonelDetay.kid = kid;
            id = int.Parse(dgv_PersonelListesi.CurrentRow.Cells[0].Value.ToString());
            ImageBase64 = db.UserProperties.Where(a => a.ID == id).First().Vesikalık.ToString();
            frmPersonelDetay.id = id;
            frmPersonelDetay.base64Image = ImageBase64;
            frmPersonelDetay.Show();
        }

        private void dgv_PersonelListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
