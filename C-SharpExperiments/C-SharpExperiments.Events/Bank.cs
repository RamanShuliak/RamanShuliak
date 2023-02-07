using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.Events
{
    public class Bank
    {
        public string Name { get; set; }
        public List<BankAccount> BankAccounts { get; set; }
        public Bank() { }

        public Bank(string name, List<BankAccount> bankAccounts)
        {
            Name = name;
            BankAccounts = bankAccounts;
        }

        public void AddAccount(BankAccount bankAccount)
        {
            BankAccounts.Add(bankAccount);
            bankAccount.Notify += SmsNotify;
        }

        public void SmsNotify(BankAccount sender, BankAccountNotificationEventArgs eventArgs)
        {
            var targetPhoneNumber = sender.PhoneNumber;

            var sb = new StringBuilder();
            sb.Append(eventArgs.Message);
            sb.Append(Environment.NewLine);
            sb.Append($"Actual state: {eventArgs.SumOnAccount}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(sb.ToString());
            Console.ResetColor();
        }
    }
}
