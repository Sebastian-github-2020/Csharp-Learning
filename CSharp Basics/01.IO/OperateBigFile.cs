using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace _01.IO {
    /// <summary>
    /// 读写大文件  需要用到流
    /// </summary>
    public class OperateBigFile {
        /// <summary>
        /// 文件流读取
        /// </summary>
        /// <param name="path">路径</param>
        public static void ReadFileWithFileStream(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read)) {
                //缓冲区
                byte[] buffer = new byte[1024];
                //读取内容 返回读取的实际长度，并不一定是 缓冲区的长度


                while (true) {
                    int count = stream.Read(buffer, 0, buffer.Length);

                    if (count < 1) {
                        break;
                    } else {
                        string a = Encoding.UTF8.GetString(buffer);
                        Console.WriteLine("读取的内容:" + a);

                    }
                }

                Console.WriteLine("读取完毕");
            }

        }


        /// <summary>
        /// 文件流的形式写入文件
        /// </summary>
        /// <param name="source">源路径</param>
        /// <param name="destination">目标路径</param>
        public static void WriteFileWithFileStream(string source, string destination)
        {
            if (File.Exists(source)) {
                byte[] readBuffer = new byte[1024 * 1024];
               
                using (FileStream fs = new FileStream(source, FileMode.Open, FileAccess.Read)) {
                    using (FileStream fw = new FileStream(destination, FileMode.OpenOrCreate, FileAccess.Write)) {
                        //1.读取目标文件
                        while (true) {
                            int count_read = fs.Read(readBuffer,0,readBuffer.Length);
                            if (count_read ==0) {
                                break;
                            } else {
                                //写入到新的地址中
                                fw.Write(readBuffer,0,count_read);
                            }
                        }
                    }
                }
            }

        }
    }
}
