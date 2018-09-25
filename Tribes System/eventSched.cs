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
    public partial class eventSched : UserControl
    {

        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root; Convert Zero Datetime = True;");
        MySqlCommand cmd;

        DataTable grid = new DataTable();
        int selectedRow;

        string currentDate = DateTime.Today.ToString("yyyy-MM-dd");


        public eventSched()
        {
            InitializeComponent();

            boldEvents();      
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            string query = "SELECT * FROM event WHERE start_date = '" + calendar.SelectionStart.Date.ToString("yyyy-MM-dd") + "' OR end_date = '"
                + calendar.SelectionStart.Date.ToString("yyyy-MM-dd") + "' UNION SELECT * FROM event WHERE start_date <= '" + 
                calendar.SelectionStart.Date.ToString("yyyy-MM-dd") + "' AND end_date >= '" + calendar.SelectionStart.Date.ToString("yyyy-MM-dd") + "'";

            eventTable(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editEvent form = new editEvent(this);
            form.nameBox = nameLabel.Text;
            form.locateBox = locLabel.Text;
            form.passNoteBox = notesBox.Text;
            form.clientNameBox = clientLabel.Text;
            form.idValue = id_select;
            form.startD = start;
            form.endD = end;
            form.mail = mailLabel.Text;
            form.ShowDialog();

            show_deets();
            date();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addEvent form = new addEvent();
            form.ShowDialog();

            deetPanel.Visible = false;
        }

        string id_select;
        string event_stat;
        string event_name;

        public static string id;

        private void show_deets()
        {
            string selectQuery = "select * from event where id_event = " + eventGrid.CurrentRow.Cells[0].Value.ToString();
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            string cancel;

            while (reader.Read())
            {
                event_name = reader["event_name"].ToString();

                cancel = reader["event_status"].ToString();
                nameLabel.Text = event_name + " - " + reader["event_status"].ToString();
                //dateLabel.Text = reader["start_date"].ToString() + " - " + reader["end_date"].ToString();
                timeLabel.Text = reader["start_time"].ToString() + " - " + reader["end_time"].ToString();
                locLabel.Text = reader["event_location"].ToString();
                notesBox.Text = reader["event_notes"].ToString();
                clientLabel.Text = reader["client_name"].ToString();
                numLabel.Text = reader["client_contact"].ToString();
                mailLabel.Text = reader["client_email"].ToString();

                if (reader["event_price"].ToString() == "" || reader["event_price"].ToString() == "0.00")
                {
                    amLabel.Text = "PHP " + reader["prices"].ToString();
                }
                else
                {
                    amLabel.Text = "PHP " + reader["event_price"].ToString();
                }

                if (cancel == "Cancelled")
                {
                    viewEquip.Enabled = false;
                    viewStaff.Enabled = false;
                    viewPay.Enabled = false;
                    editButt.Enabled = false;
                    cancellationButt.Enabled = false;
                    remCanButt.Visible = true;
                }
                else
                {
                    viewEquip.Enabled = true;
                    viewStaff.Enabled = true;
                    viewPay.Enabled = true;
                    editButt.Enabled = true;
                    cancellationButt.Enabled = true;
                    remCanButt.Visible = false;
                }
            }
            closeConnection();
        }

        private void eventGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deetPanel.Visible = true;

            selectedRow = e.RowIndex;
            DataGridViewRow row = eventGrid.Rows[selectedRow];
            id = eventGrid.CurrentRow.Cells[0].Value.ToString();
            id_select = eventGrid.CurrentRow.Cells[0].Value.ToString();
            event_stat = eventGrid.CurrentRow.Cells[11].Value.ToString();

            show_deets();

            date();
        }

        string start;
        string end;

        private void date()
        {
            string selectQuery = "select substring(start_date, 1, 10), substring(end_date, 1, 10) from event where id_event = " + id_select;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                start = reader["substring(start_date, 1, 10)"].ToString();
                end = reader["substring(end_date, 1, 10)"].ToString();
                dateLabel.Text = reader["substring(start_date, 1, 10)"].ToString() + " to " + reader["substring(end_date, 1, 10)"].ToString();
            }
            closeConnection();
        }

        private void eventSched_Load(object sender, EventArgs e)
        {
            string current_query = "select * from event where start_date = '" + currentDate + "' OR end_date = '" + currentDate + "'";
            eventTable(current_query);
        }

        private void eventTable(string query)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            eventGrid.Columns.Clear();
            eventGrid.DataSource = table;
            eventGrid.Columns[0].Visible = false;
            eventGrid.Columns[1].HeaderCell.Value = "Event Name";
            eventGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            eventGrid.Columns[2].Visible = false;
            eventGrid.Columns[3].Visible = false;
            eventGrid.Columns[4].Visible = false;
            eventGrid.Columns[5].Visible = false;
            eventGrid.Columns[6].Visible = false;
            eventGrid.Columns[7].Visible = false;
            eventGrid.Columns[8].Visible = false;
            eventGrid.Columns[9].Visible = false;
            eventGrid.Columns[10].Visible = false;
            eventGrid.Columns[11].Visible = false;
            eventGrid.Columns[12].Visible = false;
            eventGrid.Columns[13].Visible = false;
            eventGrid.Columns[14].Visible = false;
            eventGrid.Columns[15].Visible = false;
            eventGrid.Columns[16].Visible = false;
            eventGrid.Columns[17].Visible = false;
            eventGrid.Columns[18].Visible = false;
            eventGrid.Columns[19].Visible = false;

            eventGrid.RowHeadersVisible = false;
        }

        private void viewEquip_Click(object sender, EventArgs e)
        {
            addViewEquip form = new addViewEquip(this);
            form.eventName = event_name;
            form.idValue = eventGrid.CurrentRow.Cells[0].Value.ToString();
            form.ShowDialog();

            show_deets();
            date();
        }

        private void viewStaff_Click(object sender, EventArgs e)
        {
            addViewStaff form = new addViewStaff(this);
            form.eventName = event_name;
            form.idValue = eventGrid.CurrentRow.Cells[0].Value.ToString();
            form.ShowDialog();

            show_deets();
            date();
        }   

        private void cancellationButt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm cancellation of event?", "Cancel Event", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string cancelQuery = "UPDATE event SET event_status = 'Cancelled' WHERE id_event = " + id_select;
                executeMyQuery(cancelQuery);
                MessageBox.Show("Event Cancelled");
                show_deets();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void viewPay_Click(object sender, EventArgs e)
        {
            payDeets form = new payDeets(this);
            form.nameBox = event_name;
            form.idValue = id_select;
            form.statusOfEvent = event_stat;
            form.ShowDialog();

            show_deets();
            date();
        }

        private void label9_Click(object sender, EventArgs e)
        {

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

        private void remCanButt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm removal of cancellation?", "Cancelled Event", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string cancelQuery = "UPDATE event SET event_status = 'Unpaid' WHERE id_event = " + id_select;
                executeMyQuery(cancelQuery);
                MessageBox.Show("Event Cancellation Removed");
                show_deets();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        //------------Color----------------

        public DataTable GetDates()
        {
            DataTable table = new DataTable();
            string query = "SELECT * FROM event";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            return table;
        }

        private void boldEvents()
        {
            /*string query = "SELECT * FROM event WHERE start_date = '" + calendar.SelectionStart.Date.ToString("yyyy-MM-dd") + "' OR end_date = '"
                + calendar.SelectionStart.Date.ToString("yyyy-MM-dd") + "' UNION SELECT * FROM event WHERE start_date <= '" +
                calendar.SelectionStart.Date.ToString("yyyy-MM-dd") + "' AND end_date >= '" + calendar.SelectionStart.Date.ToString("yyyy-MM-dd") + "'";*/

            string selectQuery = "select substring(start_date, 1, 4), substring(end_date, 1, 4), substring(start_date, 6, 2), substring(end_date, 6, 2), " +
                "substring(start_date, 9, 2), substring(end_date, 9, 2) from event";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string firstd = reader["substring(start_date, 9, 2)"].ToString();
                int fd = Convert.ToInt32(firstd);
                string firstm = reader["substring(start_date, 6, 2)"].ToString();
                int fm = Convert.ToInt32(firstm);
                string firsty = reader["substring(start_date, 1, 4)"].ToString();
                int fy = Convert.ToInt32(firsty);
                string lastd = reader["substring(end_date, 9, 2)"].ToString();
                int ld = Convert.ToInt32(lastd);
                string lastm = reader["substring(end_date, 6, 2)"].ToString();
                int lm = Convert.ToInt32(lastm);
                string lasty = reader["substring(end_date, 1, 4)"].ToString();
                int ly = Convert.ToInt32(lasty);

                calendar.BoldedDates = new DateTime[] { new DateTime(fy, fm, fd, 0, 0, 0, 0), new DateTime(ly, lm, ld, 0, 0, 0, 0) };
            }
            closeConnection();        
        }

        //http://geekswithblogs.net/dotNETvinz/archive/2009/05/03/changing-the-background-color-of-the-calendar-control-based-on.aspx
    }
}
