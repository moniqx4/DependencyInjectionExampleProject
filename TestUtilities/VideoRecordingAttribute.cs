using System;
using System.Collections.Generic;
using System.Text;

namespace TestUtilities
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public sealed class VideoRecordingAttribute : Attribute
    {
        public VideoRecordingAttribute(VideoRecordingMode videoRecordingMode) => VideoRecording = videoRecordingMode;

        public VideoRecordingMode VideoRecording { get; set; }
    }

    public enum VideoRecordingMode
    {
        Always,
        DoNotRecord,
        Ignore,
        OnlyPass,
        OnlyFail,
    }
}
