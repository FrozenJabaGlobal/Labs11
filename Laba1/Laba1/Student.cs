using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using static Laba1.Person;

namespace Laba1
{
    public class Student : Person
    {
        public string Course { get; set; }
        public string StudentId { get; set; }

        public static string path = @"F:\source\repos\Labs11\Laba1\DataBase.txt";
        public Student()
        {
        }
    }

}