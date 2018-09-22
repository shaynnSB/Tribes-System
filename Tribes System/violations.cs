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
    public partial class violations : Form
    {
        salaryUI form = new salaryUI();
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

        public violations(salaryUI form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void violations_Load(object sender, EventArgs e)
        {
            DisplayData();
            total();
        }

        public string nameBox
        {
            get { return NameLab.Text; }
            set { NameLab.Text = value; }
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

        private void ClearData()
        {
            amBox.Text = "";
            dateBox.Text = "";
            descBox.Text = "";
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            if (amBox.Text != "" && dateBox.MaskCompleted && descBox.Text != "")
            {
                checking();

                if(checkneg > 0)
                {
                    string insertQuery = "INSERT INTO violations(id_emp, violation_amount, date, reason) VALUES (" + idPassed + ", "
                    + amBox.Text + ", '" + dateBox.Text + "', '" + descBox.Text + "')";

                    executeMyQuery(insertQuery);
                    MessageBox.Show("Added Successfully");

                    DisplayData();
                    total();
                    ClearData();

                }else if (checkneg < 0)
                {
                    MessageBox.Show("ERROR: Violations are greater than the employee's salary!");
                }
            }
            else
            {
                MessageBox.Show("Please Provide Required Details!");
            }
        }

        string salary_amount;

        private void salary()
        {
            string query = "select SUM(salary) from staff_lineup where staff_id = " + idPassed;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            openConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                salary_amount = reader["SUM(salary)"].ToString();
            }

            closeConnection();
        }

        string bonus_amount;

        private void bonus()
        {
            string query = "select SUM(bonus_amount) from bonus where id_emp = " + idPassed;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            openConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //bonus_amount = reader["SUM(bonus_amount)"].ToString();
                if (reader["SUM(bonus_amount)"] != DBNull.Value)
                {
                    bonus_amount = reader["SUM(bonus_amount)"].ToString();
                }
                else
                {
                    bonus_amount = "0";
                }
            }
            closeConnection();
        }

        private void DisplayData()
        {
            string query = "select * from violations where id_emp = " + idPassed;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            violationsGrid.Columns.Clear();
            violationsGrid.DataSource = table;
            violationsGrid.Columns[0].Visible = false;
            violationsGrid.Columns[1].Visible = false;
            violationsGrid.Columns[2].HeaderCell.Value = "Date";
            violationsGrid.Columns[3].HeaderCell.Value = "Amount";
            violationsGrid.Columns[4].HeaderCell.Value = "Description";

            violationsGrid.RowHeadersVisible = false;

            violationsGrid.Columns[2].Width = 100;
            violationsGrid.Columns[3].Width = 100;
            violationsGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void total()
        {
            string query = "select SUM(violation_amount) from violations where id_emp = " + idPassed;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            openConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                totLabel.Text = reader["SUM(violation_amount)"].ToString();
            }

            closeConnection();
        }

        double checkneg;

        private void checking()
        {
            total();
            bonus();
            salary();

            double vio = Convert.ToDouble(totLabel.Text);
            double vio2 = Convert.ToDouble(amBox.Text);
            double bon = Convert.ToDouble(bonus_amount);
            double sal = Convert.ToDouble(salary_amount);

            checkneg = (bon + sal) - (vio + vio2);
        }

        private void editButt_Click(object sender, EventArgs e)
        {
            if (amBox.Text != "" && dateBox.MaskCompleted && descBox.Text != "")
            {
                string editQuery = "UPDATE violations SET violation_amount = " + amBox.Text + ", date = '" + dateBox.Text + "', reason = '"
                    + descBox.Text + "' WHERE id_emp = " + idPassed + " AND id = " + id_amount;

                executeMyQuery(editQuery);
                MessageBox.Show("Edited Successfully");

                DisplayData();
                total();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update!");
            }
        }

        private void violationsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            amBox.Text = violationsGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateBox.Text = violationsGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            descBox.Text = violationsGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            id_amount = violationsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void remButt_Click(object sender, EventArgs e)
        {
            if (amBox.Text != "" && dateBox.MaskCompleted && descBox.Text != "")
            {
                string editQuery = "DELETE FROM violations WHERE id_emp = " + idPassed + " AND id = " + id_amount;

                executeMyQuery(editQuery);
                MessageBox.Show("Removed Successfully");

                DisplayData();
                total();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete!");
            }
        }

        private void amBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void closeButt_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void minButt_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}