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
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server = DESKTOP-NIR4HMP\\SQLSERVER2017EXP; database=kutuphane; integrated security = true");


        private void Label3_Click(object sender, EventArgs e)
        {
            GirisYap girisYap = new GirisYap();
            girisYap.Show();
            this.Hide();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text != bunifuMaterialTextbox3.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor!");
                return;
            }

            else if (bunifuMaterialTextbox1.Text == "" || bunifuMaterialTextbox2.Text == "" || bunifuMaterialTextbox3.Text == "" || bunifuMaterialTextbox4.Text == "" || bunifuMaterialTextbox5.Text == "")
            {

                MessageBox.Show("Boş alan bırakmayınız!");
                return;
            }
            else
                baglan.Open();
            SqlCommand komut = new SqlCommand("insert into kullanıcı(KullanıcıAdı,Şifre,ŞifreTekrarı,Email,Telefon) values ('" + bunifuMaterialTextbox1.Text.ToString() + "','" + bunifuMaterialTextbox2.Text.ToString() + "','" + bunifuMaterialTextbox3.Text.ToString() + "','" + bunifuMaterialTextbox4.Text.ToString() + "','" + bunifuMaterialTextbox5.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kaydınız başarıyla tamamlandı!");
            baglan.Close();

            GirisYap girisYap = new GirisYap();
            girisYap.Show();
            this.Hide();
              
            
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuMaterialTextbox2_MouseClick(object sender, MouseEventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
        }

        private void BunifuMaterialTextbox2_DoubleClick(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
        }

        private void BunifuMaterialTextbox2_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
        }

        private void BunifuMaterialTextbox3_MouseClick(object sender, MouseEventArgs e)
        {
            bunifuMaterialTextbox3.isPassword = true;
        }

        private void BunifuMaterialTextbox3_DoubleClick(object sender, EventArgs e)
        {
            bunifuMaterialTextbox3.isPassword = true;
        }

        private void BunifuMaterialTextbox3_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox3.isPassword = true;
        }
    }
}
