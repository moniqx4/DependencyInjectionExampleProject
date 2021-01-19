using Autofac;
using Autofac.Features.ResolveAnything;
using DependencyInjectionExampleProject;
using System.Reflection;

namespace NUnitTestProject
{
    public static class PageObjectProvider
    {
        public static IContainer Container { get; set; }

        public static string Version { get; set; }

        public static IContainer Setup()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(Assembly.Load("DependencyInjectionExampleProject")).AsImplementedInterfaces();

            // Registering Classes without Interfaces
            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());

            if (Version == "V3")
            {
                builder.RegisterType<EmployeeDashboardV3>().As<IEmployeeDashboard>();
            }
            else builder.RegisterType<EmployeeDashboardV2>().As<IEmployeeDashboard>();

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
