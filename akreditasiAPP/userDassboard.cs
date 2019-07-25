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
    public partial class userDassboard : Form
    {
        public userDassboard()
        {
            InitializeComponent();
        }

        private void btLG_Click(object sender, EventArgs e)
        {
            
            Form1 lgus = new Form1();
            lgus.Show();
            this.Hide();
        }

        private void userDassboard_Load(object sender, EventArgs e)
        {
            usUS.Text = userForm.nama;
        }

        private void btViewAK_Click(object sender, EventArgs e)
        {
            viewData vw = new viewData();
            vw.Show();
        }
    }
}
