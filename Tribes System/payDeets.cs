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
    public partial class payDeets : Form
    {

        eventSched form = new eventSched();
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");
        MySqlCommand cmd;
        string id_amount;
        
        private bool drag = false;
        private Point startPoint = new Point(0, 0);

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

        public payDeets(eventSched form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addDiscount_Click(object sender, EventArgs e)
        {

        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void minButt_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        public string nameBox
        {
            get { return eventLabel.Text; }
            set { eventLabel.Text = value; }
        }

        string idPassed;

        public string idValue
        {
            get { return this.idPassed; }
            set { this.idPassed = value; }
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

        private void addAmButt_Click(object sender, EventArgs e)
        {
            if (recievedBox.Text != "" && dateBox.Text != "")
            {
                string insertQuery = "INSERT INTO amount_paid(event_id, amount, date_paid) VALUES (" + idPassed + ", " 
                    + recievedBox.Text + ", '" + dateBox.Text + "')";

                executeMyQuery(insertQuery);
                MessageBox.Show("Added Successfully");

                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Required Details!");
            }
        }

        private void DisplayData()
        {
            string query = "select id, amount, date_paid from amount_paid where event_id = " + idPassed;
            DataTable table = new DataTable();
            openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            closeConnection();
            adapter.Fill(table);
            paymentGrid.DataSource = table; 
        }

        private void ClearData()
        {
            recievedBox.Text = "";
            dateBox.Text = "";
        }

        private void dateBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void payDeets_Load(object sender, EventArgs e)
        {
            DisplayData();

            string selectQuery = "select SUM(amount) from amount_paid where event_id = " + idPassed;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                amRevLabel.Text = reader["SUM(amount)"].ToString();
            }
            closeConnection();
        }

        private void paymentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            recievedBox.Text = paymentGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateBox.Text = paymentGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            id_amount = paymentGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void editAmButt_Click(object sender, EventArgs e)
        {
           if (recievedBox.Text != "" && dateBox.Text != "")
            {
                string editQuery = "UPDATE amount_paid SET amount = " + recievedBox.Text + ", date_paid = '" + dateBox.Text + "' WHERE event_id = " 
                    + idPassed + " AND id = " + id_amount;

                executeMyQuery(editQuery);
                MessageBox.Show("Edited Successfully");

                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update!");
            }
        }

        private void remAmButt_Click(object sender, EventArgs e)
        {
            if (recievedBox.Text != "" && dateBox.Text != "")
            {
                string editQuery = "DELETE FROM amount_paid WHERE event_id = " + idPassed + " AND id = " + id_amount;

                executeMyQuery(editQuery);
                MessageBox.Show("Removed Successfully");

                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete!");
            }
        }

        private void amRevLabel_Click(object sender, EventArgs e)
        {

        }

        private void addExpButt_Click(object sender, EventArgs e)
        {
            if (amExpBox.Text != "" && (expBox.Text != "" || expBox.Text == "Category"))
            {
                string addQuery = "DELETE FROM amount_paid WHERE event_id = " + idPassed + " AND id = " + id_amount;

                executeMyQuery(addQuery);
                MessageBox.Show("Added Successfully");

                DisplayExpData();
                ClearExpData();
            }
            else
            {
                MessageBox.Show("Please Provide Required Details!");
            }
        }

        private void editExpButt_Click(object sender, EventArgs e)
        {
            if (amExpBox.Text != "" && (expBox.Text != "" || expBox.Text == "Category"))
            {
                string editQuery = "DELETE FROM amount_paid WHERE event_id = " + idPassed + " AND id = " + id_amount;

                executeMyQuery(editQuery);
                MessageBox.Show("Edited Successfully");

                DisplayExpData();
                ClearExpData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update!");
            }
        }

        private void remExpButt_Click(object sender, EventArgs e)
        {
            if (amExpBox.Text != "" && (expBox.Text != "" || expBox.Text == "Category"))
            {
                string remQuery = "DELETE FROM amount_paid WHERE event_id = " + idPassed + " AND id = " + id_amount;

                executeMyQuery(remQuery);
                MessageBox.Show("Removed Successfully");

                DisplayExpData();
                ClearExpData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete!");
            }
        }

        private void DisplayExpData()
        {
            string query = "select id, amount, date_paid from amount_paid where event_id = " + idPassed;
            DataTable table = new DataTable();
            openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            closeConnection();
            adapter.Fill(table);
            paymentGrid.DataSource = table;
        }

        private void ClearExpData()
        {
            amExpBox.Text = "";
            expBox.Text = "Category";
        }

        private void recievedBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void amExpBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
