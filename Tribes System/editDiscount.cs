﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tribes_System
{
    public partial class editDiscount : Form
    {
        public editDiscount()
        {
            InitializeComponent();
        }

        private void cancelButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
