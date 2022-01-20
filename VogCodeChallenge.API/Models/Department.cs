using System.Collections.Generic;

namespace VogCodeChallenge.API.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public IList<Employee> EmployeeList { get; set; }
    }
}