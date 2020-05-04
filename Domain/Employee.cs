using Domain.Enums;

namespace Domain
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public double Salary { get; set; }

        public Employee()
        {

        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
