using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Laba2
{
    public class ConsoleMenu
    {
        List _list = new List();
        Arrays _arrays = new Arrays();
        ArrayLists _arrayLists = new ArrayLists();
        public ConsoleMenu()
        {
            MainMenu();
        }
        public void MainMenu()
        {
            int Choice;
            string Serch = null;
            string Str = null;
            Console.WriteLine("Главное Меню: \nВведите 1 для поиска по символу, строке или номеру строки \nВведите 2 для смены порядка сортировки \nВведите 3 для добавления строки к существующей строке \nВведите 4 для вывода строки ");
            Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Console.WriteLine(
                        "Выберите способ поиска: \nВведите 1 для поиска по символу или строке \nВведите 2 для поиска по номеру строки");
                    Choice = Convert.ToInt32(Console.ReadLine());
                    switch(Choice)
                {
                    case 1:
                        Console.WriteLine("Введите символ или строку для поиска");
                        Serch = Console.ReadLine();
                        SerchLine(_list, Serch, _arrays, _arrayLists);
                        Console.WriteLine("Нажмите любую клавишу для выхода в главное меню");
                        Console.ReadKey();
                        Console.Clear();
                        MainMenu();
                        break;
                    case 2:
                        Console.WriteLine("Введите номер строки");
                        Serch = Console.ReadLine();
                        SerchLine(_list, Serch, _arrays, _arrayLists);
                        Console.WriteLine("Нажмите любую клавишу для выхода в главное меню");
                        Console.ReadKey();
                        Console.Clear();
                        MainMenu();
                        break;
                        
                }
                    break;
                case 2:
                    Console.WriteLine("Выберите способ сртировки: \nВведите 1 для сортировке по номеру строки \nВведите 2 для сортировки по номеру строки(обратная)");
                    Choice = Convert.ToInt32(Console.ReadLine());
                    switch(Choice)
                    {
                        case 1:
                            SortByNum(_list, _arrays, _arrayLists);
                            Console.WriteLine("Нажмите любую клавишу для выхода в главное меню");
                            Console.ReadKey();
                            Console.Clear();
                            MainMenu();
                            break;
                        case 2:
                            SortByNumR(_list, _arrays, _arrayLists);
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
                    AddStr(_list, Choice, Str, _arrays, _arrayLists);
                    Console.WriteLine("Нажмите любую клавишу для выхода в главное меню");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu();
                    break;
                case 4:
                    Console.WriteLine("Введите номер строки для поиска");
                    Serch = Console.ReadLine();
                    SerchSt(_list, Serch, _arrays, _arrayLists);
                    Console.WriteLine("Нажмите любую клавишу для выхода в главное меню");
                    Console.ReadKey();
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }
        public void SerchLine(List list,string serch, Arrays _arrays, ArrayLists _arrayLists)
        {
            for (int i = 0; i < list.Lines.Count; i++)
            {
                if (list.Lines[i].Num == serch || list.Lines[i].Strings == serch || _arrays.StrArray[i] == serch || _arrayLists.StrList[i] == serch)
                {
                    Console.WriteLine($"Номер строки: {list.Lines[i].Num}, длинна строки: {list.Lines[i].Strings.Length}, строка: {list.Lines[i].Strings}");
                    Console.WriteLine($" \nНомер строки: {i + 1}, длинна строки: {_arrays.StrArray[i].Length}, строка: {_arrays.StrArray[i]}");
                    Console.WriteLine($" \nНомер строки: {i + 1}, длинна строки: {_arrayLists.StrList[i].ToString().Length}, строка: {_arrayLists.StrList[i]}");
                }
            }
        }
        public void SortByNum(List list, Arrays _arrays, ArrayLists _arrayLists)
        {
            for (int i = 0; i < list.Lines.Count; i++)
            {
                Console.WriteLine($"Номер строки: {list.Lines[i].Num}, длинна строки: {list.Lines[i].Strings.Length}, строка: {list.Lines[i].Strings}");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Номер строки: {i + 1}, длинна строки: {_arrays.StrArray[i].Length}, строка: {_arrays.StrArray[i]}");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Номер строки: {i + 1}, длинна строки: {_arrayLists.StrList[i].ToString().Length}, строка: {_arrayLists.StrList[i]}");
            }
        }
        public void SortByNumR(List list, Arrays _arrays, ArrayLists _arrayLists)
        {
            int j = 3;
            for (int i = 0 ;i < list.Lines.Count; i++)
            {
                Console.WriteLine($"Номер строки: {list.Lines[j].Num}, длинна строки: {list.Lines[j].Strings.Length}, строка: {list.Lines[j].Strings}");
                j--;
            }
            Console.WriteLine();
            j = 3;
            for (int i = 0 ;i < 4; i++)
            {
                Console.WriteLine($"Номер строки: {j + 1}, длинна строки: {_arrays.StrArray[j].Length}, строка: {_arrays.StrArray[j]}");
                j--;
            }
            Console.WriteLine();
            j = 3;
            for (int i = 0 ;i < 4; i++)
            {
                Console.WriteLine($"Номер строки: {j + 1}, длинна строки: {_arrayLists.StrList[j].ToString().Length}, строка: {_arrayLists.StrList[j]}");
                j--;
            }
        }
        public void AddStr(List list, int choice, string str, Arrays _arrays, ArrayLists _arrayLists)
        {
            list.Lines[choice - 1].Strings += str;
            _arrays.StrArray[choice - 1] += str;
            _arrayLists.StrList[choice - 1] += str;
        }
        public void SerchSt(List list, string serch, Arrays _arrays, ArrayLists _arrayLists)
        {
            for (int i = 0; i < list.Lines.Count; i++)
            {
                if (list.Lines[i].Num == serch)
                {
                    Console.WriteLine($"Номер строки: {list.Lines[i].Num}, длинна строки: {list.Lines[i].Strings.Length}, строка: {list.Lines[i].Strings}");
                    Console.WriteLine($" \nНомер строки: {i + 1}, длинна строки: {_arrays.StrArray[i].Length}, строка: {_arrays.StrArray[i]}");
                    Console.WriteLine($" \nНомер строки: {i + 1}, длинна строки: {_arrayLists.StrList[i].ToString().Length}, строка: {_arrayLists.StrList[i]}");
                }
            }
        }
    }
}