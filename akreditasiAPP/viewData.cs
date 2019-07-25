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
    public partial class viewData : Form
    {
        public viewData()
        {
            InitializeComponent();
        }

        private void viewData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'akreditasiDataSet1.id_data_akre' table. You can move, or remove it, as needed.
            this.id_data_akreTableAdapter.Fill(this.akreditasiDataSet1.id_data_akre);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.id_data_akreTableAdapter.FillBy(this.akreditasiDataSet1.id_data_akre, textBox1.Text);
                dataGridView1.Refresh();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
