using Autofac;


namespace TestRunnerLibrary
{
    public class ServiceProvider
    {
        public static IContainer Container { get; set; }


        public static IContainer Setup()
        {
            var builder = new ContainerBuilder();

            return builder.Build();
        }
    }
}
