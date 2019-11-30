using CNPM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.DAO
{
    class NongSanDAO
    {
        private static NongSanDAO instance;

        public static NongSanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NongSanDAO();
                return NongSanDAO.instance;
            }
            private set { NongSanDAO.instance = value; }
        }
        private NongSanDAO() { }
        public List<NongSan> GetNongSanByCategoryId(int id)
        {
            List<NongSan> list = new List<NongSan>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from nongsan where idCategory="+id);
            foreach (DataRow item in data.Rows)
            {
                NongSan ns = new NongSan(item);
                list.Add(ns);
            }
            return list;
        }
        public List<NongSan> GetListNongSan()
        {
            List<NongSan> list = new List<NongSan>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from nongsan");
            foreach (DataRow item in data.Rows)
            {
                NongSan ns = new NongSan(item);
                list.Add(ns);
            }
            return list;
        }
        public bool InsertNongSan(string name, int id, float price)
        {
            int inst = DataProvider.Instance.ExecuteNonQuery("Insert dbo.nongsan(name,idCategory,price) values(N'" + name + "','" + id + "','" + price+"')");
            return inst>0;
        }
        public bool UpdateNongSan(int idns,string name, int id, float price)
        {
            int upd = DataProvider.Instance.ExecuteNonQuery("Update dbo.nongsan set name=N'" + name + "',idCategory='" + id + "',price='" + price + "'where id='"+idns+"'");
            return upd > 0;
        }
        public bool DeleteNongSan(int id)
        {
            int del = DataProvider.Instance.ExecuteNonQuery("Delete nongsan where id='"+id+"'");
            return del > 0;
        }
    }
}
