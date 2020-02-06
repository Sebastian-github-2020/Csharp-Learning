using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _01.IO {
    /// <summary>
    /// 小文件读写
    /// </summary>
    public class OperateLittleFile : IOperaFile {
        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="path">路径</param>
        public string ReadFiles(string path)
        {
            string txt = File.ReadAllText(path, Encoding.UTF8);
            return txt;
        }
        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="encoding">编码</param>
        public string ReadFiles(string path, Encoding encoding)
        {
            string txt = File.ReadAllText(path, encoding);

            return txt;
        }
        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="content">写入的内容</param>
        public void WriteFiles(string path, string content)
        {
            File.WriteAllText(path, content);
        }
        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="content">写入的内容</param>
        /// <param name="encoding">编码格式</param>
        public void WriteFiles(string path, string content, Encoding encoding)
        {
            File.WriteAllText(path, content, encoding);
        }
    }
}
