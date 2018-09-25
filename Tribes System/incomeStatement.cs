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
    public partial class incomeStatement : Form
    {
        PrintDocument printdoc1 = new PrintDocument();
        PrintPreviewDialog previewdlg = new PrintPreviewDialog();
        Panel pannel = null;

        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");
        MySqlCommand cmd;

        string sMonth = DateTime.Now.ToString("MM");
        string sYear = DateTime.Now.ToString("yyyy");

        string m = DateTime.Now.ToString("MM");
        string y = DateTime.Now.ToString("yyyy");

        public incomeStatement()
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

        private void incomeStatement_Load(object sender, EventArgs e)
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
            printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
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
        //--------------------------------------Revenue----------------------------------
        string amM;

        private void calAmMonth()
        {
            string selectQuery = "select SUM(prices) from event where substring(start_date, 6,2) = '" + sMonth + "' AND substring(start_date, 1,4) = '" + sYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                amM = reader["SUM(prices)"].ToString();
            }
            closeConnection();
        }

        string feeM;

        private void calFeeMonth()
        {
            string selectQuery = "select SUM(fee_amount) from event, additional_fees where id_event = event_id AND substring(start_date, 6,2) = '" + sMonth +
                "' AND substring(start_date, 1,4) = '" + sYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                feeM = reader["SUM(fee_amount)"].ToString();
            }
            closeConnection();
        }

        string discM;
        
        private void calDiscMonth()
        {
            string selectQuery = "select SUM(disc_amount) from event, discount where id_event = event_id AND substring(start_date, 6,2) = '" + sMonth +
                "' AND substring(start_date, 1,4) = '" + sYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                discM = reader["SUM(disc_amount)"].ToString();
            }
            closeConnection();
        }

        string revM;
        double revenueM;
        private void calcRevMonth()
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

            revenueM = total;
            revM = Convert.ToString(total) + ".00";
            revMonth.Text = revM;
        }

        //----------------------------------------------Operational Expense-----------------------------
        string expM;
        double expenseM;
        private void totExpMonth()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND substring(start_date, 6,2) = '" + sMonth
                + "' AND substring(start_date, 1,4) = '" + sYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                expM = reader["SUM(exp_price)"].ToString();
                if (expM == "")
                {
                    expenseM = 0;
                } else
                {
                    expenseM = Convert.ToDouble(expM);
                }
                opMonth.Text = expM;
            }
            closeConnection();
        }

        //----------------------------------------------Salary-------------------------------------------

        string bonusM;

        private void calcBonusMonth()
        {
            string selectQuery = "select SUM(bonus_amount) from bonus, employee where bonus.id_emp = employee.id_emp " +
                "AND substring(date, 6,2) = '" + sMonth + "' AND substring(date, 1,4) = '" + sYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                bonusM = reader["SUM(bonus_amount)"].ToString();
            }
            closeConnection();
        }

        string vioM;

        private void calcVioMonth()
        {
            string selectQuery = "select SUM(violation_amount) from violations, employee where violations.id_emp = employee.id_emp " +
                "AND substring(date, 6,2) = '" + sMonth + "' AND substring(date, 1,4) = '" + sYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                vioM = reader["SUM(violation_amount)"].ToString();
            }
            closeConnection();
        }

        string fullM;

        private void calcFullMonth()
        {
            string selectQuery = "select SUM(emp_salary) from employee where emp_status = 'Full-Time'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                fullM = reader["SUM(emp_salary)"].ToString();
            }
            closeConnection();
        }

        string callM;

        private void calcCallMonth()
        {
            string selectQuery = "select SUM(salary) from staff_lineup, employee, event where id_emp = staff_id AND id_event = no_event " +
                "AND substring(start_date, 6,2) = '" + sMonth + "' AND substring(start_date, 1,4) = '" + sYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                callM = reader["SUM(salary)"].ToString();
            }
            closeConnection();
        }

        string salM;
        double salaryM;
        private void calcSalMonth()
        {
            double full;
            double call;
            double bonus;
            double violation;

            if (fullM == "" || fullM == "--")
            {
                full = 0;
            }
            else
            {
                full = Convert.ToDouble(fullM);
            }

            if (callM == "" || callM == "--")
            {
                call = 0;
            }
            else
            {
                call = Convert.ToDouble(callM);
            }

            if (bonusM == "" || bonusM == "--")
            {
                bonus = 0;
            }
            else
            {
                bonus = Convert.ToDouble(bonusM);
            }

            if (vioM == "" || vioM == "--")
            {
                violation = 0;
            }
            else
            {
                violation = Convert.ToDouble(vioM);
            }

            double total = (full + call + bonus) - violation;

            salaryM = total;
            salM = Convert.ToString(total) + ".00";
            salMonth.Text = salM;
        }

        //-----------Total----------

        double totExpM;
        private void plusExpMonth()
        {
            totExpM = salaryM + expenseM;
            expTotMonth.Text = "(" + Convert.ToString(totExpM) + ".00)";
        }

        double totM;
        private void calcTotMonth()
        {
            totM = revenueM - totExpM;
            totMonth.Text = Convert.ToString(totM) + ".00";
            if (totM > 0)
            {
                incLoss.Text = "TOTAL NET INCOME";
            }else if (totM == 0)
            {
                incLoss.Text = "BREAKEVEN";
            }
            else
            {
                incLoss.Text = "TOTAL NET LOSS";
            }
        }

        //------------

        private void fillMonth()
        {
            monthLabel.Text = mmonthBox.Text + " - " + myearBox.Text;
            calAmMonth();
            calFeeMonth();
            calDiscMonth();
            calcRevMonth();
            totExpMonth();
            calcBonusMonth();
            calcVioMonth();
            calcFullMonth();
            calcCallMonth();
            calcSalMonth();
            plusExpMonth();
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

        string first2 = "(substring(date, 6,2) = '01' OR substring(date, 6,2) = '02' OR substring(date, 6,2) = '03')";
        string second2 = "(substring(date, 6,2) = '04' OR substring(date, 6,2) = '05' OR substring(date, 6,2) = '06')";
        string third2 = "(substring(date, 6,2) = '07' OR substring(date, 6,2) = '08' OR substring(date, 6,2) = '09')";
        string fourth2 = "(substring(date, 6,2) = '10' OR substring(date, 6,2) = '11' OR substring(date, 6,2) = '12')";

        string quarter2;

        private void changeQuarter2()
        {
            if (qmonthBox.Text == "First Quarter")
            {
                quarter2 = first2;
            }
            else if (qmonthBox.Text == "Second Quarter")
            {
                quarter2 = second2;
            }
            else if (qmonthBox.Text == "Third Quarter")
            {
                quarter2 = third2;
            }
            else if (qmonthBox.Text == "Fourth Quarter")
            {
                quarter2 = fourth2;
            }
        }

        string qYear;

        private void changeQuartYear()
        {
            qYear = qyearBox.Text;
        }

        //---------------------------------------Revenue-------------------------------
        string amQ;

        private void calAmQuart()
        {
            string selectQuery = "select SUM(prices) from event where substring(start_date, 1,4) = '" + qYear + "' AND " + quarter;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                amQ = reader["SUM(prices)"].ToString();
            }
            closeConnection();
        }

        string feeQ;

        private void calFeeQuart()
        {
            string selectQuery = "select SUM(fee_amount) from event, additional_fees where id_event = event_id " +
                "AND substring(start_date, 1,4) = '" + qYear + "' AND " + quarter;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                feeQ = reader["SUM(fee_amount)"].ToString();
            }
            closeConnection();
        }

        string discQ;

        private void calDiscQuart()
        {
            string selectQuery = "select SUM(disc_amount) from event, discount where id_event = event_id " +
                "AND substring(start_date, 1,4) = '" + qYear + "' AND " + quarter;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                discQ = reader["SUM(disc_amount)"].ToString();
            }
            closeConnection();
        }

        string revQ;
        double revenueQ;
        private void calcRevQuart()
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

            revenueQ = total;
            revQ = Convert.ToString(total) + ".00";
            revQuart.Text = revQ;
        }

        //-----------------------------Operational Expense------------------------

        double expenseQ;
        string opQ;
        private void totOpQuart()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND " + quarter
                + " AND substring(start_date, 1,4) = '" + qYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                opQ = reader["SUM(exp_price)"].ToString();
                opQuart.Text = opQ;
                if (opQ == "")
                {
                    expenseQ = 0;
                }
                else
                {
                    expenseQ = Convert.ToDouble(opQ);
                }
            }
            closeConnection();
        }

        //------------------------------Salary----------------------------------------

        string bonusQ;

        private void calcBonusQuart()
        {
            string selectQuery = "select SUM(bonus_amount) from bonus, employee where bonus.id_emp = employee.id_emp " +
                " AND substring(date, 1,4) = '" + qYear + "' AND " + quarter2;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                bonusQ = reader["SUM(bonus_amount)"].ToString();
            }
            closeConnection();
        }

        string vioQ;

        private void calcVioQuart()
        {
            string selectQuery = "select SUM(violation_amount) from violations, employee where violations.id_emp = employee.id_emp " +
                " AND substring(date, 1,4) = '" + qYear + "' AND " + quarter2;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                vioQ = reader["SUM(violation_amount)"].ToString();
            }
            closeConnection();
        }

        string fullQ;

        private void calcFullQuart()
        {
            string selectQuery = "select SUM(emp_salary) from employee where emp_status = 'Full-Time'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                fullQ = reader["SUM(emp_salary)"].ToString();
            }
            closeConnection();
        }

        string callQ;

        private void calcCallQuart()
        {
            string selectQuery = "select SUM(salary) from staff_lineup, employee, event where id_emp = staff_id AND id_event = no_event" +
                " AND substring(start_date, 1,4) = '" + qYear + "' AND " + quarter;
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                callQ = reader["SUM(salary)"].ToString();
            }
            closeConnection();
        }

        string salQ;
        double salaryQ;
        private void calcSalQuart()
        {
            double full;
            double call;
            double bonus;
            double violation;

            if (fullQ == "" || fullQ == "--")
            {
                full = 0;
            }
            else
            {
                full = Convert.ToDouble(fullQ);
            }

            if (callQ == "" || callQ == "--")
            {
                call = 0;
            }
            else
            {
                call = Convert.ToDouble(callQ);
            }

            if (bonusQ == "" || bonusQ == "--")
            {
                bonus = 0;
            }
            else
            {
                bonus = Convert.ToDouble(bonusQ);
            }

            if (vioQ == "" || vioQ == "--")
            {
                violation = 0;
            }
            else
            {
                violation = Convert.ToDouble(vioQ);
            }

            double total = (full + call + bonus) - violation;

            salQ = Convert.ToString(total) + ".00";
            salaryQ = total;
            salQuart.Text = salQ;
        }

        //-----------Total----------

        double totExpQ;
        private void plusExpQuart()
        {
            totExpQ = salaryQ + expenseQ;
            totExpQuart.Text = "(" + Convert.ToString(totExpQ) + ".00)";
        }

        double totQ;
        private void calcTotQuart()
        {
            totQ = revenueQ - totExpQ;
            totQuart.Text = Convert.ToString(totQ) + ".00";
            if (totQ > 0)
            {
                incLossQ.Text = "TOTAL NET INCOME";
            }
            else if (totQ == 0)
            {
                incLossQ.Text = "BREAKEVEN";
            }
            else
            {
                incLossQ.Text = "TOTAL NET LOSS";
            }
        }

        //--------------------------------

        private void fillQuarter()
        {
            quarterLabel.Text = qmonthBox.Text + " - " + qyearBox.Text;
            calAmQuart();
            calFeeQuart();
            calDiscQuart();
            calcFullQuart();
            calcCallQuart();
            calcBonusQuart();
            calcVioQuart();
            calcSalQuart();
            totOpQuart();
            calAmQuart();
            calFeeQuart();
            calDiscQuart();
            calcRevQuart();
            plusExpQuart();
            calcTotQuart();
        }

        private void qmonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeQuarter();
            changeQuarter2();

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

        //------------------------------Yearly Calculations-------------------------------

        string aYear;

        private void changeAnnYear()
        {
            aYear = ayearBox.Text;
        }

        private void fillYear()
        {
            yearLabel.Text = "Year " + ayearBox.Text;
            calcFullYear();
            calcCallYear();
            calcBonusYear();
            calcVioYear();
            calcSalYear();
            totExpYear();
            calAmYear();
            calFeeYear();
            calDiscYear();
            calcRevYear();
            plusExpYear();
            calcTotYear();
        }

        //---------------------------------------Salary------------------------------------

        string fullY;

        private void calcFullYear()
        {
            string selectQuery = "select SUM(emp_salary) from employee where emp_status = 'Full-Time'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                fullY = reader["SUM(emp_salary)"].ToString();
            }
            closeConnection();
        }

        string callY;

        private void calcCallYear()
        {
            string selectQuery = "select SUM(salary) from staff_lineup, employee, event where id_emp = staff_id AND id_event = no_event" +
                " AND substring(start_date, 1,4) = '" + aYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                callY = reader["SUM(salary)"].ToString();
            }
            closeConnection();
        }

        string bonusY;

        private void calcBonusYear()
        {
            string selectQuery = "select SUM(bonus_amount) from bonus, employee where bonus.id_emp = employee.id_emp " +
                " AND substring(date, 1,4) = '" + aYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                bonusY = reader["SUM(bonus_amount)"].ToString();
            }
            closeConnection();
        }

        string vioY;

        private void calcVioYear()
        {
            string selectQuery = "select SUM(violation_amount) from violations, employee where violations.id_emp = employee.id_emp " +
                " AND substring(date, 1,4) = '" + aYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                vioY = reader["SUM(violation_amount)"].ToString();
            }
            closeConnection();
        }

        string salY;
        double salaryY; 
        private void calcSalYear()
        {
            double full;
            double call;
            double bonus;
            double violation;

            if (fullY == "" || fullY == "--")
            {
                full = 0;
            }
            else
            {
                full = Convert.ToDouble(fullY);
            }

            if (callY == "" || callY == "--")
            {
                call = 0;
            }
            else
            {
                call = Convert.ToDouble(callY);
            }

            if (bonusY == "" || bonusY == "--")
            {
                bonus = 0;
            }
            else
            {
                bonus = Convert.ToDouble(bonusY);
            }

            if (vioY == "" || vioY == "--")
            {
                violation = 0;
            }
            else
            {
                violation = Convert.ToDouble(vioY);
            }

            double total = (full + call + bonus) - violation;
            salaryY = total;
            salY = Convert.ToString(total) + ".00";
            salYear.Text = salY;
        }

        //--------------------Operational Expense--------------------------------

        string opY;
        double expenseY;
        private void totExpYear()
        {
            string selectQuery = "select SUM(exp_price) from expenses, event where event_id = id_event AND substring(start_date, 1,4) = '" + aYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                opY = reader["SUM(exp_price)"].ToString();
                opYear.Text = opY + ".00";
            }
            closeConnection();
        }

        //-----------------------Revenue-----------------------

        string amY;

        private void calAmYear()
        {
            string selectQuery = "select SUM(prices) from event where substring(start_date, 1,4) = '" + aYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                amY = reader["SUM(prices)"].ToString();
            }
            closeConnection();
        }

        string feeY;

        private void calFeeYear()
        {
            string selectQuery = "select SUM(fee_amount) from event, additional_fees where id_event = event_id " +
                "AND substring(start_date, 1,4) = '" + aYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                feeY = reader["SUM(fee_amount)"].ToString();
            }
            closeConnection();
        }

        string discY;

        private void calDiscYear()
        {
            string selectQuery = "select SUM(disc_amount) from event, discount where id_event = event_id " +
                "AND substring(start_date, 1,4) = '" + aYear + "'";
            openConnection();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                discY = reader["SUM(disc_amount)"].ToString();
            }
            closeConnection();
        }

        string revY;
        double revenueY;
        private void calcRevYear()
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

            revenueY = total;
            revY = Convert.ToString(total) + ".00";
            revYear.Text = revY;
        }

        //-----------Total----------

        double totExpY;
        private void plusExpYear()
        {
            totExpY = salaryY + expenseY;
            expTotYear.Text = "(" + Convert.ToString(totExpY) + ".00)";
        }

        double totY;
        private void calcTotYear()
        {
            totY = revenueY - totExpY;
            totYear.Text = Convert.ToString(totY) + ".00";
            if (totY > 0)
            {
                incLoss.Text = "TOTAL NET INCOME";
            }
            else if (totY == 0)
            {
                incLoss.Text = "BREAKEVEN";
            }
            else
            {
                incLoss.Text = "TOTAL NET LOSS";
            }
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
            Print(this.monthPanel);
        }

        private void printQuart_Click(object sender, EventArgs e)
        {
            Print(this.quarterPanel);
        }

        private void printYear_Click(object sender, EventArgs e)
        {
            Print(this.yearPanel);
        }
    }
}
