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
        string over_amount;

        public salaryUI()
        {
            InitializeComponent();

            resetTable();
        }

        string sMonth = DateTime.Now.ToString("MM");
        string sYear = DateTime.Now.ToString("yyyy");

        string m = DateTime.Now.ToString("MM");
        string y = DateTime.Now.ToString("yyyy");

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

        private void addYear()
        {
            for (int i = 0; i < 80; i++)
            {
                int num = 2018 + i;
                yearBox.Items.Add(num);
                fullYearBox.Items.Add(num);
            }
        }

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
            string query = "select event_name, salary from staff_lineup, event where staff_id = " + selectedEmp + " AND id_event = no_event" +
                " AND substring(start_date, 6,2) = '" + sMonth + "' AND substring(start_date, 1,4) = '" + sYear + "'"; 
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
            if (e.RowIndex != -1)
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
                }
                else if (EmpGrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString() == "Full-Time")
                {
                    deetPanel.Visible = false;
                    fullPanel.Visible = true;

                    this.selectedEmp = EmpGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    fullEmpLabel.Text = EmpGrid.Rows[e.RowIndex].Cells[9].FormattedValue.ToString() + " " + EmpGrid.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
                    fullStatLabel.Text = EmpGrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    salaryFullTable();
                    violationsFull();
                    bonusFull();
                    overFull();
                    computeFull();
                }
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

        private void yearChange2()
        {
            sYear = yearBox.Text;
        }

        private void violations()
        {
            string query = "select SUM(violation_amount) from violations where id_emp = " + selectedEmp +
                " AND substring(date, 6,2) = '" + sMonth + "' AND substring(date, 1,4) = '" + sYear + "'";
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

            vioLabel.Text = "(" + vio_amount + ")";
        }       

        private void bonus()
        {
            string query = "select SUM(bonus_amount) from bonus where id_emp = " + selectedEmp +
                " AND substring(date, 6,2) = '" + sMonth + "' AND substring(date, 1,4) = '" + sYear + "'";
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

        private void salary()
        {
            string query = "select SUM(salary) from event, staff_lineup where no_event = id_event AND staff_id = " + selectedEmp +
                " AND substring(start_date, 6,2) = '" + sMonth + "' AND substring(start_date, 1,4) = '" + sYear + "'";
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

        private void vioButt_Click(object sender, EventArgs e)
        {
            violations form = new violations(this);
            form.idValue = selectedEmp;
            form.nameBox = NameLab.Text;
            form.statusVal = StatusLab.Text;
            form.ShowDialog();

            salaryTable();
            violations();
            bonus();
            compute();
        }

        private void bonusButt_Click(object sender, EventArgs e)
        {
            bonus form = new bonus(this);
            form.idValue = selectedEmp;
            form.nameBox = NameLab.Text;
            form.ShowDialog();

            salaryTable();
            violations();
            bonus();
            compute();
        }

        private void monthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthChange();
            int nextm = Convert.ToInt32(sMonth);
            int formerm = Convert.ToInt32(m);
            int nexty = Convert.ToInt32(sYear);
            int formery = Convert.ToInt32(y);

            if ((nextm > formerm) && (nexty == formery))
            {
                sMonth = m;
                assignMonth();
                MessageBox.Show("Details Are Not Yet Available!");
            }
            else
            {
                if (selectedEmp != "")
                {
                    salaryTable();
                    violations();
                    bonus();
                    compute();
                }
                else
                {

                }
            }          
        }

        private void yearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearChange2();
            int nexty = Convert.ToInt32(sYear);
            int formery = Convert.ToInt32(y);

            if (nexty > formery)
            {
                sYear = y;
                yearBox.Text = sYear;
                MessageBox.Show("Details Are Not Yet Available!");
            }
            else
            {
                if (selectedEmp != "")
                {
                    salaryTable();
                    violations();
                    bonus();
                    compute();
                }
            }
        }

        private void monthChange()
        {
            if (monthBox.Text == "January")
            {
                sMonth = "01";
            }
            else if (monthBox.Text == "February")
            {
                sMonth = "02";
            }
            else if (monthBox.Text == "March")
            {
                sMonth = "03";
            }
            else if (monthBox.Text == "April")
            {
                sMonth = "04";
            }
            else if (monthBox.Text == "May")
            {
                sMonth = "05";
            }
            else if (monthBox.Text == "June")
            {
                sMonth = "06";
            }
            else if (monthBox.Text == "July")
            {
                sMonth = "07";
            }
            else if (monthBox.Text == "August")
            {
                sMonth = "08";
            }
            else if (monthBox.Text == "September")
            {
                sMonth = "09";
            }
            else if (monthBox.Text == "October")
            {
                sMonth = "10";
            }
            else if (monthBox.Text == "November")
            {
                sMonth = "11";
            }
            else if (monthBox.Text == "December")
            {
                sMonth = "12";
            }
        }

        //--------------------Full Time-------------------

        private void violationsFull()
        {
            string query = "select SUM(violation_amount) from violations where id_emp = " + selectedEmp +
                " AND substring(date, 6,2) = '" + sMonth + "' AND substring(date, 1,4) = '" + sYear + "'";
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

            fullVioLabel.Text = "(" + vio_amount + ")";
        }

        private void bonusFull()
        {
            string query = "select SUM(bonus_amount) from bonus where id_emp = " + selectedEmp +
                " AND substring(date, 6,2) = '" + sMonth + "' AND substring(date, 1,4) = '" + sYear + "'";
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

        private void overFull()
        {
            string query = "select SUM(over_amount) from overtime where id_emp = " + selectedEmp +
                " AND substring(date, 6,2) = '" + sMonth + "' AND substring(date, 1,4) = '" + sYear + "'";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            openConnection();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //bonus_amount = reader["SUM(bonus_amount)"].ToString();
                if (reader["SUM(over_amount)"] != DBNull.Value)
                {
                    over_amount = reader["SUM(over_amount)"].ToString();
                }
                else
                {
                    over_amount = "0";
                }
            }
            closeConnection();

            overtimeLabel.Text = over_amount;
        }

        string check;
        string doublecheck;

        private void salaryFull()
        {
            string query = "select SUM(salary) from event, staff_lineup where no_event = id_event AND staff_id = " + selectedEmp +
                " AND substring(start_date, 6,2) = '" + sMonth + "' AND substring(start_date, 1,4) = '" + sYear + "'";
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
                    check = reader["SUM(salary)"].ToString();
                }
                else
                {
                    check = "0";
                }

            }

            closeConnection();

            string query2 = "select emp_salary from employee where id_emp = " + selectedEmp;
            DataTable table2 = new DataTable();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, con);
            adapter2.Fill(table2);

            openConnection();
            MySqlCommand cmd2 = new MySqlCommand(query2, con);
            MySqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                if (reader2["emp_salary"] != DBNull.Value)
                {
                    salary_amount = reader2["emp_salary"].ToString();
                }
                else
                {
                    salary_amount = "0";
                }

            }

            double tot = Convert.ToDouble(check) + Convert.ToDouble(salary_amount);

            doublecheck = Convert.ToString(tot);
            salLabel.Text = doublecheck + ".00";
            closeConnection();
        }

        private void fullMonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthChange2();
            int nextm = Convert.ToInt32(sMonth);
            int formerm = Convert.ToInt32(m);
            int nexty = Convert.ToInt32(sYear);
            int formery = Convert.ToInt32(y);

            if ((nextm > formerm) && (nexty == formery))
            {
                sMonth = m;
                assignMonth();
                MessageBox.Show("Details Are Not Yet Available!");
            }
            else
            {
                if (selectedEmp != "")
                {
                    salaryFullTable();
                    violationsFull();
                    bonusFull();
                    overFull();
                    computeFull();
                }
            }
        }

        private void yearChange()
        {
            sYear = fullYearBox.Text;
        }

        private void fullYearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearChange();
            int nexty = Convert.ToInt32(sYear);
            int formery = Convert.ToInt32(y);

            if (nexty > formery)
            {
                sYear = y;
                fullYearBox.Text = sYear;
                MessageBox.Show("Details Are Not Yet Available!");
            }
            else
            {
                if (selectedEmp != "")
                {
                    salaryFullTable();
                    violationsFull();
                    bonusFull();
                    overFull();
                    computeFull();
                }
            }
        }

        private void monthChange2()
        {
            if (fullMonthBox.Text == "January")
            {
                sMonth = "01";
            }
            else if (fullMonthBox.Text == "February")
            {
                sMonth = "02";
            }
            else if (fullMonthBox.Text == "March")
            {
                sMonth = "03";
            }
            else if (fullMonthBox.Text == "April")
            {
                sMonth = "04";
            }
            else if (fullMonthBox.Text == "May")
            {
                sMonth = "05";
            }
            else if (fullMonthBox.Text == "June")
            {
                sMonth = "06";
            }
            else if (fullMonthBox.Text == "July")
            {
                sMonth = "07";
            }
            else if (fullMonthBox.Text == "August")
            {
                sMonth = "08";
            }
            else if (fullMonthBox.Text == "September")
            {
                sMonth = "09";
            }
            else if (fullMonthBox.Text == "October")
            {
                sMonth = "10";
            }
            else if (fullMonthBox.Text == "November")
            {
                sMonth = "11";
            }
            else if (fullMonthBox.Text == "December")
            {
                sMonth = "12";
            }
        }

        private void computeFull()
        {
            salaryFull();

            double vio = Convert.ToDouble(vio_amount);
            double bon = Convert.ToDouble(bonus_amount);
            double sal = Convert.ToDouble(doublecheck);
            double over = Convert.ToDouble(over_amount);

            double total = (bon + sal + over) - vio;

            computed_amount = Convert.ToString(total) + ".00";

            fullTotLabel.Text = computed_amount;
        }

        private void salaryFullTable()
        {
            string query = "select event_name from staff_lineup, event where staff_id = " + selectedEmp + " AND id_event = no_event" +
                " AND substring(start_date, 6,2) = '" + sMonth + "' AND substring(start_date, 1,4) = '" + sYear + "'";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            fullGrid.Columns.Clear();
            fullGrid.DataSource = table;

            fullGrid.Columns[0].HeaderCell.Value = "Event Name";
            fullGrid.RowHeadersVisible = false;

            fullGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void fullVio_Click(object sender, EventArgs e)
        {
            violations form = new violations(this);
            form.idValue = selectedEmp;
            form.nameBox = fullEmpLabel.Text;
            form.statusVal = fullStatLabel.Text;
            form.ShowDialog();

            salaryFullTable();
            violationsFull();
            bonusFull();
            overFull();
            computeFull();
        }

        private void fullBonus_Click(object sender, EventArgs e)
        {
            bonus form = new bonus(this);
            form.idValue = selectedEmp;
            form.nameBox = fullEmpLabel.Text;
            form.ShowDialog();

            salaryFullTable();
            violationsFull();
            bonusFull();
            overFull();
            computeFull();
        }

        private void overButt_Click(object sender, EventArgs e)
        {
            overtime form = new overtime(this);
            form.idValue = selectedEmp;
            form.nameBox = fullEmpLabel.Text;          
            form.ShowDialog();

            salaryFullTable();
            violationsFull();
            bonusFull();
            overFull();
            computeFull();
        }
    }
}
