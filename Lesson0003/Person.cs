using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0003
{
    public class Person
    {
        //public void PrintInfo()
        //{
        //    Console.WriteLine("Person类打印信息");
        //}

        //添加virtual关键字
        public virtual void PrintInfo()
        {
            Console.WriteLine("Person类打印信息");
        }
    }
}
