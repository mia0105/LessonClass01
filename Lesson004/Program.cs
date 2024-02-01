using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson004
{
    class Program
    {
        static void Main(string[] args)
        {
            //静态修饰符 static
            Person person = new Person();
            person.name = "nitaotao";
            Person.country = "China";
            person.ShowCountry();
            //使用对象来访问静态方法,发现是访问不了的
            //使用类的类名 导航出静态方法
            Person.Show();

            //把静态理解为它是一个公共的数据
            Person person2 = new Person();
            //此时这个person2并没有设置它的国家
            //我们写一个方法，让它打印出自己的国家
            person2.ShowCountry();
        }
    }
}
