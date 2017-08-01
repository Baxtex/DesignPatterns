using System;

namespace DesignPatterns.Others.MVC
{
    internal class TestModelViewController
    {
        public TestModelViewController()
        {
            Console.WriteLine("--Test MVC start--");

            EmployeeModel model = GetEmployee();
            EmployeeView view = new EmployeeView();
            EmployeeController controller = new EmployeeController(model, view);

            controller.UpdateView();
            controller.SetEmployeeSalary(2000);
            controller.UpdateView();
            Console.WriteLine("--Test MVC end--");
        }

        //This Model/Data can come from anywhere.
        private EmployeeModel GetEmployee()
        {
            return new EmployeeModel { Name = "Anders Hansson", Salary = 1000 };
        }
    }
}