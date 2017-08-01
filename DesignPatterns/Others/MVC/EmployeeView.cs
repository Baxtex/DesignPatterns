using System;

namespace DesignPatterns.Others.MVC
{
    internal class EmployeeView
    {
        public void PrintEmployeeDetails(string name, int salary)
        {
            Console.WriteLine(name);
            Console.WriteLine(salary);
        }
    }
}