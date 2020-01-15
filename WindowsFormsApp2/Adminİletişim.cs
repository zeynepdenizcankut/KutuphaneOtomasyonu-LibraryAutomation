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
    public partial class Adminİletişim : Form
    {
        public Adminİletişim()
        {
            InitializeComponent();

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
            adminAnasayfa.Show();
            this.Hide();
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

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
