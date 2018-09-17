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
    public partial class addDiscount : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");
        MySqlCommand cmd;
        string id_Passed;

        public addDiscount()
        {
            InitializeComponent();
        }

        private void cancelButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButt_Click(object sender, EventArgs e)
        {
            if (recievedBox.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Add Discount?", " ", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    string insertQuery = "INSERT INTO discount(event_id, disc_amount) VALUES (" + id_Passed + ", "
                    + recievedBox.Text + ")";

                    executeMyQuery(insertQuery);
                    MessageBox.Show("Added Successfully");

                    this.Close();
                }
                else if (dialog == DialogResult.No)
                {

                }
            }
            else
            {
                MessageBox.Show("Please Provide Required Details!");
            }
        }

        private void recievedBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        public string idValue
        {
            set { this.id_Passed = value; }
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
    }
}
