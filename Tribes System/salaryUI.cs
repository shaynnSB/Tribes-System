using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tribes_System
{
    public partial class salaryUI : UserControl
    {
        public salaryUI()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void payrollUI_Load(object sender, EventArgs e)
        {
           // dateTimePicker1.Format = DateTimePickerFormat.Custom;
           // dateTimePicker1.CustomFormat = "yyyy-MM";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void allButt_Click(object sender, EventArgs e)
        {

        }

        private void payRepButt_Click(object sender, EventArgs e)
        {
            salaryReport form = new salaryReport();
            form.ShowDialog();
        }
    }
}
