using StepRunner.Constants;
using System;

namespace StepRunner
{
    public class StepModel
    {
        public string Description { get; set; }
        public bool SkipStep { get; set; }
        public Importance Level { get; set; }
        public bool SkipStepOnFailure { get; set; }
        public bool FailsIteration { get; set; }
        public Status Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        public Exception StepException { get; set; }
    }
}
