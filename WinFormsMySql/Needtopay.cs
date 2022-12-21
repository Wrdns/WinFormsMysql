using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMySql
{
    internal class Needtopay
    {
        public int Selpayid { get; set; }
        public int Selpaysize { get; set; }
        public int Studentfk { get; set; }
        public int Paycodefk { get; set; }

        public Needtopay(int selpayid, int selpaysize = 0, int studentfk = 0, int paycodefk = 0)
        {
            Selpayid = selpayid;
            Selpaysize = selpaysize;
            Studentfk = studentfk;
            Paycodefk = paycodefk;
        }

        public static Needtopay GetClone(Needtopay needtopay)
        {
            if (needtopay is null)
                throw new System.ArgumentNullException(nameof(needtopay));

            return new Needtopay(needtopay.Selpayid)
            {
                Selpaysize = needtopay.Selpaysize,
                Studentfk = needtopay.Studentfk,
                Paycodefk = needtopay.Paycodefk
            };
        }
    }
}
