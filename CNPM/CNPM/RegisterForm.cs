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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (userTextBox.Text == "" || passTextBox.Text == "")
            {
                MessageBox.Show("Please fill in the information.");
            }
            else if(passTextBox.Text!=confirmTextBox.Text){
                MessageBox.Show("Please check your password.");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DLGRKJK;Initial Catalog=ttnd;Integrated Security=True");
                String str = "insert into account(firstname,lastname,email,username,password) values('" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + emailTextBox.Text + "','" + userTextBox.Text + "','" + passTextBox.Text + "')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(str, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sign Up Success ");
            }
        }

        private void Aregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.ShowDialog();
            this.Show();
        }
    }
}
