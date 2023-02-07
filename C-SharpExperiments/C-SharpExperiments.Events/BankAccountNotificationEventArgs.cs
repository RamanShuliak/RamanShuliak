using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.Events
{
    public class BankAccountNotificationEventArgs
    {
        public Guid AccountId { get; }
        public string Message { get; }
        public int DeltaSum { get; }
        public int SumOnAccount { get; }

        public BankAccountNotificationEventArgs
            (Guid id, string message, int deltaSum, int sumOnAccount)
        {
            AccountId = id;
            Message = message;
            DeltaSum = deltaSum;
            SumOnAccount = sumOnAccount;
        }

    }
}
