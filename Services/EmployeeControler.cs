using EmployeeManager.Models;

namespace EmployeeManager.Services;

public class EmployeeControler
{
    private static int employeesCount = 0;

    public static void AddEmployeeFromInput()
    {
        Console.WriteLine("\n--- Add New Employee ---");
        Console.Write("Enter Name:");
        string name = Console.ReadLine();
        
        Console.Write("Enter Position:");
        string position = Console.ReadLine();
        
        Console.Write("Enter Salary:");
        string salary = Console.ReadLine();
        
        if (!decimal.TryParse(salary, out decimal salaryDecimal))
        {
            Console.WriteLine("Salary must be a decimal"); 
            return;
        }
        Employee newEmployee = new Employee(employeesCount++, name, position, salaryDecimal);
        EmployeeService.AddEmployee(newEmployee);
        
    }
}