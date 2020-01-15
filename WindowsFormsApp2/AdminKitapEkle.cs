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
    public partial class AdminKitapEkle : Form
    {
        public AdminKitapEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("server = DESKTOP-NIR4HMP\\SQLSERVER2017EXP; database=kutuphane; integrated security = true");


        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {

            if (bunifuMaterialTextbox1.Text == "" || bunifuMaterialTextbox2.Text == "" || bunifuMaterialTextbox3.Text == "" || bunifuMaterialTextbox4.Text == "" || bunifuMaterialTextbox5.Text == "")
            {

                MessageBox.Show("Boş alan bırakmayınız!");
                return;
            }
            else
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("insert into kitaplar(Adı,Yazarı,Yayınevi,BasımYılı,SayfaSayısı) values ('" + bunifuMaterialTextbox1.Text.ToString() + "','" + bunifuMaterialTextbox2.Text.ToString() + "','" + bunifuMaterialTextbox3.Text.ToString() + "','" + bunifuMaterialTextbox4.Text.ToString() + "','" + bunifuMaterialTextbox5.Text.ToString() + "')", baglan);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız başarıyla tamamlandı!");
                baglan.Close();

               
            }
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
            adminAnasayfa.Show();
            this.Hide();
        }
    }
}
