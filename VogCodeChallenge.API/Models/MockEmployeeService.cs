using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.API.Interfaces;

namespace VogCodeChallenge.API.Models
{
    public class MockEmployeeService : IEmployeeService
    {
        public IList<Department> DeptList { get; set; } = new List<Department>()
        {
            new Department()
            {
                Id = 1,
                Address = "123 Dept 1",
                EmployeeList = new List<Employee>()
                {
                    new Employee("Josh", "Adams", "123 Center Way", "Office Manager"),
                    new Employee("Alfred", "Old", "1927 Carrot Lane", "Head of Sales"),
                },
            },
            new Department()
            {
                Id = 2,
                Address = "789 Dept 2",
                EmployeeList = new List<Employee>()
                {
                    new Employee("Johnny", "Carson", "59 Near The Moon", "VP of Marketing"),
                    new Employee("Checkers", "McMaster", "49 Driving St", "Consultant")
                },
            }
        };


        public IEnumerable<Employee> GetAll()
        {
            return DeptList.Where(d => d.EmployeeList.Count > 0).SelectMany(d => d.EmployeeList).ToList();
        }

        public IList<Employee> ListAll()
        {
            return DeptList.Where(d => d.EmployeeList.Count > 0).SelectMany(d => d.EmployeeList).ToList();
        }
    }
}
