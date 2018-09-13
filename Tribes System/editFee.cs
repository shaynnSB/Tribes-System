using System;
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
    public partial class editFee : Form
    {
        public editFee()
        {
            InitializeComponent();
        }

        private void cancelButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recievedBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void saveButt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edited Successfully");
            this.Close();
        }
    }
}
