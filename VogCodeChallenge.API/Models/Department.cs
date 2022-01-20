using System.Collections.Generic;

namespace VogCodeChallenge.API.Models
{
    public class Department
    {
        public string Name { get; set; }

        public string Address { get; set; }

        private List<Employee> EmployeeList = new List<Employee>();
    }
}