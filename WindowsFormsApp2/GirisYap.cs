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
    public partial class GirisYap : Form
    {
        static string user;

        public GirisYap()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("server = DESKTOP-NIR4HMP\\SQLSERVER2017EXP; database=kutuphane; integrated security = true");

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            UyeOl uyeOl = new UyeOl();
            uyeOl.Show();
            this.Hide();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM kullanıcı where KullanıcıAdı='" + bunifuMaterialTextbox1.Text.ToString() + "' and Şifre='" + bunifuMaterialTextbox2.Text.ToString() + "'", baglan);
           SqlDataReader dr= komut.ExecuteReader();

            if (dr.Read())
            {
                this.Hide();
                user = bunifuMaterialTextbox1.Text;
                UyeAnasayfaa uyeAnasayfaa = new UyeAnasayfaa(char.ToUpper(user[0])+user.Substring(1));
                uyeAnasayfaa.Show();
                this.Hide();
            }

            else if (bunifuMaterialTextbox1.Text == "admin" && bunifuMaterialTextbox2.Text == "1234" )
            {

                AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
                adminAnasayfa.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!");
            }
          
            baglan.Close();
        }

        private void BunifuMaterialTextbox2_MouseClick(object sender, MouseEventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
        }

        private void BunifuMaterialTextbox2_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
        }

        private void BunifuMaterialTextbox2_DoubleClick(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
        }
    }
}
