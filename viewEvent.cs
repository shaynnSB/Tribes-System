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
    public partial class viewEvent : Form
    {

        private bool drag = false;
        private Point startPoint = new Point(0, 0);

        public viewEvent()
        {
            InitializeComponent();
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editEvent form = new editEvent();
            form.ShowDialog();
        }

        private void viewEvent_MouseMove(object sender, MouseEventArgs e)
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

        private void viewEvent_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void viewEvent_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
        }
    }
}
