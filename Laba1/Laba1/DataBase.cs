using System.Collections.Generic;
using System.IO;

namespace Laba1
{
    public class DataBase
    {
        public static List<Student> StudentBase = new List<Student>()
        {
            new Student() {Name = "Andrew", LastName = "Dubenskiy", StudentId = "2281337", Course = "2", Date = "13.09.2003"},
            new Student() {Name = "Timophey", LastName = "Feduchuk", StudentId = "2281337", Course = "4", Date = "22.06.2003"},
            new Student() {Name = "Richard", LastName = "Shevchuk", StudentId = "2281337", Course = "3", Date = "13.09.2002"},
            new Student() {Name = "Sofiya", LastName = "Kulik", StudentId = "2281337", Course = "2", Date = "66.66.6666"},
            new Student() {Name = "Vladimir", LastName = "Pupin", StudentId = "2281337", Course = "4", Date = "13.05.2003"},
        };
        public static void DataBaseWrite()
        {
            using (StreamWriter stream = new StreamWriter(Student.path))
            {
                for (int i = 0; i < 5; i++)
                {
                    stream.WriteLine(DataBase.StudentBase[i].Name + " " + DataBase.StudentBase[i].LastName + " номер Студенческого: " + DataBase.StudentBase[i].StudentId + " Курс: " + DataBase.StudentBase[i].Course + " день рождения: " + DataBase.StudentBase[i].Date);
                }
            }
        }
    }
}