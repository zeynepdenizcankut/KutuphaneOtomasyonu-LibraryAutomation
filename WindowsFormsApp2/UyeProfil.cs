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
    public partial class UyeProfil : Form
    {
        static string user;
        public UyeProfil()
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

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            UyeKitaplar uyeKitaplar = new UyeKitaplar();
            uyeKitaplar.Show();
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

        private void UyeProfil_Load(object sender, EventArgs e)
        {
           
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kullanıcı", baglan);
            SqlDataReader listele = komut.ExecuteReader();

            if (listele.Read())
            {
                bunifuMetroTextbox1.Text = listele["KullanıcıAdı"].ToString();
                bunifuMetroTextbox2.Text = listele["Şifre"].ToString();
                bunifuMetroTextbox3.Text = listele["Email"].ToString();
                bunifuMetroTextbox4.Text = listele["Telefon"].ToString();



            }
            baglan.Close();
        }



    }

}
