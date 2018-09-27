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
    public partial class bonus : Form
    {

        salaryUI form = new salaryUI();
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");
        MySqlCommand cmd;
        string id_amount;

        private bool drag = false;
        private Point startPoint = new Point(0, 0);

        public bonus(salaryUI form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
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

        private void ClearData()
        {
            amBox.Text = "";
            dateBox.Text = "";
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

        private void addButt_Click(object sender, EventArgs e)
        {
            if (amBox.Text != "" && dateBox.MaskCompleted)
            {
                string insertQuery = "INSERT INTO bonus(id_emp, bonus_amount, date) VALUES (" + idPassed + ", "
                    + amBox.Text + ", '" + dateBox.Text + "')";

                executeMyQuery(insertQuery);
                MessageBox.Show("Added Successfully");

                DisplayData();
                total();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Required Details!");
            }
        }

        private void editButt_Click(object sender, EventArgs e)
        {
            if (amBox.Text != "" && dateBox.MaskCompleted)
            {
                string editQuery = "UPDATE bonus SET bonus_amount = " + amBox.Text + ", date = '" + dateBox.Text + "' WHERE id_emp = " + idPassed 
                    + " AND id = " + id_amount;

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

        private void remButt_Click(object sender, EventArgs e)
        {
            if (amBox.Text != "" && dateBox.MaskCompleted)
            {
                string editQuery = "DELETE FROM bonus WHERE id_emp = " + idPassed + " AND id = " + id_amount;

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

        private void DisplayData()
        {
            string query = "select * from bonus where id_emp = " + idPassed;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            bonusGrid.Columns.Clear();
            bonusGrid.DataSource = table;
            bonusGrid.Columns[0].Visible = false;
            bonusGrid.Columns[1].Visible = false;
            bonusGrid.Columns[2].HeaderCell.Value = "Date";
            bonusGrid.Columns[3].HeaderCell.Value = "Amount";

            bonusGrid.RowHeadersVisible = false;

            bonusGrid.Columns[2].Width = 150;
            bonusGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void total()
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
                totLabel.Text = reader["SUM(bonus_amount)"].ToString();
            }

            closeConnection();
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

        private void minButt_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bonusGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                amBox.Text = bonusGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateBox.Text = bonusGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                id_amount = bonusGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void bonus_Load(object sender, EventArgs e)
        {
            DisplayData();
            total();
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
