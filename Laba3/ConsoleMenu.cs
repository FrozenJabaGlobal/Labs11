using System;

namespace Laba3
{
    public class ConsoleMenu
    {
        Lists _lists = new Lists();
        public ConsoleMenu()
        {
            MainMenu();
        }
        public void MainMenu()
        {
            int Choice;
            string Serch;
            string Str;
            Console.WriteLine("Главное Меню: \nВведите 1 для поиска по символу, строке или номеру строки \nВведите 2 для смены порядка сортировки \nВведите 3 для добавления строки к существующей строке \nВведите 4 для вывода строки \nВведите 5 для вывода списка линий из файла ");
            Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Введите символ или строку для поиска");
                        Serch = Console.ReadLine();
                        SerchLine(_lists, Serch);
                        Console.WriteLine("Нажмите любую клавишу для выхода в главное меню");
                        Console.ReadKey();
                        Console.Clear();
                        MainMenu();
                        break;
                    case 2:
                    Console.WriteLine("Выберите способ сртировки: \nВведите 1 для сортировке по номеру строки \nВведите 2 для сортировки по номеру строки(обратная)");
                    Choice = Convert.ToInt32(Console.ReadLine());
                    switch(Choice)
                    {
                        case 1:
                            SortByNum(_lists);
                            Console.WriteLine("Нажмите любую клавишу для выхода в главное меню");
                            Console.ReadKey();
                            Console.Clear();
                            MainMenu();
                            break;
                        case 2:
                            SortByNumR(_lists);
                            Console.WriteLine("Нажмите любую клавишу для выхода в главное меню");
                            Console.ReadKey();
                            Console.Clear();
                            MainMenu();
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Выберите номер строки для редактирования");
                    Choice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите что нужно добавить в строку: ");
                    Str = Console.ReadLine();
                    AddStr(_lists, Choice, Str);
                    Console.WriteLine("Нажмите любую клавишу для выхода в главное меню");
                    Console.ReadKey();
                    XmlSerializ.SerializeList("top_txt.xml",_lists);
                    Console.Clear();
                    MainMenu();
                    break;
                case 4:
                    Console.WriteLine("Введите номер строки для поиска");
                    Serch = Console.ReadLine();
                    SerchSt(_lists, Serch);
                    Console.WriteLine("Нажмите любую клавишу для выхода в главное меню");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu();
                    break;
                case 5:
                    XMLDerialize.DerializeList(_lists);
                    Console.WriteLine("Нажмите любую клавишу для выхода в главное меню");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }
        public void SerchLine(Lists list,string serch)
        {
            for (int i = 0; i < list.Lines.Count; i++)
            {
                if (list.Lines[i].StringValue == serch || list.Lines[i].StringValue == serch)
                {
                    Console.WriteLine($"Номер строки: {list.Lines[i].Num}, длинна строки: {list.Lines[i].StringValue.Length}, строка: {list.Lines[i].StringValue}");
                }
            }
        }
        public void SortByNum(Lists list)
        {
            for (int i = 0; i < list.Lines.Count; i++)
            {
                Console.WriteLine($"Номер строки: {list.Lines[i].Num}, длинна строки: {list.Lines[i].StringValue.Length}, строка: {list.Lines[i].StringValue}");
            }
        }
        public void SortByNumR(Lists list)
        {
            int j = 3;
            for (int i = 0 ;i < list.Lines.Count; i++)
            {
                Console.WriteLine($"Номер строки: {list.Lines[j].Num}, длинна строки: {list.Lines[j].StringValue.Length}, строка: {list.Lines[j].StringValue}");
                j--;
            }
        }
        public void AddStr(Lists list, int choice, string str)
        {
            list.Lines[choice - 1].StringValue += str;
        }
        public void SerchSt(Lists list, string serch)
        {
            for (int i = 0; i < list.Lines.Count; i++)
            {
                if (list.Lines[i].Num == serch)
                {
                    Console.WriteLine($"Номер строки: {list.Lines[i].Num}, длинна строки: {list.Lines[i].StringValue.Length}, строка: {list.Lines[i].StringValue}");
                }
            }
        }
    }
}