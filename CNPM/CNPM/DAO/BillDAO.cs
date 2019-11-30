using CNPM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get {
                if (instance == null)
                    instance = new BillDAO();
                return BillDAO.instance;
            }
            set {
                BillDAO.instance = value;
            }
        }
        private BillDAO()
        {

        }
        public int GetuncheckBillIDByCartId(int id)
        {
            DataTable data=DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.bill WHERE idCart="+id+"AND status=0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }
            return -1;
        }
        public void CheckOut(int id,float totalprice)
        {
            DataProvider.Instance.ExecuteNonQuery("update dbo.bill set dateCheckOut=GETDATE(), status = 1, "+"totalprice="+totalprice+"where id = " + id);
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec Insertbill @idCart",new object[]{id});
        }
        public DataTable getlistbill(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("exec getlistbill @checkin , @checkout", new object[]{ checkIn, checkOut });
        }
        public int Getmaxidbill()
        {
            return (int)DataProvider.Instance.ExecuteScalar("select max(id) from dbo.bill");            
        }
        
    }
}
