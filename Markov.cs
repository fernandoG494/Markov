using MarkovSharp.TokenisationStrategies;
using System;
using System.Collections;
using System.Linq;

namespace Markov
{
    class Markov
    {
        private string text;

        public Markov(string txt)
        {
            text = txt;
            Method();
        }

        private void Method()
        {
            int numeroCadenas = 4;
            string[] lines = LineToken(this.text);
            var model = new StringMarkov(2);
            model.Learn(lines);

            Console.WriteLine("============================================");
            for (int i = 0; i < numeroCadenas; i++)
            {
                Console.WriteLine("[" + i + "]: " + model.Walk().First());
            }
        }

        private string[] LineToken(string text)
        {
            string[] lines = { };
            Console.WriteLine(text);
            lines = text.Split('.');
            return lines;
        }
    }
}
