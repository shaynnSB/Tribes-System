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
    public partial class salaryUI : UserControl
    {

        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");

        DataTable grid = new DataTable();
        string selectedEmp = "";
        string vio_amount = "";
        string bonus_amount;
        string salary_amount;
        string computed_amount;

        public salaryUI()
        {
            InitializeComponent();

            resetTable();
        }

        string sMonth = DateTime.Now.ToString("MM");
        string sYear = DateTime.Now.ToString("yyyy");

        private void assignMonth()
        {
            if (sMonth == "01")
            {
                monthBox.Text = "January";
                fullMonthBox.Text = "January";
            } else if (sMonth == "02")
            {
                monthBox.Text = "February";
                fullMonthBox.Text = "February";
            }
            else if (sMonth == "03")
            {
                monthBox.Text = "March";
                fullMonthBox.Text = "March";
            }
            else if (sMonth == "04")
            {
                monthBox.Text = "April";
                fullMonthBox.Text = "April";
            }
            else if (sMonth == "05")
            {
                monthBox.Text = "May";
                fullMonthBox.Text = "May";
            }
            else if (sMonth == "06")
            {
                monthBox.Text = "June";
                fullMonthBox.Text = "June";
            }
            else if (sMonth == "07")
            {
                monthBox.Text = "July";
                fullMonthBox.Text = "July";
            }
            else if (sMonth == "08")
            {
                monthBox.Text = "August";
                fullMonthBox.Text = "August";
            }
            else if (sMonth == "09")
            {
                monthBox.Text = "September";
                fullMonthBox.Text = "September";
            }
            else if (sMonth == "10")
            {
                monthBox.Text = "October";
                fullMonthBox.Text = "October";
            }
            else if (sMonth == "11")
            {
                monthBox.Text = "November";
                fullMonthBox.Text = "November";
            }
            else if (sMonth == "12")
            {
                monthBox.Text = "December";
                fullMonthBox.Text = "December";
            }
        }

        /*private void loadMonth()
        {
            string sMonth = DateTime.Now.ToString("MM");
            string query = "select * from event where substring(start_date, 6, 2) = " + monthBox.Text;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            openConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //vio_amount = reader["SUM(violation_amount)"].ToString();
                if (reader["SUM(violation_amount)"] != DBNull.Value)
                {
                    vio_amount = reader["SUM(violation_amount)"].ToString();
                }
                else
                {
                    vio_amount = "0";
                }
            }
            closeConnection();
        }*/

        private void resetTable(string query = "select * from employee")
        {

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            EmpGrid.Columns.Clear();
            EmpGrid.DataSource = table;
            EmpGrid.Columns[0].Visible = false;
            EmpGrid.Columns[1].Visible = false;
            EmpGrid.Columns[2].Visible = false;
            EmpGrid.Columns[3].Visible = false;
            EmpGrid.Columns[4].HeaderCell.Value = "Status";
            EmpGrid.Columns[5].Visible = false;
            EmpGrid.Columns[6].Visible = false;
            EmpGrid.Columns[7].Visible = false;
            EmpGrid.Columns[8].Visible = false;
            EmpGrid.Columns[11].Visible = false;
            EmpGrid.Columns[9].DisplayIndex = 0;
            EmpGrid.Columns[10].DisplayIndex = 1;
            EmpGrid.Columns[9].HeaderCell.Value = "First Name";
            EmpGrid.Columns[10].HeaderCell.Value = "Last Name";
            EmpGrid.Columns[9].Width = 200;
            EmpGrid.Columns[10].Width = 200;
            EmpGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            EmpGrid.RowHeadersVisible = false;

            this.selectedEmp = "";
            NameLab.Text = "--";
            StatusLab.Text = "--";

            deetPanel.Visible = false;
        }

        private void salaryTable()
        {
            string query = "select event_name, salary from staff_lineup, event where staff_id = " + selectedEmp + " AND id_event = no_event"; 
            DataTable table = new DataTable(); 
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            earnedGrid.Columns.Clear();
            earnedGrid.DataSource = table;
            
            earnedGrid.Columns[0].HeaderCell.Value = "Event Name";
            earnedGrid.Columns[1].HeaderCell.Value = "Salary";
            earnedGrid.Columns[0].Width = 200;
            
            earnedGrid.RowHeadersVisible = false;

            earnedGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void salaryFullTable()
        {
            string query = "select event_name from staff_lineup, event where staff_id = " + selectedEmp + " AND id_event = no_event";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            fullGrid.Columns.Clear();
            fullGrid.DataSource = table;

            fullGrid.Columns[0].HeaderCell.Value = "Event Name";
            fullGrid.RowHeadersVisible = false;

            fullGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void payrollUI_Load(object sender, EventArgs e)
        {
            addYear();
            assignMonth();
            yearBox.Text = sYear;
            fullYearBox.Text = sYear;
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
        
        private void allButt_Click(object sender, EventArgs e)
        {
            resetTable();
            statusBox.Text = "";
        }

        private void EmpGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EmpGrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString() == "On-Call")
            {
                fullPanel.Visible = false;
                deetPanel.Visible = true;

                this.selectedEmp = EmpGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                NameLab.Text = EmpGrid.Rows[e.RowIndex].Cells[9].FormattedValue.ToString() + " " + EmpGrid.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
                StatusLab.Text = EmpGrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                salaryTable();
                violations();
                bonus();
                compute();
            } else if (EmpGrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString() == "Full-Time")
            {
                deetPanel.Visible = false; 
                fullPanel.Visible = true;

                this.selectedEmp = EmpGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                fullEmpLabel.Text = EmpGrid.Rows[e.RowIndex].Cells[9].FormattedValue.ToString() + " " + EmpGrid.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
                fullStatLabel.Text = EmpGrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                salaryFullTable();
                violationsFull();
                bonusFull();
                computeFull();
            }            
        }

        private void statusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (statusBox.SelectedItem.ToString())
            {
                case "Full-Time":
                    resetTable("select * from employee where emp_status = 'Full-Time'");
                    break;
                case "On-Call":
                    resetTable("select * from employee where emp_status = 'On-Call'");
                    break;
                case "Inactive":
                    resetTable("select * from employee where emp_status = 'Inactive'");
                    break;
                default:
                    resetTable();
                    break;
            }
        }

        private void violations()
        {
            string query = "select SUM(violation_amount) from violations where id_emp = " + selectedEmp;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            openConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //vio_amount = reader["SUM(violation_amount)"].ToString();
                if (reader["SUM(violation_amount)"] != DBNull.Value)
                {
                    vio_amount = reader["SUM(violation_amount)"].ToString();
                }
                else
                {
                    vio_amount = "0";
                }
            }
            closeConnection();

            vioLabel.Text = vio_amount;
        }

        private void violationsFull()
        {
            string query = "select SUM(violation_amount) from violations where id_emp = " + selectedEmp;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            openConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //vio_amount = reader["SUM(violation_amount)"].ToString();
                if (reader["SUM(violation_amount)"] != DBNull.Value)
                {
                    vio_amount = reader["SUM(violation_amount)"].ToString();
                }
                else
                {
                    vio_amount = "0";
                }
            }
            closeConnection();

            fullVioLabel.Text = vio_amount;
        }

        private void bonus()
        {
            string query = "select SUM(bonus_amount) from bonus where id_emp = " + selectedEmp;
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

            bonusLabel.Text = bonus_amount;
        }

        private void bonusFull()
        {
            string query = "select SUM(bonus_amount) from bonus where id_emp = " + selectedEmp;
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

            fullBoLabel.Text = bonus_amount;
        }

        private void salary()
        {
            string query = "select SUM(salary) from staff_lineup where staff_id = " + selectedEmp;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            openConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader["SUM(salary)"] != DBNull.Value)
                {
                    salary_amount = reader["SUM(salary)"].ToString();
                }
                else
                {
                    salary_amount = "0";
                }
                
            }

            closeConnection();
        }

        private void compute()
        {
            salary();

            double vio = Convert.ToDouble(vio_amount);
            double bon = Convert.ToDouble(bonus_amount);
            double sal = Convert.ToDouble(salary_amount);

            double total = (bon + sal) - vio;

            computed_amount = Convert.ToString(total) + ".00";
            
            totalLabel.Text = computed_amount;
        }

        private void computeFull()
        {
            salary();

            double vio = Convert.ToDouble(vio_amount);
            double bon = Convert.ToDouble(bonus_amount);
            double sal = Convert.ToDouble(salary_amount);

            double total = (bon + sal) - vio;

            computed_amount = Convert.ToString(total) + ".00";

            fullTotLabel.Text = computed_amount;
        }

        private void vioButt_Click(object sender, EventArgs e)
        {
            violations form = new violations(this);
            form.idValue = selectedEmp;
            form.nameBox = NameLab.Text;
            form.ShowDialog();

            deetPanel.Visible = false;
        }

        private void bonusButt_Click(object sender, EventArgs e)
        {
            bonus form = new bonus(this);
            form.idValue = selectedEmp;
            form.nameBox = NameLab.Text;
            form.ShowDialog();

            deetPanel.Visible = false;
        }

        private void addYear()
        {
            for (int i = 0; i < 80; i++)
            {
                int num = 2018 + i;
                yearBox.Items.Add(num);
                fullYearBox.Items.Add(num);
            }
        }

        private void monthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectedEmp != "")
            {
                salaryTable();
            }
            else
            {

            }           
        }

        private void yearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedEmp != "")
            {
                salaryTable();
            }
            else
            {

            }
        }

        private void fullVio_Click(object sender, EventArgs e)
        {
            violations form = new violations(this);
            form.idValue = selectedEmp;
            form.nameBox = fullEmpLabel.Text;
            form.ShowDialog();

            fullPanel.Visible = false;
        }

        private void fullBonus_Click(object sender, EventArgs e)
        {
            bonus form = new bonus(this);
            form.idValue = selectedEmp;
            form.nameBox = fullEmpLabel.Text;
            form.ShowDialog();

            fullPanel.Visible = false;
        }
    }
}
