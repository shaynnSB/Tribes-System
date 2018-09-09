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
    public partial class addViewStaff : Form
    {
        private bool drag = false;
        private Point startPoint = new Point(0, 0);
        eventSched form = new eventSched();
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root;Convert Zero Datetime = True;");
        DataTable eventData = new DataTable();
        DataTable addedEmployees = new DataTable();
        int selectedRow = 0;
        int addSelectedRow = 0;

        //int tempID = 1;

        private void refresh() //refresh the tables
        {
            string query = "select * from staff_lineup where no_event = '" + idPassed + "'";
            DataTable emp_table = new DataTable();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            string emps = "";
            adapter.Fill(table);

            query = "select * from event where id_event = '" + idPassed + "'"; //select the event we are currently changing the lineup for
            adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(eventData);
            

            if (table.Rows.Count > 0) //if may lineup na, select employees
            {
//--------------select assigned employees---------------------------------------
                query = "SELECT employee.id_emp, employee.first_name, employee.last_name " +
                    "FROM employee INNER JOIN staff_lineup ON employee.id_emp = staff_lineup.staff_id";
                adapter = new MySqlDataAdapter(query, con);
                adapter.Fill(emp_table);
                assignedGrid.DataSource = emp_table;
//--------------select available employees---------------------------------------
                query = "SELECT employee.id_emp, employee.first_name, employee.last_name " +
                    "FROM employee LEFT JOIN staff_lineup ON employee.id_emp = staff_lineup.staff_id " +
                    "WHERE staff_lineup.staff_id IS NULL";
                DataTable available_table = new DataTable();
                adapter = new MySqlDataAdapter(query, con);
                adapter.Fill(available_table);
                listEmpGrid.DataSource = available_table;
//------------------------------------------------------------------------------
            }
            else //if wala pang lineup, all employees will be available
            {
                query = "SELECT employee.id_emp, employee.first_name, employee.last_name FROM employee ";
                DataTable available_table = new DataTable();
                adapter = new MySqlDataAdapter(query, con);
                adapter.Fill(available_table);
                listEmpGrid.DataSource = available_table;
            }

        }

        private void listEmpGrid_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
             selectedRow = e.RowIndex;
        }

        private void addButt_Click(object sender, EventArgs e)
        {

            addGrid.Rows.Insert(0, listEmpGrid.Rows[selectedRow].Cells[0].Value, listEmpGrid.Rows[selectedRow].Cells[1].Value.ToString() + " " + listEmpGrid.Rows[selectedRow].Cells[2].Value.ToString());
            //addGrid.DataSource = addedEmployees;
            //MessageBox.Show();

        }

        public addViewStaff(eventSched form)
        {
            InitializeComponent();
            this.form = form;
            addGrid.Columns.Add("id_emp", "ID");
            addGrid.Columns.Add("emp_name", "FIRST NAME");
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minButt_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void confirmButt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm changes in staff lineup?", "Staff Lineup", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //string editQuery = "UPDATE event SET event_name = ,event_location = , event_notes = , start_date = , end_date = , start_time = , 
                //end_time = , client_name = , client_contact = WHERE id_event = " + idValue;
                //executeMyQuery(editQuery);
                string query = "";
                con.Open();
                for (int i = 0; i < addGrid.Rows.Count - 1; i++) //add each employee to the lineup
                {
                    
                    query = "INSERT INTO staff_lineup(id_line, no_event, staff_id, salary) " +
                            "VALUES (0, '" + idPassed + "', '"+ addGrid.Rows[i].Cells[0].Value+"', '100')";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    //MessageBox.Show(addGrid.Rows[i].Cells[0].Value.ToString());
                    try
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            //MessageBox.Show("Employee Added Successfully");
                            refresh();
                        }
                    }
                    catch(Exception k)
                    {
                        MessageBox.Show("ERROR! " + k.ToString());
                    }

                }
                //query = "INSERT INTO staff_lineup(no_event, staff_id, salary) " +
                //"VALUES ('"+idPassed+"', '"++"', '100')";
                con.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        public string eventName
        {
            get { return eventLabel.Text; }
            set { eventLabel.Text = value; }
        }

        string idPassed;

        public string idValue
        {
            get { return idPassed; }
            set { idPassed = value; refresh(); }
        }

        private void removeButt_Click(object sender, EventArgs e)
        {
            addGrid.Rows.RemoveAt(addSelectedRow);
        }

        private void addGrid_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            addSelectedRow = e.RowIndex;
        }
    }
}
