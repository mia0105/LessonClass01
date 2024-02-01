using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0002
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 继承中的构造函数
            Person person = new Person(2);
            //子类会自动调用父类的无参构造函数，而且是优先调用父类再调用自己的
            Student student = new Student(1);
            #endregion

            #region Object类 所有类的父类
            /*
             * 装箱拆箱
             * 装箱：把子类的对象放到了Object里面，这个行为就叫做装箱
             * 
             */
            //通过里氏原则,也就是用父类的对象来指向子类的对象
            object o = new Student(2); //在栈空间里存储的是堆空间的地址

            Show(new Person(1));
            #endregion

            #region 密封类 sealed


            #endregion
        }
        public static void Show(object o) //使用object作为参数的话，上面调用时可以传入任何参数
            //改为 int o 的话只能传入int类型了
        {
            o.ToString();
        }
    }
}
