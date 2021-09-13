using System.IO;

namespace TestUtilities
{
    public class DirectoryUtils
    {
        public bool DoesDirectoryExists(string path) => Directory.Exists(path);

        public string[] GetFiles(string path) => Directory.GetFiles(path);

        public string[] GetFiles(string path, string searchPattern) => Directory.GetFiles(path, searchPattern);

        public void CreateDirectory(string path) => Directory.CreateDirectory(path);

        public bool Exists(string path) => Directory.Exists(path);
    }
}
