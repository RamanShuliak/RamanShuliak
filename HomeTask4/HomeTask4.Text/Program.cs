using System.Text.RegularExpressions;

namespace HomeTask4.Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var textOriginal = @"D:\Programming\Repository\RamanShuliak\HomeTask4\txtFiles\sample.txt";

            var textOriginalRead = File.ReadAllText(textOriginal);

            textOriginalRead.TrimStart('\"').TrimEnd('\"');

            var regexSentence = new Regex(@"(?<=[\.!\?])\s+");

            string[] sentences = Regex.Split(textOriginalRead, @"(?<=[\.!\?])\s+");


            try
            {
                StreamWriter allSentences = new StreamWriter(@"D:\Programming\Repository\RamanShuliak\HomeTask4\txtFiles\AllSentences.txt");

                for (int i = 0; i < sentences.Length; i++)
                {

                    allSentences.WriteLine($"New sentence   -----   {sentences[i]}{Environment.NewLine}");

                }

                allSentences.Close();
            }
            finally
            {

            }


            string allSentencesNew = @"D:\Programming\Repository\RamanShuliak\HomeTask4\txtFiles\AllSentences.txt";

            string sentencesAndSymbol = @"D:\Programming\Repository\RamanShuliak\HomeTask4\txtFiles\SentencesAndSymbol.txt";

            string longestSentence = GetLongestString(allSentencesNew);

            string shortestSentence = GetShortestString(allSentencesNew, longestSentence);


            File.AppendAllText(sentencesAndSymbol, $"Sentence with the largest number of symbols is: \n {longestSentence}{Environment.NewLine}");

            File.AppendAllText(sentencesAndSymbol, $"Sentence with the least number of words is: \n {shortestSentence}{Environment.NewLine}");


            char[] divWords = { ' ', ',', '.', ':', '!', '?', ';', '-', '"', ' ', '\u000A', '_' , '=', '\'', '*', '(', ')', '\\', '/', '$', '[', ']', '&', '#' , '|', '+', '>', '<', '~'};

            List<string> words = textOriginalRead.Split(divWords, StringSplitOptions.RemoveEmptyEntries).ToList();

            words.Sort();

            string text = textOriginalRead.ToLower();
            string[] words1 = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var result = words.GroupBy(x => x)
                              .Where(x => x.Count() > 0)
                              .Select(x => new { Word = x.Key, Frequency = x.Count() });

            
            /*На то, чтобы получить самую встречаемую букву я потратил последние остатки своих сил, мозгов
             и времени. Максимум, чего смог добиться - получить самое встречаемое слово.*/ 

            var most = words.GroupBy(x => x).OrderByDescending(x => x.Count()).First();
            Console.WriteLine("Наиболее часто встречается {0} в количестве {1}", most.Key, most.Count());


            try
            {

                StreamWriter wordsByAlphabetTxt = new StreamWriter(@"D:\Programming\Repository\RamanShuliak\HomeTask4\txtFiles\WordsByAlphabet.txt");

                foreach (var item in result)
                {
                    int item2 = 0;

                    if (int.TryParse(item.Word, out item2))
                    {

                    }
                    else
                    {
                        var wordsByAlphabet = $"Word:  {item.Word}\t  |   number of repeats:   {item.Frequency}";

                        wordsByAlphabetTxt.WriteLine(wordsByAlphabet);
                    }

                }

                wordsByAlphabetTxt.Close();
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }



        }

        public static string GetLongestString(string allSentencesNew)
        {
            string currentString, longestString = "";
            using (StreamReader reader = new StreamReader(allSentencesNew))
            {
                while (!reader.EndOfStream)
                {
                    currentString = reader.ReadLine();
                    if (currentString.Length > longestString.Length)
                        longestString = currentString;
                }

                Console.WriteLine(longestString);
                return longestString;
            }
        }

        public static string GetShortestString(string allSentencesNew, string longestSentence)
        {
            string currentString, shortestString = "";

            string min = $"New sentence   -----   A";
            using (StreamReader reader = new StreamReader(allSentencesNew))
            {
                while (!reader.EndOfStream)
                {
                    currentString = reader.ReadLine();
                    if (currentString.Length < longestSentence.Length && currentString.Length > min.Length)
                        shortestString = currentString;
                }

                Console.WriteLine(shortestString);
                return shortestString;
            }
        }
    }
}