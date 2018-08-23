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

        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");

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

            string query = "select * from event where start_date = '" + calendar.SelectionStart.Date.ToString("yyyy-MM-dd") + "'";
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
            editEvent form = new editEvent();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addEvent form = new addEvent();
            form.ShowDialog();
        }

        private void eventGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            deetPanel.Visible = true;

            selectedRow = e.RowIndex;
            DataGridViewRow row = eventGrid.Rows[selectedRow];

            string selectQuery = "select * from event where id_event = " + eventGrid.CurrentRow.Cells[0].Value.ToString();
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                nameLabel.Text = reader["event_name"].ToString();
                dateLabel.Text = reader["start_date"].ToString() + " - " + reader["end_date"].ToString();
                timeLabel.Text = reader["start_time"].ToString() + " - " + reader["end_time"].ToString();
                locLabel.Text = reader["event_location"].ToString();
                notesBox.Text = reader["event_notes"].ToString();
                clientLabel.Text = reader["client_name"].ToString();
                numLabel.Text = reader["client_contact"].ToString();
            }
            closeConnection();
        }

        private void eventSched_Load(object sender, EventArgs e)
        {
            grid.Columns.Add("Id", typeof(string));
            grid.Columns.Add("Event Name", typeof(string));

            eventGrid.DataSource = grid;
            eventGrid.Columns["Id"].Visible = false; 
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
