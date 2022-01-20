namespace VogCodeChallenge.API.Models
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string JobTitle { get; set; }

        public Employee(string firstName, string lastName, string address, string jobTitle)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            JobTitle = jobTitle;
        }
    }
}
