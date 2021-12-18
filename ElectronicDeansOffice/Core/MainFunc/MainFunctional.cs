using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MainFunc
{
    public static class MainFunctional
    {
        public static Student AddStudent(string surname, string name, int age)
        {
            return new Student() { Surname = surname, Name = name, Age = age };
        }
        public static void DeleteStudent(List<Student> students, Student student)
        {
            students.Remove(student);
        }
        public static void ShowAllStudents(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(i + " Прізвище: " + students[i].Surname + " Ім'я: " + students[i].Name + " Вік: " + students[i].Age);
            }
        }
        public static Group AddGroup(string name)
        {
            return new Group() { Name = name };
        }
        public static void DeleteGroup(List<Group> groups, Group group)
        {
            groups.Remove(group);
        }
        public static void ShowAllGroups(List<Group> groups)
        {
            for (int i = 0; i < groups.Count(); i++)
            {
                Console.WriteLine(i + " Назва: " + groups[i].Name);
            }
        }
        public static void ShowCurrentGroupInfo(Group group)
        {
            Console.WriteLine(group.Name);
            ShowAllStudents(group.StudentsInGroup);
        }
        public static Room AddRoomInDormitory(int number, int countOfPlace)
        {
            return new Room() { Number = number, CountOfPlace = countOfPlace};
        }

        public static void ShowAllRooms(List<Room> rooms)
        {
            for(int i = 0; i < rooms.Count; i++)
            {
                Console.WriteLine(i + " Кімнатa: " + rooms[i].Number + " Кількість місць в кімнаті " + (rooms[i].CountOfPlace - rooms[i].StudentsInRoom.Count));
            }
        }
        public static void ShowDormitoryInfo(Dormitory dormitory)
        {
            int countOfВwellers = 0;
            foreach (Room r in dormitory.Rooms)
            {
                countOfВwellers += r.StudentsInRoom.Count;
            }
            Console.WriteLine("Назва: " + dormitory.Name + " Кількість кімнат: " + dormitory.Rooms.Count + " Кількість мешканців: " + countOfВwellers);
        }
        public static void ChangeStudent(Student student, string surname, string name, int age)
        {
            student.Surname = surname;
            student.Name = name;
            student.Age = age;
        }
        public static void ChangeGroup(Group group, string name)
        {
            group.Name = name;
        }
        public static void ChangeDormitoryInfo(Dormitory dormitory, string name, int countOfPlace)
        {
            dormitory.Name = name;
            dormitory.CountOfPlace = countOfPlace;
        }
    }
}
