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
        int selectedRow;

        public salaryUI()
        {
            InitializeComponent();
            resetTable();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void payrollUI_Load(object sender, EventArgs e)
        {
            // dateTimePicker1.Format = DateTimePickerFormat.Custom;
            // dateTimePicker1.CustomFormat = "yyyy-MM";
            grid.Columns.Add("Id", typeof(string));
            grid.Columns.Add("Employee Name", typeof(string));
            grid.Columns.Add("Status", typeof(string));

            employeeGrid.DataSource = grid;
            employeeGrid.Columns["Id"].Visible = false;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void allButt_Click(object sender, EventArgs e)
        {

        }

        private void payRepButt_Click(object sender, EventArgs e)
        {
            salaryReport form = new salaryReport();
            form.ShowDialog();
        }


        private void resetTable(string query = "select * from employee")
        {

           /* DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            employeeGrid.Columns.Clear();
            employeeGrid.DataSource = table;
           
            foreach (DataRow row in table.Rows)
            {
                string id = row["id_emp"].ToString();
                string name = row["emp_name"].ToString();
                //string fullCall = row["emp_status"].ToString();

                grid.Rows.Add(id, name);
                employeeGrid.DataSource = grid;
            }*/
        }
    }
}
