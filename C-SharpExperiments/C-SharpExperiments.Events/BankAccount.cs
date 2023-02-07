using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.Events
{
    public delegate void AccountNotificationHandler(BankAccount sender, BankAccountNotificationEventArgs eventArgs);
    public class BankAccount
    {
        public Guid AccountId { get; }
        public string PhoneNumber { get; }

        private int _sumOnAccount;

        public event AccountNotificationHandler Notify;

        public BankAccount(string phoneNumber, int sumOnAccount)
        {
            AccountId = Guid.NewGuid();
            PhoneNumber = phoneNumber;
            _sumOnAccount = sumOnAccount;
        }

        public void Add(int deltaSum)
        {
            _sumOnAccount += deltaSum;
        }

        public void CashWithdrow(int deltaSum)
        {
            if(_sumOnAccount >= deltaSum)
            {
                _sumOnAccount -= deltaSum;

                Notify?.Invoke(this,
                    new BankAccountNotificationEventArgs
                    (AccountId,
                    $"You take {deltaSum}$ from your account.",
                    deltaSum,
                    _sumOnAccount));
            }
            else
            {
                Notify?.Invoke(this,
                    new BankAccountNotificationEventArgs
                    (AccountId,
                    $"You don't have enough money on your account fo this operation.", 
                    deltaSum, 
                    _sumOnAccount));
            }
        }

        public void SmsNotify(BankAccountNotificationEventArgs eventArgs)
        {
            var targetPhoneNumber = PhoneNumber;

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
