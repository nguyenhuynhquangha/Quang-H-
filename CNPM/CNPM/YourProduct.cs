using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CNPM.DAO;
using CNPM.DTO;

namespace CNPM
{
    public partial class YourProduct : Form
    {
        BindingSource lnslist=new BindingSource();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DLGRKJK;Initial Catalog=ttnd;Integrated Security=True");
        public YourProduct()
        {            
            InitializeComponent();
            nsDataGridView.DataSource = lnslist;
            LoadCartList();
            LoadNongSanList();
            addBinding();
            LoadCategoryintocb(comboBox1);
        }
        void LoadCategoryintocb(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetlistCategory();
            cb.DisplayMember = "Name";
        }
        void LoadNongSanList()
        {
            lnslist.DataSource = NongSanDAO.Instance.GetListNongSan();
        }
        void addBinding()
        {
            idnsTextBox.DataBindings.Add("Text", nsDataGridView.DataSource, "id", true, DataSourceUpdateMode.Never);
            namensTextBox.DataBindings.Add("Text", nsDataGridView.DataSource, "name", true, DataSourceUpdateMode.Never);
            numericUpDown1.DataBindings.Add("Value", nsDataGridView.DataSource, "price", true, DataSourceUpdateMode.Never);
            userTextBox.DataBindings.Add("Text", dataGridView2.DataSource, "id",true, DataSourceUpdateMode.Never);
            nameCartTextBox.DataBindings.Add("Text", dataGridView2.DataSource, "name",true, DataSourceUpdateMode.Never);
        }
        void LoadCartList()
        {
            dataGridView2.DataSource = CartDAO.Instance.LoadCartList();
        }
        

        private void AddCartButton_Click(object sender, EventArgs e)
        {
            String str = "insert dbo.cart(name) values(N'" + nameCartTextBox.Text +  "')";
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update success");
            conn.Close();
            LoadCartList();
        }

        void LoadListBill(DateTime checkin, DateTime checkout)
        {
            billDataGridView.DataSource = BillDAO.Instance.getlistbill(checkin, checkout);
        }
        private void StatisticalButton_Click(object sender, EventArgs e)
        {
            LoadListBill(dateTimePicker1.Value, todateDateTimePicker.Value);
        }

        private void IdnsTextBox_TextChanged(object sender, EventArgs e)
        {          
            int id = (int)nsDataGridView.SelectedCells[0].OwningRow.Cells["Idcategory"].Value;
            Category category = CategoryDAO.Instance.GetCategorybyid(id);
            comboBox1.SelectedItem = category;
            int index = -1;
            int i = 0;
            foreach (Category item in comboBox1.Items)
            {
                if (item.Id == category.Id)
                {
                    index = i;
                    break;
                }
                i++;
            }
            comboBox1.SelectedIndex = index;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = namensTextBox.Text;
            int category = (comboBox1.SelectedItem as Category).Id;
            float price = (float)numericUpDown1.Value;
            NongSanDAO.Instance.InsertNongSan(name, category, price);
            MessageBox.Show("Add success");
            LoadNongSanList();            
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string name = namensTextBox.Text;
            int category = (comboBox1.SelectedItem as Category).Id;
            float price = (float)numericUpDown1.Value;
            int id = Convert.ToInt32(idnsTextBox.Text);
            if (NongSanDAO.Instance.UpdateNongSan(id,name, category, price))
            {
                MessageBox.Show("edit success");
                LoadNongSanList();
            }
            else
            {
                MessageBox.Show("edit fail");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idnsTextBox.Text);
            if (NongSanDAO.Instance.DeleteNongSan(id))
            {
                MessageBox.Show("Delete success");
                LoadNongSanList();
            }
            else
            {
                MessageBox.Show("Delete fail");
            }
        }

        private void DeleteCartButton_Click(object sender, EventArgs e)
        {
            String str = "Delete dbo.cart where id='" +userTextBox.Text+ "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete success");
            conn.Close();
            LoadCartList();
        }

        private void EditCartButton_Click(object sender, EventArgs e)
        {
            String str = "Update dbo.cart set name=N'" + nameCartTextBox.Text + "'where id='" + userTextBox.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update success");
            conn.Close();
            LoadCartList();
        }
    }
}
