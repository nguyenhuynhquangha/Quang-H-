using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM
{
    public partial class PersonalInformation : Form
    {
        public PersonalInformation()
        {
            InitializeComponent();
            LoadAccountList();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DLGRKJK;Initial Catalog=ttnd;Integrated Security=True");
        void LoadAccountList()
        {
            String sql2 = "Select * from dbo.Account";
            conn.Open();
            SqlDataAdapter data2 = new SqlDataAdapter(sql2, conn);
            DataTable tb2 = new DataTable();
            data2.Fill(tb2);
            conn.Close();
            dataGridView2.DataSource = tb2;
            IDTextBox.DataBindings.Clear();
            IDTextBox.DataBindings.Add("Text", dataGridView2.DataSource, "id", true, DataSourceUpdateMode.Never);
            userTextBox.DataBindings.Clear();
            userTextBox.DataBindings.Add("Text", dataGridView2.DataSource, "username", true, DataSourceUpdateMode.Never);
            passTextBox.DataBindings.Clear();
            passTextBox.DataBindings.Add("Text", dataGridView2.DataSource, "password", true, DataSourceUpdateMode.Never);
            firstNameTextBox.DataBindings.Clear();
            firstNameTextBox.DataBindings.Add("Text", dataGridView2.DataSource, "firstname", true, DataSourceUpdateMode.Never);
            lastNameTextBox.DataBindings.Clear();
            lastNameTextBox.DataBindings.Add("Text", dataGridView2.DataSource, "lastname", true, DataSourceUpdateMode.Never);
            emailTextBox.DataBindings.Clear();
            emailTextBox.DataBindings.Add("Text", dataGridView2.DataSource, "email", true, DataSourceUpdateMode.Never);
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            String str = "insert into account(firstname,lastname,email,username,password) values('" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + emailTextBox.Text + "','" + userTextBox.Text + "','" + passTextBox.Text + "')";
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add success");
            conn.Close();
            LoadAccountList();
        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            String str = "Delete account where id='" + IDTextBox.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete success");
            conn.Close();
            LoadAccountList();
        }

        private void EditAccountButton_Click(object sender, EventArgs e)
        {
            String str = "Update dbo.account set username='" + userTextBox.Text +"',password='"+passTextBox.Text+ "',firstname='" + firstNameTextBox.Text + "',lastname='" + lastNameTextBox.Text + "',email='" + emailTextBox.Text + "'where id='" + IDTextBox.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update success");
            conn.Close();
            LoadAccountList();
        }
    }
}
