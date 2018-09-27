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
        MySqlCommand cmd;
        DataTable grid = new DataTable();
        string selectedEmp = "";
        string stat = "";
        public string username;
        int selected = 0;

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
                selected = 0;

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
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            addEmployee win = new addEmployee();
            win.ShowDialog();
            if (win.DialogResult == DialogResult.OK)
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
                passBox2.Text = EmpGrid.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                selected = e.RowIndex;
                switch (EmpGrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString())
                {
                    case "superUser":
                        stat = "superUser";
                        radioButton1.Checked = true;
                        radioButton4.Visible = false;
                        break;
                    case "owner":
                        stat = "owner";
                        radioButton2.Checked = true;
                        radioButton4.Visible = false;
                        break;
                    case "employee":
                        stat = "employee";
                        radioButton4.Checked = true;
                        radioButton4.Visible = true;
                        radioButton1.Visible = false;
                        radioButton2.Visible = false;
                        radioButton3.Visible = false;
                        break;
                    case "secretary":
                        stat = "secretary";
                        radioButton3.Checked = true;
                        radioButton4.Visible = false;
                        break;
                    default:
                        break;
                }
                if (EmpGrid.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Equals("employee"))
                {
                    try
                    {
                        this.stat = "employee";
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

        private void button3_Click(object sender, EventArgs e)
        {
            resetTable("select * from employee where emp_name like '%" + textBox1.Text + "%'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetTable("select * from employee where id_emp = " + textBox1.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!this.selectedEmp.Equals(""))
            {
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (!passBox.Text.Equals(passBox2.Text)) { throw new hindiParehoAngPasswordsException(); }
                string query = "UPDATE accounts SET " +
                "acc_username = '" + nameBox.Text + "', " +
                "acc_pass = '" + passBox.Text + "', " +
                "acc_status = '" + stat + "' " +
                "WHERE id_acc = " + EmpGrid.Rows[selected].Cells[0].Value.ToString();

                DialogResult dr1; //= MessageBox.Show("You are about to change your own username. Please restart the system after changing", "FATAL ALERT", MessageBoxButtons.OKCancel);
                if (EmpGrid.Rows[selected].Cells[1].ToString().Equals(username))
                {
                    dr1 = MessageBox.Show("You are about to change your own username. Please restart the system after changing", "FATAL ALERT", MessageBoxButtons.OKCancel);
                }
                else
                {
                    dr1 = DialogResult.OK;
                }
                if (dr1 == DialogResult.OK)
                {
                    executeMyQuery(query);
                }
                resetTable();
            }
            catch(hindiParehoAngPasswordsException)
            {
                MessageBox.Show("The entered passwords do not match.");
            }
            catch
            {

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                this.stat = "superUser";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.stat = "owner";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                this.stat = "secretary";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton4.Checked)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (!addPassBox.Text.Equals(addPassBox2.Text)) { throw new hindiParehoAngPasswordsException(); }
                string q = "SELECT acc_username FROM accounts WHERE acc_username = '" + nameBox.Text + "'";
                MySqlDataAdapter a = new MySqlDataAdapter(q, con);
                DataTable t = new DataTable();
                a.Fill(t);
                if (t.Rows.Count > 0)
                {
                    MessageBox.Show("Username exists. Choose another one.");
                }
                else
                {
                    string addstat = "";
                    if (radioButton8.Checked)
                    {
                        addstat = "superUser";
                    }
                    if (radioButton7.Checked)
                    {
                        addstat = "owner";
                    }
                    if (radioButton6.Checked)
                    {
                        addstat = "secretary";
                    }
                    string s = "INSERT INTO accounts(acc_username, acc_pass, acc_status) VALUES ('" + addNameBox.Text + "', '" + addPassBox.Text + "', '" + addstat + "')";
                    executeMyQuery(s);
                }
            }
            catch(hindiParehoAngPasswordsException)
            {

            }
            catch
            {

            }
            
            
        }
    }

    class hindiParehoAngPasswordsException : Exception
    {

    }
}
