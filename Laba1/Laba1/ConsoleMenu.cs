using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Laba1
{
    public class ConsoleMenu
    {
        
        public ConsoleMenu()
        {
            MainMenu();
        }
        

        public void MainMenu()
        {
            int Choice;
            string Serch = null;
            Console.WriteLine("Главное Меню: \nВведите 1 для вывода информации о всех студентах \nВведите 2 для поиска студента по имени или студенческому \nВведите 3 для вывода информации о студентах 4-го курса родившихся весной ");
            Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    StudentsOutput();
                    Console.WriteLine("Нажмите любую клавишу для выхода в главное меню");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu();
                    break;
                case 2:
                    Console.WriteLine("Введите имя студента или номер студенческого");
                    Serch = Console.ReadLine();
                    SerchSt(Serch);
                    Console.WriteLine("Нажмите любую клавишу для выхода в главное меню");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu();
                    break;
                case 3:
                    Filter();
                    Console.WriteLine("Нажмите любую клавишу для выхода в главное меню");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu();
                    break;
            }
            
        }
        public static void StudentsOutput()
        {
            using (StreamWriter stream = new StreamWriter(Student.path))
            {
                for (int i = 0; i < 5; i++)
                {
                   Console.WriteLine(DataBase.StudentBase[i].Name + " " + DataBase.StudentBase[i].LastName + " номер Студенческого: " + DataBase.StudentBase[i].StudentId + " Курс: " + DataBase.StudentBase[i].Course + " день рождения: " + DataBase.StudentBase[i].Date);
                }
            }
        }
        public void SerchSt(string serch)
        {
            for (int i = 0; i < 5; i++)
            {
                if (DataBase.StudentBase[i].Name == serch || DataBase.StudentBase[i].StudentId == serch)
                {
                   Console.WriteLine(DataBase.StudentBase[i].Name + " " + DataBase.StudentBase[i].LastName + " номер Студенческого: " + DataBase.StudentBase[i].StudentId + " Курс: " + DataBase.StudentBase[i].Course + " день рождения: " + DataBase.StudentBase[i].Date);
                }
            }
        }
        public void Filter()
        {
            for (int i = 0; i < 5; i++){
                if (Regex.IsMatch(DataBase.StudentBase[i].Course, "[4]") && Regex.IsMatch(DataBase.StudentBase[i].Date, @"\d\d[.][0][3-5][.]"))
                {
                    Console.WriteLine(DataBase.StudentBase[i].Name + " " + DataBase.StudentBase[i].LastName + " номер Студенческого: " + DataBase.StudentBase[i].StudentId + " Курс: " + DataBase.StudentBase[i].Course + " день рождения: " + DataBase.StudentBase[i].Date);
                }
            }
        }
    }
}
