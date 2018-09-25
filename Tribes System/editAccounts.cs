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
    public partial class editAccounts : UserControl
    {

        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root;Convert Zero Datetime = True;");

        DataTable grid = new DataTable();
        string selectedEmp ="";

        public editAccounts()
        {
            InitializeComponent();
            resetTable();
        }

        private void resetTable(string query = "select * from accounts")
        {
            try
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                adapter.Fill(table);
                EmpGrid.Columns.Clear();
                EmpGrid.DataSource = table;
                EmpGrid.Columns[0].Visible = false; //employee ID
                EmpGrid.Columns[1].HeaderCell.Value = "Username"; //username
                EmpGrid.Columns[2].Visible = false; //password
                EmpGrid.Columns[3].Visible = false; //account status
                EmpGrid.Columns[4].Visible = false; //referenceID
                this.selectedEmp = "";
                NameLabs.Text = "Username: ";
                //StatusLab.Text = "Status: ";
                nameBox.Text = "";
                passBox.Text = "";
                addNameBox.Text = "";
                addPassBox.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                //radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;

                /*

               
                
                
                EmergencyContactLab.Text = "Emergency Contact: ";
                ENameLab.Text = "Emergency Name: ";
                BdayLab.Text = "Birthdate: ";
                numLab.Text = "Contact: ";
                addressLab.Text = "Address: ";
                genderLab.Text = "Gender: ";
                salaryLab.Text = "Salary: ";

                dataGridView2.DataSource = null;
                */
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
            


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
            if (e.RowIndex >= 0)
            {

                nameBox.Text = EmpGrid.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                passBox.Text = EmpGrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                switch (EmpGrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString())
                {
                    case "superUser":
                        radioButton1.Checked = true;
                        break;
                    case "owner":
                        radioButton2.Checked = true;
                        break;
                    case "employee":
                        radioButton4.Checked = true;
                        break;
                    case "secretary":
                        radioButton3.Checked = true;
                        break;
                    default:
                        break;
                }
                if (EmpGrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Equals("employee"))
                {
                    try
                    {
                        string q = "SELECT first_name, last_name FROM employee WHERE id_emp = " + EmpGrid.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                        MySqlDataAdapter a = new MySqlDataAdapter(q, con);
                        DataTable t = new DataTable();
                        a.Fill(t);
                        if (t.Rows.Count > 0)
                        {
                            nameLab.Text = t.Rows[0].ItemArray[1].ToString() + ", " + t.Rows[0].ItemArray[0].ToString();
                        }
                        else
                        {
                            Console.WriteLine("no rows returned");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("ERROR!");
                    }
                    
                }

            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Full-Time":
                    resetTable("select * from employee where emp_status = 'Full-Time'");
                    break;
                case "On-Call":
                    resetTable("select * from employee where emp_status = 'On-Call'");
                    break;
                case "Inactive":
                    resetTable("select * from employee where emp_status = 'Inactive'");
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

        private void genderLab_Click(object sender, EventArgs e)
        {

        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            passBox.UseSystemPasswordChar = false;
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            passBox.UseSystemPasswordChar = true;
        }

        private void editAccounts_Load(object sender, EventArgs e)
        {

        }
    }
}
