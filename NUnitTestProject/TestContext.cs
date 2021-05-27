namespace NUnitTestProject
{
    public class TestContext
    {
        //public ILogger Logger { get; internal set; }

        public string TestName { get; set; }

        public string Version { get; set; }
        
        public void Close()
        {
            //WebSite.Close();
        }
    }
    
}
