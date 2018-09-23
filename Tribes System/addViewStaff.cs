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
        int assignedSelectedRow;
        DateTime start, end;

        //int tempID = 1;

        private void refresh() //refresh the tables
        {

            listEmpGrid.Rows.Clear();
            addGrid.Rows.Clear();

            string query = "select * from staff_lineup where no_event = '" + idPassed + "'";
            DataTable emp_table = new DataTable();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            //string emps = "";
            adapter.Fill(table);

            query = "select * from event where id_event = '" + idPassed + "'"; //select the event we are currently changing the lineup for
            adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(eventData);

            try
            {
                if (table.Rows.Count > 0) //if may lineup na, select employees
                {
                    //--------------select assigned employees---------------------------------------
                    query = "SELECT employee.id_emp, employee.first_name, employee.last_name, staff_lineup.id_line " +
                            "FROM employee " +
                            "INNER JOIN staff_lineup " +
                            "ON employee.id_emp = staff_lineup.staff_id " +
                            "WHERE no_event = '" + idPassed + "'";
                    adapter = new MySqlDataAdapter(query, con);
                    adapter.Fill(emp_table);
                    assignedGrid.DataSource = emp_table;
                    assignedGrid.Columns[0].Visible = assignedGrid.Columns[3].Visible = false;
                    assignedGrid.Columns[1].HeaderText = "First Name";
                    assignedGrid.Columns[2].HeaderText = "Last Name";
                    //--------------select available employees---------------------------------------
                    query = "SELECT DISTINCT em.id_emp, em.first_name, em.last_name " + //I coded the query below myself, but I don't fully understand it, so bugs might happen when selecting available employees thx. --syed
                            "FROM (SELECT * FROM employee WHERE emp_status != 'Inactive') em " +
                            "LEFT JOIN (" +
                            "SELECT staff_id FROM staff_lineup " +
                            "INNER JOIN event " +
                            "ON staff_lineup.no_event = event.id_event " +
                            "WHERE start_date BETWEEN '" + start + "' AND '" + end + "' " +
                            ") AS c " + 
                            "ON em.id_emp = c.staff_id " + 
                            "LEFT JOIN employee " + 
                            "ON employee.id_emp = c.staff_id " +
                            "WHERE employee.id_emp";
                    DataTable available_table = new DataTable();
                    adapter = new MySqlDataAdapter(query, con);
                    adapter.Fill(available_table);
                    //listEmpGrid.DataSource = available_table;
                    foreach (DataRow row in available_table.Rows) //foreach to put each row from db into the datagridview.
                    {  //im using this instead of setting a datasource kasi temporary values pa yung sa listempgrid and addgrid
                        listEmpGrid.Rows.Add(row[0], row[1], row[2]);
                    }
                    //------------------------------------------------------------------------------
                }
                else //if wala pang lineup, all employees will be available
                {
                    query = "SELECT employee.id_emp, employee.first_name, employee.last_name FROM employee WHERE employee.emp_status <> 'Inactive'";
                    DataTable available_table = new DataTable();
                    adapter = new MySqlDataAdapter(query, con);
                    adapter.Fill(available_table);
                    //listEmpGrid.DataSource = available_table;
                    foreach (DataRow row in available_table.Rows)
                    {
                        listEmpGrid.Rows.Add(row[0], row[1], row[2]);
                    }
                }
            }
            catch(MySqlException)
            {
                MessageBox.Show("MySQL has returned an error while refreshing. Please contact your systems administrator.");
            }
            catch (Exception)
            {
                MessageBox.Show("An unknown error has occured. Please contact your systems administrator.");
            }
            

        }

        private void listEmpGrid_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
             selectedRow = e.RowIndex;
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            try
            {
                addGrid.Rows.Insert(0, listEmpGrid.Rows[selectedRow].Cells[0].Value, listEmpGrid.Rows[selectedRow].Cells[1].Value.ToString(), listEmpGrid.Rows[selectedRow].Cells[2].Value.ToString());
                listEmpGrid.Rows.RemoveAt(selectedRow);
                if (selectedRow > 0)
                {
                    selectedRow--;
                }
            }
            catch (System.ArgumentOutOfRangeException err)
            {
                MessageBox.Show("ERROR! no employee selected!");
            }
            
            //addGrid.DataSource = addedEmployees;
            //MessageBox.Show();

        }

        public addViewStaff(eventSched form)
        {
            InitializeComponent();
            this.form = form;
            addGrid.Columns.Add("id_emp", "ID");
            addGrid.Columns.Add("irst_name", "First Name");
            addGrid.Columns.Add("last_name", "Last Name");
            listEmpGrid.Columns.Add("id_emp", "ID");
            listEmpGrid.Columns.Add("first_name", "First Name");
            listEmpGrid.Columns.Add("last_name", "Last Name");
            listEmpGrid.Columns[0].Visible = false;
            addGrid.Columns[0].Visible = false;
            
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
                if(addGrid.Rows.Count > 0)
                {
                    for (int i = 0; i < addGrid.Rows.Count; i++) //add each employee to the lineup
                    {

                        query = "INSERT INTO staff_lineup(no_event, staff_id, salary) " +
                                "VALUES ('" + idPassed + "', '" + addGrid.Rows[i].Cells[0].Value + "', '100')";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        //MessageBox.Show(addGrid.Rows[i].Cells[0].Value.ToString());
                        try
                        {
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                //MessageBox.Show("Employee Added Successfully");

                            }
                            else
                            {
                                MessageBox.Show("NOt executed");
                            }
                        }
                        catch (Exception k)
                        {
                            MessageBox.Show("ERROR! " + k.ToString());
                        }

                    }
                    refresh();
                }
                else
                {
                    MessageBox.Show("No employee has been added");
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
            set {
                idPassed = value;
                refresh();
                string getdate = "SELECT start_date, end_date FROM event WHERE id_event = " + idPassed;
                DataTable temp = new DataTable();
                MySqlDataAdapter a = new MySqlDataAdapter(getdate, con);
                a.Fill(temp);
                start = (DateTime)temp.Rows[0].ItemArray[0];
                end = (DateTime)temp.Rows[0].ItemArray[1];
            }
        }

        private void removeButt_Click(object sender, EventArgs e)
        {
            try
            {
                listEmpGrid.Rows.Insert(0, addGrid.Rows[addSelectedRow].Cells[0].Value,
                                    addGrid.Rows[addSelectedRow].Cells[1].Value.ToString(),
                                    addGrid.Rows[addSelectedRow].Cells[2].Value.ToString());
                addGrid.Rows.RemoveAt(addSelectedRow);
                if (addSelectedRow > 0)
                {
                    addSelectedRow--;
                }
            }
            catch (System.ArgumentOutOfRangeException err)
            {
                MessageBox.Show("ERROR! no employee selected! hehe");
            }

        }

        private void addGrid_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            addSelectedRow = e.RowIndex;
        }

        private void assignedGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            assignedSelectedRow = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dR = MessageBox.Show("Are you sure?", "Staff Lineup", MessageBoxButtons.YesNo);
            if (dR == DialogResult.Yes)
            {
                con.Open();
                string q = "DELETE FROM staff_lineup WHERE id_line = " + assignedGrid.Rows[assignedSelectedRow].Cells[3].Value;
                MySqlCommand cmd = new MySqlCommand(q, con);
                cmd.ExecuteNonQuery();
                con.Close();
                refresh();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string q = "UPDATE staff_lineup SET salary = " + salaryBox.Text + " WHERE staff_id = " + assignedGrid.Rows[assignedSelectedRow].Cells[0].FormattedValue.ToString() + " AND no_event = "+ idPassed;
            try
            {
                decimal n = Decimal.Parse(salaryBox.Text);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(q, con);
                if(cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Changed successfully");
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Enter a correct value");
            }
            catch(MySqlException)
            {
                MessageBox.Show("MySQL has returned an error");
            }
            finally
            {
                con.Close();
            }
            
        }
    }
}
