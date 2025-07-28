// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using EmployeeManager.Models;
using EmployeeManager.Services;

Console.WriteLine("EmployeeManager");
Employee lukasz = new Employee(1,"Lukasz","Magazynier",3200.00m);

lukasz.Print();
