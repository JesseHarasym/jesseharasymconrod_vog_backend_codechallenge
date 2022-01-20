using System.Collections.Generic;

namespace VogCodeChallenge.API.Models
{
    public class Department
    {
        public string Name { get; set; }

        public string Address { get; set; }

        private List<Employee> _employeeList = new List<Employee>()
        {
            new Employee("Josh", "Adams", "123 Center Way", "Office Manager"),
            new Employee("Alfred", "Old", "1927 Carrot Lane", "Head of Sales"),
            new Employee("Johnny", "Carson", "59 Near The Moon", "VP of Marketing"),
            new Employee("Checkers", "McMaster", "49 Driving St", "Consultant")
        };

        public IEnumerable<Employee> GetAll()
        {
            return _employeeList;
        }

        public IList<Employee> ListAll()
        {
            return _employeeList;
        }
    }
}