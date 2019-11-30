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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DLGRKJK;Initial Catalog=ttnd;Integrated Security=True");
            String sql = "select * from account where username = '" + textUser.Text + "' and password = '" + textPass.Text + "'";
            SqlDataAdapter data = new SqlDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            data.Fill(tb);
            if (tb.Rows.Count==1)
            {
                Mainform frm = new Mainform();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Check your username and password.");
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.ShowDialog();
        }
    }
}
