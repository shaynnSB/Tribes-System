﻿using System;
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
    public partial class editEmployee : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");
        MySqlCommand cmd;

        private bool drag = false;
        private Point startPoint = new Point(0, 0);

        string empid;
        string stat = "";
        string gender = "";

        public editEmployee(string id)
        {
            this.empid = id;
            InitializeComponent();
            string query = "select * from employee where id_emp = " + empid;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);

            //nameBox.Text = table.Rows[0].ItemArray[1].ToString();
            addressBox.Text = table.Rows[0].ItemArray[2].ToString();
            numBox.Text = table.Rows[0].ItemArray[3].ToString();
            emergencyContact.Text = table.Rows[0].ItemArray[5].ToString();
            emergencyName.Text = table.Rows[0].ItemArray[6].ToString();
            nameBox.Text = table.Rows[0].ItemArray[9].ToString();
            lastnameBox.Text = table.Rows[0].ItemArray[10].ToString();
            //DateTime dt = ;
            dateTimePicker1.Value = (DateTime)table.Rows[0].ItemArray[7];

            switch (table.Rows[0].ItemArray[4].ToString())
            {
                case "call":
                    radioButton1.Checked = true;
                    this.stat = "call";
                    break;
                case "full":
                    radioButton2.Checked = true;
                    this.stat = "full";
                    break;
                case "fired":
                    radioButton3.Checked = true;
                    this.stat = "fired";
                    break;
                default:
                    break;
            }

            switch (table.Rows[0].ItemArray[8].ToString())
            {
                case "male":
                    radioButton6.Checked = true;
                    this.gender = "male";
                    break;
                case "female":
                    radioButton5.Checked = true;
                    this.gender = "female";
                    break;
                case "other":
                    radioButton4.Checked = true;
                    this.gender = "other";
                    break;
                default:
                    break;
            }

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
            if (nameBox.Text != "" && addressBox.Text != "" && numBox.Text != "" && stat != "" && emergencyContact.Text != "" && emergencyName.Text != "")
            {
                if (nameBox.Text != "Name of Employee" && addressBox.Text != "Address of Employee" && numBox.Text != "Contact Number of Employee" && emergencyContact.Text != "Emergency Contact" && emergencyName.Text != "Emergency Contact Name")
                {
                    DialogResult dg = MessageBox.Show("Are you sure?","Alert!",MessageBoxButtons.YesNo);
                    if(dg == DialogResult.Yes)
                    {
                        string insertQuery = "UPDATE employee SET " +
                            "emp_address = '" + addressBox.Text + "', emp_contact = '" + numBox.Text + "', emp_status = '" + stat + "'," +
                            "emergency_contact = '" + emergencyContact.Text + "', emergency_name = '" + emergencyName.Text + "', birthdate = '" + 
                            dateTimePicker1.Value.ToString("yyyy-mm-dd") + "', gender = '"+ this.gender +"', first_name = '" + nameBox.Text + "', last_name = " + lastnameBox.Text +
                            " WHERE id_emp = "+ this.empid;
                        executeMyQuery(insertQuery);
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Dispose();
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
                    MessageBox.Show("Employee Edited Successfully");
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
                this.stat = "call";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.stat = "full";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                this.stat = "fired";
            }
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
    }
}
