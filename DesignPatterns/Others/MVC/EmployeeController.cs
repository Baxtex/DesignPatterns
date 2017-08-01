using System;

namespace DesignPatterns.Others.MVC
{
    internal class EmployeeController
    {
        private EmployeeModel model;
        private EmployeeView view;

        public EmployeeController(EmployeeModel model, EmployeeView view)
        {
            this.model = model;
            this.view = view;
        }

        public String GetEmployeeName()
        {
            return model.Name;
        }

        public void SetEmployeeName(string name)
        {
            model.Name = name;
        }

        public int GetEmployeeSalary()
        {
            return model.Salary;
        }

        public void SetEmployeeSalary(int salary)
        {
            model.Salary = salary;
        }

        public void UpdateView()
        {
            view.PrintEmployeeDetails(model.Name, model.Salary);
        }
    }
}