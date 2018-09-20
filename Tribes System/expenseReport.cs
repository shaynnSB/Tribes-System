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
        MySqlCommand cmd;

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
            changeQuarter();
            fillMonth();
            fillQuarter();
        }

        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                cmd = new MySqlCommand(query, con);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("Executed");
                }

                else
                {
                    MessageBox.Show("Not Executed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
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
            string query = "select start_date, event_name, exp_name, exp_price from event, expenses where event_id = id_event AND substring(start_date, 6,2) = '" + sMonth 
                + "' AND substring(start_date, 1,4) = '" + sYear + "' ORDER BY start_date";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            monthExpRep.Columns.Clear();
            monthExpRep.DataSource = table;

            monthExpRep.Columns[0].HeaderCell.Value = "Date";
            monthExpRep.Columns[1].HeaderCell.Value = "Event Name";
            monthExpRep.Columns[2].HeaderCell.Value = "Expense Name";
            monthExpRep.Columns[3].HeaderCell.Value = "Expense Price";
            monthExpRep.RowHeadersVisible = false;

            monthExpRep.Columns[0].Width = 80;
            monthExpRep.Columns[1].Width = 300;
            monthExpRep.Columns[2].Width = 130;
            monthExpRep.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            totExpMonth();
        }

        private void fillQuarter()
        {
            string query = "select start_date, event_name, exp_name, exp_price from event, expenses where event_id = id_event AND " + quarter
                + " ORDER BY start_date";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            quarterGrid.Columns.Clear();
            quarterGrid.DataSource = table;

            quarterGrid.Columns[0].HeaderCell.Value = "Date";
            quarterGrid.Columns[1].HeaderCell.Value = "Event Name";
            quarterGrid.Columns[2].HeaderCell.Value = "Expense Name";
            quarterGrid.Columns[3].HeaderCell.Value = "Expense Price";
            quarterGrid.RowHeadersVisible = false;

            quarterGrid.Columns[0].Width = 80;
            quarterGrid.Columns[1].Width = 300;
            quarterGrid.Columns[2].Width = 130;
            quarterGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            totExpMonth();
        }

        private void myearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearChange();
            fillMonth();
        }

        private void mmonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthChange();
            fillMonth();
        }

        private void yearChange()
        {
            sYear = myearBox.Text;
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

        string first = "substring(start_date, 6,2) = '01' OR substring(start_date, 6,2) = '02' OR substring(start_date, 6,2) = '03'";
        string second = "substring(start_date, 6,2) = '04' OR substring(start_date, 6,2) = '05' OR substring(start_date, 6,2) = '06'";
        string third = "substring(start_date, 6,2) = '07' OR substring(start_date, 6,2) = '08' OR substring(start_date, 6,2) = '09'";
        string fourth = "substring(start_date, 6,2) = '10' OR substring(start_date, 6,2) = '11' OR substring(start_date, 6,2) = '12'";

        string quarter;

        private void changeQuarter()
        {
            if(qmonthBox.Text == "First Quarter")
            {
                quarter = first; 
            }
            else if (qmonthBox.Text == "Second Quarter")
            {
                quarter = second; 
            }
            else if (qmonthBox.Text == "Third Quarter")
            {
                quarter = third;
            }
            else if (qmonthBox.Text == "Fourth Quarter")
            {
                quarter = fourth;
            }
        }

        private void totExpMonth()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND substring(start_date, 6,2) = '" + sMonth
                + "' AND substring(start_date, 1,4) = '" + sYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                mTotLabel.Text = "PHP " + reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        private void qmonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeQuarter();
            fillQuarter();
        }
    }

}

