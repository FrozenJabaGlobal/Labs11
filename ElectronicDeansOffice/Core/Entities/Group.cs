using System.Collections.Generic;

namespace Core.Entities
{
    public class Group
    {
        public string Name { get; set; }
        public List<Student> StudentsInGroup { get; set; }

        public Group()
        {
            StudentsInGroup = new List<Student>();
        }
    }
}