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
    public partial class expenseReport : Form
    {
        PrintDocument printdoc1 = new PrintDocument();
        PrintPreviewDialog previewdlg = new PrintPreviewDialog();
        Panel pannel = null;
        
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");
        MySqlCommand cmd;

        string sMonth = DateTime.Now.ToString("MM");
        string sYear = DateTime.Now.ToString("yyyy");

        public expenseReport()
        {
            InitializeComponent();
        }

        private void expenseReport_Load(object sender, EventArgs e)
        {
            addYear();
            assignMonth();
            myearBox.Text = sYear;
            qyearBox.Text = sYear;
            ayearBox.Text = sYear;
            changeQuarter();
            changeQuartYear();
            changeAnnYear();
            fillMonth();
            fillQuarter();
            fillYear();

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

        private void closeButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minButt_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //-----------------For Monthly Calculations------------------------------------

        private void totExpMonth()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND substring(start_date, 6,2) = '" + sMonth
                + "' AND substring(start_date, 1,4) = '" + sYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                totMonth.Text = reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        private void myearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearChange();
            fillMonth();
        }

        private void mmonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthChange();
            fillMonth();
        }

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

        private void fillMonth()
        {
            monthLabel.Text = mmonthBox.Text + " - " + myearBox.Text;
            calcFoodMonth();
            calcFuelMonth();
            calcTranslMonth();
            calcMisclMonth();
            totExpMonth();
        }

        private void calcFoodMonth()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND exp_name = 'Food/Snacks' " +
                "AND substring(start_date, 6,2) = '" + sMonth + "' AND substring(start_date, 1,4) = '" + sYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                foodMonth.Text = reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        private void calcFuelMonth()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND exp_name = 'Fuel' " +
                "AND substring(start_date, 6,2) = '" + sMonth + "' AND substring(start_date, 1,4) = '" + sYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                fuelMonth.Text = reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        private void calcTranslMonth()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND exp_name = 'Transportation' " +
                "AND substring(start_date, 6,2) = '" + sMonth + "' AND substring(start_date, 1,4) = '" + sYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                transMonth.Text = reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        private void calcMisclMonth()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND exp_name = 'Miscellaneous' " +
                "AND substring(start_date, 6,2) = '" + sMonth + "' AND substring(start_date, 1,4) = '" + sYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                miscMonth.Text = reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        //-----------------For Quarterly Calculations------------------------------------

        private void assignMonth()
        {
            if (sMonth == "01")
            {
                mmonthBox.Text = "January";
                qmonthBox.Text = "First Quarter";
            }
            else if (sMonth == "02")
            {
                mmonthBox.Text = "February";
                qmonthBox.Text = "First Quarter";
            }
            else if (sMonth == "03")
            {
                mmonthBox.Text = "March";
                qmonthBox.Text = "First Quarter";
            }
            else if (sMonth == "04")
            {
                mmonthBox.Text = "April";
                qmonthBox.Text = "Second Quarter";
            }
            else if (sMonth == "05")
            {
                mmonthBox.Text = "May";
                qmonthBox.Text = "Second Quarter";
            }
            else if (sMonth == "06")
            {
                mmonthBox.Text = "June";
                qmonthBox.Text = "Second Quarter";
            }
            else if (sMonth == "07")
            {
                mmonthBox.Text = "July";
                qmonthBox.Text = "Third Quarter";
            }
            else if (sMonth == "08")
            {
                mmonthBox.Text = "August";
                qmonthBox.Text = "Third Quarter";
            }
            else if (sMonth == "09")
            {
                mmonthBox.Text = "September";
                qmonthBox.Text = "Third Quarter";
            }
            else if (sMonth == "10")
            {
                mmonthBox.Text = "October";
                qmonthBox.Text = "Fourth Quarter";
            }
            else if (sMonth == "11")
            {
                mmonthBox.Text = "November";
                qmonthBox.Text = "Fourth Quarter";
            }
            else if (sMonth == "12")
            {
                mmonthBox.Text = "December";
                qmonthBox.Text = "Fourth Quarter";
            }
        }

        private void fillQuarter()
        {
            quarterLabel.Text = qmonthBox.Text + " - " + qyearBox.Text;
            calcFoodQuart();
            calcFuelQuart();
            calcTransQuart();
            calcMiscQuart();
            totExpQuart();
        }

        string first = "(substring(start_date, 6,2) = '01' OR substring(start_date, 6,2) = '02' OR substring(start_date, 6,2) = '03')";
        string second = "(substring(start_date, 6,2) = '04' OR substring(start_date, 6,2) = '05' OR substring(start_date, 6,2) = '06')";
        string third = "(substring(start_date, 6,2) = '07' OR substring(start_date, 6,2) = '08' OR substring(start_date, 6,2) = '09')";
        string fourth = "(substring(start_date, 6,2) = '10' OR substring(start_date, 6,2) = '11' OR substring(start_date, 6,2) = '12')";

        string quarter;

        private void changeQuarter()
        {
            if (qmonthBox.Text == "First Quarter")
            {
                quarter = first;
            }
            else if (qmonthBox.Text == "Second Quarter")
            {
                quarter = second;
            }
            else if (qmonthBox.Text == "Third Quarter")
            {
                quarter = third;
            }
            else if (qmonthBox.Text == "Fourth Quarter")
            {
                quarter = fourth;
            }
        }

        private void calcFoodQuart()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND " + quarter + " AND exp_name = 'Food/Snacks' "
                + " AND substring(start_date, 1,4) = '" + qYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                foodQuart.Text = reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        private void calcFuelQuart()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND " + quarter + " AND exp_name = 'Fuel' "
                + " AND substring(start_date, 1,4) = '" + qYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                fuelQuart.Text = reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        private void calcTransQuart()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND " + quarter + " AND exp_name = 'Transportation' "
                + " AND substring(start_date, 1,4) = '" + qYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                transQuart.Text = reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        private void calcMiscQuart()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND " + quarter + " AND exp_name = 'Miscellaneous' "
                + " AND substring(start_date, 1,4) = '" + qYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                miscQuart.Text = reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        private void totExpQuart()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND " + quarter 
                + " AND substring(start_date, 1,4) = '" + qYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                totQuart.Text = reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        private void qmonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeQuarter();
            fillQuarter();
        }

        string qYear;

        private void changeQuartYear()
        {
            qYear = qyearBox.Text;
        }

        private void qyearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeQuartYear();
            fillQuarter();
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
            calcFoodYear();
            calcFuelYear();
            calcTransYear();
            calcMiscYear();
            totExpYear();
        }

        private void calcFoodYear()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND exp_name = 'Food/Snacks' "
                + " AND substring(start_date, 1,4) = '" + aYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                foodYear.Text = reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        private void calcFuelYear()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND exp_name = 'Fuel' "
                + " AND substring(start_date, 1,4) = '" + aYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                fuelYear.Text = reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        private void calcTransYear()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND exp_name = 'Transportation' "
                + " AND substring(start_date, 1,4) = '" + aYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                transYear.Text = reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        private void calcMiscYear()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND exp_name = 'Miscellaneous' "
                + " AND substring(start_date, 1,4) = '" + aYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                miscYear.Text = reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        private void totExpYear()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND substring(start_date, 1,4) = '" + aYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                totYear.Text = reader["SUM(exp_price)"].ToString();
            }
            closeConnection();
        }

        private void ayearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeAnnYear();
            fillYear();
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
            Print(this.monthPanel);
        }

        private void printQuart_Click(object sender, EventArgs e)
        {
            Print(this.quartPanel);
        }

        private void printYear_Click(object sender, EventArgs e)
        {
            Print(this.yearPanel);
        }
    }

}

