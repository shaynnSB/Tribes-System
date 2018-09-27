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
    public partial class logIn : Form
    {
        private bool drag = false; 
        private Point startPoint = new Point(0, 0); 

        public logIn()
        {
            InitializeComponent();
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void passBox_Enter(object sender, EventArgs e)
        {
            passBox.UseSystemPasswordChar = true;
        }

        private void logButt_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");

            string query = "select * from accounts where acc_username ='" + userBox.Text + "' and acc_pass ='" + passBox.Text + "'";
            // ganito nalang ang query para ma access ang account type in one query
            using (MySqlDataAdapter adpt = new MySqlDataAdapter(query, con))
            {

                DataTable dt = new DataTable();

                adpt.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    try
                    {
                        equipButt form = new equipButt(dt.Rows[0].ItemArray[3].ToString(), dt.Rows[0].ItemArray[1].ToString(), (int)dt.Rows[0].ItemArray[4]);
                        // nilagyan ko ng parameter para mapass ang account type
                        form.ShowDialog();
                    }
                    catch (InvalidCastException)
                    {
                        equipButt form = new equipButt(dt.Rows[0].ItemArray[3].ToString(), dt.Rows[0].ItemArray[1].ToString()); 
                        // nilagyan ko ng parameter para mapass ang account type
                        form.ShowDialog();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter correct username and password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
    }
}
