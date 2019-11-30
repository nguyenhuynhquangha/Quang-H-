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
namespace CNPM
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }        

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PassChangeButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DLGRKJK;Initial Catalog=ttnd;Integrated Security=True");
            String sql = "select count(*) from account where username = '" + textBox1.Text + "'and password='"+textBox2.Text+" '";
            SqlDataAdapter data = new SqlDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            data.Fill(tb);
            if (tb.Rows[0][0].ToString() == "1")
            {
                if (textBox3.Text == textBox4.Text)
                {
                    SqlDataAdapter cp = new SqlDataAdapter("update account set password='" + textBox3.Text + "'where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", conn);
                    DataTable dt = new DataTable();
                    cp.Fill(dt);
                    MessageBox.Show("Password Changed!!");
                }
                else
                {
                    MessageBox.Show("New password and confirmation password are incorrect");
                }
            }
            else{
                MessageBox.Show("Please check your username or password");
            }
        }
    }
}
