using System;
using System.IO;
using System.Text;
namespace _01.IO {
    class Program {
       
        static void Main(string[] args)
        {
            //OperateLittleFile rf = new OperateLittleFile();
            //string txt =rf.ReadFiles(@"C:\Users\asus i7 radeon\Desktop\1.txt");
            //Console.WriteLine($"读取文件内容为:{txt}");
            //Console.WriteLine("开始写内容");
            //rf.WriteFiles("file.txt","写入内容");

            //BigFile.ReadFileWithFileStream("file.txt");


            OperateBigFile.WriteFileWithFileStream(@"C:\Users\asus i7 radeon\Downloads\Telegram Desktop\bug.docx",@"bug.docx");

            Console.ReadKey();
        }
       
    }
}
