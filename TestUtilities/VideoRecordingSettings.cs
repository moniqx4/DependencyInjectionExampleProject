namespace TestUtilities
{
    public class VideoRecordingSettings
    {
        public int WaitAfterFinishRecordingMilliseconds { get; set; } = 500;
        public string FilePath { get; set; }
        public bool IsEnabled { get; set; }
    }
}
