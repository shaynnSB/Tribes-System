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
    public partial class addEvent : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");
        MySqlCommand cmd;

        private bool drag = false;
        private Point startPoint = new Point(0, 0);

        public addEvent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addEvent_Load(object sender, EventArgs e)
        {
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.CustomFormat = "yyyy-MM-dd";
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.CustomFormat = "yyyy-MM-dd";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void startTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //nameBox.Clear();
        }

        private void locBox_Click(object sender, EventArgs e)
        {
            //locBox.Clear();
        }

        private void notesBox_Click(object sender, EventArgs e)
        {
            //notesBox.Clear();
        }

        private void nameClientBox_Click(object sender, EventArgs e)
        {
            //nameClientBox.Clear();
        }

        private void conClientBox_Click(object sender, EventArgs e)
        {
            //conClientBox.Clear();
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO event(event_name, event_location, event_notes, start_date, end_date, start_time, end_time, " +
                "client_name, client_contact, event_status) VALUES ('" + nameBox.Text + "','" + locBox.Text + "','" + notesBox.Text + "','" 
                + startDate.Text + "','" + endDate.Text + "','" + startHr.Text + ":" + startMin.Text + " " + startMeri.Text + "','" +
                endHr.Text + ":" + endMin.Text + " " + endMeri.Text + "','" + nameClientBox.Text + "', '+(63) " + conClientBox.Text + "', 'Unpaid')";

            executeMyQuery(insertQuery);
            MessageBox.Show("Added Successfully");
            this.Close();
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
    }
}
