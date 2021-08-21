using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MailSender
{
    public class StorageHelper
    {
        private List<FileInfo> fileList;

        public StorageHelper()
        {
            fileList = new List<FileInfo>();
        }

        public FileInfo GetFileInfo(string filePath)
        {
            FileInfo info = new FileInfo(filePath);
            return info;
        }

        public void AddToFileList(string path)
        {
            fileList.Add(new FileInfo(path));
        }

        public void RemoveFromFileList(string fileName)
        {
            fileList.RemoveAll(x => x.Name == fileName);
        }

        public List<string>GetFileList()
        {
            return fileList.Select(x => x.Name).ToList();
        }

        public string[] GetFilePaths()
        {
            return fileList.Select(x => x.FullName).ToArray();
        }

        public void ClearFileList()
        {
            fileList.Clear();
        }
    }
}
