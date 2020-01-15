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
    public partial class AdminRapor : Form
    {
        public AdminRapor()
        {
            InitializeComponent();
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void AdminRapor_Load(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AdminAnasayfa adminAnasayfa = new AdminAnasayfa();
            adminAnasayfa.Show();
            this.Hide();
        }
    }
}
