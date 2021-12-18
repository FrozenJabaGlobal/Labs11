using System.Collections.Generic;

namespace Core.Entities
{
    public class Dormitory
    {
        public string Name { get; set; }
        public List<Room> Rooms { get; set; }
        public int CountOfPlace { get; set; }

        public Dormitory()
        {
            Rooms = new List<Room>();
        } 
    }
}