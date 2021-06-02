using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace qBT.Core
{
    public class FileLoader
    {
        private string _fileName;
        private IMessager _messager;

        public FileLoader(string fileName, IMessager messager){
            _fileName = fileName;
            _messager = messager;
        }

        public List<string> Get() {
            var result = new List<string>();
            FileInfo fileInfo = new FileInfo(_fileName);
            if (!fileInfo.Exists) {
                _messager.Message($"file {fileInfo.FullName} not exist");
                return result;
            }

            using (FileStream fstream = File.OpenRead(_fileName))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                result = textFromFile
                    .Trim()
                    .Split(new string[] { "\r\n" } , StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }

            return result;
        }

        
    }
}