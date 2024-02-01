using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0003
{
    public class Student:Person 
    {
        //public void PrintInfo(string name)
        //{
        //    Console.WriteLine("Student类打印信息");
        //    添加virtual关键字后即可省略该写法，通过override关键字来重写方法
        //}

        public string name { get; set; }
        //override+空格 自动生成
        public override void PrintInfo()
        {
            //base.PrintInfo();
            Console.WriteLine("Student类打印信息");
        }

    }
}
