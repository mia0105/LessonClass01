using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0002
{
    public class Student : Person
    {
        public string address;
        public Student(int id):base(id)
        {
            this.id = id;
        }

    }
}
