using System;
using System.IO;

namespace Markov.Tools
{
    class LinesGet
    {
        public LinesGet()
        {

        }

        public string[] LoadFileLines(string path)
        {
            string[] empty = { };
            if (File.Exists(path))
            {
                return File.ReadAllLines(path);
            }
            else
            {
                Console.WriteLine("No existing file");
                return empty;
            }
        }
    }
}
