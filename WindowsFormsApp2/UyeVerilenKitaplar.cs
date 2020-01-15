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
    public partial class UyeVerilenKitaplar : Form
    {
        static string user;
        public UyeVerilenKitaplar()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server = DESKTOP-NIR4HMP\\SQLSERVER2017EXP; database=kutuphane; integrated security = true");


        private void UyeVerilenKitaplar_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM emanet", baglan);
            SqlDataReader listele = komut.ExecuteReader();
           

            while (listele.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = listele["EmanetId"].ToString();
                ekle.SubItems.Add(listele["KullanıcıAdı"].ToString());
                ekle.SubItems.Add(listele["KitapId"].ToString());
                ekle.SubItems.Add(listele["Adı"].ToString());
                ekle.SubItems.Add(listele["EmanetTarihi"].ToString());
                ekle.SubItems.Add(listele["TeslimTarihi"].ToString());


                listView1.Items.Add(ekle);
            }

            baglan.Close();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            UyeAnasayfaa uyeAnasayfaa = new UyeAnasayfaa(user);
            uyeAnasayfaa.Show();
            this.Hide();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            UyeKitaplar uyeKitaplar = new UyeKitaplar();
            uyeKitaplar.Show();
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
    }
}
