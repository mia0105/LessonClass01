using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0004
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 抽象类 抽象方法
            //关键字：abstract修饰符
            // 1. 覆盖的方式
            // 在子类里和父类里创建一个相同的方法，那么在调用子类方法时就会覆盖掉父类方法
            //子类的成员变量和方法，作为父类的对象它可以存储但不能访问
            //Person person1 = new Student();
            //person1.Speak();
            //(person1 as Student).Speak();
            Person person1 = new Student();
            //Speak(person1);

            // 2.关键字方式（virtual override base方式）
            //简洁的去调用,没有进行判断，只需要看你赋值的对象是什么
            Person person2 = new Teacher();
            //Speak(person2);

            // 3. abstract修饰符
            //需要研究的三个方向：成员变量、方法、类
            //不能修饰成员变量，可以修饰成员属性，属性不能有语句块，且也必须定义在抽象类中
            //public abstract int id;
            //public abstract int ID { get; set; }
            //修饰方法：必须定义在抽象类中，且不能有方法体
            //修饰类
            Person person3 = new Student();
            Person person4 = new Teacher();
            PrintInfo(person3);
            PrintInfo(person4);
        #endregion
    }
        public static void PrintInfo(Person person)
        {
            person.PrintInfo();
        }

        public static void Speak(Person person)
        {
            //person.Speak();

            //if (person is Student)
            //{
            //    (person as Student).Speak();
            //}

            //if (person is Teacher)
            //{
            //    (person as Teacher).Speak();
            //}
        }
    }
}
