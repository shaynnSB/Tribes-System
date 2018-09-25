﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tribes_System
{
    public partial class equipButt : Form
    {
        int PW;
        bool hidden;
        private bool drag = false;
        private Point startPoint = new Point(0, 0);
        string access; // use this to access account type
        int empid;

        public equipButt(string access, int empid = 0)
        {
            InitializeComponent();
            PW = panelMenu.Width;
            hidden = false;
            this.access = access;
            this.empid = empid;
            if (access.Equals("employee"))
            {
                panelMenu.Visible = false;
                menuIcon.Visible = false;
                //employeeView1.Visible = true;
                employeeView uc = new employeeView(empid.ToString());
                uc.Location = new Point(67, 51);
                this.Controls.Add(uc);
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
            editAccounts1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employeeTab.Visible = true;
            financesUI1.Visible = false;
            payrollUI1.Visible = false;
            eventSched1.Visible = false;
            equipment1.Visible = false;
            editAccounts1.Visible = false;
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

        private void empButt_Click(object sender, EventArgs e)
        {
            timer.Start();

            employeeTab.Visible = true;
            financesUI1.Visible = false;
            payrollUI1.Visible = false;
            eventSched1.Visible = false;
            equipment1.Visible = false;
            editAccounts1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Start();

            employeeTab.Visible = false;
            financesUI1.Visible = false;
            payrollUI1.Visible = false;
            eventSched1.Visible = false;
            equipment1.Visible = true;
            editAccounts1.Visible = false;
        }

        private void eventButt_Click(object sender, EventArgs e)
        {
            timer.Start();

            employeeTab.Visible = false;
            financesUI1.Visible = false;
            payrollUI1.Visible = false;
            eventSched1.Visible = true;
            equipment1.Visible = false;
            editAccounts1.Visible = false;
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
            editAccounts1.Visible = false;
            equipment1.Visible = false;
        }

        private void payButt_Click(object sender, EventArgs e)
        {
            timer.Start();

            payrollUI1.Visible = true;
            financesUI1.Visible = false;
            employeeTab.Visible = false;
            eventSched1.Visible = false;
            equipment1.Visible = false;
            editAccounts1.Visible = false;

        }

        private void profButt_Click(object sender, EventArgs e)
        {
            editAccounts1.Visible = true;
            payrollUI1.Visible = false;
            financesUI1.Visible = false;
            employeeTab.Visible = false;
            eventSched1.Visible = false;
            equipment1.Visible = false;
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
        }

        private void payIcon_Click(object sender, EventArgs e)
        {
            payrollUI1.Visible = true;
            financesUI1.Visible = false;
            employeeTab.Visible = false;
            eventSched1.Visible = false;
            equipment1.Visible = false;
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
        }

        private void payrollUI1_Load(object sender, EventArgs e)
        {

        }
    }
}
