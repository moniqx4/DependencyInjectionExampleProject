using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExampleProject
{
    public class EmployeeDashboard : IEmployeeDashboard
    {
        public EmployeeDashboard()
        {

        }
        public void GetEmployeeDashboard()
        {
            Console.WriteLine("Loads Whatever Version of Page is registered.");

        }
    }
}
