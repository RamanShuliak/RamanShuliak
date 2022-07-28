using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.ATS
{
    public class Terminal
    {
        public int Number { get; set; }

        public bool OpenPort { get; set; }

        public int MonthPay { get; set; }

        public Terminal(int number, bool openPort, int monthPay)
        {
            Number = number;
            OpenPort = openPort;
            MonthPay = monthPay;
        }
    }
}
