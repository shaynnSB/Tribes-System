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
    public partial class salaryReport : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");

        string sMonth = DateTime.Now.ToString("MM");
        string sYear = DateTime.Now.ToString("yyyy");

        public salaryReport()
        {
            InitializeComponent();
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minButt_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void salaryReport_Load(object sender, EventArgs e)
        {
            addYear();
            assignMonth();
            myearBox.Text = sYear;
            qyearBox.Text = sYear;
            ayearBox.Text = sYear;
        }

        private void assignMonth()
        {
            if (sMonth == "01")
            {
                mmonthBox.Text = "January";
                qmonthBox.Text = "First Quarter";
            }
            else if (sMonth == "02")
            {
                mmonthBox.Text = "February";
                qmonthBox.Text = "First Quarter";
            }
            else if (sMonth == "03")
            {
                mmonthBox.Text = "March";
                qmonthBox.Text = "First Quarter";
            }
            else if (sMonth == "04")
            {
                mmonthBox.Text = "April";
                qmonthBox.Text = "Second Quarter";
            }
            else if (sMonth == "05")
            {
                mmonthBox.Text = "May";
                qmonthBox.Text = "Second Quarter";
            }
            else if (sMonth == "06")
            {
                mmonthBox.Text = "June";
                qmonthBox.Text = "Second Quarter";
            }
            else if (sMonth == "07")
            {
                mmonthBox.Text = "July";
                qmonthBox.Text = "Third Quarter";
            }
            else if (sMonth == "08")
            {
                mmonthBox.Text = "August";
                qmonthBox.Text = "Third Quarter";
            }
            else if (sMonth == "09")
            {
                mmonthBox.Text = "September";
                qmonthBox.Text = "Third Quarter";
            }
            else if (sMonth == "10")
            {
                mmonthBox.Text = "October";
                qmonthBox.Text = "Fourth Quarter";
            }
            else if (sMonth == "11")
            {
                mmonthBox.Text = "November";
                qmonthBox.Text = "Fourth Quarter";
            }
            else if (sMonth == "12")
            {
                mmonthBox.Text = "December";
                qmonthBox.Text = "Fourth Quarter";
            }
        }

        private void addYear()
        {
            for(int i = 0; i < 80; i++)
            {
                int num = 2018 + i;
                myearBox.Items.Add(num);
                qyearBox.Items.Add(num);
                ayearBox.Items.Add(num);
            }
        }
    }
}
