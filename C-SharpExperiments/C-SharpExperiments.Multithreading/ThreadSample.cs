using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.Multithreading
{
    public class ThreadSample
    {
        private int _number = 0;

        private AutoResetEvent _waitHandler = new AutoResetEvent(true);
        // создаём в рамках класса объект событий, которые сообщают
        // наружу другим потокам состояние логики (свободна или нет).
        // По умолчанию true - да, доступ открыт.

        private object _locker = new object();
        // Создаём локер для закрытие исполняемой
        // внутри потока логики от других потоков

        public void CreateThread()
        {
            for(var i = 1; i<=3; i++)
            {
                var thread = new Thread(PrintMessageWithAutoResetEvents)
                {
                    Name = $"Thread {i}"
                };

                thread.Start();
            }
        }

        public void PrintMessageWithLocker()
        {
            var currentThreadName = Thread.CurrentThread.Name;

            lock (_locker)// Запихиваем внутрь локера логику
            {
                _number = 0;
                for (var i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{currentThreadName} - {_number}");
                    _number++;
                }
            }
        }

        public void PrintMessageWithMonitor()
        {
            var currentThreadName = Thread.CurrentThread.Name;

            var acquiredLock = false;

            try
            {
                Monitor.Enter(_locker, ref acquiredLock);
                // Открываем блокировку через класс Monitor
                // Далее прописываем блокируемую логику

                _number = 0;
                for (var i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{currentThreadName} - {_number}");
                    _number++;
                }
            }
            finally
            {
                if (acquiredLock)
                {
                    Monitor.Exit(_locker);
                    // Отменяем блокировку
                }
            }
        }

        public void PrintMessageWithAutoResetEvents()
        {
            var currentThreadName = Thread.CurrentThread.Name;
            Console.WriteLine($"!!!!{currentThreadName} start here!!!!");

            _waitHandler.WaitOne();// Изменяет состояние на false

            _number = 0;
            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{currentThreadName} - {_number}");
                _number++;
            }

            Console.WriteLine($"!!!!{currentThreadName} finish here!!!!");

            _waitHandler.Set();// Возвращает true
        }
    }
}
