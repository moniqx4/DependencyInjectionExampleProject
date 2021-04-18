using System;

namespace NUnitTestProject.Services
{
    public class TestListeners
    {
        public DateTime TestStartTime { get; set; }

        public DateTime TestEndTime { get; set; }

        public bool OnTestFail { get; set; }

        public bool OnTestPass { get; set; }

        public DateTime OnStartTime { get; set; }

        public DateTime OnEndTime { get; set; }

        public bool OnSuccess { get; set; }
    }
}
