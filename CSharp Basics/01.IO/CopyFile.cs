using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _01.IO {
    /// <summary>
    /// 复制文件
    /// </summary>
    public class CopyFile {
        /// <summary>
        /// 复制文件--小文件，大文件还是用文件流 读写的形式
        /// </summary>
        /// <param name="sourFilePath"></param>
        /// <param name="destinationFilePath"></param>
        public void CopyFileDemo(string sourFilePath,string destinationFilePath) {
            File.Copy(sourFilePath, destinationFilePath);          
        }
    }
}
