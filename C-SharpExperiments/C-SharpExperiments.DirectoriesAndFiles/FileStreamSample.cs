using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpExperiments.DirectoriesAndFiles
{
    public class FileStreamSample
    {
        public void WorkWithFile(string filePath)
        {
            using(var fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                Console.WriteLine(fs.Name);
                Console.WriteLine(fs.Length);
                Console.WriteLine(fs.Position);

                var intValue = fs.ReadByte();

                var firstSymbol = Encoding.UTF8.GetString(new[] { (byte)intValue });

                Console.WriteLine(fs.Position);
                Console.WriteLine(intValue);
                Console.WriteLine(firstSymbol);
            }
        }

        public void UseFilaStreamMainMethods(string filePath, string newFilePath)
        {
            using (var fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                fs.Seek(0, SeekOrigin.Begin);

                var buffer = new byte[256];

                using (var newFS = new FileStream(newFilePath, FileMode.OpenOrCreate))
                {
                    fs.CopyTo(newFS);
                    var readingData = fs.Read(buffer, 0, (int)fs.Length);
                    newFS.Flush(true);
                }

                fs.Seek(0, SeekOrigin.Begin);

                var newContent = new byte[]
                {
                    64,
                    65,
                    78,
                    81
                };

                fs.Write(newContent, 0, (int)newContent.Length);
            }
        }
    }
}
