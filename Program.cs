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

            string path = dirGet.GetBookPath();
            Console.WriteLine("Loading book: " + path);
            string[] lines = t.LoadFileLines(path);

            Markov markov = new Markov(lines);

            Console.WriteLine("\t === Random quotes generator ===");
            markov.GenerateQuotes(4);

            /*Console.WriteLine("\t === Names generator ===");


            Console.WriteLine("\t ########## Midi Shit ##########");
            markov.MidiGen();*/
        }
    }
}
