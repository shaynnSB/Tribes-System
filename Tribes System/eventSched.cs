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
        MySqlCommand adapter;
        DataTable grid = new DataTable();
        int selectedRow;

        public eventSched()
        {
            InitializeComponent();
            
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

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            eventGrid.Visible = true;

            string query = "SELECT * FROM event WHERE isArchived<1 and (start_date = '" + calendar.SelectionStart.Date.ToString("yyyy-MM-dd") + "' OR end_date = '"
                + calendar.SelectionStart.Date.ToString("yyyy-MM-dd") + "') ";

 //           SELECT * from Product_sales where
//(From_date BETWEEN '2013-01-03'AND '2013-01-09') OR 
//(To_date BETWEEN '2013-01-03' AND '2013-01-09') OR 
//(From_date <= '2013-01-03' AND To_date >= '2013-01-09')

            DataTable table = new DataTable();
            openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            closeConnection();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                string id = row["id_event"].ToString();
                string name = row["event_name"].ToString();

                grid.Rows.Add(id, name);
                eventGrid.DataSource = grid;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editEvent form = new editEvent(this);
            form.nameBox = nameLabel.Text;
            form.locateBox = locLabel.Text;
            form.passNoteBox = notesBox.Text;
            form.clientNameBox = clientLabel.Text;
            form.numBox = numLabel.Text;
            form.idValue = eventGrid.CurrentRow.Cells[0].Value.ToString();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addEvent form = new addEvent();
            form.ShowDialog();
        }
        public static string id;
        private void eventGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deetPanel.Visible = true;

            selectedRow = e.RowIndex;
            DataGridViewRow row = eventGrid.Rows[selectedRow];

            string selectQuery = "select * from event where id_event = " + eventGrid.CurrentRow.Cells[0].Value.ToString();
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            id = eventGrid.CurrentRow.Cells[0].Value.ToString();
            // eventGrid.Rows[eventGrid.SelectedRows[0].Index].Cells[0].Value.ToString();
            while (reader.Read())
            {
                nameLabel.Text = reader["event_name"].ToString();
                dateLabel.Text = reader["start_date"].ToString() + " - " + reader["end_date"].ToString();
                timeLabel.Text = reader["start_time"].ToString() + " - " + reader["end_time"].ToString();
                locLabel.Text = reader["event_location"].ToString();
                notesBox.Text = reader["event_notes"].ToString();
                clientLabel.Text = reader["client_name"].ToString();
                numLabel.Text = reader["client_contact"].ToString();
                if (reader["prices"].ToString() != "")
                {
                    totalni.Text = reader["prices"].ToString();
                }
                else
                {
                    totalni.Text = "--";
                }
               
            }
            closeConnection();
        }

        private void eventSched_Load(object sender, EventArgs e)
        {
            grid.Columns.Add("Id", typeof(string));
            grid.Columns.Add("Event Name", typeof(string));

            eventGrid.DataSource = grid;
            eventGrid.Columns["Id"].Visible = false;
            eventGrid.Columns["Event Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void viewEquip_Click(object sender, EventArgs e)
        {
            addViewEquip form = new addViewEquip(this);
            form.eventName = nameLabel.Text;
            form.idValue = eventGrid.CurrentRow.Cells[0].Value.ToString();
            form.ShowDialog();
        }

        private void viewStaff_Click(object sender, EventArgs e)
        {
            addViewStaff form = new addViewStaff(this);
            form.eventName = nameLabel.Text;
            form.idValue = eventGrid.CurrentRow.Cells[0].Value.ToString();
            form.ShowDialog();
        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void cancellationButt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm cancellation of event?", "Cancel Event", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string cancelQuery = "UPDATE event SET status = 'Cancelled' WHERE id_event = " + eventGrid.CurrentRow.Cells[0].Value.ToString();
                openConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cancelQuery, con);
                closeConnection();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void viewPay_Click(object sender, EventArgs e)
        {
            payDeets form = new payDeets(this);
            form.nameBox = nameLabel.Text;
            form.idValue = eventGrid.CurrentRow.Cells[0].Value.ToString();
            form.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public static string test;
        public void setCount(string query)
        {

            openConnection();
            adapter = new MySqlCommand(query, con);
            MySqlDataReader myreader = adapter.ExecuteReader();
            if (myreader.Read())
            {

                test = myreader.GetValue(0).ToString();

            }
            myreader.Close();
            closeConnection();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            setCount("Select COUNT(itemcontent.id) as test from itemcontent where itemcontent.eventID =" + eventGrid.CurrentRow.Cells[0].Value.ToString());
            if (test == "0")
            {
                string insertQuery1 = "UPDATE itemcontent SET eventID='0' where  eventID=" + eventGrid.CurrentRow.Cells[0].Value.ToString();
                 string insertQuery = "UPDATE event SET isArchived=1  WHERE id_event =" + eventGrid.CurrentRow.Cells[0].Value.ToString();

                 executeMyQuery(insertQuery1);
                 executeMyQuery(insertQuery);
                MessageBox.Show("Marked as done ");
            }
            else
            {
                MessageBox.Show("Can't mark it as done, there are still "+test+" unreturned items.");
            }




          
     
        }

        private void eventGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    //MessageBox.Show("Item added Successfully");

                }

                else
                {
                   // MessageBox.Show("Not Executed");
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

        private void button3_Click(object sender, EventArgs e)
        {
            var a = new Form1();
            a.ShowDialog();
        }
    }
}
