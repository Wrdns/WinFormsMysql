using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMySql
{
    internal class Payed
    {
        public int Payid { get; set; }
        public string PayDate { get; set; }
        public int PaySize { get; set; }
        public int Studentfk { get; set; }

        public Payed(int payid, string paydate = "<?>", int paysize = 0, int studentfk = 0)
        {
            Payid = payid;
            PayDate = paydate;
            PaySize = paysize;
            Studentfk = studentfk;
        }

        public static Payed GetClone(Payed payed)
        {
            if (payed is null)
                throw new System.ArgumentNullException(nameof(payed));

            return new Payed(payed.Payid)
            {
                PayDate = payed.PayDate,
                PaySize = payed.PaySize,
                Studentfk = payed.Studentfk
            };
        }
    }
}
