using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akreditasiAPP
{
    public partial class adminDasboard : Form
    {
        public adminDasboard()
        {
            InitializeComponent();
        }

        private void btLG_Click(object sender, EventArgs e)
        {
            Form1 lgt = new Form1();
            lgt.Show();
            this.Hide();
        }

        private void btInputAK_Click(object sender, EventArgs e)
        {
            menuInput inp = new menuInput();
            inp.Show();
        }

        private void adminDasboard_Load(object sender, EventArgs e)
        {
            usADM.Text = adminForm.namaAdmin;
        }
    }
}
