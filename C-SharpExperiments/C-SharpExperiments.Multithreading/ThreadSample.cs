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

        private object _locker = new object();
        // Создаём локер для закрытие исполняемой
        // внутри потока логики от других потоков

        public void CreateThread()
        {
            var thread = new Thread(PrintMessage)
            // Передаём в поток ёисполняемый в нём метод
            {
                Name = "First"
            };

            var thread2 = new Thread(PrintMessage)
            {
                Name = "SecondThread"
            };

            var message = "HAHA";

/*            var thread3 = new Thread(() => PrintMessage(message));

            thread3.Start();*/

            thread.Start();
            //Запускаем поток

            thread2.Start();
        }

        public void PrintMessage()
        {
            var currentThreadName = Thread.CurrentThread.Name;

            /*            lock (_locker)// Запихиваем внутрь локера логику
                        {
                            _number = 0;
                            for (var i = 0; i <= 10; i++)
                            {
                                Console.WriteLine($"{currentThreadName} - {_number}");
                                _number++;
                            }
                        }*/

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
    }
}
