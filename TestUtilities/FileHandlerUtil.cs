using System.IO;
using System.IO.Compression;
using System.Text;

namespace TestUtilities
{
    public class FileHandlerUtil
    {
        public void Copy(string sourceFileName, string destFileName, bool overwrite) => File.Copy(sourceFileName, destFileName, overwrite);

        public void WriteAllText(string path, string contents) => File.WriteAllBytes(path, Encoding.UTF8.GetBytes(contents));

        public string ReadAllText(string path) => File.ReadAllText(path);

        public void Delete(string path) => File.Delete(path);

        public void CreateZip(string sourceDirectoryPath, string zipPath) => ZipFile.CreateFromDirectory(sourceDirectoryPath, zipPath);

        public void ExtractZip(string zipPath, string extractPath) => ZipFile.ExtractToDirectory(zipPath, extractPath);

        public byte[] ReadAllBytes(string filePath) => File.ReadAllBytes(filePath);

        public void WriteAllBytes(string filePath, byte[] fileData) => File.WriteAllBytes(filePath, fileData);

        public bool Exists(string filePath) => File.Exists(filePath);

        public bool IsWithExtension(string filePath, string extension)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("The specified file does not exist", filePath);
            }

            var fileInfo = new FileInfo(filePath);
            return fileInfo.Extension.Equals(extension);
        }
    }
}
