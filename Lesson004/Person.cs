using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson004
{
    public static class Person
    {
        //Person类拥有了两个属性/成员变量
        public string name;
        public static string country;
        public static int age;

        public static int Age 
        { get { return age; }
          set{ age = value; }
        }

        public void ShowCountry()
        {
            Console.WriteLine(country);
        }

        //静态方法
        //访问修饰符 static关键字 返回值类型 方法名
        public static void Show()
        {
            Console.WriteLine(country);
        }
    }
}
