using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace akreditasiAPP
{
    public partial class adminForm : Form
    {
        public static string namaAdmin = " ";
        public adminForm()
        {
            InitializeComponent();
            
        }

        private void btLG_Click(object sender, EventArgs e)
        {
            string strKoneksi = "Data Source=localhost;Initial Catalog=akreditasi;User "
                        + "ID=sa;Password=ayi240799";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from admin where username = '" + boxID.Text + "' and password ='" + boxPass.Text + "'", koneksi);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                //this.Hide();
                boxID.Text = namaAdmin;
                adminDasboard dsb = new adminDasboard();
                dsb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter corect username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boxID_Enter(object sender, EventArgs e)
        {
            if (boxID.Text == "username")
            {
                boxID.Text = "";

                boxID.ForeColor = Color.Black;
            }
        }

        private void boxID_Leave(object sender, EventArgs e)
        {
            if (boxID.Text == "")
            {
                boxID.Text = "username";

                boxID.ForeColor = Color.Silver;
            }
        }

        private void boxPass_Enter(object sender, EventArgs e)
        {
            if (boxPass.Text == "password")
            {
                boxPass.UseSystemPasswordChar = true;
                boxPass.Text = "";

                boxPass.ForeColor = Color.Black;
            }
        }

        private void boxPass_Leave(object sender, EventArgs e)
        {
            if (boxPass.Text == "")
            {
                boxPass.Text = "password";

                boxPass.ForeColor = Color.Silver;
            }
        }

        private void btBK_Click(object sender, EventArgs e)
        {
            Form1 one = new Form1();
            one.Show();
            this.Hide();
        }
    }
}
