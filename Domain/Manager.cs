using Domain.Enums;

namespace Domain
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }
        public string Department { get; set; }
        public Manager(string firstName, string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }
        public void AddBonus(double bonus)
        {
            Bonus = bonus;
        }
        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
