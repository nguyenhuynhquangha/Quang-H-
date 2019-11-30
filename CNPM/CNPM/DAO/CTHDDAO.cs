using CNPM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.DAO
{
    public class CTHDDAO
    {
        private static CTHDDAO instance;

        public static CTHDDAO Instance
        {
            
            get
            {
                if (instance == null)
                    instance = new CTHDDAO();
                return CTHDDAO.instance;
            }
            set { CTHDDAO.instance = value; }
        }
        private CTHDDAO()
        {

        }
        public List<CTHD> GetListCTHD(int id)
        {
            List<CTHD> listCTHD = new List<CTHD>();
            DataTable data=DataProvider.Instance.ExecuteQuery("SELECT ns.name, bi.count, ns.price, ns.price*bi.count AS totalPrice FROM dbo.billinfo AS bi, dbo.bill AS b, dbo.nongsan AS ns WHERE bi.idBill = b.id AND bi.idNongSan = ns.id AND b.status=0 AND b.idCart = " + id);
            foreach (DataRow item in data.Rows)
            {
                CTHD cthd = new CTHD(item);
                listCTHD.Add(cthd);
            }
            return listCTHD;
        }
    }
}
