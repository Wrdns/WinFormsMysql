namespace WinFormsMySql.Models
{
    public class Employee
    {
        public int Id { get; set; }
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
        public int Admfk { get; set; }
        public int Carfk { get; set; }

        public Employee(int id, string lastname = "<?>", string firstname = "<?>", string patronymic = "<?>", 
            string dtdate = "<?>", string sex = "<?>", int passeria = 0, int passnumber = 0, 
            string issued = "<?>", string registration = "<?>", string number = "<?>", string post = "<?>", int admfk = 0, int carfk=0)
        {
            Id = id;
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
            Admfk = admfk;
            Carfk = carfk;
        }

        /// <summary>
        /// Получение клонированного экземпляра
        /// </summary>
        /// <param name="employee">существующий экземпляр</param>
        /// <returns>клон существующего сотрудника</returns>
        public static Employee GetClone(Employee employee)
        {
            if (employee is null)
                throw new System.ArgumentNullException(nameof(employee));

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
                Admfk = employee.Admfk,
                Carfk = employee.Carfk
            };
        }
    }
}
