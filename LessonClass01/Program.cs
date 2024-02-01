using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonClass01
{
    class Program
    {
        //Main方法是项目的入口点
        static void Main(string[] args)
        {
            //推演生成类的实例化使用
            int a = 1;
            //类名 对象名（变量名） = 关键字new 类名()
            //类的实例化 实例
            //充分理解类和对象
            //类是引用类型
            Person nitaotao = new Person();
            
            Person2 person2 = new Person2(); //结构体

            //区域语句
            #region 访问修饰符
            //访问 要使用这个变量 对象 使用的方式，形象化 访问
            //访问级别 从小到大 
            //private protect internal public
            //私有的  保护的  内部的   公共的
            //private 类自己内部可以使用
            PrivateClass privateClass = new PrivateClass();

            #endregion

            #region 类名和文件名
            Car car = new Car();

            #endregion
        }
    }
}
