using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMySql
{
    internal class Lesinfo
    {
        public int Idlesinf { get; set; }
        public string Lestype { get; set; }
        public string Lesdate { get; set; }
        public string Plase { get; set; }
        public int Studentsfk { get; set; }
        public int Groupfk { get; set; }
        public int Instructorsidfk { get; set; }
        public int Instructorsadmidfk { get; set; }
        public int Instructorscaridfk { get; set; }

        public Lesinfo(int idlesinf, string lestype = "<?>", string lesdate = "<?>", string plase = "<?>", int studentsfk = 0, int groupfk = 0, int instructorsidfk = 0, int instructorsadmidfk = 0, int instructorscaridfk = 0)
        {
            Idlesinf = idlesinf;
            Lestype = lestype;
            Lesdate = lesdate;
            Plase = plase;
            Studentsfk = studentsfk;
            Groupfk = groupfk;
            Instructorsidfk = instructorsidfk;
            Instructorsadmidfk = instructorsadmidfk;
            Instructorscaridfk = instructorscaridfk;

        }

        public static Lesinfo GetClone(Lesinfo lesinfo)
        {
            if (lesinfo is null)
                throw new System.ArgumentNullException(nameof(lesinfo));

            return new Lesinfo(lesinfo.Idlesinf)
            {
                Idlesinf = lesinfo.Idlesinf,
                Lestype=lesinfo.Lestype,
                Lesdate=lesinfo.Lesdate,
                Plase=lesinfo.Plase,
                Studentsfk=lesinfo.Studentsfk,
                Groupfk=lesinfo.Groupfk,
                Instructorsidfk=lesinfo.Instructorsidfk,
                Instructorsadmidfk=lesinfo.Instructorsadmidfk,
                Instructorscaridfk=lesinfo.Instructorscaridfk
            };
        }
    }
}
