﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnADM_Click(object sender, EventArgs e)
        {
            adminForm adm = new adminForm();
            adm.Show();
            this.Hide();

        }

        private void btnMHS_Click(object sender, EventArgs e)
        {
            userForm usr = new userForm();
            usr.Show();
        }
    }
}
