using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson003
{
    /// <summary>
    /// 学生
    /// </summary>
    class Student
    {
        /// <summary>
        /// 学生ID
        /// </summary>
        public int ID { get; set; } //默认的成员属性
        /// <summary>
        /// 学生姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 学生年龄
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public bool Sex { get; set; }
        /// <summary>
        /// 家庭地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 打印信息
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("我的学号{0}，我的姓名{1},我的年龄{2},我的性别{3},我的家庭住址{4}", ID, Name, Age, Sex, Address);
        }

        //构造函数
        public Student()
        {
            Console.WriteLine("我的无参构造函数");
        }

        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="id">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="age">年龄</param>
        public Student(int id,string name,int age)
        {
            ID = id; //使用属性来接收参数的值
            Name = name;
            Age = age;
        }

        /// <summary>
        /// 有参构造函数2
        /// </summary>
        /// <param name="sex">性别</param>
        /// <param name="address">家庭住址</param>
        public Student(bool sex,string address)
        {
            Sex = sex;
            Address = address;
        }
        /// <summary>
        /// this调用函数1，不用重复写
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="sex"></param>
        /// <param name="address"></param>
        public Student(int id,string name,int age,bool sex,string address):this(id,name,age)
        {
            Sex = sex;
            Address = address;
        }

        //没有引用
        //析构函数
        //也不用特地写出来，C#会自动调用，在你将对象设为null之后
        ~Student()
        {
            Console.WriteLine("析构函数");

        }
    }
}
