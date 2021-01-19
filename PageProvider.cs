using Autofac;
using System;

namespace DependencyInjectionExampleProject
{
    public class PageProvider
    {
        public static void Main()
        {
            // this could be set in XML config, to be set per deployment
            AutofacExample.Version = "V2";

            //Autofac Example:
            IContainer container = AutofacExample.Setup();

            var pages = container.Resolve<IPages>();

            /*** This would be an example of getting our objects available in container using HomeGrown container ***/
            //var pages = HomeGrownDIExample.Setup();

            /*** Accessing and using the container objects ***/
            pages.GetPages();

            /*** Without DI to handle the same pages, and this would be necessary in every class that needs to use them, the other options above ONLY needs to be in the entry point/program startup class ***/
            //EmployeeDashboardV3 employeedb = new EmployeeDashboardV3();
            //EmployeeDashboardV2 employeedb2 = new EmployeeDashboardV2();
            //PunchComponent punch = new PunchComponent();
            //employeedb.GetEmployeeDashboard();
            //employeedb2.GetEmployeeDashboard();
            //punch.GetPunchcomponent();

            /*** Normally you would return the container from a method, and then call this method in the entry point of your project ***/

            Console.ReadKey();
        }
    }
}
