﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool
{
    public partial class Toernooi : UserControl
    {
        public Toernooi()
        {
            InitializeComponent();
        }

        private void BtnTerug_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnVerder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Het toernooi wordt gestart, veel plezier!");
        }
    }
}
