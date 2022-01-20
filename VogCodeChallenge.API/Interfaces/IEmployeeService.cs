using System.Collections.Generic;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Interfaces
{
    public interface IEmployeeService
    {
        IList<Department> DeptList { get; set; }

        IEnumerable<Employee> GetAll();

        IList<Employee> ListAll();


    }
}
