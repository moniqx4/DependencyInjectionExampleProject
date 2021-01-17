using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExampleProject
{
    public class EmployeeDashboardV2 : IEmployeeDashboard
    {
        
        public void GetEmployeeDashboard()
        {          
            Console.WriteLine("Getting Employee Dashboard version 2");
        }
    }
}
