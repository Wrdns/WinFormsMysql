using System.Collections.Generic;
using System.Threading.Tasks;
using WinFormsMySql.Models;
using WinFormsMySql.Utils;

namespace WinFormsMySql.Interfaces
{
    public interface ITaskRepository
    {
        //получение всех инструкторов
        Task<Result<List<Employee>>> GetEmployee();
        //добавление инструкторов
        Task<Result<int>> AddEmployee(Employee employee);
        //удаление инструкторов
        Task<Result<int>> RemoveEmployee(int id);
        //обновление инструкторов
        Task<Result<int>> UpdateEmployee(Employee employee);



        //добавление администрации
        Task<Result<int>> AddAdmin(Admins admins);
        //Удаление администрации
        Task<Result<int>> RemoveAdmin(int id);
        //получение сотрудников администрации
        Task<Result<List<Admins>>> GetAdmins();
        //обновление администрации
        Task<Result<int>> UpdateAdmin(Admins admins);

    }
}
