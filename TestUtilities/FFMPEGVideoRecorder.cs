using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace TestUtilities
{
    public class FFMPEGVideoRecorder
    {

        private Process _recorderProcess;
        private bool _isRunning;
        private static string _driverExecutablePath = string.Empty;

        public FFMPEGVideoRecorder()
        {

        }

        public void Dispose()
        {
            if (_isRunning)
            {
                // Control with setting. Waits a little bit after the recording has finished.
                Thread.Sleep(ConfigurationService.Instance.GetVideoSettings().WaitAfterFinishRecordingMilliseconds);
                if (!_recorderProcess.HasExited)
                {
                    _recorderProcess?.Kill();
                    _recorderProcess?.WaitForExit();
                }

                _isRunning = false;
            }

            GC.SuppressFinalize(this);
        }

        public void Stop() => Dispose();

        public string Record(string filePath, string fileName)
        {
            string videoPath = $"{Path.Combine(filePath, fileName)}";
            string videoFilePathWithExtension = GetFilePathWithExtension(videoPath);
            try
            {
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"A problem occurred trying to initialize the create the directory you have specified. - {filePath}", ex);
            }

            if (!_isRunning)
            {

                var startInfo = GetProcessStartInfo(videoFilePathWithExtension);

                _recorderProcess = new Process
                {
                    StartInfo = startInfo,
                };
                ProcessProvider.StartProcess(_recorderProcess,
                    s =>
                    {
                        Debug.WriteLine(s);
                        Console.WriteLine(s);
                    },
                    er =>
                    {
                        var exception = new Exception(er);
                        Debug.WriteLine(exception.ToString());
                        Console.Error.WriteLine(exception);
                    });
                _isRunning = true;
            }

            return videoFilePathWithExtension;
        }

        private string GetFilePathWithExtension(string videoPathNoExtension)
        {
            string videoPathWithExtension;

            videoPathWithExtension = $"{videoPathNoExtension}.mpg";            

            return videoPathWithExtension;
        }

        private static IEnumerable<string> GetAllParentDirectories(DirectoryInfo directoryToScan)
        {
            var parentFolders = new List<string>();
            GetAllParentDirectories(directoryToScan, parentFolders);
            return parentFolders;
        }

        private static void GetAllParentDirectories(DirectoryInfo directoryToScan, List<string> directories)
        {
            if (directoryToScan == null || directoryToScan.Name == directoryToScan.Root.Name)
            {
                return;
            }

            directories.Add(directoryToScan.Name);
            GetAllParentDirectories(directoryToScan.Parent, directories);
        }

        private static string GetDriverExecutablePath()
        {
            if (string.IsNullOrEmpty(_driverExecutablePath))
            {
                string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var directoryInfo = new DirectoryInfo(assemblyFolder);
                var parentDirectories = GetAllParentDirectories(directoryInfo);

                if (parentDirectories.Count(x => x.Equals(directoryInfo.Name)) > 1)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        directoryInfo = directoryInfo?.Parent;
                    }
                }

                _driverExecutablePath = directoryInfo?.FullName;
            }

            return _driverExecutablePath;
        }


        private string GetFFmpegPath()
        {
            string assemblyFolder = GetDriverExecutablePath();
            string recorderFile = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "ffmpeg.exe" : "ffmpeg";
            string recorderFinalPath = Path.Combine(assemblyFolder ?? throw new InvalidOperationException(), recorderFile);
            return recorderFinalPath;
        }

        private ProcessStartInfo GetProcessStartInfo(string videoFilePathWithExtension)
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = GetFFmpegPath(),
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            startInfo.Arguments = $"-f gdigrab -framerate 30 -i desktop {videoFilePathWithExtension}";

            return startInfo;
        }
    }
}
