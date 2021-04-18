using Autofac;
using NUnitTestProject.Services;
using System;
using System.Collections.Generic;

namespace NUnitTestProject
{
    internal class TestRunner
        {
            private readonly IContainer _container;

            private Queue<ServiceMethod> _setupMethods;

            private Queue<ServiceMethod> _teardownMethods;

            private List<Tuple<Type, Type>> _registrations;

            private readonly string _testName;

            //private readonly string _version;

            private readonly ITestLogger _logger;

        public TestRunner(string testName)
        {
            _testName = testName;
            //_version = version;
            _registrations = new List<Tuple<Type, Type>>();
            _container = ServiceProvider.Container;           
            _setupMethods = new Queue<ServiceMethod>();
            _teardownMethods = new Queue<ServiceMethod>();
            _logger.LogTest(testName);
        }

        public void Setup<T>(Action<object> setupMethod)
            {
                var method = new ServiceMethod { Service = typeof(T), Method = setupMethod };

                _setupMethods.Enqueue(method);
            }

            public void Setup<TTarget, TSource>()
            {
                _registrations.Add(Tuple.Create(typeof(TTarget), typeof(TSource)));
            }

            public void TearDown<T>(Action<object> setupMethod)
            {
                var method = new ServiceMethod { Service = typeof(T), Method = setupMethod };

                _teardownMethods.Enqueue(method);
            }

            public void Execute<T>(Action<T> testMethod)
            {
                while (_setupMethods.Count != 0)
                {
                    var method = _setupMethods.Dequeue();                
                    var service = _container.Resolve(method.Service);
                    method.Method(service);
                }
                var testContext = BuildTestContext();

                using (var scope = _container.BeginLifetimeScope(
                        builder =>
                        {                            
                            builder.RegisterInstance(testContext);
                        //builder.RegisterInstance(testContext.WebSite);
                        foreach (var registration in _registrations)
                            {                                
                                builder.RegisterType(registration.Item2).As(registration.Item1);
                            }
                        }))
                {
                    var service = scope.Resolve<T>();

                    try
                    {
                        testMethod(service);
                    }
                    finally
                    {
                        // Cleaning up the context
                        //testContext.Close();
                    }
                }

                while (_teardownMethods.Count != 0)
                {
                    var method = _teardownMethods.Dequeue();
                    var service = _container.Resolve(method.Service);
                    method.Method(service);
                }
            }

            private TestContext BuildTestContext()
            {
                var testContextBuilder = new TestContextBuilder(_logger);
                
                testContextBuilder
                    .AddLogger()
                    .AddName(_testName);
                        //.AddVersion(_version);

                var testContext = testContextBuilder.Build();

                return testContext;
            }


            private class ServiceMethod
            {
                public Type Service { get; set; }

                public Action<object> Method { get; set; }
            }
        }
    
}
