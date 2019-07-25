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

namespace akreditasiAPP
{
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
        }

        private void btSG_Click(object sender, EventArgs e)
        {
            userSIGNUP sg = new userSIGNUP();
            sg.Show();
        }

        public static string nama = " ";

        private void btLG_Click(object sender, EventArgs e)
        {
            string strKoneksi = "Data Source=localhost;Initial Catalog=akreditasi;User "
                        + "ID=sa;Password=ayi240799";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from user_data where userid = '" + boxID.Text + "' and password ='" + boxPass.Text + "'", koneksi);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                
                this.Hide();
                nama = boxID.Text;
                userDassboard dsb = new userDassboard();
                dsb.Show();

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
                boxPass.UseSystemPasswordChar = false;
                boxPass.Text = "password";

                boxPass.ForeColor = Color.Silver;
            }
        }

        private void userForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btBK_Click(object sender, EventArgs e)
        {
            Form1 one = new Form1();
            one.Show();
            this.Hide();
        }
    }
}
