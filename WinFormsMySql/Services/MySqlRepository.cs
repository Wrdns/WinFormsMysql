using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using WinFormsMySql.Interfaces;
using WinFormsMySql.Models;
using WinFormsMySql.Utils;
using MySql.Data.MySqlClient;

namespace WinFormsMySql.Services
{
    class MySqlRepository : ITaskRepository
    {
        //Костыли поиска
        private string SearchString;
        private string ColumnString;
        public MySqlRepository()
        { 

        }

        //Подключение к бд
        private MySqlConnection GetConnection()
        {
            var cs = ConfigurationManager.ConnectionStrings["MySqlConn"].ToString();
            var builder = new MySqlConnectionStringBuilder(cs);
            //чтоб избежать проблем с русским языком
            builder.CharacterSet = "utf8";
            return new MySqlConnection(builder.ConnectionString);
        }

        //костыль получения параметра поиска
        private void GetColumnString()
        {
            ColumnString =MainForm.ColumnString;
        }

        //костыль получения текста поиска
        private void GetSearchString()
        {
            SearchString = MainForm.SearchString;
        }

        //Выгрузка сотрудников
        public async Task<Result<List<Employee>>> GetEmployee()
        {
            var list = new List<Employee>();

            try
            {
                GetColumnString();
                GetSearchString();
                using (var con = GetConnection())
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = ("SELECT * FROM instructors where " + ColumnString + " LIKE " + SearchString);
                    con.Open();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var emp = new Employee(reader.GetInt32(0));
                            emp.LastName = reader.GetString(1);
                            emp.FirstName = reader.GetString(2);
                            emp.Patronymic = reader.GetString(3);
                            emp.Dtdate = reader.GetString(4);
                            emp.Sex = reader.GetString(5);
                            emp.Passeria = reader.GetInt32(6);
                            emp.Passnumber = reader.GetInt32(7);
                            emp.Issued = reader.GetString(8);
                            emp.Registration = reader.GetString(9);
                            emp.Number = reader.GetString(10);
                            emp.Post = reader.GetString(11);
                            emp.Admfk = reader.GetInt32(12);
                            emp.Carfk= reader.GetInt32(13);

                            list.Add(emp);
                        }
                    }
                }

            }
            catch (MySqlException ex)
            {
                return new Result<List<Employee>>(GetUserFriendlyErrorMessage(ex));
            }
            catch (Exception ex)
            {
                return new Result<List<Employee>>(ex.Message);
            }

            return new Result<List<Employee>>(list);
        }

        //выгрузка админов
        public async Task<Result<List<Admins>>> GetAdmins()
        {
            var list = new List<Admins>();

            try
            {
                GetColumnString();
                GetSearchString();
                using (var con = GetConnection())
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = ("SELECT * FROM administration where " + ColumnString + " LIKE " + SearchString);
                    con.Open();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var adm = new Admins(reader.GetInt32(0));
                            adm.LastName = reader.GetString(1);
                            adm.FirstName = reader.GetString(2);
                            adm.Patronymic = reader.GetString(3);
                            adm.Dtdate = reader.GetString(4);
                            adm.Sex = reader.GetString(5);
                            adm.Passeria = reader.GetInt32(6);
                            adm.Passnumber = reader.GetInt32(7);
                            adm.Issued = reader.GetString(8);
                            adm.Registration = reader.GetString(9);
                            adm.Number = reader.GetString(10);
                            adm.Post = reader.GetString(11);

                            list.Add(adm);
                        }
                    }
                }

            }
            catch (MySqlException ex)
            {
                return new Result<List<Admins>>(GetUserFriendlyErrorMessage(ex));
            }
            catch (Exception ex)
            {
                return new Result<List<Admins>>(ex.Message);
            }

            return new Result<List<Admins>>(list);
        }

        //добавление сотрудника
        public async Task<Result<int>> AddEmployee(Employee employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(employee));

            int result = 0;
            try
            {
                using (var con = GetConnection())
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO instructors (firstname, lastname, patronymic, dtdate, sex, passeria, passnumber, issued, registration, number, post, administratorsfk, carfk)" +
                        " VALUES(@LastName, @FirstName, @Patronymic, @Dtdate, @Sex, @Passeria, @Passnumber, @Issued, @Registration, @Number, @Post, @Admfk, @Carfk)";

                    cmd.Parameters.Add(new MySqlParameter("@LastName", MySqlDbType.VarChar, 30)
                    { Value = employee.FirstName });

                    cmd.Parameters.Add(new MySqlParameter("@FirstName", MySqlDbType.VarChar, 30)
                    { Value = employee.LastName });

                    cmd.Parameters.Add(new MySqlParameter("@Patronymic", MySqlDbType.VarChar, 30)
                    { Value = employee.Patronymic });

                    cmd.Parameters.Add(new MySqlParameter("@Dtdate", MySqlDbType.VarChar, 20)
                    { Value = employee.Dtdate });

                    cmd.Parameters.Add(new MySqlParameter("@Sex", MySqlDbType.VarChar, 8)
                    { Value = employee.Sex });

                    cmd.Parameters.Add(new MySqlParameter("@Passeria", MySqlDbType.Int32)
                    { Value = employee.Passeria });

                    cmd.Parameters.Add(new MySqlParameter("@Passnumber", MySqlDbType.Int32)
                    { Value = employee.Passnumber });

                    cmd.Parameters.Add(new MySqlParameter("@Issued", MySqlDbType.VarChar, 100)
                    { Value = employee.Issued });

                    cmd.Parameters.Add(new MySqlParameter("@Registration", MySqlDbType.VarChar, 100)
                    { Value = employee.Registration });

                    cmd.Parameters.Add(new MySqlParameter("@Number", MySqlDbType.VarChar, 20)
                    {
                        Value = employee.Number
                    });

                    cmd.Parameters.Add(new MySqlParameter("@Post", MySqlDbType.VarChar, 20)
                    { Value = employee.Post });

                    cmd.Parameters.Add(new MySqlParameter("@Admfk", MySqlDbType.Int32)
                    { Value = employee.Admfk });

                    cmd.Parameters.Add(new MySqlParameter("@Carfk", MySqlDbType.Int32)
                    { Value = employee.Carfk });

                    con.Open();
                    result = await cmd.ExecuteNonQueryAsync();
                }

            }
            catch (MySqlException ex)
            {
                return new Result<int>(GetUserFriendlyErrorMessage(ex));
            }
            catch (Exception ex)
            {
                return new Result<int>(ex.Message);
            }

            return new Result<int>(result);
        }


        //добавление админа
        public async Task<Result<int>> AddAdmin(Admins admins)
        {
            if (admins is null)
                throw new ArgumentNullException(nameof(admins));

            int result = 0;
            try
            {
                using (var con = GetConnection())
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO administrators (firstname, lastname, patronymic, dtdate, sex, passeria, passnumber, issued, registration, number, post)" +
                        " VALUES(@LastName, @FirstName, @Patronymic, @Dtdate, @Sex, @Passeria, @Passnumber, @Issued, @Registration, @Number, @Post)";

                    cmd.Parameters.Add(new MySqlParameter("@LastName", MySqlDbType.VarChar, 30)
                    { Value = admins.FirstName });

                    cmd.Parameters.Add(new MySqlParameter("@FirstName", MySqlDbType.VarChar, 30)
                    { Value = admins.LastName });

                    cmd.Parameters.Add(new MySqlParameter("@Patronymic", MySqlDbType.VarChar, 30)
                    { Value = admins.Patronymic });

                    cmd.Parameters.Add(new MySqlParameter("@Dtdate", MySqlDbType.Date)
                    { Value = admins.Dtdate });

                    cmd.Parameters.Add(new MySqlParameter("@Sex", MySqlDbType.VarChar, 8)
                    { Value = admins.Sex });

                    cmd.Parameters.Add(new MySqlParameter("@Passeria", MySqlDbType.Int32)
                    { Value = admins.Passeria });

                    cmd.Parameters.Add(new MySqlParameter("@Passnumber", MySqlDbType.Int32)
                    { Value = admins.Passnumber });

                    cmd.Parameters.Add(new MySqlParameter("@Issued", MySqlDbType.VarChar, 100)
                    { Value = admins.Issued });

                    cmd.Parameters.Add(new MySqlParameter("@Registration", MySqlDbType.VarChar, 100)
                    { Value = admins.Registration });

                    cmd.Parameters.Add(new MySqlParameter("@Number", MySqlDbType.VarChar, 20)
                    {
                        Value = admins.Number ?? (object)System.DBNull.Value
                    });

                    cmd.Parameters.Add(new MySqlParameter("@Post", MySqlDbType.VarChar, 20)
                    { Value = admins.Post });

                    con.Open();
                    result = await cmd.ExecuteNonQueryAsync();
                }

            }
            catch (MySqlException ex)
            {
                return new Result<int>(GetUserFriendlyErrorMessage(ex));
            }
            catch (Exception ex)
            {
                return new Result<int>(ex.Message);
            }

            return new Result<int>(result);
        }



        //удаление сотрудника
        public async Task<Result<int>> RemoveEmployee(int id)
        {
            if (id <= 0)
                throw new ArgumentException(nameof(id));

            int result = 0;
            try
            {
                using (var con = GetConnection())
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM instructors WHERE mpovid =@Id";

                    cmd.Parameters.Add(new MySqlParameter("@Id", MySqlDbType.Int32)
                    { Value = id });

                    con.Open();
                    result = await cmd.ExecuteNonQueryAsync();
                }

            }
            catch (MySqlException ex)
            {
                return new Result<int>(GetUserFriendlyErrorMessage(ex));
            }
            catch (Exception ex)
            {
                return new Result<int>(ex.Message);
            }

            return new Result<int>(result);
        }

        //удаление админа
        public async Task<Result<int>> RemoveAdmin(int id)
        {
            if (id <= 0)
                throw new ArgumentException(nameof(id));

            int result = 0;
            try
            {
                using (var con = GetConnection())
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM administrators WHERE admid =@Id";

                    cmd.Parameters.Add(new MySqlParameter("@Id", MySqlDbType.Int32)
                    { Value = id });

                    con.Open();
                    result = await cmd.ExecuteNonQueryAsync();
                }

            }
            catch (MySqlException ex)
            {
                return new Result<int>(GetUserFriendlyErrorMessage(ex));
            }
            catch (Exception ex)
            {
                return new Result<int>(ex.Message);
            }

            return new Result<int>(result);
        }

        //обновление сотрудника
        public async Task<Result<int>> UpdateEmployee(Employee employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(employee));

            int result = 0;
            try
            {
                using (var con = GetConnection())
                using (var cmd = con.CreateCommand())
                {

                    cmd.CommandText = "UPDATE instructors" +
                        " SET lastname = @LastName, firstname = @FirstName, patronymic = @Patronymic, dtdate = @Dtdate, sex = @Sex, passeria = @Passeria, passnumber = @Passnumber, issued = @Issued, registration = @Registration, number = @Number, post = @Post, administratorsfk = @Admfk" +
                        " WHERE mpovid = @Id";

                    cmd.Parameters.Add(new MySqlParameter("@Id", MySqlDbType.Int32)
                    { Value = employee.Id });

                    cmd.Parameters.Add(new MySqlParameter("@LastName", MySqlDbType.VarChar, 30)
                    { Value = employee.LastName });

                    cmd.Parameters.Add(new MySqlParameter("@FirstName", MySqlDbType.VarChar, 30)
                    { Value = employee.FirstName });

                    cmd.Parameters.Add(new MySqlParameter("@Patronymic", MySqlDbType.VarChar, 30)
                    { Value = employee.Patronymic });

                    cmd.Parameters.Add(new MySqlParameter("@Dtdate", MySqlDbType.VarChar, 20)
                    { Value = employee.Dtdate });

                    cmd.Parameters.Add(new MySqlParameter("@Sex", MySqlDbType.VarChar, 8)
                    { Value = employee.Sex });

                    cmd.Parameters.Add(new MySqlParameter("@Passeria", MySqlDbType.Int32)
                    { Value = employee.Passeria });

                    cmd.Parameters.Add(new MySqlParameter("@Passnumber", MySqlDbType.Int32)
                    { Value = employee.Passnumber });

                    cmd.Parameters.Add(new MySqlParameter("@Issued", MySqlDbType.VarChar, 100)
                    { Value = employee.Issued });

                    cmd.Parameters.Add(new MySqlParameter("@Registration", MySqlDbType.VarChar, 100)
                    { Value = employee.Registration });

                    cmd.Parameters.Add(new MySqlParameter("@Number", MySqlDbType.VarChar, 20)
                    {
                        Value = employee.Number
                    });

                    cmd.Parameters.Add(new MySqlParameter("@Post", MySqlDbType.VarChar, 20)
                    { Value = employee.Post });

                    cmd.Parameters.Add(new MySqlParameter("@Admfk", MySqlDbType.Int32)
                    { Value = employee.Admfk });

                    con.Open();
                    result = await cmd.ExecuteNonQueryAsync();
                }

            }
            catch (MySqlException ex)
            {
                return new Result<int>(GetUserFriendlyErrorMessage(ex));
            }
            catch (Exception ex)
            {
                return new Result<int>(ex.Message);
            }

            return new Result<int>(result);
        }

        //обновление админа
        public async Task<Result<int>> UpdateAdmin(Admins admins)
        {
            if (admins is null)
                throw new ArgumentNullException(nameof(admins));

            int result = 0;
            try
            {
                using (var con = GetConnection())
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "UPDATE administrators" +
                        " SET lastname = @LastName, firstname = @Firstname, patronymic = @Patronymic, dtdate = @Dtdate, sex = @Sex, passeria = @Passeria, passnumber = @Passnumber, issued = @Issued, registration = @Registration, number = @Number, post = @Post" +
                        " WHERE admid = @Id";

                    cmd.Parameters.Add(new MySqlParameter("@Id", MySqlDbType.Int32)
                    { Value = admins.Admid });

                    cmd.Parameters.Add(new MySqlParameter("@LastName", MySqlDbType.VarChar, 30)
                    { Value = admins.LastName });

                    cmd.Parameters.Add(new MySqlParameter("@FirstName", MySqlDbType.VarChar, 30)
                    { Value = admins.FirstName });

                    cmd.Parameters.Add(new MySqlParameter("@Patronymic", MySqlDbType.VarChar, 30)
                    { Value = admins.Patronymic });

                    cmd.Parameters.Add(new MySqlParameter("@Dtdate", MySqlDbType.VarChar, 20)
                    { Value = admins.Dtdate });

                    cmd.Parameters.Add(new MySqlParameter("@Sex", MySqlDbType.VarChar, 8)
                    { Value = admins.Sex });

                    cmd.Parameters.Add(new MySqlParameter("@Passeria", MySqlDbType.Int32)
                    { Value = admins.Passeria });

                    cmd.Parameters.Add(new MySqlParameter("@Passnumber", MySqlDbType.Int32)
                    { Value = admins.Passnumber });

                    cmd.Parameters.Add(new MySqlParameter("@Issued", MySqlDbType.VarChar, 100)
                    { Value = admins.Issued });

                    cmd.Parameters.Add(new MySqlParameter("@Registration", MySqlDbType.VarChar, 100)
                    { Value = admins.Registration });

                    cmd.Parameters.Add(new MySqlParameter("@Number", MySqlDbType.VarChar, 20)
                    {
                        Value = admins.Number ?? (object)System.DBNull.Value
                    });

                    cmd.Parameters.Add(new MySqlParameter("@Post", MySqlDbType.VarChar, 20)
                    { Value = admins.Post });

                    con.Open();
                    result = await cmd.ExecuteNonQueryAsync();
                }

            }
            catch (MySqlException ex)
            {
                return new Result<int>(GetUserFriendlyErrorMessage(ex));
            }
            catch (Exception ex)
            {
                return new Result<int>(ex.Message);
            }

            return new Result<int>(result);
        }

        //обработчик ошибок
        private string GetUserFriendlyErrorMessage(MySqlException ex)
        {
            var message = String.Empty;
            switch (ex.Number)
            {
                case 0:
                    if (ex.InnerException.Message.Contains("Unknown"))
                    {
                        message = "Неверное название схемы или таблицы.";
                    }
                    else if (ex.InnerException.Message.Contains("Access"))
                    {
                        message = "Неверное имя или пароль доступа.";
                    }
                    else
                    {
                        message = ex.Message;
                    }
                    break;
                case 1042:
                    message = "Сервер по указанному адресу не доступен." +
                        "\nОшибка ожидания.";
                    break;
                case 1045:
                    message = "Неверное имя пользователя или пароль, " +
                        "\nпожалуйста, попробуйте еще раз.";
                    break;
                default:
                    message = ex.Message;
                    break;
            }
            return message;
        }
    }
}
