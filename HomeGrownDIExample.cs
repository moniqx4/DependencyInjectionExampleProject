using System.ComponentModel;

namespace DependencyInjectionExampleProject
{
    public static class HomeGrownDIExample {
        public static IContainer container { get; set; }

        public static IPages Setup()
        {
            //Build new Container
            DIContainer container = new DIContainer();

            //Register our interfaces
            container.Register<IEmployeeDashboard, EmployeeDashboardV3>();
            container.Register<IPunchComponent, PunchComponent>();
            container.Register<IPages, Pages>();

            //resolve these interfaces
            IPages pages = container.Resolve<IPages>();
            return pages;
        }
}
}
