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
    public partial class standar01 : Form
    {
        //int counter;
        public standar01()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public string prodID_ = " ";
        public string prodID_standar01 = " ";

        private void btADD_Click(object sender, EventArgs e)
        {
            string str = "";
            string strKoneksi = "Data Source=localhost;Initial Catalog=akreditasi;User "
                        + "ID=sa;Password=ayi240799";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            string satu = box01.Text.ToString().Trim();
            string dua = box02.Text.ToString().Trim();
            string tiga = box03.Text.ToString().Trim();
            string empat = box04.Text.ToString().Trim();
            string lima = box05.Text.ToString().Trim();
            string enam = box06.Text.ToString().Trim();
            string tujuh = box07.Text.ToString().Trim();
            string delapan = box08.Text.ToString().Trim();
            string sembilan = prodID_.Trim();
            string sepuluh = prodID_standar01.Trim();


            str = "insert into standar_01 values (@satu, @dua, @tiga, @empat, @lima, @enam, @tujuh, @delapan, @sembilan, @sepuluh)";
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
            cmd.ExecuteNonQuery();
            koneksi.Close();

            this.standar_01TableAdapter.Fill(this.akreditasiDataSet2.standar_01);
            dataGridView1.Refresh();

            //menuInput menu = new menuInput();
            //menu.Show();
        }

        private void standar01_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'akreditasiDataSet2.standar_01' table. You can move, or remove it, as needed.
            this.standar_01TableAdapter.Fill(this.akreditasiDataSet2.standar_01);
            prodID_ = inputAK01.prodID;
            prodID_standar01 = inputAK01.prodID + "_STRD01";
        }

        private void btSB_Click(object sender, EventArgs e)
        {
            menuInput mn = new menuInput();
            mn.Show();
            this.Hide();
        }

        private void btUPDATE_Click(object sender, EventArgs e)
        {
            string str = "";
            string strKoneksi = "Data Source=localhost;Initial Catalog=akreditasi;User "
                        + "ID=sa;Password=ayi240799";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            string satu = box01.Text.ToString().Trim();
            string dua = box02.Text.ToString().Trim();
            string tiga = box03.Text.ToString().Trim();
            string empat = box04.Text.ToString().Trim();
            string lima = box05.Text.ToString().Trim();
            string enam = box06.Text.ToString().Trim();
            string tujuh = box07.Text.ToString().Trim();
            string delapan = box08.Text.ToString().Trim();
            string sembilan = prodID_.Trim();
            string sepuluh = prodID_standar01.Trim();


            str = "update standar_01 set lembaga_mitra=@satu, tingkat_international=@dua, tingkat_nasional=@tiga, lokasi_atau_wilayah=@empat, judul_kegiatan_kerjasama=@lima, manfaat_bagi_ps_yang_diakreditasi=@enam, waktu_dan_durasi=@tujuh, bukti_kerjasama=@delapan, program_studi_id=@sembilan where standar_01=@sepuluh";
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
            cmd.ExecuteNonQuery();
            koneksi.Close();

            this.standar_01TableAdapter.Fill(this.akreditasiDataSet2.standar_01);
            dataGridView1.Refresh();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string satu = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            string dua = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            string tiga = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            string empat = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            string lima = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            string enam = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            string tujuh = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            string delapan = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            string sembilan = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            string sepuluh = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[9].Value);

            box01.Text = satu;
            box02.Text = dua;
            box03.Text = tiga;
            box04.Text = empat;
            box05.Text = lima;
            box06.Text = enam;
            box07.Text = tujuh;
            box08.Text = delapan;
            prodID_ = sembilan;
            prodID_standar01 = sepuluh;
        }

        private void btDL_Click(object sender, EventArgs e)
        {
            string str = "";
            string strKoneksi = "Data Source=localhost;Initial Catalog=akreditasi;User "
                        + "ID=sa;Password=ayi240799";
            SqlConnection koneksi = new SqlConnection();
            koneksi.ConnectionString = strKoneksi;
            koneksi.Open();

            string sepuluh = prodID_standar01.Trim();

            str = "delete standar_01 where standar_01 =" + "'" + sepuluh + "'";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.Add(new SqlParameter("sepuluh", sepuluh));
            cmd.ExecuteNonQuery();

            koneksi.Close();

            this.standar_01TableAdapter.Fill(this.akreditasiDataSet2.standar_01);
            dataGridView1.Refresh();
        }
    }
}
