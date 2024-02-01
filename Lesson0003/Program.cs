using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0003
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 方法重写
            //同一个方法称为：方法名，返回值，参数列表是一致的
            Student stu = new Student();
            stu.PrintInfo();
            #endregion

            #region 里氏替换原则
            Person person1 = new Student();
            //if (person1 is Person)
            //{
            //    Console.WriteLine("Person");
            //}

            //if (person1 is Student)
            //{
            //    Console.WriteLine("Student");
            //}

            PrintInfo(new Student()); //调用方法时传入子类
            PrintInfo(new Teacher());
            #endregion
        }

        //静态方法：通过传入的参数来打印相应的信息
        public static void PrintInfo(Person person) //参数数父类对象
        {
            person.PrintInfo(); //调用的是父类的方法
        }
    }
}
