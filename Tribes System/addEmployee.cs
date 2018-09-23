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
    public partial class addEmployee : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");
        MySqlCommand cmd;

        private bool drag = false;
        private Point startPoint = new Point(0, 0);

        private string stat = "On-call";
        private string gender = "male";
        private int autoincrement;

        public addEmployee()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;

            string q = "SELECT max(id_emp) FROM employee";
            DataTable t = new DataTable();
            MySqlDataAdapter a = new MySqlDataAdapter(q, con);
            a.Fill(t);
            autoincrement = (int)t.Rows[0].ItemArray[0] + 1;

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region useless functions
        private void startDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addEvent_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void startTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {

        } 
        #endregion

        private void textBox1_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
        }

        private void locBox_Click(object sender, EventArgs e)
        {
            addressBox.Clear();
        }

        private void conClientBox_Click(object sender, EventArgs e)
        {
            numBox.Clear();
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != "" && addressBox.Text != "" && numBox.Text != "" && stat != "" && emergencyContact.Text != "" && emergencyName.Text != "" && passBox.Text != "")
            {
                if (nameBox.Text != "Name of Employee" && addressBox.Text != "Address of Employee" && numBox.Text != "Contact Number of Employee" && emergencyContact.Text != "Emergency Contact" && emergencyName.Text != "Emergency Contact Name" && passBox.Text != "Employee Account Password")
                {
                    string q = "select first_name, last_name FROM employee WHERE first_name = '"+nameBox.Text+"' AND last_name = '"+lastnameBox.Text+"'";
                    DataTable t = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(q, con);
                    adapter.Fill(t);

                    if (t.Rows.Count == 0)
                    {
                        DialogResult dg = MessageBox.Show("Are you sure?", "Alert!", MessageBoxButtons.YesNo);
                        if (dg == DialogResult.Yes)
                        {
                            string insertQuery = "INSERT INTO " +
                                "employee(emp_address, emp_contact, emp_status, emergency_contact, emergency_name, birthdate, gender, first_name, last_name, emp_salary) " +
                                "VALUES ('" + addressBox.Text + "','" + numBox.Text + "','" + stat + "','" + emergencyContact.Text + "','" + emergencyName.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + this.gender + "', '" + nameBox.Text + "', '" + lastnameBox.Text + "', "+salarayBox.Text+")";
                            executeMyQuery(insertQuery);
                            

                            string fn = nameBox.Text;
                            string uname = "";
                            foreach (string letter in fn.Split(' '))
                            {
                                uname += letter[0];
                            }
                            uname += lastnameBox.Text.Replace(" ", string.Empty);
                            uname = uname.ToLower();

                            insertQuery = "INSERT INTO " + //second insert query para sa accounts table
                                "accounts(acc_username, acc_pass, acc_status, reference_id) " +
                                "VALUES ('" + uname + "', '" + passBox.Text + "', 'employee', " + autoincrement +")";
                            executeMyQuery(insertQuery);

                            this.DialogResult = System.Windows.Forms.DialogResult.OK;
                            this.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("An employee with that name already exists!");
                    }
                    
                    
                }
                else
                {
                    alertLabel.Visible = true;
                }
            }
            else
            {
                alertLabel.Visible = true;
            }
            
            
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
                    MessageBox.Show("Employee Added Successfully");
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.stat = "On-Call";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.stat = "Full-Time";
                label7.Visible = true;
                salarayBox.Visible = true;
            }
            else
            {
                label7.Visible = false;
                salarayBox.Text = "0.0";
                salarayBox.Visible = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                this.gender = "male";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                this.gender = "female";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                this.gender = "other";
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        string salaraylastvalidinput = "";
        private void salarayBox_TextChanged(object sender, EventArgs e)
        {
            //Decimal.TryParse
            try
            {
                if(salarayBox.Text != "")
                {
                    Decimal.Parse(salarayBox.Text);
                    salaraylastvalidinput = salarayBox.Text;
                }
            }
            catch
            {
                //MessageBox.Show("Invalid value!");
                salarayBox.Text = salaraylastvalidinput;
            }
        }
    }
}
