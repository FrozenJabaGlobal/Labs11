using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MainFunc
{

    public static class Entering
    {
        public static string format = "{0,40}: ";

        public static int EnterInt32(string prompt)
        {
            while (true)
            {
                Console.Write(format, prompt);
                string s = Console.ReadLine();
                int value;
                if (s == "")
                {
                    Console.WriteLine("\t\tпомилка введення");
                }
                else
                {
                    if (int.TryParse(s, out value))
                    {
                        return value;
                    }
                    Console.WriteLine("\t\tпомилка введення");
                }

            }
        }
        public static bool StringToBool(string prompt)
        {
            while (true)
            {
                Console.Write(format, prompt);
                string s = Console.ReadLine();
                if (s == "Н?" || s == "н?" || s == "Так" || s == "так")
                {
                    if (s == "Так" || s == "так")
                    {
                        return true;
                    }
                    else return false;
                }
                else Console.WriteLine("\t\tпомилка введення");
            }
        }
        public static string BoolToString(bool cheker)
        {
            if (cheker == true)
            {
                return "Так";
            }
            else
            {
                return "Ні";
            }
        }
        public static int EnterInt32(string prompt, int min, int max = int.MaxValue)
        {
            while (true)
            {
                int value = EnterInt32(prompt);
                if (value >= min && value <= max)
                {
                    return value;
                }
                Console.WriteLine("\t\tПотрібно вказати значення " + "в межах від {0} до {1} включно", min, max);
            }
        }

        public static double EnterDouble(string prompt)
        {
            while (true)
            {
                Console.Write(format, prompt);
                string s = Console.ReadLine();
                s = s.Replace('.', ',');
                double value;
                if (s == "")
                {
                    Console.WriteLine("\t\tпомилка введення");
                }
                else
                {
                    if (double.TryParse(s, out value))
                    {
                        return value;
                    }
                    Console.WriteLine("\t\tпомилка введення");
                }
            }
        }

        public static double EnterDouble(string prompt, double min, double max = double.MaxValue)
        {
            while (true)
            {
                double value = EnterDouble(prompt);
                if (value >= min && value <= max)
                {
                    return value;
                }
                Console.WriteLine("\t\tПотрібно вказати значення " + "в межах від {0} до {1} включно", min, max);
            }
        }

        public static string EnterString(string prompt)
        {
            Console.Write("\t{0}: ", prompt);
            string str = Console.ReadLine();
            str = str.Trim();
            return str;
        }

        public static string EnterString(string prompt, int min, int max = int.MaxValue)
        {
            while (true)
            {
                Console.Write("\t{0}: ", prompt);
                string str = Console.ReadLine();

                if (str.Length >= min && str.Length <= max)
                {
                    str = str.Trim();
                    return str;
                }
                Console.WriteLine("\t\tпотрібно вказати значеня рівне в межах від {0} до {1} включно", min, max);
            }
        }
        public static string EnterString(string prompt, int eq)
        {
            while (true)
            {
                Console.Write("\t{0}: ", prompt);
                string str = Console.ReadLine();

                if (str.Length == eq)
                {
                    str = str.Trim();
                    return str;
                }
                Console.WriteLine("\t\tпотрібно вказати значеня рівне {0}", eq);
            }
        }

        public static string EnterStringOrNull(string prompt)
        {
            Console.Write(format, prompt);

            string s = Console.ReadLine();
            s = s.Trim();

            return s == "" ? null : s;
        }

        public static double? EnterNullableDouble(string prompt)
        {
            Console.Write(format, prompt);
            string s = Console.ReadLine();
            double v;
            return (s == "") ? (double?)null : v = EnterDouble(s);
        }
    }
}
