using CNPM.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.DTO
{
    public class Billinfo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdBill
        {
            get { return idBill; }
            set { idBill = value; }
        }

        public int IdNongSan
        {
            get { return idNongSan; }
            set { idNongSan = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int idBill;
        private int idNongSan;
        private int count;
        public Billinfo(int id,int idBill,int idNongSan,int count)
        {
            this.Id = id;
            this.IdBill = idBill;
            this.IdNongSan = idNongSan;
            this.Count = count;
        }
        public Billinfo(DataRow row)
        {
            this.Id =(int)row["id"];
            this.IdBill = (int)row["idBill"];
            this.IdNongSan = (int)row["idNongSan"];
            this.Count = (int)row["count"];
        }
    }
}
