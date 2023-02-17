using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.Multithreading
{
    public class SemaphoreSample
    {
        private static Semaphore _semaphore = new Semaphore(3, 5);
        // Создаём поле класса  Semaphore
        // 3 - сколько потоков допущено к логике
        // 5 - сколько может быть максимально допущено

        private Thread _semaphoreThread;

        private int _count = 5;

        public SemaphoreSample(int id)
        {
            _semaphoreThread = new Thread(GetConsultation);
            _semaphoreThread.Name = $"Client {id}";
            _semaphoreThread.Start();
        }

        public void GetConsultation()
        {
            while(_count > 0)
            {
                _semaphore.WaitOne();// Ожидает сообщения, что логика свободна для занятия потоком

                Console.WriteLine($"{Thread.CurrentThread.Name} entered the office.");
                Console.WriteLine($"{Thread.CurrentThread.Name} get consultation.");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} left.");

                _semaphore.Release();// Освобождает логику от данного потока

                _count--;
            }
        }
    }
}
