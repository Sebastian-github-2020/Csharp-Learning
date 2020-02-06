using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace _02.数据库操作 {
    class SQLServerHelper {
        public static readonly string ConnectionString="server=127.0.0.1;database=Account;user=sa;pwd=zaks";

       
        /// <summary>
        /// 基础版本
        /// </summary>
        private static void Demo()
        {
            //1.连接字符串
            string connStr = "server=.;database=Account;uid=sa;pwd=zaks";
            //2.构建链接对象
            SqlConnection connection = new SqlConnection(connStr);
            //3.链接数据库
            connection.Open();
            //4.创建查询命令
            SqlCommand cmd = new SqlCommand("select * from User_Account", connection);
            //5. 执行命令
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) {
                while (reader.Read()) {
                    Console.WriteLine($"{Convert.ToInt32(reader[0])}\t{reader[1].ToString()}\t{reader[2]}");
                }
            }
            //关闭读取流
            reader.Close();
            //释放链接资源
            connection.Dispose();
            //关闭链接
            connection.Close();
        }
        /// <summary>
        /// 自动释放的版本
        /// </summary>
        public void GetData()
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString)) {
                //连接数据库
                sqlConnection.Open();
                //创建命令
                SqlCommand cmd = new SqlCommand("select * from User_Account", sqlConnection);
                //执行命令
                SqlDataReader reader = cmd.ExecuteReader();
                //判断是否能读取到行
                if (reader.HasRows) {
                    //循环读取
                    while (reader.Read()) {
                        Console.WriteLine($"{Convert.ToInt32(reader[0])}\t{reader[1].ToString()}\t{reader[2]}");
                    }
                }

            }
        }

        /// <summary>
        /// 查询出数据表
        /// DataSet 包含数据表 DataTable
        /// </summary>
        /// <returns></returns>
        public DataTable GetAccountList() {
            using (SqlConnection connection = new SqlConnection(ConnectionString)) {
                connection.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from User_Account",connection);
                adapter.Fill(dt);
                return dt;
            }

           
        }
    }
}
