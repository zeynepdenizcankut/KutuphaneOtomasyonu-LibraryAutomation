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
    public partial class UyeKitaplar : Form
    {
        static string user;
        public UyeKitaplar()
        {
            InitializeComponent();
           
        }
        SqlConnection baglan = new SqlConnection("server = DESKTOP-NIR4HMP\\SQLSERVER2017EXP; database=kutuphane; integrated security = true");


        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            UyeAnasayfaa uyeAnasayfaa = new UyeAnasayfaa(user);
            uyeAnasayfaa.Show();
            this.Hide();
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            UyeProfil uyeProfil = new UyeProfil();
            uyeProfil.Show();
            this.Hide();
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Uyeİletisim uyeİletisim = new Uyeİletisim();
            uyeİletisim.Show();
            this.Hide();

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UyeKitaplar_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kitaplar", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];


            baglan.Close();
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            UyeOduncAl uyeOduncAl = new UyeOduncAl();
            uyeOduncAl.Show();
            this.Hide();
        }
    }
}
