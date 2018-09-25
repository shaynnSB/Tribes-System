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
                    NameLab.Text = "Name: " + empData.Rows[0].ItemArray[9].ToString() + " " + empData.Rows[0].ItemArray[10].ToString().ToString();
                    StatusLab.Text = "Status: " + empData.Rows[0].ItemArray[4].ToString();
                    EmergencyContactLab.Text = "Emergency Contact: " + empData.Rows[0].ItemArray[5].ToString();
                    ENameLab.Text = "Emergency Name: " + empData.Rows[0].ItemArray[6].ToString();
                    BdayLab.Text = "Birthdate: " + empData.Rows[0].ItemArray[7].ToString();
                    numLab.Text = "Contact: " + empData.Rows[0].ItemArray[3].ToString();
                    addressLab.Text = "Address: " + empData.Rows[0].ItemArray[2].ToString();
                    genderLab.Text = "Gender: " + empData.Rows[0].ItemArray[8].ToString();
                    salaryLab.Text = "Salary: " + empData.Rows[0].ItemArray[11].ToString();

                    welcomeLab.Text = welcome + empData.Rows[0].ItemArray[9].ToString() + " " + empData.Rows[0].ItemArray[10].ToString().ToString() + "!";

                    DataTable sched = new DataTable();
                    string query = "SELECT event_name, event_location, start_date, end_date FROM event " +
                                "INNER JOIN staff_lineup " +
                                "ON id_event = staff_lineup.no_event " +
                                "WHERE staff_lineup.staff_id = " + empData.Rows[0].ItemArray[0].ToString() +
                               " AND event.end_date > NOW()";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    adapter.Fill(sched);
                    dataGridView2.DataSource = sched;
                }
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
    }
}
