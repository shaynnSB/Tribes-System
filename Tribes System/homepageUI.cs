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
    public partial class homepageUI : UserControl
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root; Convert Zero Datetime = True;");
        MySqlCommand cmd;

        string currentDate = DateTime.Today.ToString("yyyy-MM-dd");
        string sMonth = DateTime.Now.ToString("MM");
        string sYear = DateTime.Now.ToString("yyyy");

        public homepageUI()
        {
            InitializeComponent();
        }

        private void homepageUI_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            show_deets();
            show_deets2();
            show_deets3();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTime.Text = DateTime.Now.ToString("MM-dd-yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss");
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

        string event_name;
        private void show_deets()
        {
            string selectQuery = "SELECT event_name, start_time, end_time, event_location, substring(start_date, 1, 10), " +
                "substring(end_date, 1, 10) FROM event WHERE start_date > '" + currentDate + "' AND event_status <> 'Cancelled' ORDER BY start_date LIMIT 1"; 
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader["event_name"].ToString() == "")
                {
                    panel1.Visible = false;
                }
                else
                {
                    event_name = reader["event_name"].ToString();
                    nameLabel.Text = event_name;
                    timeLabel.Text = reader["start_time"].ToString() + " - " + reader["end_time"].ToString();
                    locLabel.Text = reader["event_location"].ToString();
                    dateLabel.Text = reader["substring(start_date, 1, 10)"].ToString() + " to " + reader["substring(end_date, 1, 10)"].ToString();
                }         
            }
            closeConnection();
        }

        string event_name2;
        private void show_deets2()
        {
            string selectQuery = "SELECT event_name, start_time, end_time, event_location, substring(start_date, 1, 10), " +
                "substring(end_date, 1, 10) FROM event WHERE start_date > '" + currentDate + "' AND event_status <> 'Cancelled' ORDER BY start_date LIMIT 2";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader["event_name"].ToString() == "")
                {
                    panel2.Visible = false;
                }
                else
                {
                    event_name2 = reader["event_name"].ToString();
                    nameLabel2.Text = event_name2;
                    timeLabel2.Text = reader["start_time"].ToString() + " - " + reader["end_time"].ToString();
                    locLabel2.Text = reader["event_location"].ToString();
                    dateLabel2.Text = reader["substring(start_date, 1, 10)"].ToString() + " to " + reader["substring(end_date, 1, 10)"].ToString();
                }
            }
            closeConnection();
        }

        string event_name3;
        private void show_deets3()
        {
            string selectQuery = "SELECT event_name, start_time, end_time, event_location, substring(start_date, 1, 10), " +
                "substring(end_date, 1, 10) FROM event WHERE start_date > '" + currentDate + "' AND event_status <> 'Cancelled' ORDER BY start_date LIMIT 3";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader["event_name"].ToString() == "")
                {
                    panel3.Visible = false;
                }
                else
                {
                    event_name3 = reader["event_name"].ToString();
                    nameLabel3.Text = event_name3;
                    timeLabel3.Text = reader["start_time"].ToString() + " - " + reader["end_time"].ToString();
                    locLabel3.Text = reader["event_location"].ToString();
                    dateLabel3.Text = reader["substring(start_date, 1, 10)"].ToString() + " to " + reader["substring(end_date, 1, 10)"].ToString();
                }
            }
            closeConnection();
        }
    }
}
