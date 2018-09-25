using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tribes_System
{
    public partial class financesUI : UserControl
    {
        public financesUI()
        {
            InitializeComponent();
        }

        private void salaryButt_Click(object sender, EventArgs e)
        {
            salaryReport form = new salaryReport();
            form.ShowDialog();
        }

        private void expButt_Click(object sender, EventArgs e)
        {
            expenseReport form = new expenseReport();
            form.ShowDialog();
        }

        private void revButt_Click(object sender, EventArgs e)
        {
            revenueReport form = new revenueReport();
            form.ShowDialog();
        }

        private void incButt_Click(object sender, EventArgs e)
        {
            incomeStatement form = new incomeStatement();
            form.ShowDialog();
        }

        private void chartButt_Click(object sender, EventArgs e)
        {
            progressRep form = new progressRep();
            form.ShowDialog();
        }
    }
}
