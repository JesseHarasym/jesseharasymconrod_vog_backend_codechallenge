using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.API.Interfaces;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // for question 6: we could create another class called EmployeeService()
        // with our database logic and have it inherit IEmployee service and implement its methods.
        IEmployeeService _employeeService = new MockEmployeeService();

        // GET api/employees
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeService.GetAll();
        }

        // GET api/employees/department/{departmentId}
        [HttpGet("department/{departmentId}")]
        public IList<Employee> Get(int departmentId)
        {
            return _employeeService.DeptList.Where(d => d.Id == departmentId).SelectMany(d => d.EmployeeList).ToList();
        }
    }
}
