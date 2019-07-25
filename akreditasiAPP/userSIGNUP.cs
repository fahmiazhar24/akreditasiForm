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
    public partial class userSIGNUP : Form
    {
        public userSIGNUP()
        {
            InitializeComponent();
            btSG.Enabled = false;
            boxPass.UseSystemPasswordChar = true;
            boxCnfirm.UseSystemPasswordChar = true;
        }

        private void btSG_Click(object sender, EventArgs e)
        {
            
            if (boxPass.Text == boxCnfirm.Text)
            {
                string str = "";
                string strKoneksi = "Data Source=localhost;Initial Catalog=akreditasi;User "
                            + "ID=sa;Password=ayi240799";
                SqlConnection koneksi = new SqlConnection();
                koneksi.ConnectionString = strKoneksi;
                koneksi.Open();

                string user = boxID.Text.ToString().Trim();
                string pass = boxPass.Text.ToString().Trim();

                str = "insert into user_data values (@User, @Pass)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("User", user));
                cmd.Parameters.Add(new SqlParameter("Pass", pass));
                cmd.ExecuteNonQuery();

                btSG.Enabled = true;

                userDassboard dsb = new userDassboard();
                dsb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter corect password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
