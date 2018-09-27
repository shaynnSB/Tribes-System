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
    public partial class overtime : Form
    {
        salaryUI form = new salaryUI();
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");
        MySqlCommand cmd;
        string id_amount;

        private bool drag = false;
        private Point startPoint = new Point(0, 0);

        public overtime(salaryUI form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minButt_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void dateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
                string insertQuery = "INSERT INTO overtime(id_emp, over_amount, date) VALUES (" + idPassed + ", "
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
                string editQuery = "UPDATE overtime SET over_amount = " + amBox.Text + ", date = '" + dateBox.Text + "' WHERE id_emp = " + idPassed
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
                string editQuery = "DELETE FROM overtime WHERE id_emp = " + idPassed + " AND id = " + id_amount;

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
            string query = "select * from overtime where id_emp = " + idPassed;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            overGrid.Columns.Clear();
            overGrid.DataSource = table;
            overGrid.Columns[0].Visible = false;
            overGrid.Columns[1].Visible = false;
            overGrid.Columns[2].HeaderCell.Value = "Date";
            overGrid.Columns[3].HeaderCell.Value = "Amount";

            overGrid.RowHeadersVisible = false;

            overGrid.Columns[2].Width = 150;
            overGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void total()
        {
            string query = "select SUM(over_amount) from overtime where id_emp = " + idPassed;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            openConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                totLabel.Text = reader["SUM(over_amount)"].ToString();
            }

            closeConnection();
        }

        private void overGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                amBox.Text = overGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateBox.Text = overGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                id_amount = overGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void overtime_Load(object sender, EventArgs e)
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
