using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson003
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 构造函数
            //想使用类，必须先实例化类
            //无参构造函数
            Student student1 = new Student();
            student1.ID = 12;
            student1.Name = "nitaotao";
            student1.ShowInfo();

            //构造函数
            //此时不需要再像上面一样，一个个赋值
            Student student2 = new Student(2, "jimeiqin", 30); 
            student2.ShowInfo();

            //表示student2这个对象已经使用完，不再使用，不会再有引用
            student2 = null;
            /*
             * 当对象消亡时，会调用析构函数
             * 什么是垃圾？垃圾代表着没有引用的对象
             * GC就是垃圾回收
             */
            System.GC.Collect(); //C#会自动调用，不需要把这句写出来

            Student student3 = new Student(true,"shanghai");
            student3.ShowInfo();

            Student student4 = new Student(62474, "nitaotao", 20, true, "徐州");
            student4.ShowInfo();
            #endregion
        }
    }
}
