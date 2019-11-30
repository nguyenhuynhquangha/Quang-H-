using CNPM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get {
                if (instance == null)
                    instance = new BillInfoDAO();
                return BillInfoDAO.instance; }
            set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO()
        {

        }
        public List<Billinfo> Getlistbillinfo(int id)
        {
            List<Billinfo> listBillinfo = new List<Billinfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.billinfo WHERE idBill=" + id );
            foreach (DataRow item in data.Rows)
            {
                Billinfo info = new Billinfo(item);
                listBillinfo.Add(info); 
            }
            return listBillinfo;
        }
        public void InsertBillInfo(int idBill,int idNongSan,int count)
        {
            DataProvider.Instance.ExecuteNonQuery("InsertBillInfo @idBill , @idNongSan , @Count", new object[]{idBill, idNongSan, count });
        }
    }
}
