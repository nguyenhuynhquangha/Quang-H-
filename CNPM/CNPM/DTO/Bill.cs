using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.DTO
{
    public class Bill
    {
        private int id;
        private DateTime? dateCheckIn;

        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }

        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Id {
            get { return id; }
            set { id = value; }
        }

        private DateTime? dateCheckOut;
        private int status;
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
        {
            this.Id=id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = DateCheckOut;
            this.status = status;
        }
        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            var dateCheckOut1 = row["DateCheckOut"];
            if(dateCheckOut1.ToString() !="")
                this.DateCheckOut = (DateTime?)dateCheckOut1;

            this.status = (int)row["status"];
        }
    }
}

