using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0002
{
    public class Person
    {
        public int id;
        public string name;

        //ctor+Tab键 创建无参构造函数
        public Person(int id)
        {
            this.id = id;
            
            //Console.WriteLine("Person的构造函数");
        }
    }
}
