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
    public partial class UyeAnasayfaa : Form
    {
        
        public UyeAnasayfaa(string val)
        {
            InitializeComponent();
            name.Text = val;
        }

        public UyeAnasayfaa()
        {
            InitializeComponent();
           
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            UyeProfil uyeProfil = new UyeProfil();
            uyeProfil.Show();
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

        private void BunifuImageButton4_Click(object sender, EventArgs e)
        {
            UyeOduncAl uyeOduncAl = new UyeOduncAl();
            uyeOduncAl.Show();
            this.Hide();
        }

        private void BunifuImageButton6_Click(object sender, EventArgs e)
        {
            UyeVerilenKitaplar uyeVerilenKitaplar = new UyeVerilenKitaplar();
            uyeVerilenKitaplar.Show();
            this.Hide();
        }

        private void BunifuImageButton7_Click(object sender, EventArgs e)
        {
            GirisYap girisYap = new GirisYap();
            girisYap.Show();
            this.Hide();
        }

        private void BunifuImageButton5_Click(object sender, EventArgs e)
        {
            UyeIade uyeIade = new UyeIade();
            uyeIade.Show();
            this.Hide();
        }
    }
}
