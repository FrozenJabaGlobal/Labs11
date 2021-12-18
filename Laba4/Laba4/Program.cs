using System;
using System.Collections.Generic;
using System.Text;

namespace Prog
{
    class Program
    {
        static void Main()
        {
            int[,] nums = { { 0, 1, 2 }, { 3, 4, 5 } };
            Console.WriteLine("Анонимные функции\n Sum: " + LambdaAnonymous.CountAnonymousFunction(nums));
            Console.WriteLine("Лямбда Функции\n Sum: " + LambdaAnonymous.CountLambda(nums));
            double money = 7300;
            BankAccount bankAccount = new BankAccount(money);
            Console.WriteLine($"Количество денег на счёте : " + money);
            Console.WriteLine($"Снятие 300 грн : {bankAccount.WithdrawMoney(300)}");
            Console.WriteLine($"Снятие 7001 грн : {bankAccount.WithdrawMoney(7001)}");
        }
    }
}