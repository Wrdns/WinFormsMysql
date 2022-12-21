using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMySql
{
    public class Students
    {
        public int Studid { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Dtdate { get; set; }
        public string Sex { get; set; }
        public int Passeria { get; set; }
        public int Passnumber { get; set; }
        public string Issued { get; set; }
        public string Registration { get; set; }
        public string Number { get; set; }
        public int Groupfk { get; set; }

        public Students(int studid, string lastname = "<?>", string firstname = "<?>", string patronymic = "<?>",
            string dtdate = "<?>", string sex = "<?>", int passeria = 0, int passnumber = 0,
            string issued = "<?>", string registration = "<?>", string number = "<?>", int groupfk = 0)
        {
            Studid = studid;
            LastName = lastname;
            FirstName = firstname;
            Patronymic = patronymic;
            Dtdate = dtdate;
            Sex = sex;
            Passeria = passeria;
            Passnumber = passnumber;
            Issued = issued;
            Registration = registration;
            Number = number;
            Groupfk = groupfk;
        }

        public static Students GetClone(Students students)
        {
            if (students is null)
                throw new System.ArgumentNullException(nameof(students));

            return new Students(students.Studid)
            {
                LastName = students.LastName,
                FirstName = students.FirstName,
                Patronymic = students.Patronymic,
                Dtdate = students.Dtdate,
                Sex = students.Sex,
                Passeria = students.Passeria,
                Passnumber = students.Passnumber,
                Issued = students.Issued,
                Registration = students.Registration,
                Number = students.Number,
                Groupfk = students.Groupfk
            };
        }
    }
}
