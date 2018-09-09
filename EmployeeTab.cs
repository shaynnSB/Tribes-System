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
        int selectedRow;

        public EmployeeTab()
        {
            InitializeComponent();
            resetTable();
        }

        private void resetTable(string query = "select * from employee")
        {
            
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            EmpGrid.Columns.Clear();
            EmpGrid.DataSource = table;
            EmpGrid.Columns[0].HeaderCell.Value = "ID Number";
            EmpGrid.Columns[1].HeaderCell.Value = "Employee Name";
            EmpGrid.Columns[2].HeaderCell.Value = "Address";
            EmpGrid.Columns[3].HeaderCell.Value = "Contact Number";
            EmpGrid.Columns[4].HeaderCell.Value = "On-call or Full-time";
            

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetTable("select * from employee where emp_name like '%"+ textBox1.Text +"%'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetTable("select * from employee where id_emp = " + textBox1.Text);
        }
    }
}
