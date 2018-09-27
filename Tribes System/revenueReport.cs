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
using System.Drawing;
using System.Drawing.Printing;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;

namespace Tribes_System
{
    public partial class revenueReport : Form
    {
        PrintDocument printdoc1 = new PrintDocument();
        PrintPreviewDialog previewdlg = new PrintPreviewDialog();
        Panel pannel = null;

        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");
        MySqlCommand cmd;

        string stamp = DateTime.Now.ToString();

        string sMonth = DateTime.Now.ToString("MM");
        string sYear = DateTime.Now.ToString("yyyy");

        string m = DateTime.Now.ToString("MM");
        string y = DateTime.Now.ToString("yyyy");

        public revenueReport()
        {
            InitializeComponent();
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minButt_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void revenueReport_Load(object sender, EventArgs e)
        {
            addYear();
            assignMonth();
            changeAnnYear();
            myearBox.Text = sYear;
            qyearBox.Text = sYear;
            ayearBox.Text = sYear;
            changeQuartYear();
            changeQuarter();            
            fillMonth();
            fillQuarter();
            fillYear();

            timestampM.Text = stamp;
            timestampQ.Text = stamp;
            timestampY.Text = stamp;

            printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
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

        private void addYear()
        {
            for (int i = 0; i < 80; i++)
            {
                int num = 2018 + i;
                myearBox.Items.Add(num);
                qyearBox.Items.Add(num);
                ayearBox.Items.Add(num);
            }
        }

        //-----------------For Monthly Calculations------------------------------------

        private void yearChange()
        {
            sYear = myearBox.Text;
        }

        private void monthChange()
        {
            if (mmonthBox.Text == "January")
            {
                sMonth = "01";
            }
            else if (mmonthBox.Text == "February")
            {
                sMonth = "02";
            }
            else if (mmonthBox.Text == "March")
            {
                sMonth = "03";
            }
            else if (mmonthBox.Text == "April")
            {
                sMonth = "04";
            }
            else if (mmonthBox.Text == "May")
            {
                sMonth = "05";
            }
            else if (mmonthBox.Text == "June")
            {
                sMonth = "06";
            }
            else if (mmonthBox.Text == "July")
            {
                sMonth = "07";
            }
            else if (mmonthBox.Text == "August")
            {
                sMonth = "08";
            }
            else if (mmonthBox.Text == "September")
            {
                sMonth = "09";
            }
            else if (mmonthBox.Text == "October")
            {
                sMonth = "10";
            }
            else if (mmonthBox.Text == "November")
            {
                sMonth = "11";
            }
            else if (mmonthBox.Text == "December")
            {
                sMonth = "12";
            }
        }

        string amM;

        private void calAmMonth()
        {
            string selectQuery = "select SUM(prices) from event where substring(start_date, 6,2) = '" + sMonth + "' AND substring(start_date, 1,4) = '" + sYear + "' AND event_status <> 'Cancelled'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                amM = reader["SUM(prices)"].ToString();
                amMonth.Text = amM;
            }
            closeConnection();
        }

        string feeM;

        private void calFeeMonth()
        {
            string selectQuery = "select SUM(fee_amount) from event, additional_fees where id_event = event_id AND substring(start_date, 6,2) = '" + sMonth + 
                "' AND substring(start_date, 1,4) = '" + sYear + "' AND event_status <> 'Cancelled'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                feeM = reader["SUM(fee_amount)"].ToString();
                feeMonth.Text = feeM;
            }
            closeConnection();
        }

        string discM;

        private void calDiscMonth()
        {
            string selectQuery = "select SUM(disc_amount) from event, discount where id_event = event_id AND substring(start_date, 6,2) = '" + sMonth +
                "' AND substring(start_date, 1,4) = '" + sYear + "' AND event_status <> 'Cancelled'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                discM = reader["SUM(disc_amount)"].ToString(); 
                discMonth.Text = "(" + discM + ")";
            }
            closeConnection();
        }

        string totM;

        private void calcTotMonth()
        {
            double price;
            double fee;
            double disc;

            if (amM == "" || amM == "--")
            {
                price = 0;
            }
            else
            {
                price = Convert.ToDouble(amM);
            }

            if (feeM == "" || feeM == "0")
            {
                fee = 0;
            }
            else
            {
                fee = Convert.ToDouble(feeM);
            }

            if (discM == "" || discM == "--")
            {
                disc = 0;
            }
            else
            {
                disc = Convert.ToDouble(discM);
            }
           

            double total = (price + fee) - disc;
            
            totM = Convert.ToString(total) + ".00";
            totMonth.Text = totM;
        }

        private void fillMonth()
        {
            monthLabel.Text = mmonthBox.Text + " - " + myearBox.Text;
            calAmMonth();
            calFeeMonth();
            calDiscMonth();
            calcTotMonth();
        }

        private void mmonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthChange();
            int nextm = Convert.ToInt32(sMonth);
            int formerm = Convert.ToInt32(m);
            int nexty = Convert.ToInt32(sYear);
            int formery = Convert.ToInt32(y);

