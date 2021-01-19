using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExampleProject.Tests.Workflows
{
    public class TestWorkflow
    {
        private IEmployeeDashboard _employeeDashboard;

        public TestWorkflow(IEmployeeDashboard employeeDashboard)
        {
            _employeeDashboard = employeeDashboard;
        }

        public void Execute()
        {
            ShowEmployeeDashboardPageMsg();
        }

        private void ShowEmployeeDashboardPageMsg()
        {
            Console.Write("If you see this, then the test runner is setup properly.");

            _employeeDashboard.GetEmployeeDashboard();
        }
    }
}
