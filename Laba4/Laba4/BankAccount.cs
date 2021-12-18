using System;
using System.Collections.Generic;
using System.Text;

namespace Prog
{
    class BankAccount
    {
        public string AccountCredit { get; set; }
        public double Money { get; set; }
        
        public bool isOverdrafted;
        public delegate void BacnkAccountHandler(object sender, AccountEvent args);
        public event BacnkAccountHandler Overdraft;
        Functions funcions = new Functions();
        public BankAccount(double money)
        {
            if (money != 0)
            {
                AccountCredit = "Активен";
                isOverdrafted = false;
            }
            else
            {
                isOverdrafted = true;
                AccountCredit = "Бан";
            }
            Money = money;
            
            Overdraft += funcions.Overdrafted;
        }
        public double GetAmount(double amoutOfMoney)
        {
            Money += amoutOfMoney;
            return Money;
        }
        public double WithdrawMoney(double amoutOfMoney)
        {
            if(isOverdrafted == false)
            {
                Money -= amoutOfMoney;
                if (Money < 0)
                    Overdraft?.Invoke(this, new AccountEvent("Ваш аккаунт заблокирован, востановите свой аккаунт"));
                
            }
            return Money;
        }
    }
}