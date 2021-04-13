using NLog;

namespace NUnitTestProject
{
    public class TestContext
    {
        public ILogger Logger { get; internal set; }

        public string WorkflowName { get; set; }

        public string Version { get; set; } = "V3";
        
        public void Close()
        {
            //WebSite.Close();
        }
    }
    
}
