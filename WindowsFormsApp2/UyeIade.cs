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
    public partial class UyeIade : Form
    {
        static string user;
        public UyeIade()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server = DESKTOP-NIR4HMP\\SQLSERVER2017EXP; database=kutuphane; integrated security = true");

        private void UyeIade_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM emanet", baglan);
            SqlDataReader listele = komut.ExecuteReader();


            while (listele.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = listele["KullanıcıId"].ToString();
                ekle.SubItems.Add(listele["KullanıcıAdı"].ToString());
                ekle.SubItems.Add(listele["KitapId"].ToString());
                ekle.SubItems.Add(listele["Adı"].ToString());
                ekle.SubItems.Add(listele["EmanetTarihi"].ToString());
                ekle.SubItems.Add(listele["TeslimTarihi"].ToString());


                listView1.Items.Add(ekle);
            }

            baglan.Close();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            UyeAnasayfaa uyeAnasayfaa = new UyeAnasayfaa(user);
            uyeAnasayfaa.Show();
            this.Hide();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into iade(KullanıcıId,KullanıcıAdı,Email,Telefon,KitapId,Adı,TeslimTarihi) values (@KullanıcıId,@KullanıcıAdı,@Email,@Telefon,@KitapId,@Adı,@TeslimTarihi)", baglan);
            komut.Parameters.AddWithValue("@KullanıcıId", bunifuMetroTextbox1.Text);
            komut.Parameters.AddWithValue("@KullanıcıAdı", bunifuMetroTextbox2.Text);
            komut.Parameters.AddWithValue("@Email", bunifuMetroTextbox3.Text);
            komut.Parameters.AddWithValue("@Telefon", bunifuMetroTextbox4.Text);
            komut.Parameters.AddWithValue("@KitapId", bunifuMetroTextbox8.Text);
            komut.Parameters.AddWithValue("@Adı", bunifuMetroTextbox7.Text);
            komut.Parameters.AddWithValue("@TeslimTarihi", bunifuDatepicker2.Value);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kitabınız iade edildi!");
            baglan.Close();

        }
    }
}
