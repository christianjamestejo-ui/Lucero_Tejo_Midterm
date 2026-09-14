using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Midterm_Exam__Lab_.Holder
{
    public class BankAccount
    {
        private string _accNumber;
        private string _accHolder;
        private double _balance;

        public string AccountNumber => _accNumber;
        public string AccountHolder => _accHolder;

        //To do 1
        public double Balance => _balance;

        public BankAccount(string num, string name, double initialDep)
        {
            _accNumber = num; 
            _accHolder = name;
            //To do 2
            if (initialDep >= 0)
            {
                _balance = initialDep;
            }
            else
            {
                initialDep = 0.0;
            }

        }
        public bool Deposit(double amount)
        {
            //To do 3
            if (amount > 0)
            {
                double value = amount + _balance;
                _balance = value;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Withdraw(double amount)
        {
            //To do 4
            if (amount > 0 && amount <= _balance)
            {
                double value = _balance - amount;
                _balance = value;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetSummary()
        {
            return $"Acc: {_accNumber} | Holder: {_accHolder} | Balance: PHP {_balance:N2}";
        }
    }
}
