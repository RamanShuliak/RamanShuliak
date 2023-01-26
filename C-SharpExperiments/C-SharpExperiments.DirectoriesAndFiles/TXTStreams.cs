using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.DirectoriesAndFiles
{
    public class TXTStreams
    {
        public void WorkWithText()
        {
            var textFilePath = @"D:\Programming\DT.txt";
            using (var sr = new StreamReader(textFilePath, Encoding.UTF8))
            {
                var symbol = sr.Peek();
                // возвращает интом в UTF8 кодировке значение одного символа в текстовике
                // (начиная от последней остановки коретки), или -1 (если док закончился)

                var buffer = new char[15];

                sr.Read();// возвращает следующий от указателя символ char-ом
                sr.Read(buffer, 0, 20);
                // возвратит в заготовленный buffer символы начиная с 0-го в кол-ве 20

                sr.ReadLine();// вернёт одну строку
                sr.ReadToEnd();// считает всё до конца от последней остановки коретки

            }
        }

    }
}
