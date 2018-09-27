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
    public partial class equipButt : Form
    {
        salaryUI form = new salaryUI();
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");
        MySqlCommand cmd;

        int PW;
        bool hidden;
        private bool drag = false;
        private Point startPoint = new Point(0, 0);
        string access; // use this to access account type
        int empid;
        string username;

        string currentDate = DateTime.Today.ToString("yyyy-MM-dd");

        string sMonth = DateTime.Now.ToString("MM");
        string sYear = DateTime.Now.ToString("yyyy");

        public equipButt(string access, string username, int empid = 0)
        {
            InitializeComponent();
            PW = panelMenu.Width;
            hidden = false;

            this.access = access;
            this.empid = empid;
            this.username = username;
            editAccounts1.username = username;
            Console.WriteLine(username);
            if (access.Equals("employee"))
            {
                panelMenu.Visible = false;
                menuIcon.Visible = false;
                //employeeView1.Visible = true;
                //employeeView uc = new employeeView(empid.ToString());
                //uc.Location = new Point(67, 51);
                //this.Controls.Add(uc);
            }
            
            checkStat();
            checkSal();
        }

        private void checkStat()
        {
            if(access == "employee")
            {
                payButt.Enabled = false;
                finButt.Enabled = false;
                finIcon.Enabled = false;
                payIcon.Enabled = false;
            }
        }

        private void minButt_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            employeeTab.Visible = false;
            financesUI1.Visible = false;
            payrollUI1.Visible = false;
            eventSched1.Visible = false;
            equipment1.Visible = true;
            //editAccounts1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employeeTab.Visible = true;
            financesUI1.Visible = false;
            payrollUI1.Visible = false;
            eventSched1.Visible = false;
            equipment1.Visible = false;
            //editAccounts1.Visible = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(hidden)
            {
                panelMenu.Width = panelMenu.Width + 35;
                if (panelMenu.Width >= PW)
                {
                    timer.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }else
            {
                panelMenu.Width = panelMenu.Width - 35;
                if (panelMenu.Width <= 0)
                {
                    timer.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void homePage_Load(object sender, EventArgs e)
        {
            
        }

        private void pastSal()
        {
            string selectQuery = "SELECT * from salary_full where substring(date, 1,4) = " + sYear + " AND " +
                    "substring(date, 6, 2) = " + sMonth + " - 1 and id_emp = " + id;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                past_am = reader["amount"].ToString();
            }
            closeConnection();
        }



        string id;
        string past_am;
        private void checkSal()
        {
            string query = "select id_emp from employee where emp_status = 'Full-Time'";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                id = row["id_emp"].ToString();
                string selectQuery = "SELECT * from salary_full where substring(date, 1,4) = " + sYear + " AND " +
                    "substring(date, 6, 2) = " + sMonth + " and id_emp = " + id;

                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(selectQuery, con);
                adapter2.Fill(table2);
                foreach (DataRow row2 in table2.Rows)
                {
                    if (row2.IsNull("amount"))
                    {
                        pastSal();
                        string q = "INSERT INTO salary_full(id_emp, date, amount) VALUES(" + id + ", " + currentDate + ", " + past_am + ")";
                        executeMyQuery(q);
                    }
                }
            }
        }

        private void empButt_Click(object sender, EventArgs e)
        {
            timer.Start();
          
            employeeTab.Visible = true;
            financesUI1.Visible = false;
            payrollUI1.Visible = false;
            eventSched1.Visible = false;
            equipment1.Visible = false;
            //editAccounts1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Start();

            employeeTab.Visible = false;
            financesUI1.Visible = false;
            payrollUI1.Visible = false;
            eventSched1.Visible = false;
            equipment1.Visible = true;
            //editAccounts1.Visible = false;
        }

        private void eventButt_Click(object sender, EventArgs e)
        {
            timer.Start();

            employeeTab.Visible = false;
            financesUI1.Visible = false;
            payrollUI1.Visible = false;
            eventSched1.Visible = true;
            equipment1.Visible = false;
            //editAccounts1.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            logIn form = new logIn();
            form.ShowDialog();
            this.Close();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void finButt_Click(object sender, EventArgs e)
        {
            timer.Start();

            financesUI1.Visible = true;
            payrollUI1.Visible = false;
            employeeTab.Visible = false;
            eventSched1.Visible = false;
            equipment1.Visible = false;
            //editAccounts1.Visible = false;
        }

        private void payButt_Click(object sender, EventArgs e)
        {
            timer.Start();

            payrollUI1.Visible = true;
            financesUI1.Visible = false;
            employeeTab.Visible = false;
            eventSched1.Visible = false;
            equipment1.Visible = false;
            //editAccounts1.Visible = false;

        }

        private void profButt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WARNING: Be careful when handling profiles.\nDO NOT GIVE UNAUTHORIZED USERS COMPLETE ACCESS TO THE SYSTEM. UNAUTHORIZED ACCESS TO THIS SCREEN " +
                "IS PUNISHABLE.", "FATAL WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            editAccounts1.Visible = true;
            payrollUI1.Visible = false;
            financesUI1.Visible = false;
            employeeTab.Visible = false;
            eventSched1.Visible = false;
            equipment1.Visible = false;
            homepageUI1.Visible = false;
            timer.Start();
        }

        private void title_Paint(object sender, PaintEventArgs e)
        {

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

        private void calendarIcon_Click(object sender, EventArgs e)
        {
            employeeTab.Visible = false;
            financesUI1.Visible = false;
            payrollUI1.Visible = false;
            eventSched1.Visible = true;
            equipment1.Visible = false;
            //editAccounts1.Visible = false;
        }

        private void payIcon_Click(object sender, EventArgs e)
        {
            payrollUI1.Visible = true;
            financesUI1.Visible = false;
            employeeTab.Visible = false;
            eventSched1.Visible = false;
            equipment1.Visible = false;
            //editAccounts1.Visible = false;
        }

        private void financesUI1_Load(object sender, EventArgs e)
        {

        }

        private void finIcon_Click(object sender, EventArgs e)
        {
            financesUI1.Visible = true;
            payrollUI1.Visible = false;
            employeeTab.Visible = false;
            eventSched1.Visible = false;
            equipment1.Visible = false;
            //editAccounts1.Visible = false;
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

        private void homeButt_Click(object sender, EventArgs e)
        {
            financesUI1.Visible = false;
            payrollUI1.Visible = false;
            employeeTab.Visible = false;
            eventSched1.Visible = false;
            equipment1.Visible = false;
            editAccounts1.Visible = false;
            homepageUI1.Visible = true;
        }
    }
}
