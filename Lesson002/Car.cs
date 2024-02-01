using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson002
{
    class Car
    {
        //成员变量
        //任何类型的变量 变量的个数没有限制 
        //类里的变量可以不初始化
        
        public string name = "红旗"; //public修饰是因为在program里被访问到
        public int[] array;
        public Car car; //不要初始化

        //成员变量和成员属性的名称对应，看到属性名知道对哪一个成员变量进行操作
        //一般情况属性名和成员变量名都是一一对应的
        //属性名一般大写
        public int year;
        public int month;
        public int[] months; //数组成员变量

        //成员属性
        //睡眠阶段
        public int sleeptime;
        //
        public int Year{
            set {
                if (value < 0)
                {
                    value = 0;
                }
                year = value; //把外部的值真正赋值给变量year
            }
            get {
                //对获取到的值进行一些处理
                year += 5;
                return year;
            }
        }

        public int[] Months
        {
            set
            {
                months = value; //下面的简便写法
                //for (int i = 0; i < months.Length -1; i++)
                //{
                //    months[i] = value[i];
                //}
            }
            get
            {
                return months;
            }
        }

        //索引器
        //this 代表当前的对象
        //索引器语法：
        //访问修饰符  类型  this[参数]
        //{
        //    set{}
        //    get{}
        // }
        public int this[int index]
        {
            set { 
                months[index] = value;
            }
            get { return months[index]; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("这辆车的信息：生产自" + this.year + "年" + month + "月");
        }
    }
}
