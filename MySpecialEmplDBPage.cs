using System;

namespace DependencyInjectionExampleProject
{
    public class MySpecialEmplDBPage: IEmployeeDashboard
    {
        public MySpecialEmplDBPage()
        {

        }

        public void GetEmployeeDashboard()
        {
            Console.WriteLine("Getting My Special V2 EMPL DB Page");
        }
    }
}
