using System;
using System.Collections.Generic;
using System.Text;

namespace DataModelLibrary
{
    public class StepInfo
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

    public enum Status
    {
        Passed,
        Failed,
        Skipped,
        Ready
    }

    public enum Importance
    {
        Lowest,
        Low,
        Normal,
        High,
        Highest
    }
}