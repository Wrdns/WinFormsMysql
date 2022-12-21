namespace WinFormsMySql
{
    public class Admins
    {
        public int Admid { get; set; }
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
        public string Post { get; set; }

        public Admins(int admid, string lastname = "<?>", string firstname = "<?>", string patronymic = "<?>",
            string dtdate = "<?>", string sex = "<?>", int passeria = 0, int passnumber = 0,
            string issued = "<?>", string registration = "<?>", string number = "<?>", string post = "<?>")
        {
            Admid = admid;
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
            Post = post;
        }

        public static Admins GetClone(Admins admins)
        {
            if (admins is null)
                throw new System.ArgumentNullException(nameof(admins));

            return new Admins(admins.Admid)
            {
                LastName = admins.LastName,
                FirstName = admins.FirstName,
                Patronymic = admins.Patronymic,
                Dtdate = admins.Dtdate,
                Sex = admins.Sex,
                Passeria = admins.Passeria,
                Passnumber = admins.Passnumber,
                Issued = admins.Issued,
                Registration = admins.Registration,
                Number = admins.Number,
                Post = admins.Post
            };
        }
    }
}
