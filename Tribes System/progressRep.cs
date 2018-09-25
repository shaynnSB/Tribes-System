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
    public partial class progressRep : Form
    {
        string sYear = DateTime.Now.ToString("yyyy");
        string y = DateTime.Now.ToString("yyyy");

        public progressRep()
        {
            InitializeComponent();
        }

        private void addYear()
        {
            for (int i = 0; i < 80; i++)
            {
                int num = 2018 + i;
                yearBox.Items.Add(num);       
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

        private void progressRep_Load(object sender, EventArgs e)
        {
            addYear();
            yearBox.Text = y;
            yearChange();
        }

        private void yearChange()
        {
            sYear = yearBox.Text;
        }

        private void yearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearChange();
            int nexty = Convert.ToInt32(sYear);
            int formery = Convert.ToInt32(y);

            if (nexty > formery)
            {
                sYear = y;
                yearBox.Text = sYear;
                MessageBox.Show("Details Are Not Yet Available!");
            }
            else
            {
                //fillMonth();
            }
        }
    }
}
