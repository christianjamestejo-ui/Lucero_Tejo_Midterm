using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Midterm_Exam__Lab_.Functions
{
    public static class BankUI
    {
        public static void ShowMenu() => Console.Write("1. View Summary | 2. Deposit | 3. Withdraw | 4. Exit"
            + "\nChoose (1-4): ");

            
        public static double ReadPositiveAmount(string prompt)
        {
            //To do 5
            while (true)
            {
                double.TryParse(prompt = Console.ReadLine(), out double validValue);
                if (validValue > 0)
                {
                    return validValue;
                    break;
                }
            }
        }
    }
}
