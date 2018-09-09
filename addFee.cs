using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tribes_System
{
    public partial class addFee : Form
    {
        eventSched form = new eventSched();
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");
        MySqlCommand cmd;

        public addFee()
        {
            InitializeComponent();
        }

        private void cancelButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added Successfully");
            this.Close();
        }
    }
}
