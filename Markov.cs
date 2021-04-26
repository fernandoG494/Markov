using MarkovSharp.TokenisationStrategies;
using System;
using System.Collections;
using System.Linq;

namespace Markov
{
    class Markov
    {
        private string[] lines;

        public Markov(string[] lines)
        {
            this.lines = lines;
            Method();
        }

        private void Method()
        {
            int numeroCadenas = 4;
            var model = new StringMarkov();
            Console.WriteLine("\nTraining ...");
            model.Learn(lines);

            Console.WriteLine("============================================");
            for (int i = 0; i < numeroCadenas; i++)
            {
                Console.WriteLine("[" + i + "]: " + model.Walk().First());
            }
        }
    }
}
