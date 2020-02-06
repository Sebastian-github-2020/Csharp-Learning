using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;
namespace _02.数据库操作 {
    /// <summary>
    /// 操作sqlite数据库 方法和操作sqlsever一样  ,需要先创建数据库
    /// </summary>
    public class SqliteHelper {
        public static readonly string ConnectionString = "Data source=zaks.db";
        public static void demo() {
            using (SqliteConnection connection = new SqliteConnection(ConnectionString)) {
                connection.Open();
                SqliteCommand cmd = new SqliteCommand("select * from account",connection);
                SqliteDataReader reader =  cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        Console.WriteLine($"{reader[0]},{reader[1]},{reader[2]}");
                    }
                }
            }
        }
    }
}
