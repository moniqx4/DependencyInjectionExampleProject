using Autofac;

namespace DependencyInjectionExampleProject
{
    public static class AutofacExample
    {
        public static IContainer Container { get; set; }

        public static string EEDBVersion { get; set; }

        public static IContainer Setup()
        {
            var builder = new ContainerBuilder();
            if (EEDBVersion == "V3")
            {
                builder.RegisterType<EmployeeDashboardV3>().As<IEmployeeDashboard>();
            } else builder.RegisterType<EmployeeDashboardV2>().As<IEmployeeDashboard>();

          
            builder.RegisterType<PunchComponent>().As<IPunchComponent>();
            builder.RegisterType<Pages>().As<IPages>();

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
