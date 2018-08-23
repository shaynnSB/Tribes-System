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
    public partial class equipHome : UserControl
    {
        public equipHome()
        {
            InitializeComponent();
        }

        public static string sendtext = "";

        private void equipGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;"
+ "uid=root;"
+ "pwd=root;"
+ "SslMode=none;"
+ "database=tribes_system";

            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {

                    /*var a = new ViewUI();
                    sendtext = equipGrid.Rows[e.RowIndex].Cells[2].Value.ToString();

                    a.Show(); */

                }
                if (e.ColumnIndex == 1)
                {
                    conn.ConnectionString = myConnectionString;
                    conn.Open();
                    using (MySqlConnection con = new MySqlConnection(myConnectionString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM items WHERE id =" + equipGrid.Rows[e.RowIndex].Cells[2].Value.ToString(), conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            if (cmd.ExecuteNonQuery() > 0)
                            {



                                using (MySqlConnection con1 = new MySqlConnection(myConnectionString))
                                {
                                    using (MySql.Data.MySqlClient.MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks FROM items ", conn))
                                    {
                                        cmd1.CommandType = CommandType.Text;
                                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd1))
                                        {
                                            using (DataTable dt = new DataTable())
                                            {
                                                sda.Fill(dt);
                                                equipGrid.DataSource = dt;
                                                equipGrid.ReadOnly = false;
                                                equipGrid.ClearSelection();
                                                equipGrid.Columns[2].Visible = false;
                                                equipGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                equipGrid.Columns[3].HeaderCell.Value = "Name";
                                                equipGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                equipGrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                equipGrid.Columns[4].HeaderCell.Value = "Stocks";
                                                equipGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                equipGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                equipGrid.Columns[1].HeaderCell.Value = "";
                                                equipGrid.Columns[1].Width = 50;
                                                equipGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                equipGrid.Columns[0].HeaderCell.Value = "";
                                                equipGrid.Columns[0].Width = 50;
                                                equipGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                                equipGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                                MessageBox.Show("Data Deleted!", "Successful ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    conn.Close();

                }
            }
        }

        public void refreshni()
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;"
+ "uid=root;"
+ "pwd=root;"
+ "SslMode=none;"
+ "database=tribes_system"; 
            /*var a = new EquipmentUI();
            equipGrid.DefaultCellStyle.SelectionBackColor = equipGrid.DefaultCellStyle.BackColor;
            equipGrid.DefaultCellStyle.SelectionForeColor = equipGrid.DefaultCellStyle.ForeColor; */
            conn.ConnectionString = myConnectionString;
            conn.Open();
            using (MySqlConnection con = new MySqlConnection(myConnectionString))
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks FROM items ", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            equipGrid.DataSource = dt;
                            equipGrid.ReadOnly = false;
                            equipGrid.ClearSelection();
                            equipGrid.Columns[2].Visible = false;
                            equipGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            equipGrid.Columns[3].HeaderCell.Value = "Name";
                            equipGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            equipGrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            equipGrid.Columns[4].HeaderCell.Value = "Stock";
                            equipGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            equipGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            equipGrid.Columns[1].HeaderCell.Value = "";
                            equipGrid.Columns[1].Width = 50;
                            equipGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            equipGrid.Columns[0].HeaderCell.Value = "";
                            equipGrid.Columns[0].Width = 50;
                            equipGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            equipGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }
                }
            }
        }
    }
}
