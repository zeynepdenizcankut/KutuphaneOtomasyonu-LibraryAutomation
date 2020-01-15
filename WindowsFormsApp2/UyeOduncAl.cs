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
    public partial class UyeOduncAl : Form
    {
        static string user;
        public UyeOduncAl()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("server = DESKTOP-NIR4HMP\\SQLSERVER2017EXP; database=kutuphane; integrated security = true");


        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            UyeAnasayfaa uyeAnasayfaa = new UyeAnasayfaa();
            uyeAnasayfaa.Show();
            this.Hide();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into emanet(KullanıcıId,KullanıcıAdı,Email,Telefon,KitapId,Adı,EmanetTarihi,TeslimTarihi) values (@KullanıcıId,@KullanıcıAdı,@Email,@Telefon,@KitapId,@Adı,@EmanetTarihi,@TeslimTarihi)", baglan);
            komut.Parameters.AddWithValue("@KullanıcıId", bunifuMetroTextbox1.Text);
            komut.Parameters.AddWithValue("@KullanıcıAdı", bunifuMetroTextbox2.Text);
            komut.Parameters.AddWithValue("@Email", bunifuMetroTextbox3.Text);
            komut.Parameters.AddWithValue("@Telefon", bunifuMetroTextbox4.Text);
            komut.Parameters.AddWithValue("@KitapId", bunifuMetroTextbox8.Text);
            komut.Parameters.AddWithValue("@Adı", bunifuMetroTextbox7.Text);
            komut.Parameters.AddWithValue("@EmanetTarihi", bunifuDatepicker1.Value);
            komut.Parameters.AddWithValue("@TeslimTarihi", bunifuDatepicker2.Value);

            komut.ExecuteNonQuery();
            MessageBox.Show("Kaydınız başarıyla tamamlandı!");
            baglan.Close();

            UyeAnasayfaa uyeAnasayfaa = new UyeAnasayfaa();
            uyeAnasayfaa.Show();
            this.Hide();

        }

        private void UyeOduncAl_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kitaplar", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];


            baglan.Close();
        }

        private void BunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            UyeAnasayfaa uyeAnasayfaa = new UyeAnasayfaa(user);
            uyeAnasayfaa.Show();
            this.Hide();
        }
    }
}
