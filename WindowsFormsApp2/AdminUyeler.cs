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

namespace WindowsFormsApp2
{
    public partial class AdminUyeler : Form
    {
        public AdminUyeler()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("server = DESKTOP-NIR4HMP\\SQLSERVER2017EXP; database=kutuphane; integrated security = true");

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
            adminAnasayfa.Show();
            this.Hide();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AdminKitaplar adminKitaplar = new AdminKitaplar();
            adminKitaplar.Show();
            this.Hide();
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            AdminUyeler adminUyeler = new AdminUyeler();
            adminUyeler.Show();
            this.Hide();
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Adminİletişim adminİletişim = new Adminİletişim();
            adminİletişim.Show();
            this.Hide();
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            AdminUyeEkle adminUyeEkle = new AdminUyeEkle();
            adminUyeEkle.Show();
            this.Hide();
        }

        private void AdminUyeler_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kullanıcı", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];


            baglan.Close();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
