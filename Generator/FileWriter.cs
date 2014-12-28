using System;
using System.IO;

namespace Crafter.Generator
{
    public class FileWriter : IDisposable
    {
        private readonly StreamWriter _streamWriter;

        public FileWriter(string path)
        {
            _streamWriter = File.CreateText(path);
        }

        public void WriteLine(string text)
        {
            _streamWriter.WriteLine(text);
        }

        public static FileWriter WriteTextFile(string path)
        {
            return new FileWriter(path);   
        }

        public void Dispose()
        {
            _streamWriter.Flush();
            _streamWriter.Close();
        }
    }
}
