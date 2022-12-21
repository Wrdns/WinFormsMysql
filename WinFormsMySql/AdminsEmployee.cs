using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMySql
{
    public class AdminsEmployee
    {
        public int Adid { get; set; }
        public string Adlastname { get; set; }
        public string Adfirstname { get; set; }
        public string Adpatronymic { get; set; }
        public string Addtdate { get; set; }
        public string Adsex { get; set; }
        public int Adpasseria { get; set; }
        public int Adpassnumber { get; set; }
        public string Adissued { get; set; }
        public string Adregistration { get; set; }
        public string Adnumber { get; set; }
        public string Adpost { get; set; }
        public int Emid { get; set; }
        public string Emlastname { get; set; }
        public string Emfirstname { get; set; }
        public string Empatronymic { get; set; }
        public string Emdtdate { get; set; }
        public string Emsex { get; set; }
        public int Empasseria { get; set; }
        public int Empassnumber { get; set; }
        public string Emissued { get; set; }
        public string Emregistration { get; set; }
        public string Emnumber { get; set; }
        public string Empost { get; set; }
        public int Admfokey { get; set; }


        public AdminsEmployee(int adid, string adlastname = "<?>", string adfirstname = "<?>", string adpatronymic = "<?>",
            string addtdate = "<?>", string adsex = "<?>", int adpasseria = 0, int adpassnumber = 0,
            string adissued = "<?>", string adregistration = "<?>", string adnumber = "<?>", string adpost = "<?>", int emid, string emlastname = "<?>", string emfirstname = "<?>", string empatronymic = "<?>",
            string emdtdate = "<?>", string emsex = "<?>", int empasseria = 0, int empassnumber = 0,
            string emissued = "<?>", string emregistration = "<?>", string emnumber = "<?>", string empost = "<?>", int admfokey = 0)
        {
            Adid = adid;
            Adlastname = adlastname;
            Adfirstname = adfirstname;
            Adpatronymic = adpatronymic;
            Adregistration = adregistration;
            Adpost = adpost;
            Addtdate = addtdate;
            Adsex = adsex;
            Adpasseria = adpasseria;
            Adpassnumber = adpassnumber;
            Adissued = adissued;
            Adnumber = adnumber;
            Adpost = adpost;
            Emid = emid;
            Emlastname = emlastname;
            Emfirstname = emfirstname;
            Empatronymic = empatronymic;
            Emdtdate = emdtdate;
            Emsex = emsex;
            Empasseria = empasseria;
            Empassnumber = empassnumber;
            Empost = empost;
            Emissued = emissued;
            Emregistration = emregistration;
            Emnumber = emnumber;
            Admfokey = admfokey;


        }

        public static AdminsEmployee GetClone(AdminsEmployee adminsemployee)
        {
            if (adminsemployee is null)
                throw new System.ArgumentNullException(nameof(adminsemployee));

            return new Employee(employee.Id)
            {
                LastName = employee.LastName,
                FirstName = employee.FirstName,
                Patronymic = employee.Patronymic,
                Dtdate = employee.Dtdate,
                Sex = employee.Sex,
                Passeria = employee.Passeria,
                Passnumber = employee.Passnumber,
                Issued = employee.Issued,
                Registration = employee.Registration,
                Number = employee.Number,
                Post = employee.Post,
                Admfk = employee.Admfk
            };
        }
    }
}
