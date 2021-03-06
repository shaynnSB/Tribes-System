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
    public partial class addViewEquip : Form
    {
        private bool drag = false;
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");
        //MySqlCommand adapter;
        MySqlCommand cmd;
        private Point startPoint = new Point(0, 0);
        eventSched form = new eventSched();
        MySqlCommand adapter;
        public addViewEquip(eventSched form)
        {
            InitializeComponent();
            this.form = form;
            snl.Enabled = false;
            lvw.Enabled = false;
            stg.Enabled = false;
            vcs.Enabled = false;
            msc.Enabled = false;
            refresh("select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where eventID = " + eventSched.id);
            setTextform("select event.prices,event.soundAndLights,event.ledVideoWall,event.miscellaneous,event.staging,event.videoCameraServices from event where event.id_event = " + eventSched.id);
        }

        
        public string eventName
        {
            get { return eventLabel.Text; }
            set { eventLabel.Text = value; }
        }
        public void checker()
        {
            int rowCount1 = assignedGrid.Rows.Count;
            if (rowCount1 > 0)
            {
                var a = new eventSched();
                button1.Visible = true;
            }
        }
        string idPassed;

        public string idValue
        {
            get { return this.idPassed; }
            set { this.idPassed = value; }
        }

        public void refresh(string query = "select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID;")
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);
            assignedGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            assignedGrid.Columns.Clear();
            assignedGrid.DataSource = table;
            assignedGrid.Columns[0].Visible = false;
            assignedGrid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            assignedGrid.Columns[1].HeaderCell.Value = "Model Number / Name";
            assignedGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            assignedGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            assignedGrid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            assignedGrid.Columns[2].HeaderCell.Value = "Equipment Name";
            assignedGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            assignedGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            assignedGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            assignedGrid.Columns[3].HeaderCell.Value = "Category";
            assignedGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            assignedGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            assignedGrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            assignedGrid.Columns[4].HeaderCell.Value = "Status";
            assignedGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            assignedGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            count = assignedGrid.Rows.Count;
        }

       
        private void confirmButt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm changes in list of equipment?", "List of Equipment", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //string editQuery = "UPDATE event SET event_name = ,event_location = , event_notes = , start_date = , end_date = , start_time = , 
                //end_time = , client_name = , client_contact = WHERE id_event = " + idValue;
                //executeMyQuery(editQuery);
                //Bind datagridview to linq 
                string soundNlights;
                string ledvideowall;
                string miscellaneous;
                string staging;
                string videoCameraServices;
                if(snl.Text == "")
                {
                    soundNlights = "0";
                }
                else
                {
                    soundNlights = snl.Text;
                }
                if (lvw.Text == "")
                {
                    ledvideowall = "0";
                }
                else
                {
                    ledvideowall = lvw.Text;
                }
                if (stg.Text == "")
                {
                    staging = "0";
                }
                else
                {
                    staging = stg.Text;
                }
                if (vcs.Text == "")
                {
                    videoCameraServices = "0";
                }
                else
                {
                    videoCameraServices = vcs.Text;
                }
                if (msc.Text == "")
                {
                    miscellaneous = "0";
                }
                else
                {
                    miscellaneous = msc.Text;
                }
                rowCount1 = listEmpGrid.Rows.Count;
                //loop dg1 and save it to datagridview2
                for (var i = 0; i < rowCount1; i++)
                {
                 
                    string insertQuery = "UPDATE itemcontent SET eventID='" + eventSched.id + "' where  id=" + listEmpGrid.Rows[i].Cells[0].Value.ToString();
 
                    executeMyQuery(insertQuery);
                }
                MessageBox.Show("Success");
                while (listEmpGrid.Rows.Count > 0)
                {
                    listEmpGrid.Rows.RemoveAt(0);
                }
                refresh("select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where eventID = " + eventSched.id);
                string insertQuery1 = "UPDATE event SET prices='" + total.Text + "', soundAndLights='" + soundNlights + "', ledVideoWall='" + ledvideowall + "', miscellaneous='" + miscellaneous + "', staging='" + staging + "', videoCameraServices='" + videoCameraServices + "' where  event.id_event=" + eventSched.id;
                executeMyQuery(insertQuery1);
            }
            else if (dialogResult == DialogResult.No)
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

        private void closeButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minButt_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        public static int[] test;
        public static int rowCount1;
        private void customButt_Click(object sender, EventArgs e)
        {
            rowCount1 = listEmpGrid.Rows.Count;
            int i = 0;
            test = new int[rowCount1];
            if (rowCount1 > 0)
            {
                for (i = 0; i < rowCount1; i++)
                {          
                    test[i] = int.Parse(listEmpGrid.Rows[i].Cells[0].Value.ToString());
                }
            }

            customPack form = new customPack();
            form.ShowDialog();
        }
        public static int count;

        private void removeButt_Click(object sender, EventArgs e)
        {
            int rowCount1 = assignedGrid.Rows.Count;
            count =assignedGrid.Rows.Count;
            if (rowCount1 > 0)
            {
                string insertQuery1 = "UPDATE itemcontent SET eventID='0' where  eventID=" + eventSched.id+" and itemcontent.id = "+assignedGrid.Rows[assignedGrid.SelectedRows[0].Index].Cells[0].Value.ToString();
                executeMyQuery(insertQuery1);
                refresh("select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where eventID = " + eventSched.id);
        
            }
            else
            {
                MessageBox.Show("Nothing is selected");
            }
           
        }

        private void addViewEquip_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowCount = assignedGrid.Rows.Count;
            //loop dg1 and save it to datagridview2
            if (rowCount > 0)
            {
                for (var i = 0; i < rowCount; i++)
                {
                    //listEmpGrid.Rows.Add();
                    string insertQuery = "UPDATE itemcontent SET eventID='0' where  id=" + assignedGrid.Rows[i].Cells[0].Value.ToString();
                    executeMyQuery(insertQuery);
                }

                while (listEmpGrid.Rows.Count > 0)
                {
                    listEmpGrid.Rows.RemoveAt(0);
                }
                MessageBox.Show("Success");
                refresh("select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where eventID = " + eventSched.id);
            }
            else
            {
                MessageBox.Show("Nothing is selected");
            }
        }

  

        private void snl_TextChanged(object sender, EventArgs e)
        {
            int lvw1 = 0;
            int snl1 = 0;
            int vcs1 = 0;
            int msc1 = 0;
            int stg1 = 0;
            if (lvw.Text == "")
            {
                lvw1 = 0;
            }
            else
            {
                lvw1 = int.Parse(Convert.ToInt64(Convert.ToDouble(lvw.Text)).ToString()); ;

            }
            if (snl.Text == "")
            {
                snl1 = 0;
            }
            else
            {
                snl1 =  int.Parse(Convert.ToInt64(Convert.ToDouble(snl.Text)).ToString());
            }

            if (vcs.Text == "")
            {
                vcs1 = 0;
            }
            else
            {
                vcs1 = int.Parse(Convert.ToInt64(Convert.ToDouble(vcs.Text)).ToString()); ;
            }
            if (msc.Text == "")
            {
                msc1 = 0;
            }
            else
            {
                msc1 = int.Parse(Convert.ToInt64(Convert.ToDouble(msc.Text)).ToString()); ;
            }
            if (stg.Text == "")
            {
                stg1 = 0;
            }
            else
            {
                stg1 = int.Parse(Convert.ToInt64(Convert.ToDouble(stg.Text)).ToString()); ;
            }
            int a = lvw1 + snl1 + vcs1 + msc1 + stg1;
            total.Text = a.ToString();
        }

        private void lvw_TextChanged(object sender, EventArgs e)
        {
            int lvw1 = 0;
            int snl1 = 0;
            int vcs1 = 0;
            int msc1 = 0;
            int stg1 = 0;
            if (lvw.Text == "")
            {
                lvw1 = 0;
            }
            else
            {
                lvw1 = int.Parse(Convert.ToInt64(Convert.ToDouble(lvw.Text)).ToString());
            }
            if (snl.Text == "")
            {
                snl1 = 0;
            }
            else
            {
                snl1 = int.Parse(Convert.ToInt64(Convert.ToDouble(snl.Text)).ToString());
            }

            if (vcs.Text == "")
            {
                vcs1 = 0;
            }
            else
            {
                vcs1 = int.Parse(Convert.ToInt64(Convert.ToDouble(vcs.Text)).ToString());
            }
            if (msc.Text == "")
            {
                msc1 = 0;
            }
            else
            {
                msc1 = int.Parse(Convert.ToInt64(Convert.ToDouble(msc.Text)).ToString());
            }
            if (stg.Text == "")
            {
                stg1 = 0;
            }
            else
            {
                stg1 = int.Parse(Convert.ToInt64(Convert.ToDouble(stg.Text)).ToString());
            }
            int a = lvw1 + snl1 + vcs1 + msc1 + stg1;
            total.Text = a.ToString();
        }

        private void vcs_TextChanged(object sender, EventArgs e)
        {
            int lvw1 = 0;
            int snl1 = 0;
            int vcs1 = 0;
            int msc1 = 0;
            int stg1 = 0;
            if (lvw.Text == "")
            {
                lvw1 = 0;
            }
            else
            {
                lvw1 = int.Parse(Convert.ToInt64(Convert.ToDouble(lvw.Text)).ToString());
            }
            if (snl.Text == "")
            {
                snl1 = 0;
            }
            else
            {
                snl1 = int.Parse(Convert.ToInt64(Convert.ToDouble(snl.Text)).ToString());
            }

            if (vcs.Text == "")
            {
                vcs1 = 0;
            }
            else
            {
                vcs1 = int.Parse(Convert.ToInt64(Convert.ToDouble(vcs.Text)).ToString());
            }
            if (msc.Text == "")
            {
                msc1 = 0;
            }
            else
            {
                msc1 = int.Parse(Convert.ToInt64(Convert.ToDouble(msc.Text)).ToString());
            }
            if (stg.Text == "")
            {
                stg1 = 0;
            }
            else
            {
                stg1 = int.Parse(Convert.ToInt64(Convert.ToDouble(stg.Text)).ToString());
            }
            int a = lvw1 + snl1 + vcs1 + msc1 + stg1;
            total.Text = a.ToString();
        }

        private void msc_TextChanged(object sender, EventArgs e)
        {
            int lvw1 = 0;
            int stg1= 0;
            int snl1 = 0;
            int vcs1 = 0;
            int msc1 = 0;

            if (lvw.Text == "")
            {
                lvw1 = 0;
            }
            else
            {
                lvw1 = int.Parse(Convert.ToInt64(Convert.ToDouble(lvw.Text)).ToString());
            }
            if (snl.Text == "")
            {
                snl1 = 0;
            }
            else
            {
                snl1 = int.Parse(Convert.ToInt64(Convert.ToDouble(snl.Text)).ToString());
            }

            if (vcs.Text == "")
            {
                vcs1 = 0;
            }
            else
            {
                vcs1 = int.Parse(Convert.ToInt64(Convert.ToDouble(vcs.Text)).ToString());
            }
            if (msc.Text == "")
            {
                msc1 = 0;
            }
            else
            {
                msc1 = int.Parse(Convert.ToInt64(Convert.ToDouble(msc.Text)).ToString());
            }
            if (stg.Text == "")
            {
                stg1 = 0;
            }
            else
            {
                stg1 = int.Parse(Convert.ToInt64(Convert.ToDouble(stg.Text)).ToString());
            }
            int a = lvw1 + snl1 + vcs1 + msc1+stg1;
            total.Text = a.ToString();
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

        private void snl_KeyPress(object sender, KeyPressEventArgs e)
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

        private void lvw_KeyPress(object sender, KeyPressEventArgs e)
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

        private void stg_KeyPress(object sender, KeyPressEventArgs e)
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

        private void vcs_KeyPress(object sender, KeyPressEventArgs e)
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

        private void msc_KeyPress(object sender, KeyPressEventArgs e)
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

     
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (tabControl1.SelectedIndex == 1)
            {
                snl.Enabled = true;
                lvw.Enabled = true;
                stg.Enabled = true;
                vcs.Enabled = true;
                msc.Enabled = true;
            }
            else
            {
                
                snl.Enabled = false;
                lvw.Enabled = false;
                stg.Enabled = false;
                vcs.Enabled = false;
                msc.Enabled = false;
               
            }
        }

        private void stg_TextChanged(object sender, EventArgs e)
        {
            int lvw1 = 0;
            int snl1 = 0;
            int vcs1 = 0;
            int msc1 = 0;
            int stg1 = 0;
            if (lvw.Text == "")
            {
                lvw1 = 0;
            }
            else
            {
                lvw1 = int.Parse(Convert.ToInt64(Convert.ToDouble(lvw.Text)).ToString());
            }
            if (snl.Text == "")
            {
                snl1 = 0;
            }
            else
            {
                snl1 = int.Parse(Convert.ToInt64(Convert.ToDouble(snl.Text)).ToString());
            }

            if (vcs.Text == "")
            {
                vcs1 = 0;
            }
            else
            {
                vcs1 = int.Parse(Convert.ToInt64(Convert.ToDouble(vcs.Text)).ToString());
            }
            if (msc.Text == "")
            {
                msc1 = 0;
            }
            else
            {
                msc1 = int.Parse(Convert.ToInt64(Convert.ToDouble(msc.Text)).ToString());
            }
            if (stg.Text == "")
            {
                stg1 = 0;
            }
            else
            {
                stg1 = int.Parse(Convert.ToInt64(Convert.ToDouble(stg.Text)).ToString());
            }
            int a = lvw1 + snl1 + vcs1 + msc1 + stg1;
            total.Text = a.ToString();
        }
        public void setTextform(string query)
        {
            openConnection();
            adapter = new MySqlCommand(query, con);
            MySqlDataReader myreader = adapter.ExecuteReader();
            if (myreader.Read())
            {
                total.Text = myreader.GetValue(0).ToString();
                snl.Text = myreader.GetValue(1).ToString();
                lvw.Text = myreader.GetValue(2).ToString();
                msc.Text = myreader.GetValue(3).ToString();
                stg.Text = myreader.GetValue(4).ToString();
                vcs.Text = myreader.GetValue(5).ToString();
            }
            myreader.Close();
            closeConnection();
        }

        private void title_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
