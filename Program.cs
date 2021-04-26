using System;
using Markov.Tools;


namespace Markov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t === Markov chains ===");

            DirectoryGet dirGet = new DirectoryGet();
            LinesGet t = new LinesGet();

            string path = dirGet.GetPath();
            Console.WriteLine("Loading book: " + path);

            string[] lines = t.LoadFileLines(path);

            Markov markov = new Markov(lines);
        }
    }
}