            if ((nextm > formerm) && (nexty == formery))
            {
                sMonth = m;
                assignMonth();
                MessageBox.Show("Details Are Not Yet Available!");
            }
            else
            {
                fillMonth();
            }
        }

        private void myearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearChange();
            int nexty = Convert.ToInt32(sYear);
            int formery = Convert.ToInt32(y);

            if (nexty > formery)
            {
                sYear = y;
                myearBox.Text = sYear;
                MessageBox.Show("Details Are Not Yet Available!");
            }
            else
            {
                fillMonth();
            }
        }

        //-----------------For Quarterly Calculations------------------------------------
        int q;
        private void assignMonth()
        {
            if (sMonth == "01")
            {
                mmonthBox.Text = "January";
                qmonthBox.Text = "First Quarter";
                q = 3;
            }
            else if (sMonth == "02")
            {
                mmonthBox.Text = "February";
                qmonthBox.Text = "First Quarter";
                q = 3;
            }
            else if (sMonth == "03")
            {
                mmonthBox.Text = "March";
                qmonthBox.Text = "First Quarter";
                q = 3;
            }
            else if (sMonth == "04")
            {
                mmonthBox.Text = "April";
                qmonthBox.Text = "Second Quarter";
                q = 6;
            }
            else if (sMonth == "05")
            {
                mmonthBox.Text = "May";
                qmonthBox.Text = "Second Quarter";
                q = 6;
            }
            else if (sMonth == "06")
            {
                mmonthBox.Text = "June";
                qmonthBox.Text = "Second Quarter";
                q = 6;
            }
            else if (sMonth == "07")
            {
                mmonthBox.Text = "July";
                qmonthBox.Text = "Third Quarter";
                q = 9;
            }
            else if (sMonth == "08")
            {
                mmonthBox.Text = "August";
                qmonthBox.Text = "Third Quarter";
                q = 9;
            }
            else if (sMonth == "09")
            {
                mmonthBox.Text = "September";
                qmonthBox.Text = "Third Quarter";
                q = 9;
            }
            else if (sMonth == "10")
            {
                mmonthBox.Text = "October";
                qmonthBox.Text = "Fourth Quarter";
                q = 12;
            }
            else if (sMonth == "11")
            {
                mmonthBox.Text = "November";
                qmonthBox.Text = "Fourth Quarter";
                q = 12;
            }
            else if (sMonth == "12")
            {
                mmonthBox.Text = "December";
                qmonthBox.Text = "Fourth Quarter";
                q = 12;
            }
        }

        string first = "(substring(start_date, 6,2) = '01' OR substring(start_date, 6,2) = '02' OR substring(start_date, 6,2) = '03')";
        string second = "(substring(start_date, 6,2) = '04' OR substring(start_date, 6,2) = '05' OR substring(start_date, 6,2) = '06')";
        string third = "(substring(start_date, 6,2) = '07' OR substring(start_date, 6,2) = '08' OR substring(start_date, 6,2) = '09')";
        string fourth = "(substring(start_date, 6,2) = '10' OR substring(start_date, 6,2) = '11' OR substring(start_date, 6,2) = '12')";

        string quarter;
        int newq;
        private void changeQuarter()
        {
            if (qmonthBox.Text == "First Quarter")
            {
                quarter = first;
                newq = 3;
            }
            else if (qmonthBox.Text == "Second Quarter")
            {
                quarter = second;
                newq = 6;
            }
            else if (qmonthBox.Text == "Third Quarter")
            {
                quarter = third;
                newq = 9;
            }
            else if (qmonthBox.Text == "Fourth Quarter")
            {
                quarter = fourth;
                newq = 12;
            }
        }

        string qYear;

        private void changeQuartYear()
        {
            qYear = qyearBox.Text;
        }

        string amQ;

        private void calAmQuart()
        {
            string selectQuery = "select SUM(prices) from event where substring(start_date, 1,4) = '" + qYear + "' AND event_status <> 'Cancelled' AND " + quarter;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                amQ = reader["SUM(prices)"].ToString();
                amQuart.Text = amQ;
            }
            closeConnection();
        }

        string feeQ;

        private void calFeeQuart()
        {
            string selectQuery = "select SUM(fee_amount) from event, additional_fees where id_event = event_id " +
                "AND substring(start_date, 1,4) = '" + qYear + "' AND event_status <> 'Cancelled' AND " + quarter;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                feeQ = reader["SUM(fee_amount)"].ToString();
                feeQuart.Text = feeQ;
            }
            closeConnection();
        }

        string discQ;

        private void calDiscQuart()
        {
            string selectQuery = "select SUM(disc_amount) from event, discount where id_event = event_id " +
                "AND substring(start_date, 1,4) = '" + qYear + "' AND event_status <> 'Cancelled' AND " + quarter ;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                discQ = reader["SUM(disc_amount)"].ToString();
                discQuart.Text = "(" + discQ + ")";
            }
            closeConnection();
        }

        string totQ;

        private void calcTotQuart()
        {
            double price;
            double fee;
            double disc;

            if (amQ == "" || amQ == "--")
            {
                price = 0;
            }
            else
            {
                price = Convert.ToDouble(amQ);
            }

            if (feeQ == "" || feeQ == "0")
            {
                fee = 0;
            }
            else
            {
                fee = Convert.ToDouble(feeQ);
            }

            if (discQ == "" || discQ == "--")
            {
                disc = 0;
            }
            else
            {
                disc = Convert.ToDouble(discQ);
            }


            double total = (price + fee) - disc;

            totQ = Convert.ToString(total) + ".00";
            totQuart.Text = totQ;
        }

        private void fillQuarter()
        {
            quarterLabel.Text = qmonthBox.Text + " - " + qyearBox.Text;
            calAmQuart();
            calFeeQuart();
            calDiscQuart();
            calcTotQuart();
        }

        private void qmonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeQuarter();

            int nexty = Convert.ToInt32(qYear);
            int formery = Convert.ToInt32(y);

            if ((newq > q) && (nexty == formery))
            {
                sMonth = m;
                assignMonth();
                MessageBox.Show("Details Are Not Yet Available!");
            }
            else
            {
                fillQuarter();
            }
        }

        private void qyearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeQuartYear();

            int nexty = Convert.ToInt32(qYear);
            int formery = Convert.ToInt32(y);

            if (nexty > formery)
            {
                qYear = y;
                qyearBox.Text = qYear;
                MessageBox.Show("Details Are Not Yet Available!");
            }
            else
            {
                fillQuarter();
            }
        }

        //-----------------For Yearly Calculations------------------------------------

        string aYear;

        private void changeAnnYear()
        {
            aYear = ayearBox.Text;
        }

        private void fillYear()
        {
            yearLabel.Text = "Year " + ayearBox.Text;
            calAmYear();
            calFeeYear();
            calDiscYear();
            calcTotYear();
        }

        string amY;

        private void calAmYear()
        {
            string selectQuery = "select SUM(prices) from event where substring(start_date, 1,4) = '" + aYear + "' AND event_status <> 'Cancelled'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                amY = reader["SUM(prices)"].ToString();
                amYear.Text = amY;
            }
            closeConnection();
        }

        string feeY;

        private void calFeeYear()
        {
            string selectQuery = "select SUM(fee_amount) from event, additional_fees where id_event = event_id " +
                "AND substring(start_date, 1,4) = '" + aYear + "' AND event_status <> 'Cancelled'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                feeY = reader["SUM(fee_amount)"].ToString();
                feeYear.Text = feeY;
            }
            closeConnection();
        }

        string discY;

        private void calDiscYear()
        {
            string selectQuery = "select SUM(disc_amount) from event, discount where id_event = event_id " +
                "AND substring(start_date, 1,4) = '" + aYear + "' AND event_status <> 'Cancelled'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                discY = reader["SUM(disc_amount)"].ToString();
                discYear.Text = "(" + discY + ")";
            }
            closeConnection();
        }

        string totY;

        private void calcTotYear()
        {
            double price;
            double fee;
            double disc;

            if (amY == "" || amY == "--")
            {
                price = 0;
            }
            else
            {
                price = Convert.ToDouble(amY);
            }

            if (feeY == "" || feeY == "0")
            {
                fee = 0;
            }
            else
            {
                fee = Convert.ToDouble(feeY);
            }

            if (discY == "" || discY == "--")
            {
                disc = 0;
            }
            else
            {
                disc = Convert.ToDouble(discY);
            }

            double total = (price + fee) - disc;

            totY = Convert.ToString(total) + ".00";
            totYear.Text = totY;
        }

        private void ayearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeAnnYear();

            int nexty = Convert.ToInt32(aYear);
            int formery = Convert.ToInt32(y);

            if (nexty > formery)
            {
                aYear = y;
                ayearBox.Text = aYear;
                MessageBox.Show("Details Are Not Yet Available!");
            }
            else
            {
                fillYear();
            }
        }

        //--------------Print------------------------

        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            Rectangle rect = new Rectangle(0, 0, pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }
        private void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (pannel.Width / 2), pannel.Location.Y);
        }

        public void Print(Panel pnl)
        {
            pannel = pnl;
            GetPrintArea(pnl);
            previewdlg.Document = printdoc1;
            previewdlg.ShowDialog();
        }

        private void printMonth_Click(object sender, EventArgs e)
        {
            timestampM.Visible = true;
            Print(this.monthPanel);
            timestampM.Visible = false;
        }

        private void printQuart_Click(object sender, EventArgs e)
        {
            timestampQ.Visible = true;
            Print(this.quartPanel);
            timestampQ.Visible = false;
        }

        private void printYear_Click(object sender, EventArgs e)
        {
            timestampY.Visible = true;
            Print(this.yearPanel);
            timestampY.Visible = false;
        }
    }
}
