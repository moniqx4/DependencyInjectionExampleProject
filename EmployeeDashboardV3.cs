using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExampleProject
{
    public class EmployeeDashboardV3 : IEmployeeDashboard
    {
        public void GetEmployeeDashboard()
        {
            Console.WriteLine("Getting version 3 of Employee Dashboard");
        }
    }
}
