using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5.ATS
{
    internal class User
    {
        delegate void UserRateHandler(string message);

        event UserRateHandler NotifyUserRate;
        public string Name { get; set; }

        public string Rate { get; set; }

        public int Number { get; set; }

        public DateTime UserDate { get; set; }

        public User(string name, string rate, int number, DateTime userDate)
        {
            Name = name;
            Rate = rate;
            Number = number;
            UserDate = userDate;
        }

        public int CreateUserID()
        {
            var createdUserID = new Random().Next(0, 2);

            return createdUserID;
        }
        
        // Данный метод даёт юзеру Роману попытку поменять свой тарифный план.
        // Я не смог родить аналогичный метод, общий для всех юзеров, чтобы каждый из них мог его вызвать.
        // Пытался делать через доп.цикл for с перебором листа юзеров, но он тогда меняет тариф у всех,
        // даже если вызывает метод конкретный юзер.
        public void ChoseRate(User roman, List<Rate> rates, DateTime startTime)
        {
            var prescriptionChoicingRate = DateTime.Now - roman.UserDate;

            var prescriptionChoicingRateInt = prescriptionChoicingRate.Days;

            var x = 0;

            for (int i = 0; i < rates.Count; i++)
            {
                if (prescriptionChoicingRateInt >= 30 && roman.Rate != rates[i].Name)
                {
                    roman.Rate = rates[i].Name;

                    roman.UserDate = DateTime.Now;

                    NotifyUserRate?.Invoke($"User {roman.Name}, you have changed your rate for {roman.Rate}");

                    Console.WriteLine($"User {roman.Name}, you have changed your rate for {roman.Rate}");
                    
                    break;

                }
                else
                {
                    x++;
                }
            }

            if (x >= rates.Count)
            {
                NotifyUserRate?.Invoke($"User {roman.Name}, you can't change your rate" +
                    $"because you have already changed it in this month " +
                    $"or you already use this rate");

                Console.WriteLine($"User {roman.Name}, you can't change your rate " +
                    $"because you have already changed it in this month " +
                    $"or you already use this rate");
            }
        }
    }
}
