using Autofac;
using Autofac.Features.ResolveAnything;
using System.Reflection;

namespace NUnitTestProject
{
    public static class ServiceProvider
    {
        public static IContainer Container { get; set; }

        public static IContainer Setup()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterType<SeleniumConfiguration>().As<ISeleniumRepositoryConfiguration>();

            //builder.RegisterAssemblyTypes(Assembly.Load("DependencyInjectionExampleProject")).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(NUnitTestProject)))
                            .Where(t => t.Namespace.Contains("Services"))
                            .AsImplementedInterfaces();
                        
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(AutomationServices)))
                            .Where(t => t.Name.StartsWith("I"))
                            .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(PageObjects))).AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(SeleniumWebDriver)))
                         .Where(t => t.Name.StartsWith("I"))
                         .AsImplementedInterfaces();

            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(DataModelLibrary))).InstancePerMatchingLifetimeScope();
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DataModelLibrary))).AsSelf();

            // Registering Classes without Interfaces
            builder.RegisterSource(new AnyConcreteTypeNotAlreadyRegisteredSource());

            //if (Version == "V3")
            //{
            //    builder.RegisterType<EmployeeDashboardPage>().As<IEmployeeDashboard>();
            //}
            //else builder.RegisterType<EmployeeDashboardPageV2>().As<IEmployeeDashboard>();

            // Scan an assembly for components
            //builder.RegisterAssemblyTypes(DependencyInjectionExampleProject)
            //       .Where(t => t.Name.StartsWith("I"))
            //       .AsImplementedInterfaces();

            return builder.Build();
           
        }

    }
}
