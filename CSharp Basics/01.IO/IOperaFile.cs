using System;
using System.Collections.Generic;
using System.Text;

namespace _01.IO {
    public interface IOperaFile {
       
        abstract public string ReadFiles(string path);
        abstract public string ReadFiles(string path, Encoding encoding);
        abstract public void WriteFiles(string path, string content);
        abstract public void WriteFiles(string path, string content,Encoding encoding);
    }
}
