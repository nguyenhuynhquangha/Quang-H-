using CNPM.DAO;
using CNPM.DTO;
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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            LoadCart();
            LoadCategory();
        }

        #region method
        void LoadCart()
        {
            cartFlowLayoutPanel.Controls.Clear();
            List<Cart> cartList= CartDAO.Instance.LoadCartList();
            foreach (Cart item in cartList)
            {
                Button btn = new Button() { Width =CartDAO.CartWidth,Height=CartDAO.CartHeight};
                btn.Text = item.Name;
                btn.Click += btn_Click;
                btn.Tag = item;
                cartFlowLayoutPanel.Controls.Add(btn);
                
            }
        }
        void ShowBill(int id)
        {
            listView1.Items.Clear();
            List<CTHD> listBillinfo = CTHDDAO.Instance.GetListCTHD(id);
            float totalPrice = 0;
            foreach (CTHD item in listBillinfo)
            {
                ListViewItem lvitem = new ListViewItem(item.Name.ToString());
                lvitem.SubItems.Add(item.Count.ToString());
                lvitem.SubItems.Add(item.Price.ToString());
                lvitem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                listView1.Items.Add(lvitem);
            }
            tpTextBox.Text = totalPrice.ToString();

        }
        void LoadCategory()
        {
            List<Category> lc = CategoryDAO.Instance.GetlistCategory();
            categoryComboBox.DataSource = lc;
            categoryComboBox.DisplayMember = "name";
        }
        void LoadNongsanByCategoryID(int id)
        {
            List<NongSan> lns = NongSanDAO.Instance.GetNongSanByCategoryId(id);
            nongsanComboBox.DataSource = lns;
            nongsanComboBox.DisplayMember = "name";
        }
        #endregion
        #region event 
        void btn_Click(object sender, EventArgs e)
        {
            int cartID=((sender as Button).Tag as Cart).Id ;
            listView1.Tag = (sender as Button).Tag;
            ShowBill(cartID);
        }
        private void SignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            this.Hide();
            cp.ShowDialog();
            this.Show();
        }

        private void YPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YourProduct cp = new YourProduct();
            this.Hide();
            cp.ShowDialog();

        }


        #endregion

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            Category s = cb.SelectedItem as Category;
            id = s.Id;
            LoadNongsanByCategoryID(id);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Cart cart = listView1.Tag as Cart;
            int idBill = BillDAO.Instance.GetuncheckBillIDByCartId(cart.Id);
            int nsID= (nongsanComboBox.SelectedItem as NongSan).Id;
            int count = (int)numericUpDown1.Value;
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(cart.Id);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.Getmaxidbill(), nsID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, nsID, count);
            }
            ShowBill(cart.Id);
            LoadCart();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            Cart cart = listView1.Tag as Cart;
            int idBill = BillDAO.Instance.GetuncheckBillIDByCartId(cart.Id);
            double totalprice = Convert.ToDouble(tpTextBox.Text.Split(',')[0]);
            if (idBill != -1)
            {
                BillDAO.Instance.CheckOut(idBill, (float)totalprice);
                ShowBill(cart.Id);
                LoadCart();
            }          
        }

        private void PiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalInformation pi = new PersonalInformation();
            this.Hide();
            pi.ShowDialog();
            this.Show();
        }
    }
}
