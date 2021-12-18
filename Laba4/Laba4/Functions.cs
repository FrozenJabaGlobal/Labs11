using System;
using System.Collections.Generic;
using System.Text;

namespace Prog
{
    class Functions
    {
        public void Overdrafted(object sender,AccountEvent e)
        {
            BankAccount bankAccount = (BankAccount)sender;
            bankAccount.isOverdrafted = true;
            Console.WriteLine(e.message);
        }
    }
}