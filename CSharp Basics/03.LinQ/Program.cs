using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LinQ {
    class Program {
        static void Main(string[] args)
        {
            Demo1();
            Console.ReadKey();
        }
        /// <summary>
        /// 基本使用
        /// </summary>
        static void Demo1()
        {
            
            //1.准备实体
            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "zaks", Age = 20, Score = 100 });
            students.Add(new Student { Name = "link", Age = 21, Score = 20 });
            students.Add(new Student { Name = "sephiroth", Age = 23, Score = 10 });
            students.Add(new Student { Name = "sebas", Age = 25, Score = 70 });
            students.Add(new Student { Name = "sebastian", Age = 120, Score = 100 });
            students.Add(new Student { Name = "jean", Age = 34, Score = 103 });
            //2.准备查询
            IEnumerable<Student> query = from student in students
                                         where student.Score > 60
                                         orderby student.Age ascending
                                         select student;
            //迭代
          
            Console.WriteLine(query.ToString());
            foreach (Student item in query) {
                Console.WriteLine($"{item.Name}-{item.Score}-{item.Age}");
            }
        }
        /// <summary>
        /// 返回总量
        /// </summary>
        static void Demo2()
        {
            //1.准备实体
            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "zaks", Age = 20, Score = 100 });
            students.Add(new Student { Name = "link", Age = 21, Score = 20 });
            students.Add(new Student { Name = "sephiroth", Age = 23, Score = 10 });
            students.Add(new Student { Name = "sebas", Age = 25, Score = 70 });
            students.Add(new Student { Name = "sebastian", Age = 120, Score = 100 });
            students.Add(new Student { Name = "jean", Age = 34, Score = 103 });
            //2.准备查询
            int a = (from student in students
                                          where student.Score > 60
                                          orderby student.Age ascending
                                          select student).Count();
           
            Console.WriteLine("有效数据数量是:{0}",a);
        
        }
    }
}
