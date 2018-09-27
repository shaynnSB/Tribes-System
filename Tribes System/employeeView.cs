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
    public partial class employeeView : UserControl
    {
        string firstname = "";
        string lastname = "";
        string welcome = "Welcome, ";
        string empid = "0";
        DataTable empData = new DataTable();
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root;Convert Zero Datetime = True;");

        public employeeView(string empid)
        {
            InitializeComponent();
            this.empid = empid;
            dateLab.Text = "Today is: " + DateTime.Now.ToString("MMMM, dd yyyy");
            try
            {
                string q = "SELECT * FROM employee WHERE id_emp = " + empid;
                MySqlDataAdapter a = new MySqlDataAdapter(q, con);
                //DataTable t = new DataTable();
                a.Fill(empData);
                if(empData.Rows.Count > 0)
                {
                    if (empData.Rows[0].ItemArray[4].ToString().Equals("Inactive"))
                    {
                        throw new EmployeeIsInactiveException(); //throw custom exception i defined below if inactive. just dont show anything if the employee is inactive.
                    }
                    NameLab.Text = "Name: " + empData.Rows[0].ItemArray[9].ToString() + " " + empData.Rows[0].ItemArray[10].ToString().ToString();
                    StatusLab.Text = "Status: " + empData.Rows[0].ItemArray[4].ToString();
                    EmergencyContactLab.Text = "Emergency Contact: " + empData.Rows[0].ItemArray[5].ToString();
                    ENameLab.Text = "Emergency Name: " + empData.Rows[0].ItemArray[6].ToString();
                    BdayLab.Text = "Birthdate: " + empData.Rows[0].ItemArray[7].ToString();
                    numLab.Text = "Contact: " + empData.Rows[0].ItemArray[3].ToString();
                    addressLab.Text = "Address: " + empData.Rows[0].ItemArray[2].ToString();
                    genderLab.Text = "Gender: " + empData.Rows[0].ItemArray[8].ToString();

                    if (empData.Rows[0].ItemArray[11].ToString().Equals("0.00"))
                    {
                        salaryLab.Visible = false;
                    }
                    else
                    {
                        salaryLab.Text = "Salary: " + empData.Rows[0].ItemArray[11].ToString();
                    }
                    

                    welcomeLab.Text = welcome + empData.Rows[0].ItemArray[9].ToString() + " " + empData.Rows[0].ItemArray[10].ToString().ToString() + "!";

                    DataTable sched = new DataTable();
                    string query = "SELECT event_name, event_location, start_date, end_date, id_event FROM event " +
                                "INNER JOIN staff_lineup " +
                                "ON id_event = staff_lineup.no_event " +
                                "WHERE staff_lineup.staff_id = " + empData.Rows[0].ItemArray[0].ToString() +
                               " AND event.end_date > NOW()";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    adapter.Fill(sched);
                    dataGridView2.DataSource = sched;
                    
                }
            }
            catch(MySqlException)
            {
                MessageBox.Show("An error has occured");
            }
            catch(EmployeeIsInactiveException)
            {
                panel1.Visible = false;
                welcomeLab.Visible = false;
                dateLab.Visible = false;
                label6.Visible = true;
            }
            catch
            {
                MessageBox.Show("An error has occured");
            }
        }

        public void setId(string empid)
        {
            this.empid = empid;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable d = new DataTable();
            string query = "SELECT event_name, event_location, start_date, end_date, start_time, end_time, id_event FROM event WHERE id_event = " + dataGridView2[4, e.RowIndex].Value.ToString();
            MySqlDataAdapter a = new MySqlDataAdapter(query, con);
            a.Fill(d);

            eventName.Text = "Name: " + d.Rows[0].ItemArray[0].ToString();
            eventLocation.Text = "Location: " + d.Rows[0].ItemArray[1].ToString();
            eventStartDate.Text = "Start Date: " + d.Rows[0].ItemArray[2].ToString();
            eventEndDate.Text = "End Date: " + d.Rows[0].ItemArray[3].ToString();
            eventStartTime.Text = "Start Time: " + d.Rows[0].ItemArray[4].ToString();
            eventEndTime.Text = "End Time: " + d.Rows[0].ItemArray[5].ToString();

            DataTable s = new DataTable();
            query = "SELECT employee.first_name, employee.last_name " +
                        "FROM employee " +
                        "INNER JOIN staff_lineup " +
                        "ON employee.id_emp = staff_lineup.staff_id " +
                        "WHERE no_event = " + dataGridView2[4, e.RowIndex].Value.ToString();
            a = new MySqlDataAdapter(query, con);
            a.Fill(s);

            DataTable i = new DataTable();
            query = "SELECT * FROM itemcontent" +
                "INNER JOIN event ON event.id_event = itemcontent.eventID" +
                "WHERE itemcontent.eventID = " + d.Rows[0].ItemArray[6].ToString();
            a = new MySqlDataAdapter(query,con);


            dataGridView3.DataSource = i;
            dataGridView1.DataSource = s;

            //dataGridView3.DataSource = d;
        }
    }

    class EmployeeIsInactiveException : Exception
    {

    }
}
