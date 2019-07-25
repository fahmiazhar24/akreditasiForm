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
    public partial class menuInput : Form
    {
        public menuInput()
        {
            InitializeComponent();
        }

        private void btID_Click(object sender, EventArgs e)
        {
            inputAK01 ip = new inputAK01();
            ip.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            standar01 std = new standar01();
            std.Show();
        }
    }
}
