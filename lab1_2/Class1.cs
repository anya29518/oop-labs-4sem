using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp1_2_
{
    [Serializable]
    class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string University { get; set; }

        public Student(string s, string n, int a, string u)
        {
            Surname = s;
            Name = n;
            Age = a;
            University = u;
        }
        public Student()
        {
            Surname = " ";
            Name = " ";
            Age = 0;
            University = " ";
        }
    }
}
