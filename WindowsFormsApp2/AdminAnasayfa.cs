using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AdminAnasayfa : Form
    {
        public AdminAnasayfa()
        {
            InitializeComponent();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void AdminAnasayfa_Load(object sender, EventArgs e)
        {
           
        }

        private void BunifuImageButton8_Click(object sender, EventArgs e)
        {
            GirisYap girisYap = new GirisYap();
            girisYap.Show();
            this.Hide();
        }

        private void BunifuImageButton4_Click(object sender, EventArgs e)
        {
            AdminKitapEkle adminKitapEkle = new AdminKitapEkle();
            adminKitapEkle.Show();
            this.Hide();
        }

        private void BunifuImageButton5_Click(object sender, EventArgs e)
        {
            AdminUyeEkle adminUyeEkle = new AdminUyeEkle();
            adminUyeEkle.Show();
            this.Hide();
        }

        private void BunifuImageButton6_Click(object sender, EventArgs e)
        {
            AdminRapor adminRapor = new AdminRapor();
            adminRapor.Show();
            this.Hide();
        }
    }
}
