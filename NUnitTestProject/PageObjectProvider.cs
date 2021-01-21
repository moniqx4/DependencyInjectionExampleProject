using Autofac;
using Autofac.Features.ResolveAnything;
using PageObjects.WTDashboards;
using PageObjects.WTDashboards.ConcreteClasses;
using System.Reflection;

namespace NUnitTestProject
{
    public static class PageObjectProvider
    {
        public static IContainer Container { get; set; }

        public static string Version { get; set; } = "V3";

        public static IContainer Setup()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterAssemblyTypes(Assembly.Load("DependencyInjectionExampleProject")).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(Assembly.Load("NUnitTestProject")).AsImplementedInterfaces();

            // Registering Classes without Interfaces
            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());

            if (Version == "V3")
            {
                builder.RegisterType<EmployeeDashboardPage>().As<IEmployeeDashboard>();
            }
            else builder.RegisterType<EmployeeDashboardPageV2>().As<IEmployeeDashboard>();

            // Scan an assembly for components
            //builder.RegisterAssemblyTypes(DependencyInjectionExampleProject)
            //       .Where(t => t.Name.StartsWith("I"))
            //       .AsImplementedInterfaces();


            Container = builder.Build();
            Container.BeginLifetimeScope();

            return Container;
        }

    }
}
