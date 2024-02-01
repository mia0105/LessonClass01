using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson002
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 成员变量
            //方法，成员方法（行为，功能）
            //Car car = new Car();
            ////设置值
            //car.name = "吉利";
            //car.months = new int[] { 1, 2, 3, 4, 5 }; //通过成员变量来调用
            //car.Months = new int[] { 1, 2, 3, 4, 5 }; //通过属性来调用
            //通过索引器来赋值,好处就是十分简洁代码
            //car[2] = 11; 
            //获取值
            //Console.WriteLine(car.name);
            //Console.WriteLine(car.months[2]); //获取到的值应该是3
            //Console.WriteLine(car[2]);

            Car car = new Car();
            car.Year = -2021;
            car.month = 1;

            Car car2 = new Car();
            car2.Year = 2023;
            car2.month = 3;

            car.ShowInfo();
            car2.ShowInfo();
            #endregion
        }
    }
}
