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
    public partial class EmployeeTab : UserControl
    {

        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");

        DataTable grid = new DataTable();
        string selectedEmp ="";

        public EmployeeTab()
        {
            InitializeComponent();
            resetTable();
        }

        private void resetTable(string query = "select * from employee where emp_status <> 'fired'")
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
            EmpGrid.Columns[9].DisplayIndex = 0;
            EmpGrid.Columns[10].DisplayIndex = 1;
            EmpGrid.Columns[9].HeaderCell.Value = "First Name";
            EmpGrid.Columns[10].HeaderCell.Value = "Last Name";
            EmpGrid.Columns[9].Width = 250;
            EmpGrid.Columns[10].Width = 250;
            EmpGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.selectedEmp = "";
            NameLab.Text = "Name: ";
            StatusLab.Text = "Status: ";
            EmergencyContactLab.Text = "Emergency Contact: ";
            ENameLab.Text = "Emergency Name: ";
            BdayLab.Text = "Birthdate: ";
            numLab.Text = "Contact: ";
            addressLab.Text = "Address: ";
            genderLab.Text = "Gender: ";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            addEmployee win = new addEmployee();
            win.ShowDialog();
            if(win.DialogResult == DialogResult.OK)
            {
                resetTable();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selectedEmp = EmpGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            NameLab.Text = "Name: " + EmpGrid.Rows[e.RowIndex].Cells[9].FormattedValue.ToString() + " " + EmpGrid.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
            StatusLab.Text = "Status: " + EmpGrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            EmergencyContactLab.Text = "Emergency Contact: " + EmpGrid.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            ENameLab.Text = "Emergency Name: " + EmpGrid.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            BdayLab.Text = "Birthdate: " + EmpGrid.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
            numLab.Text = "Contact: " + EmpGrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            addressLab.Text = "Address: " + EmpGrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            genderLab.Text = "Gender: " + EmpGrid.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();

            /*DataTable sched = new DataTable();
            string q = "SELECT event_name, event_location, start_date, end_date FROM event WHERE STAFF_ID = '" + EmpGrid.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(q, con);
            adapter.Fill(sched);
            dataGridView2.DataSource = sched;*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Full-Time":
                    resetTable("select * from employee where emp_status = 'full'");
                    break;
                case "On-Call":
                    resetTable("select * from employee where emp_status = 'call'");
                    break;
                case "Inactive":
                    resetTable("select * from employee where emp_status = 'fired'");
                    break;
                default:
                    resetTable();
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetTable("select * from employee where emp_name like '%"+ textBox1.Text +"%'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetTable("select * from employee where id_emp = " + textBox1.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!this.selectedEmp.Equals("")) { 
                editEmployee win = new editEmployee(selectedEmp);
                win.ShowDialog();
                if (win.DialogResult == DialogResult.OK)
                {
                    resetTable();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetTable();
        }
    }
}
