using System.Collections.Generic;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();

        IList<Employee> ListAll();
    }
}
