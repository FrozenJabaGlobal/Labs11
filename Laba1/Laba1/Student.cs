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