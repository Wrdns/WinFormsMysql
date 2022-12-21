using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMySql
{
    internal class Groups
    {
        public int Groupid { get; set; }
        public string Date { get; set; }
        public int Persnumb { get; set; }
        public int Instructorsfk { get; set; }

        public Groups(int groupid, string date = "<?>", int persnumb = 0, int instructorsfk = 0)
        {
            Groupid = groupid;
            Date = date;
            Persnumb = persnumb;
            Instructorsfk = instructorsfk;
        }

        public static Groups GetClone(Groups groups)
        {
            if (groups is null)
                throw new System.ArgumentNullException(nameof(groups));

            return new Groups(groups.Groupid)
            {
                Date = groups.Date,
                Persnumb = groups.Persnumb,
                Instructorsfk = groups.Instructorsfk
            };
        }
    }
}
