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
    public partial class WachtwoordVergeten : UserControl
    {
        public WachtwoordVergeten()
        {
            InitializeComponent();
        }

        private void Btn_Terug_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
