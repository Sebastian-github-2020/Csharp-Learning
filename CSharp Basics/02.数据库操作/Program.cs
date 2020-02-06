using System;
using System.Data;

namespace _02.数据库操作 {
    class Program {
        static void Main(string[] args)
        {
            SQLServerHelper sqlServer = new SQLServerHelper();
            //sqlServer.GetData();
            DataTable dt = sqlServer.GetAccountList();
            foreach (DataRow item in dt.Rows) {
                Console.WriteLine($"{item[0]},{item[1]},{item[2]}");
            }
            Console.ReadKey();
        }
    }
}
