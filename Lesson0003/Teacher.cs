using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0003
{
    public class Teacher : Person 
    {
        public override void PrintInfo()
        {
            Console.WriteLine("Teacher 的打印信息");
        }
    }
}
