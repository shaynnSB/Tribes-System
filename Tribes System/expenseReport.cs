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
    public partial class expenseReport : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");

        string sMonth = DateTime.Now.ToString("MM");
        string sYear = DateTime.Now.ToString("yyyy");

        public expenseReport()
        {
            InitializeComponent();
        }

        private void expenseReport_Load(object sender, EventArgs e)
        {
            addYear();
            assignMonth();
            myearBox.Text = sYear;
            qyearBox.Text = sYear;
            ayearBox.Text = sYear;
            fillMonth();
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
            for (int i = 0; i < 80; i++)
            {
                int num = 2018 + i;
                myearBox.Items.Add(num);
                qyearBox.Items.Add(num);
                ayearBox.Items.Add(num);
            }
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minButt_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void fillMonth()
        {
            string query = "select event_name, exp_name, exp_price from event, expenses where event_id = id_event AND substring(start_date, 6,2) = '" + sMonth 
                + "' AND substring(start_date, 1,4) = '" + sYear + "'";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            monthExpRep.Columns.Clear();
            monthExpRep.DataSource = table;

            monthExpRep.Columns[0].HeaderCell.Value = "Event Name";
            monthExpRep.Columns[1].HeaderCell.Value = "Expense Name";
            monthExpRep.Columns[2].HeaderCell.Value = "Expense Price";
            monthExpRep.RowHeadersVisible = false;

            monthExpRep.Columns[0].Width = 350;
            monthExpRep.Columns[1].Width = 150;
            monthExpRep.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void myearBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mmonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthChange();
            fillMonth();
        }

        private void monthChange()
        {
            if (mmonthBox.Text == "January")
            {
                sMonth = "01";
            } else if (mmonthBox.Text == "February")
            {
                sMonth = "02";
            } else if (mmonthBox.Text == "March")
            {
                sMonth = "03";
            } else if (mmonthBox.Text == "April")
            {
                sMonth = "04";
            } else if (mmonthBox.Text == "May")
            {
                sMonth = "05";
            } else if (mmonthBox.Text == "June")
            {
                sMonth = "06";
            } else if (mmonthBox.Text == "July")
            {
                sMonth = "07";
            } else if (mmonthBox.Text == "August")
            {
                sMonth = "08";
            } else if (mmonthBox.Text == "September")
            {
                sMonth = "09";
            } else if (mmonthBox.Text == "October")
            {
                sMonth = "10";
            } else if (mmonthBox.Text == "November")
            {
                sMonth = "11";
            } else if (mmonthBox.Text == "December")
            {
                sMonth = "12";
            }
        }
    }

}

