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
        string id_exp;
        string id_Passed;
        string statusEvent;


        private bool drag = false;
        private Point startPoint = new Point(0, 0);

        public payDeets(eventSched form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void payDeets_Load(object sender, EventArgs e)
        {
            DisplayData();
            getPastFee();
            getPastDisc();
            getEventPrice();
            computeGross();
            computeAccRec();
            DisplayExpData();

            statusLabel.Text = "- " + statusEvent;
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public string idValue
        {
            get { return this.id_Passed; }
            set { this.id_Passed = value; }
        }

        public string statusOfEvent
        {
            get { return this.statusEvent; }
            set { this.statusEvent = value; }
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

        private void addAmButt_Click(object sender, EventArgs e)
        {
            if (recievedBox.Text != "" && dateBox.Text != "")
            {
                string insertQuery = "INSERT INTO amount_paid(event_id, amount, date_paid) VALUES (" + id_Passed + ", " 
                    + recievedBox.Text + ", '" + dateBox.Text + "')";

                string editQuery = "UPDATE event SET event_status = 'Partially Paid' WHERE id_event = " + id_Passed;

                executeMyQuery(insertQuery);
                MessageBox.Show("Added Successfully");

                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Required Details!");
            }

            computeGross();
            computeAccRec();
        }

        private void DisplayData()
        {
            string query = "select id, amount, date_paid from amount_paid where event_id = " + id_Passed;
            DataTable table = new DataTable();
            openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            closeConnection();
            adapter.Fill(table);
            
            paymentGrid.Columns.Clear();
            paymentGrid.DataSource = table;
            paymentGrid.Columns[0].Visible = false;
            paymentGrid.Columns[1].HeaderCell.Value = "Amount";
            paymentGrid.Columns[2].HeaderCell.Value = "Date Paid";
            paymentGrid.Columns[1].Width = 200;
            paymentGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            paymentGrid.RowHeadersVisible = false;

            string selectQuery = "select SUM(amount) from amount_paid where event_id = " + id_Passed;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                amRevLabel.Text = reader["SUM(amount)"].ToString();

            }
            closeConnection();

        }

        private void ClearData()
        {
            recievedBox.Text = "";
            dateBox.Text = "";
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
                    + id_Passed + " AND id = " + id_amount;

                executeMyQuery(editQuery);
                MessageBox.Show("Edited Successfully");

                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update!");
            }

            computeGross();
            computeAccRec();
        }

        private void remAmButt_Click(object sender, EventArgs e)
        {
            if (recievedBox.Text != "" && dateBox.Text != "")
            {
                string editQuery = "DELETE FROM amount_paid WHERE event_id = " + id_Passed + " AND id = " + id_amount;

                executeMyQuery(editQuery);
                MessageBox.Show("Removed Successfully");

                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete!");
            }

            computeGross();
            computeAccRec();
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

        //----------------EXPENSES-------------------

        private void addExpButt_Click(object sender, EventArgs e)
        {
                if (amExpBox.Text != "" && expBox.Text != "")
                {
                    string query = "select count(*) from expenses where exp_name = '" + expBox.Text + "' AND event_id = " + id_Passed;

                    using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, con))
                    {

                        DataTable dt = new DataTable();

                        adpt.Fill(dt);

                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            getPastExp();

                            double sum = Convert.ToDouble(past_exp) + Convert.ToDouble(amExpBox.Text);

                            string updateQuery = "UPDATE expenses SET exp_price = " + sum + " WHERE exp_name = '" + expBox.Text + "' AND event_id = "
                                + id_Passed;

                            executeMyQuery(updateQuery);
                            MessageBox.Show("Added Successfully");

                            DisplayExpData();
                            ClearExpData();
                        }
                        else
                        {
                            string addQuery = "INSERT INTO expenses(event_id, exp_name, exp_price) VALUES(" + id_Passed + ",'" + expBox.Text + "',"
                                + amExpBox.Text + ")";

                            executeMyQuery(addQuery);
                            MessageBox.Show("Added Successfully");

                            DisplayExpData();
                            ClearExpData();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please Provide Required Details!");
                }
            
        }

        private void editExpButt_Click(object sender, EventArgs e)
        {
            if (amExpBox.Text != "" && expBox.Text != "")
            {
                string query = "select count(*) from expenses where exp_name = '" + expBox.Text + "' AND event_id = " + id_Passed;

                using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, con))
                {

                    DataTable dt = new DataTable();

                    adpt.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        getPastExp();

                        double sum = Convert.ToDouble(past_exp) + Convert.ToDouble(amExpBox.Text);

                        string updateQuery = "UPDATE expenses SET exp_price = " + sum + " WHERE exp_name = '" + expBox.Text + "' AND event_id = "
                            + id_Passed;

                        executeMyQuery(updateQuery);

                        string remQuery = "DELETE FROM expenses WHERE event_id = " + id_Passed + " AND no_exp = " + id_exp;

                        executeMyQuery(remQuery);

                        MessageBox.Show("Edited Successfully");

                        DisplayExpData();
                        ClearExpData();
                    }
                    else
                    {
                        string editQuery = "UPDATE expenses SET exp_name = '" + expBox.Text + "', exp_price = " + amExpBox.Text + " WHERE no_exp = " + id_exp
                    + " AND event_id = " + id_Passed;

                        executeMyQuery(editQuery);
                        MessageBox.Show("Edited Successfully");

                        DisplayExpData();
                        ClearExpData();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please Select Record to Update!");
            }
        }

        private void remExpButt_Click(object sender, EventArgs e)
        {
            if (amExpBox.Text != "" && expBox.Text != "")
            {
                string remQuery = "DELETE FROM expenses WHERE event_id = " + id_Passed + " AND no_exp = " + id_exp;

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
            string query = "select no_exp, exp_name, exp_price from expenses where event_id = " + id_Passed;
            DataTable table = new DataTable();
            openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            closeConnection();
            adapter.Fill(table);

            expensesGrid.Columns.Clear();
            expensesGrid.DataSource = table;
            expensesGrid.Columns[0].Visible = false;
            expensesGrid.Columns[1].HeaderCell.Value = "Expense";
            expensesGrid.Columns[2].HeaderCell.Value = "Amount";
            expensesGrid.Columns[1].Width = 200;
            expensesGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            expensesGrid.RowHeadersVisible = false;

            string selectQuery = "select SUM(exp_price) from expenses where event_id = " + id_Passed;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                totExpLabel.Text = "PHP " + reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        private void ClearExpData()
        {
            amExpBox.Text = "";
            expBox.Text = "";
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

        private void expensesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            expBox.Text = expensesGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            amExpBox.Text = expensesGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            id_exp = expensesGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        string past_exp;

        private void getPastExp()
        {
            string selectQuery = "select * from expenses where event_id = " + id_Passed + " AND exp_name = '" + expBox.Text + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                past_exp = reader["exp_price"].ToString();
            }
            closeConnection();
        }

        //------------------------extra---------------------

        private void addFee_Click(object sender, EventArgs e)
        {
            addFee form = new addFee();
            form.idValue = id;
            form.ShowDialog();

            getPastFee();
            getPastDisc();
            getEventPrice();
            computeGross();
            computeAccRec();

        }

        public string id
        {
            get { return id_Passed; }
        }

        public string fee_Amount
        {
            get { return addLabel.Text; }
        }

        public string disc_Amount
        {
            get { return discLabel.Text; }
        }

        private void editFee_Click(object sender, EventArgs e)
        {
            editFee form = new editFee();
            form.idValue = id;
            form.amountValue = fee_Amount;
            form.ShowDialog();

            getPastFee();
            getPastDisc();
            getEventPrice();
            computeGross();
            computeAccRec();
        }

        private void addDiscount_Click(object sender, EventArgs e)
        {
            addDiscount form = new addDiscount();
            form.idValue = id;
            form.ShowDialog();

            getPastFee();
            getPastDisc();
            getEventPrice();
            computeGross();
            computeAccRec();
        }

        private void editDiscount_Click(object sender, EventArgs e)
        {
            editDiscount form = new editDiscount();
            form.idValue = id;
            form.amountValue = disc_Amount;
            form.ShowDialog();

            getPastFee();
            getPastDisc();
            getEventPrice();
            computeGross();
            computeAccRec();
        }

        private void remFee_Click(object sender, EventArgs e)
        {
            string remQuery = "DELETE FROM additional_fees WHERE event_id = " + id_Passed;

            DialogResult dialog = MessageBox.Show("Remove Additional Fee?", " ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                executeMyQuery(remQuery);
                MessageBox.Show("Removed Successfully");
            }
            else if (dialog == DialogResult.No)
            {

            }

            addLabel.Text = "";
            
            computeGross();
            computeAccRec();
        }

        private void remDiscount_Click(object sender, EventArgs e)
        {
            string remQuery = "DELETE FROM discount WHERE event_id = " + id_Passed;

            DialogResult dialog = MessageBox.Show("Remove Discount?", " ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                executeMyQuery(remQuery);
                MessageBox.Show("Removed Successfully");
            }
            else if (dialog == DialogResult.No)
            {

            }

            discLabel.Text = "";
            
            computeGross();
            computeAccRec();
        }

        private void updateFee()
        {
            string selectQuery = "select SUM(amount) from amount_paid where event_id = " + id_Passed;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                amRevLabel.Text = reader["SUM(amount)"].ToString();

            }
            closeConnection();
        }

        string past_fee;

        private void getPastFee()
        {
            string selectQuery = "select * from additional_fees where event_id = " + id_Passed;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                past_fee = reader["fee_amount"].ToString();
            }
            closeConnection();

            addLabel.Text = past_fee;
        }

        string past_disc;

        private void getPastDisc()
        {
            string selectQuery = "select * from discount where event_id = " + id_Passed;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                past_disc = reader["disc_amount"].ToString();
            }
            closeConnection();

            discLabel.Text = past_disc;
        }

        string eventPrice;

        private void getEventPrice()
        {
            string selectQuery = "select event_price from event where id_event = " + id_Passed;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                eventPrice = reader["event_price"].ToString();
            }
            closeConnection();

            if(eventPrice == "")
            {
                eventPrice = "0";
            }

            priceLabel.Text = eventPrice;
        }

        string gross;

        private void computeGross()
        {
            double fee;
            double disc; 

            double price = Convert.ToDouble(eventPrice);

            if (addLabel.Text == "" || discLabel.Text == "--")
            {
                fee = 0;
            }
            else
            {
                fee = Convert.ToDouble(addLabel.Text);
            }
            
            if (discLabel.Text == "" || discLabel.Text == "--")
            {
                disc = 0;
            }
            else
            {
                disc = Convert.ToDouble(discLabel.Text);
            }

            double total = (price + fee) - disc;

            gross = Convert.ToString(total) + ".00";

            totalLabel.Text = gross;
        }

        string accRec;

        private void computeAccRec()
        {
            double amRev;
            double price = Convert.ToDouble(gross);

            if (amRevLabel.Text == "" || amRevLabel.Text == "--")
            {
                amRev = 0;
            }
            else
            {
               amRev = Convert.ToDouble(amRevLabel.Text);
            }

            double total = price - amRev;

            accRec = Convert.ToString(total) + ".00";

            if (accRec == "0.00")
            {
                changeStat();
            } else
            {
                changeStat2();
            }

            accRecLabel.Text = accRec;
        }

        private void changeStat()
        {
            string addQuery = "UPDATE event SET event_status = 'Fully Paid' WHERE id_event = " + id_Passed;

            executeMyQuery(addQuery);
            
            statusLabel.Text = "- Fully Paid";
        }

        private void changeStat2()
        {
            string addQuery = "UPDATE event SET event_status = 'Partially Paid' WHERE id_event = " + id_Passed;

            executeMyQuery(addQuery);

            statusLabel.Text = "- Partially Paid";
        }

        private void dateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
