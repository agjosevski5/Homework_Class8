using Domain;

namespace Homework_Class8
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Aleksej";
            employee.Salary = 10000;

            var employeeSalary = employee.GetSalary();

            SalesPerson salesPerson = new SalesPerson();
            salesPerson.AddSuccessRevenue(3000);

            var salesPersonSalary = salesPerson.GetSalary();

            Manager manager = new Manager("Aleksej","Gjoshevski",Domain.Enums.Role.Manager, 14500);
            manager.Department = "IT";
            manager.AddBonus(5000);

            var menagerSalary = manager.GetSalary();

            Contractor contractor = new Contractor();
            contractor.PayPerHour = 2500;
            contractor.WorkHours = 8;
            contractor.Responsible = manager;

            var contractorSalary = contractor.GetSalary();
            var department = contractor.CurrentPosition();
            
        }
    }
}
