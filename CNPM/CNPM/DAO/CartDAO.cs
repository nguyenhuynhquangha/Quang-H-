using CNPM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.DAO
{
    public class CartDAO
    {
        private static CartDAO instance;

        public static CartDAO Instance
        {
            get { if (instance == null) instance = new CartDAO(); return CartDAO.instance; }
            private set { CartDAO.instance = value; }
        }
        private CartDAO() { }
        public List<Cart> LoadCartList()
        {
            List<Cart> cartList = new List<Cart>();

            DataTable data = DataProvider.Instance.ExecuteQuery("getcartlist");
            foreach (DataRow item in data.Rows)
            {
                Cart cart = new Cart(item);
                cartList.Add(cart);
            }
            return cartList;
        }
        public static int CartWidth = 100;
        public static int CartHeight = 100;
        public void InsertBillInfo(int name)
        {
            DataProvider.Instance.ExecuteNonQuery("InsertBillInfo @name", new object[] { name });
        }
    }
}
