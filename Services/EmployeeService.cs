using EmployeeManager.Models;

namespace EmployeeManager.Services;

public class EmployeeService
{
    private static List<Employee> employees = new List<Employee>();

    public static void AddEmployee(Employee employee)
    {
        employees.Add(employee);
        Console.WriteLine("Employee Added");
    }

    public static void ShowAllEmployees()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No Employees Found");
            return;
        }
        
        Console.WriteLine("Employees:");
        foreach (var employee in employees)
        {
            employee.Print();
        }
    }

}