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
    public partial class editEvent : Form
    {
        eventSched form = new eventSched();
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");
        MySqlCommand cmd;

        private bool drag = false;
        private Point startPoint = new Point(0, 0);

        public editEvent(eventSched form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editEvent_MouseMove(object sender, MouseEventArgs e)
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

        private void editEvent_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void editEvent_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
        }

        public string nameBox
        {
            get { return eventBox.Text; }
            set { eventBox.Text = value; }
        }

        public string locateBox
        {
            get { return locBox.Text; }
            set { locBox.Text = value; }
        }

        public string passNoteBox
        {
            get { return notesBox.Text; }
            set { notesBox.Text = value; }
        }

        public string clientNameBox
        {
            get { return nameClientBox.Text; }
            set { nameClientBox.Text = value; }
        }

        string idPassed;

        public string idValue
        {
            get { return this.idPassed; }
            set { this.idPassed = value; }
        }

        private void start_time()
        {
            string selectQuery = "select substring(start_time, 1,2), substring(start_time, 3,4), substring(start_time, 7) from event where id_event = " + idPassed;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string min = reader["substring(start_time, 3,4)"].ToString();
                min = min.Substring(1);
                startHour.Text = reader["substring(start_time, 1,2)"].ToString();
                startMeri.Text = reader["substring(start_time, 7)"].ToString();
                startMin.Text = min;
            }
            closeConnection();
        }

        private void end_time()
        {
            string selectQuery = "select substring(end_time, 1,2), substring(end_time, 3,4), substring(end_time, 7) from event where id_event = " + idPassed;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string min = reader["substring(end_time, 3,4)"].ToString();
                min = min.Substring(1);
                endHour.Text = reader["substring(end_time, 1,2)"].ToString();
                endMeri.Text = reader["substring(end_time, 7)"].ToString();
                endMin.Text = min;
            }
            closeConnection();
        }

        private void client_num()
        {
            string selectQuery = "select substring(client_contact, 7) from event where id_event = " + idPassed;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string num = reader["substring(client_contact, 7)"].ToString();
                numClientBox.Text = num;
            }
            closeConnection();
        }

        private void saveButt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm changes?", "Edit Event Details", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                /*string editQuery = "UPDATE event SET event_name = '" + eventBox.Text + "' ,event_location = '" + locBox.Text + "' , event_notes = '" + notesBox.Text +
                    "', start_time = '" + startHour.Text + ":" + startMin.Text + " " + startMeri.Text + "', end_time = '" + endHour.Text + ":" + endMin.Text + " " + endMeri.Text + 
                    "', start_date = , end_date = , client_name = '" + nameClientBox.Text + "', client_contact = '+(63) " + numClientBox.Text + "' WHERE id_event = " + idPassed;
                executeMyQuery(editQuery);*/
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
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

        private void numClientBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void editEvent_Load(object sender, EventArgs e)
        {
            client_num();
            start_time();
            end_time();
        }
    }
}
