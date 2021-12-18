using System.Collections.Generic;

namespace Core.Entities
{
    public class Room
    {
        public int Number { get; set; }
        public int CountOfPlace { get; set; }
        public List<Student> StudentsInRoom { get; set; }

        public Room()
        {
            StudentsInRoom = new List<Student>();
        }
    }
}