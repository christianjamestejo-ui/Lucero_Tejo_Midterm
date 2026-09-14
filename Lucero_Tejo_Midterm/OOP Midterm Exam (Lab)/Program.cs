using System;
using System.Security.Principal;
using OOP_Midterm_Exam__Lab_.Holder;
using OOP_Midterm_Exam__Lab_.Functions;
using System.Linq.Expressions;

Console.Write("Enter Account Number: ");
string num = Console.ReadLine();
Console.Write("Enter Account Holder: ");
string name = Console.ReadLine();
double initBal = BankUI.ReadPositiveAmount(@"Enter Opening Balance: PHP ");

// To do 6
BankAccount account = new BankAccount(num, name, initBal);

bool run = true;
while (run)
{
    BankUI.ShowMenu();
    int.TryParse(Console.ReadLine(), out int ch);

    switch (ch)
    {
        case 1:
            Console.WriteLine(account.GetSummary());
            break;
        case 2:
            double dAmt =
            BankUI.ReadPositiveAmount("Deposit Amount: PHP ");
            if (account.Deposit(dAmt))
            {
                Console.WriteLine($"Deposited PHP {dAmt:N2}. Balance: PHP {account.Balance:N2}");
            }
            else
            {
                Console.WriteLine("Deposit failed! Invalid amount.");
            }
            break;
        case 3:
            double wAmt = BankUI.ReadPositiveAmount("Withdraw Amount: PHP ");
            if (account.Withdraw(wAmt))
            {
                Console.WriteLine($"Withdrew PHP {wAmt:N2}. Balance : PHP {account.Balance:N2}");
            }
            else
            {
                Console.WriteLine("Withdrawal failed! Insufficient funds.");
            }
            break;
        case 4:
            // To do 7
            Console.WriteLine("Goodbye!");
            run = false;
            break;
        default:
            Console.WriteLine("Invalid selection! Try again.");
            break;
    }
}