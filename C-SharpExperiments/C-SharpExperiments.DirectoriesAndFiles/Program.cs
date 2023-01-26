namespace C_SharpExperiments.DirectoriesAndFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"D:\Programming\NewFolder");

            var directories = Directory.GetDirectories(@"D:\Programming");

            foreach(var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Delete(@"D:\Programming\NewFolder");

            Console.WriteLine("_________________");

            directories = Directory.GetDirectories(@"D:\Programming");

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            var file = @"D:\Programming\NewFile.txt";

            File.AppendAllText(file, "ABSD");

            Console.WriteLine(File.ReadAllText(file));

            Console.WriteLine($"\n_______________FileStream_______________\n");

            //_______________FileStream_______________

            var fileSample = new FileStreamSample();
            fileSample.WorkWithFile(@"D:\Programming\NewFile.txt");
            fileSample.UseFilaStreamMainMethods(file, @"D:\Programming\NewFile2.txt");


        }
    }
}