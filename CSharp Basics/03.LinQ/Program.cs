using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LinQ {
    class Program {
        static void Main(string[] args)
        {
            Demo5();
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


        /// <summary>
        /// 返回字符串
        /// </summary>
        static void Demo3() {
            //1.准备实体
            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "zaks", Age = 20, Score = 100 });
            students.Add(new Student { Name = "link", Age = 21, Score = 20 });
            students.Add(new Student { Name = "sephiroth", Age = 23, Score = 10 });
            students.Add(new Student { Name = "sebas", Age = 25, Score = 70 });
            students.Add(new Student { Name = "sebastian", Age = 120, Score = 100 });
            students.Add(new Student { Name = "jean", Age = 34, Score = 103 });
            //2.准备查询
            var a = (from student in students
                     where student.Score > 60
                     orderby student.Age ascending
                     select $"字符串{student}");

            foreach (var item in a) {
                Console.WriteLine(a);
            }

        }
        /// <summary>
        /// 返回字符串
        /// </summary>
        static void Demo4() {
            //1.准备实体
            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "zaks", Age = 20, Score = 100 });
            students.Add(new Student { Name = "link", Age = 21, Score = 20 });
            students.Add(new Student { Name = "sephiroth", Age = 23, Score = 10 });
            students.Add(new Student { Name = "sebas", Age = 25, Score = 70 });
            students.Add(new Student { Name = "sebastian", Age = 120, Score = 100 });
            students.Add(new Student { Name = "jean", Age = 34, Score = 103 });
            //2.准备查询
            var a = students.Where(s=>s.Age>20);

            foreach (var item in a) {
                Console.WriteLine(item.ToString());
            }

        }

        /// <summary>
        /// 多from子句
        /// </summary>
        static void Demo5() {
            //1.准备实体
            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "zaks", Age = 20, Score = 100 ,Books=new List<int> { 1,2,3,4,5} });
            students.Add(new Student { Name = "link", Age = 21, Score = 20, Books = new List<int> { 6,7,8 } });
            students.Add(new Student { Name = "sephiroth", Age = 23, Score = 10, Books = new List<int> { 11, 21, 31, 4, 51 } });
            students.Add(new Student { Name = "sebas", Age = 25, Score = 70, Books = new List<int> { 12, 23, 34, 45, 56 } });


            //2.准备查询 双重from
            var a = from student in students
                    from num in student.Books
                    where num > 10
                    orderby num ascending
                    select num;
            foreach (var item in a) {
                Console.WriteLine(item);
            }

        }
    }
}
