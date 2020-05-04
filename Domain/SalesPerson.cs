using Domain.Enums;

namespace Domain
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }
        public SalesPerson()
        {
            Role = Role.Sales;
            Salary = 500;
        }
        public SalesPerson(string firstName, string lastName, Role role, double salary, double successSaleRevenue)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
            SuccessSaleRevenue = successSaleRevenue;
        }
        public void AddSuccessRevenue(double successRevenue)
        {
            SuccessSaleRevenue = successRevenue;
        }
        public override double GetSalary()
        {
            double bonus = 0;

            if (SuccessSaleRevenue <= 2000)
            {
                bonus = 500;
            }
            else if (SuccessSaleRevenue > 2000 || SuccessSaleRevenue <= 5000)
            {
                bonus = 1000;
            }
            else if (SuccessSaleRevenue > 5000)
            {
                bonus = 1500;
            }

            return Salary + bonus;

        }
    }
}
