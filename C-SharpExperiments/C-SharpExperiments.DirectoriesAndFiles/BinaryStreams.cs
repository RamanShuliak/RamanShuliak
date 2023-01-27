using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.DirectoriesAndFiles
{
    public class BinaryStreams
    {
        public void WorkWithBinaryFile(string path)
        {
            var employeesList = new List<string>()
            {
                "Sekiguchi Sharaku",
                "Amari Oniji",
                "Kawata Tomohiko",
                "Gima Kyoden",
                "Isayama Kosho",
                "Tachibana Okura",
                "Ueyonabaru Tetsuyuki",
                "Mizuno Chikafusa",
                "Okazaki Sadaharu",
                "Toma Yoshitake"
            };

            var companiesList = new List<string>()
            {
                "Mitsubishi",
                "KDDI",
                "Japan Post Holdings",
                "Sumitomo Mitsui Financial Group",
                "Honda Motor",
                "Mitsubishi UFJ Financial Group",
                "Nippon Telegraph and Telephone",
                "Sony",
                "SoftBank",
                "Toyota Motor"
            };


            using (var bw = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate, FileAccess.Write)))
                // ограничение по доступу через Mode и Access не обязательно, но нужно для наглядности
            {
                for (int i = 0; i < 10; i++)
                {
                    var durationOfWorkInYears = new Random().Next(1, 70);
                    bw.Write(employeesList[i]);
                    bw.Write(durationOfWorkInYears);
                    bw.Write(companiesList[i]);
                    // запись в файл ведётся из ранее созданных коллекций
                }
            }

            var employees = new List<JapanEmployee>();

            using (var br = new BinaryReader(File.Open(path, FileMode.Open, FileAccess.Read)))
            {
                for (int i = 0; i < 10; i++)
                {
                    var name = br.ReadString();
                    var duration = br.ReadInt32();
                    var company = br.ReadString();
                    // читаем данные из файла, зная в каком порядке они там записаны, перемещая каретку по доку

                    employees.Add(new JapanEmployee()
                    {
                        Name = name,
                        Duration = duration,
                        Company = company
                    });
                    // передаём полученные данные объектам класса JapanEmployee при их создании
                }

                foreach(var employee in employees)
                {
                    Console.WriteLine($"Employee {employee.Name} work in {employee.Company} " +
                        $"for {employee.Duration} years.");
                }
            }
        }
    }
}
