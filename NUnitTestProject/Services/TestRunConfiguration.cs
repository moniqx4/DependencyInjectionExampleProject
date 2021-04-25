using DataModelLibrary.Enums;

namespace NUnitTestProject.Services
{
    public class TestRunConfiguration
    {
        public string StartUrl { get; set; }
       
        private Environment Environment { get; set; }

        private Teams Team { get; set; }

    }
}
