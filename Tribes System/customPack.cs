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
            string a = "select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where eventID = 0 ";
            if (addViewEquip.rowCount1 == 0)
            {
                refresh("select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where eventID = 0 ");
            }
            else
            {      
                for (int i = 0; i <addViewEquip.test.Length; i++)
                {         
                        a = a + " and itemcontent.id !=" + addViewEquip.test[i].ToString();  
                }
                refresh(a);
            }
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                var x = categoryBox.SelectedIndex + 1;
                if (statusBox.SelectedIndex == -1)
                {
                string a = "select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where eventID = 0 and category.id = " + x;
                if (addViewEquip.rowCount1 == 0)
                {
                    refresh("select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where eventID = 0 and category.id =" + x);
                }
                else
                {
                    for (int i = 0; i < addViewEquip.test.Length; i++)
                    {
                        a = a + " and itemcontent.id !=" + addViewEquip.test[i].ToString();
                    }
                    refresh(a);
                }

               
                }

                else
                {
                string a = "select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where eventID = 0 and category.id =" + x + " and items.status ='" + statusBox.Text + "'";
             
                if (addViewEquip.rowCount1 == 0)
                {
                    refresh("select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where eventID = 0 and category.id =" + x + " and items.status ='" + statusBox.Text + "'");
                }
                else
                {
                    for (int i = 0; i < addViewEquip.test.Length; i++)
                    {
                        a = a + " and itemcontent.id !=" + addViewEquip.test[i].ToString();
                    }
                    refresh(a);
                }

            }
            

           
        }
        public void refresh(string query)
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
            availEmpGrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            availEmpGrid.Columns[4].HeaderCell.Value = "Status";
            availEmpGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            availEmpGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


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
            addEquipGrid.Columns[4].HeaderCell.Value = "Category";
            addEquipGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            addEquipGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                var x = categoryBox.SelectedIndex + 1;
                if (categoryBox.SelectedIndex == -1)
                {
                  
                string a = "select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where eventID = 0 and items.status ='" + statusBox.Text + "'";
                if (addViewEquip.rowCount1 == 0)
                {
                    refresh("select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where eventID = 0 and items.status ='" + statusBox.Text + "'");
                }
                else
                {
                    for (int i = 0; i < addViewEquip.test.Length; i++)
                    {
                        a = a + " and itemcontent.id !=" + addViewEquip.test[i].ToString();
                    }
                    refresh(a);
                }
            }

                else
                {
                
                string a = "select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where eventID = 0 and category.id =" + x + " and items.status ='" + statusBox.Text + "'";
                if (addViewEquip.rowCount1 == 0)
                {
                    refresh("select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where eventID = 0 and category.id =" + x + " and items.status ='" + statusBox.Text + "'");
                }
                else
                {
                    for (int i = 0; i < addViewEquip.test.Length; i++)
                    {
                        a = a + " and itemcontent.id !=" + addViewEquip.test[i].ToString();
                    }
                    refresh(a);
                }

            }
          
           
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

            //Bind datagridview to linq 
             int rowCount = addEquipGrid.Rows.Count;
            //loop dg1 and save it to datagridview2
           for(var i=0; i<rowCount; i++)
            {
                (System.Windows.Forms.Application.OpenForms["addViewEquip"] as addViewEquip).listEmpGrid.Rows.Add(addEquipGrid.Rows[i].Cells[0].Value.ToString(), addEquipGrid.Rows[i].Cells[1].Value.ToString(), addEquipGrid.Rows[i].Cells[2].Value.ToString(), addEquipGrid.Rows[i].Cells[3].Value.ToString(), addEquipGrid.Rows[i].Cells[4].Value.ToString());
            }
            this.Dispose();

        }
        public string id;
        public string modelnumber;
        public string name;
        public string category;
        public string status;

        private void addButt_Click(object sender, EventArgs e)
        {
            int rowCount1 = availEmpGrid.Rows.Count;
            if (rowCount1 > 0)
            {
                id = availEmpGrid.Rows[availEmpGrid.SelectedRows[0].Index].Cells[0].Value.ToString();
                modelnumber = availEmpGrid.Rows[availEmpGrid.SelectedRows[0].Index].Cells[1].Value.ToString();
                name = availEmpGrid.Rows[availEmpGrid.SelectedRows[0].Index].Cells[2].Value.ToString();
                category = availEmpGrid.Rows[availEmpGrid.SelectedRows[0].Index].Cells[3].Value.ToString();
                status = availEmpGrid.Rows[availEmpGrid.SelectedRows[0].Index].Cells[4].Value.ToString();
                availEmpGrid.Rows.RemoveAt(availEmpGrid.SelectedRows[0].Index);

                addEquipGrid.Rows.Add(id, modelnumber, name, category,status);
            }
            else
            {
                MessageBox.Show("Nothing is selected");
            }
        }
        public string idremove;
        public string modelnumberremove;
        public string nameremove;
        public string categoryremove;
        public string statusremove;
        private void removeButt_Click(object sender, EventArgs e)
        {

            int rowCount = addEquipGrid.Rows.Count;
            int rowCount1 = availEmpGrid.Rows.Count;
            if (rowCount > 0)
            {
            idremove = addEquipGrid.Rows[addEquipGrid.SelectedRows[0].Index].Cells[0].Value.ToString();
            modelnumberremove = addEquipGrid.Rows[addEquipGrid.SelectedRows[0].Index].Cells[1].Value.ToString();
            nameremove = addEquipGrid.Rows[addEquipGrid.SelectedRows[0].Index].Cells[2].Value.ToString();
            categoryremove = addEquipGrid.Rows[addEquipGrid.SelectedRows[0].Index].Cells[3].Value.ToString();
            statusremove = addEquipGrid.Rows[addEquipGrid.SelectedRows[0].Index].Cells[4].Value.ToString();
                addEquipGrid.Rows.RemoveAt(addEquipGrid.SelectedRows[0].Index);
                DataTable dataTable = (DataTable)availEmpGrid.DataSource;
                DataRow drToAdd = dataTable.NewRow();   
                    drToAdd[0] = idremove;
                    drToAdd[1] = modelnumberremove;
                    drToAdd[2] = nameremove;
                    drToAdd[3] = categoryremove;
                    drToAdd[4] = statusremove;
                dataTable.Rows.Add(drToAdd);
                    dataTable.AcceptChanges();

                }
            else
                {
                    MessageBox.Show("Nothing is selected");
            
                }
               


        }

        private void allButt_Click(object sender, EventArgs e)
        {
            int rowCount = availEmpGrid.Rows.Count;
            //loop dg1 and save it to datagridview2

            categoryBox.SelectedIndex = -1;
            statusBox.SelectedIndex = -1;
            
            string a = "select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where eventID = 0 ";
            if (addViewEquip.rowCount1 == 0)
            {
                refresh("select itemcontent.id, itemcontent.modelNumber,items.name,category.description,items.status from itemcontent left join items on items.id = itemcontent.itemID left join category on category.id = items.categoryID where eventID = 0 ");
            }
            else
            {
                for (int i = 0; i < addViewEquip.test.Length; i++)
                {
                    a = a + " and itemcontent.id !=" + addViewEquip.test[i].ToString();
                }
                refresh(a);
            }
        }

        private void customPack_Load(object sender, EventArgs e)
        {

        }
    }
}
