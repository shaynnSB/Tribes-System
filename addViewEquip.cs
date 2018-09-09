using System;
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
    public partial class addViewEquip : Form
    {
        private bool drag = false;
        private Point startPoint = new Point(0, 0);
        eventSched form = new eventSched();

        public addViewEquip(eventSched form)
        {
            InitializeComponent();
            this.form = form;
        }

        public string eventName
        {
            get { return eventLabel.Text; }
            set { eventLabel.Text = value; }
        }

        string idPassed;

        public string idValue
        {
            get { return this.idPassed; }
            set { this.idPassed = value; }
        }

        private void confirmButt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirm changes in list of equipment?", "List of Equipmet", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //string editQuery = "UPDATE event SET event_name = ,event_location = , event_notes = , start_date = , end_date = , start_time = , 
                //end_time = , client_name = , client_contact = WHERE id_event = " + idValue;
                //executeMyQuery(editQuery);
            }
            else if (dialogResult == DialogResult.No)
            {
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

        private void customButt_Click(object sender, EventArgs e)
        {
            customPack form = new customPack();
            form.ShowDialog();
        }

        private void amRevLabel_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
