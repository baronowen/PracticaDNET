using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\Users\owena\stack\jaar 2\periode 4\DNET\practica\Practica\Practicum 3\randomtext.txt";

            foreach (String word in GetWords(path, s => s.StartsWith("a")))
                Console.WriteLine("{0}; ", word);

            string[] strings = GetWords(path, s => s.StartsWith("b")).ToArray();
            Array.Sort(strings, (x, y) => x.Length.CompareTo(y.Length));
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }

        static IEnumerable<String> GetWords(String path, Predicate<string> p)
        {
            StreamReader sr;        
            try
            {
                sr = new StreamReader(path);
            } catch(FileNotFoundException)
            {
                Console.WriteLine("File not found!");
                yield break;
            }

            var line = sr.ReadLine();

            while(line != null)
            {
                var words = line.Split();
                foreach (string word in words)
                {
                    if (p(word) == true){
                        yield return word;
                    }
                }
                line = sr.ReadLine();
            }
        }
    }
}
