using DependencyInjectionExampleProject;
using System;

namespace NUnitTestProject.Workflows
{
    public class ExampleTestWorkflow
    {
        private readonly IEmployeeDashboard _employeeDashboard;
        private readonly IPunchComponent _punchComponent;

        public ExampleTestWorkflow(IEmployeeDashboard employeeDashboard, IPunchComponent punchComponent)
        {
            _employeeDashboard = employeeDashboard;
            _punchComponent = punchComponent;
        }

        public void Execute()
        {
            ShowEmployeeDashboardPageMsg();
            ShowPunchComponentPageMsg();
        }

        private void ShowEmployeeDashboardPageMsg()
        {
            Console.Write("If you see this, then the test runner is setup properly. ");

            _employeeDashboard.GetEmployeeDashboard();
        }

        private void ShowPunchComponentPageMsg()
        {
            Console.Write("If you see this, then the test runner is setup properly. ");

            _punchComponent.GetPunchcomponent();
        }
    }
}
