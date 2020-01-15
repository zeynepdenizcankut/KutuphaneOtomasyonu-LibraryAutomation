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
    public partial class Uyeİletisim : Form
    {
        static string user;
        public Uyeİletisim()
        {
            InitializeComponent();
        
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

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
