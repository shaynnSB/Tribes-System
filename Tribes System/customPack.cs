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
namespace Tribes_System
{
    public partial class customPack : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;database=tribes_system;user=root;password=root");
        MySqlCommand cmd;
        MySqlCommand adapter;
        DataTable grid = new DataTable();
        public customPack()
        {
            InitializeComponent();
            refresh("select itemcontent.id, itemcontent.modelNumber,items.name,category.description from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID;");

        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void refresh(string query = "select itemcontent.id, itemcontent.modelNumber,items.name,category.description from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID;")
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
            adapter.Fill(table);
            availEmpGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            availEmpGrid.Columns.Clear();
            availEmpGrid.DataSource = table;
            availEmpGrid.Columns[0].Visible = false;
            availEmpGrid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            availEmpGrid.Columns[1].HeaderCell.Value = "Model Number";
            availEmpGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            availEmpGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            availEmpGrid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            availEmpGrid.Columns[2].HeaderCell.Value = "Equipment Name";
            availEmpGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            availEmpGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            availEmpGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            availEmpGrid.Columns[3].HeaderCell.Value = "Category";
            availEmpGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            availEmpGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            addEquipGrid.Columns[0].Visible = false;
            addEquipGrid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            addEquipGrid.Columns[1].HeaderCell.Value = "Model Number";
            addEquipGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            addEquipGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            addEquipGrid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            addEquipGrid.Columns[2].HeaderCell.Value = "Equipment Name";
            addEquipGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            addEquipGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            addEquipGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            addEquipGrid.Columns[3].HeaderCell.Value = "Category";
            addEquipGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            addEquipGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelButt_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    MessageBox.Show("Deleted");

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

        private void okButt_Click(object sender, EventArgs e)
        {

        }
        public string id;
        public string modelnumber;
        public string name;
        public string category;

        private void addButt_Click(object sender, EventArgs e)
        {
            id = availEmpGrid.Rows[availEmpGrid.SelectedRows[0].Index].Cells[0].Value.ToString();
            modelnumber = availEmpGrid.Rows[availEmpGrid.SelectedRows[0].Index].Cells[1].Value.ToString();
            name = availEmpGrid.Rows[availEmpGrid.SelectedRows[0].Index].Cells[2].Value.ToString();
            category = availEmpGrid.Rows[availEmpGrid.SelectedRows[0].Index].Cells[3].Value.ToString();
            availEmpGrid.Rows.RemoveAt(availEmpGrid.SelectedRows[0].Index);

            addEquipGrid.Rows.Add(id,modelnumber,name,category);
        }
        public string idremove;
        public string modelnumberremove;
        public string nameremove;
        public string categoryremove;
        private void removeButt_Click(object sender, EventArgs e)
        {
            idremove = addEquipGrid.Rows[addEquipGrid.SelectedRows[0].Index].Cells[0].Value.ToString();
            modelnumberremove = addEquipGrid.Rows[addEquipGrid.SelectedRows[0].Index].Cells[1].Value.ToString();
            nameremove = addEquipGrid.Rows[addEquipGrid.SelectedRows[0].Index].Cells[2].Value.ToString();
            categoryremove = addEquipGrid.Rows[addEquipGrid.SelectedRows[0].Index].Cells[3].Value.ToString();
            addEquipGrid.Rows.RemoveAt(addEquipGrid.SelectedRows[0].Index);
            int rowCount = addEquipGrid.Rows.Count;
            int rowCount1 = availEmpGrid.Rows.Count;
            if (rowCount > 0)
            {
                refresh("select itemcontent.id, itemcontent.modelNumber,items.name,category.description from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where itemcontent.id =" + idremove);
            }
            else
            {
                refresh("select itemcontent.id, itemcontent.modelNumber,items.name,category.description from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID");
            }
            if (rowCount1 > 0 && rowCount !=0)
            {
                refresh("select itemcontent.id, itemcontent.modelNumber,items.name,category.description from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where itemcontent.id !=" + addEquipGrid.Rows[addEquipGrid.SelectedRows[0].Index].Cells[0].Value.ToString());
            }



        }
    }
}
