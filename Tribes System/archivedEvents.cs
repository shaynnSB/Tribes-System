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
    public partial class archivedEvents : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root; Convert Zero Datetime = True;");
        MySqlCommand cmd;

        string currentDate = DateTime.Today.ToString("yyyy-MM-dd");

        DataTable grid = new DataTable();
        int selectedRow;

        private bool drag = false;
        private Point startPoint = new Point(0, 0);

        public archivedEvents()
        {
            InitializeComponent();
        }

        private void minButt_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void title_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X,
                                     p2.Y - this.startPoint.Y);
                this.Location = p3;
            }
        }

        private void title_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
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

        private void date()
        {
            string selectQuery = "select substring(start_date, 1, 10), substring(end_date, 1, 10) from event where id_event = " + id_select;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dateLabel.Text = reader["substring(start_date, 1, 10)"].ToString() + " to " + reader["substring(end_date, 1, 10)"].ToString();
            }
            closeConnection();
        }

        string id_select;
        string event_name;
        public static string id;

        private void show_deets()
        {
            string selectQuery = "select * from event where id_event = " + eventGrid.CurrentRow.Cells[0].Value.ToString();
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                event_name = reader["event_name"].ToString();
                nameLabel.Text = event_name + " - " + reader["event_status"].ToString();
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
            }
            closeConnection();
        }

        private void start()
        {
            string query = "SELECT * FROM event WHERE start_date < '" + currentDate + "'";

            eventTable(query);
        }

        private void archivedEvents_Load(object sender, EventArgs e)
        {
            start();
        }

        private void eventGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow != -1)
            {
                deetPanel.Visible = true;
                DataGridViewRow row = eventGrid.Rows[selectedRow];
                id = eventGrid.CurrentRow.Cells[0].Value.ToString();
                id_select = eventGrid.CurrentRow.Cells[0].Value.ToString();

                show_deets();
                date();
            }
        }
    }
}
