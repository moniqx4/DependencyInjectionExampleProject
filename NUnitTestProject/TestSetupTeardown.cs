using NUnit.Framework;

namespace NUnitTestProject
{
    public class TestSetupTeardown
    {
        [SetUpFixture]
        public class TestSetupTearDown
        {
            // this is for the stuff that runs one time for the entire test suite
            [OneTimeSetUp]
            public void RunBeforeAnyTests()
            {
                PageObjectProvider.Setup("V3"); // passing the version, demonstrates a way to switch versions of objects to be set
            }

        }
    }
}
