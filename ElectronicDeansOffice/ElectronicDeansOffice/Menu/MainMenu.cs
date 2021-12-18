using Core.Entities;
using Core.MainFunc;
using Data.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDeansOffice.Menu
{
    public class MainMenu
    {
        private int id;
        private bool IsExit = true;

        private List<Student> Students = new List<Student>();
        private List<Group> Groups = new List<Group>();
        private List<Dormitory> Dormitories = new List<Dormitory>();

        public MainMenu()
        {
            Students = XmlDataServices.LoadStudents(Students);
            Groups = XmlDataServices.LoadGroups(Groups);
            Dormitories = XmlDataServices.LoadDormitories(Dormitories);

            Menu();
        }

        private void Menu()
        {
            while (IsExit)
            {

                Console.Clear();
                Console.WriteLine("\tЕлектронний деканат: облік студентів навчального закладу");
                Console.WriteLine("\n\n" + "Управління студентами"
                    + "\n 0. Вийти з програми"
                    + "\n 1. Додати студента"
                    + "\n 2. Видалити студента"
                    + "\n 3. Реагувати дані про студента"
                    + "\n 4. Переглянути список всіх студентів");
                Console.WriteLine("\nУправління групами"
                    + "\n 5. Додати групу"
                    + "\n 6. Видалити групу"
                    + "\n 7. Редагувати дані групи"
                    + "\n 8. Переглянути список всіх груп"
                    + "\n 9. Переглянути дані певної групи"
                    + "\n 10. Додати студента до групи"
                    + "\n 11. Видалити студента з групи");
                Console.WriteLine("\n Управління поселенням у гуртожиток "
                    + "\n 12. Додати дані про гуртожиток"
                    + "\n 13. Змінити дані про гуртожиток"
                    + "\n 14. Поселити студента в гуртожиток"
                    + "\n 15. Виписати студента з гуртожитку"
                    + "\n 16. Переглянути інформацію про гуртожиток");
                Console.WriteLine("\n Пошук"
                    + "\n 17. Пошук студента за прізвищем"
                    + "\n 18. Пошук студента за ім'ям"
                    + "\n 19. Пошук студента у гуртожитку"
                    + "\n 20. Пошук студента певної групи");

            
                id = Entering.EnterInt32("\n\n\t Введіть номер команди", 0, 20);
                switch (id)
                {
                    case 0:

                        IsExit = false;
                        break;
                    case 1:
                        Console.WriteLine("\tЗаповніть форму");
                        string surname = Entering.EnterString("Прізвище:", 2, 20);
                        string name = Entering.EnterString("Ім'я:", 2, 20);
                        int age = Entering.EnterInt32("Вік:", 16, 70);
                        Students.Add(MainFunctional.AddStudent(surname, name, age));
                        break;
                    case 2:
                        MainFunctional.ShowAllStudents(Students);
                        id = Entering.EnterInt32("\t Введіть номер студента", 0, Students.Count - 1);
                        MainFunctional.DeleteStudent(Students, Students[id]);
                        break;
                    case 3:
                        MainFunctional.ShowAllStudents(Students);
                        id = Entering.EnterInt32("\t Введіть номер студента", 0, Students.Count - 1);
                        Console.WriteLine("\tЗаповніть форму");
                        surname = Entering.EnterString("Прізвище:", 2, 20);
                        name = Entering.EnterString("Ім'я:", 2, 20);
                        age = Entering.EnterInt32("Вік:", 16, 70);
                        MainFunctional.ChangeStudent(Students[id], surname, name, age);
                        break;
                    case 4:
                        Console.WriteLine("\tВсі клієнти");
                        MainFunctional.ShowAllStudents(Students);
                        break;
                    case 5:
                        Console.WriteLine("\tЗаповніть форму");
                        name = Entering.EnterString("Назва групи:", 2, 20);
                        Groups.Add(MainFunctional.AddGroup(name));
                        break;
                    case 6:
                        MainFunctional.ShowAllGroups(Groups);
                        id = Entering.EnterInt32("\t Введіть номер групи", 0, Groups.Count - 1);
                        MainFunctional.DeleteGroup(Groups, Groups[id]);
                        break;
                    case 7:
                        MainFunctional.ShowAllGroups(Groups);
                        id = Entering.EnterInt32("\t Введіть номер групи", 0, Groups.Count - 1);
                        Console.WriteLine("\tЗаповніть форму");
                        name = Entering.EnterString("Назва групи:", 2, 20);
                        MainFunctional.ChangeGroup(Groups[id], name);
                        break;
                    case 8:
                        Console.WriteLine("\tВсі групи");
                        MainFunctional.ShowAllGroups(Groups);
                        break;
                    case 9:
                        MainFunctional.ShowAllGroups(Groups);
                        id = Entering.EnterInt32("\t Введіть номер групи", 0, Groups.Count - 1);
                        MainFunctional.ShowCurrentGroupInfo(Groups[id]);
                        break;
                    case 10:
                        MainFunctional.ShowAllGroups(Groups);
                        int G_id = Entering.EnterInt32("\t Введіть номер групи", 0, Groups.Count - 1);
                        MainFunctional.ShowAllStudents(Students);
                        int S_id = Entering.EnterInt32("\t Введіть номер студента", 0, Students.Count - 1);
                        Groups[G_id].StudentsInGroup.Add(Students[S_id]);
                        break;
                    case 11:
                        MainFunctional.ShowAllGroups(Groups);
                        G_id = Entering.EnterInt32("\t Введіть номер групи", 0, Groups.Count - 1);
                        MainFunctional.ShowAllStudents(Groups[G_id].StudentsInGroup);
                        S_id = Entering.EnterInt32("\t Введіть номер студента", 0, Students.Count - 1);
                        Groups[G_id].StudentsInGroup.Remove(Groups[G_id].StudentsInGroup[S_id]);
                        break;
                    case 12:
                        Console.WriteLine("\tЗаповніть форму");
                        int number = Entering.EnterInt32("Номер кімнати:");
                        int countOfPlace = Entering.EnterInt32("Кількість місць", 1, 4);
                        Dormitories[0].Rooms.Add(MainFunctional.AddRoomInDormitory(number, countOfPlace));
                        break;
                    case 13:
                        Console.WriteLine("\tЗаповніть форму");
                        name = Entering.EnterString("Назва гуртожитку:", 2, 20);
                        countOfPlace = Entering.EnterInt32("Кількість місць", 20, 1000);
                        MainFunctional.ChangeDormitoryInfo(Dormitories[0], name, countOfPlace);
                        break;
                    case 14:
                        MainFunctional.ShowAllStudents(Students);
                        S_id = Entering.EnterInt32("\t Введіть номер студента", 0, Students.Count - 1);
                        MainFunctional.ShowAllRooms(Dormitories[0].Rooms);
                        id = Entering.EnterInt32("\t Введіть номер кімнати", 0, Dormitories[0].Rooms.Count-1);
                        if (Dormitories[0].Rooms[id].StudentsInRoom.Count < Dormitories[0].Rooms[id].CountOfPlace)
                        {
                            Dormitories[0].Rooms[id].StudentsInRoom.Add(Students[S_id]);
                        }
                        else Console.WriteLine("В даній кімнаті немає вільних місць");
                        break;
                    case 15:
                        MainFunctional.ShowAllRooms(Dormitories[0].Rooms);
                        id = Entering.EnterInt32("\t Введіть номер кімнати", 0, Dormitories[0].Rooms.Count - 1);
                        MainFunctional.ShowAllStudents(Dormitories[0].Rooms[id].StudentsInRoom);
                        S_id = Entering.EnterInt32("\t Введіть номер студента", 0, Students.Count - 1);
                        Dormitories[0].Rooms[id].StudentsInRoom.Remove(Dormitories[0].Rooms[id].StudentsInRoom[S_id]);
                        break;
                    case 16:
                        Console.WriteLine("\tІнформація про гуртожиток");
                        MainFunctional.ShowDormitoryInfo(Dormitories[0]);
                        break;
                    case 17:
                        string mainWord = Entering.EnterString("Введіть прізвище студнета");
                        try
                        {
                            var FindStudent = Students.Find(x => x.Surname.Contains(mainWord));
                            Console.WriteLine("Прізвище: {0}  Ім'я: {1} Вік: {2}", FindStudent.Surname, FindStudent.Name, FindStudent.Age);
                        }
                        catch
                        {
                            Console.WriteLine("Такого студнета немає");
                        }
                        break;
                    case 18:
                        mainWord = Entering.EnterString("Введіть ім'я студнета");
                        try
                        {
                            var FindStudent = Students.Find(x => x.Name.Contains(mainWord));
                            Console.WriteLine("Прізвище: {0}  Ім'я: {1} Вік: {2}", FindStudent.Surname, FindStudent.Name, FindStudent.Age);
                        }
                        catch
                        {
                            Console.WriteLine("Такого студнета немає");
                        }
                        break;
                    case 19:
                        mainWord = Entering.EnterString("Введіть прізвище студнета");
                        try
                        {
                            foreach (Room r in Dormitories[0].Rooms)
                            {
                                var FindStudent = r.StudentsInRoom.Find(x => x.Surname.Contains(mainWord));
                                Console.WriteLine("Прізвище: {0}  Ім'я: {1} Картка: {2}  Кімната: {3}", FindStudent.Surname, FindStudent.Name, FindStudent.Age, r.Number);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Такого студнета немає");
                        }
                        break;
                    case 20:
                        MainFunctional.ShowAllGroups(Groups);
                        G_id = Entering.EnterInt32("\t Введіть номер групи", 0, Groups.Count - 1);
                        mainWord = Entering.EnterString("Введіть прізвище студнета");
                        try
                        {
                            var FindStudent = Groups[G_id].StudentsInGroup.Find(x => x.Surname.Contains(mainWord));
                            Console.WriteLine("Прізвище: {0}  Ім'я: {1} Картка: {2}", FindStudent.Surname, FindStudent.Name, FindStudent.Age);
                        }
                        catch
                        {
                            Console.WriteLine("Такого студнета немає");
                        }
                        break;
                }
                XmlDataServices.SaveStudents(Students);
                XmlDataServices.SaveGroups(Groups);
                XmlDataServices.SaveDormitories(Dormitories);
                Console.WriteLine("\nДля продовження натисніть будь яку клавішу");
                Console.ReadLine();
            }
        }
    }
}
