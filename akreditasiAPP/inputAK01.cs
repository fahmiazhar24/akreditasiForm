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
    public partial class inputAK01 : Form
    {
        public inputAK01()
        {
            InitializeComponent();
        }

        public static string prodID = " ";

        private void btSUBMIT_Click(object sender, EventArgs e)
        {
            string str = "";
            string strKoneksi = "Data Source=localhost;Initial Catalog=akreditasi;User "
                        + "ID=sa;Password=ayi240799";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            prodID = textBox15.Text;

            string nol = textBox15.Text.ToString().Trim();
            string satu = textBox1.Text.ToString().Trim();
            string dua = textBox2.Text.ToString().Trim();
            string tiga = textBox3.Text.ToString().Trim();
            string empat = textBox4.Text.ToString().Trim();
            string lima = textBox5.Text.ToString().Trim();
            string enam = textBox10.Text.ToString().Trim();
            string tujuh = textBox9.Text.ToString().Trim();
            string delapan = textBox14.Text.ToString().Trim();
            string sembilan = textBox8.Text.ToString().Trim();
            string sepuluh = textBox7.Text.ToString().Trim();
            string sebelas = textBox6.Text.ToString().Trim();
            string duabelas = textBox12.Text.ToString().Trim();
            string tigabelas = textBox13.Text.ToString().Trim();
            string empatbelas = textBox11.Text.ToString().Trim();

            str = "insert into id_data_akre values (@satu, @dua, @tiga, @empat, @lima, @enam, @tujuh, @delapan, @sembilan, @sepuluh, @sebelas, @duabelas, @tigabelas, @empatbelas, @nol)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("satu", satu));
            cmd.Parameters.Add(new SqlParameter("dua", dua));
            cmd.Parameters.Add(new SqlParameter("tiga", tiga));
            cmd.Parameters.Add(new SqlParameter("empat", empat));
            cmd.Parameters.Add(new SqlParameter("lima", lima));
            cmd.Parameters.Add(new SqlParameter("enam", enam));
            cmd.Parameters.Add(new SqlParameter("tujuh", tujuh));
            cmd.Parameters.Add(new SqlParameter("delapan", delapan));
            cmd.Parameters.Add(new SqlParameter("sembilan", sembilan));
            cmd.Parameters.Add(new SqlParameter("sepuluh", sepuluh));
            cmd.Parameters.Add(new SqlParameter("sebelas", sebelas));
            cmd.Parameters.Add(new SqlParameter("duabelas", duabelas));
            cmd.Parameters.Add(new SqlParameter("tigabelas", tigabelas));
            cmd.Parameters.Add(new SqlParameter("empatbelas", empatbelas));
            cmd.Parameters.Add(new SqlParameter("nol", nol));
            cmd.ExecuteNonQuery();

            menuInput menu = new menuInput();
            menu.Show();
            this.Hide();
        }
    }
}
