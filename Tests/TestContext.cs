using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExampleProject.Tests
{
    public class TestContext
    {
        //public ILogger Logger { get; internal set; }

        public string WorkflowName { get; set; }
        public void Close()
        {
            //WebSite.Close();
        }
    }
}
