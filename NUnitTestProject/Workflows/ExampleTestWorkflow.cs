using DependencyInjectionExampleProject;
using System;

namespace NUnitTestProject.Workflows
{
    public class ExampleTestWorkflow
    {
        private IEmployeeDashboard _employeeDashboard;

        public ExampleTestWorkflow(IEmployeeDashboard employeeDashboard)
        {
            _employeeDashboard = employeeDashboard;
        }

        public void Execute()
        {
            ShowEmployeeDashboardPageMsg();
        }

        private void ShowEmployeeDashboardPageMsg()
        {
            Console.Write("If you see this, then the test runner is setup properly. ");

            _employeeDashboard.GetEmployeeDashboard();
        }
    }
}
