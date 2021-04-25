using Markov.Modelos;
using Markov.Herramientas;
using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Markov
{
    class Markov
    {
        private int n;
        private string text;
        ArrayList ngramas = new ArrayList();

        public Markov(string txt, int n)
        {
            text = txt;
            this.n = n;
        }

        public void Method()
        {
            ArrayList counter = new ArrayList();
            /*  
             *  Generar y dividir en archivos cada uno de los tipos de n-gramas (unigramas,
             *  bigramas, trigramas, etc.) y contabilizar el numero de veces que ocurren en
             *  el corpus.
             */

            string[] split = this.text.Split(' ');
            for (int i = 0; i < split.Length; i++)
            {
                if ((i + n) != split.Length) ngramas.Add(split[i] + " " + split[i + n]);
            }

            // por cada ngrama, recorrer el texto y acumular las veces que aparezca
            for (int i = 0; i < ngramas.Count; i++)
            {
                string palabra = (string)ngramas[i];
                int total = Regex.Matches(this.text, palabra).Count;
                counter.Add(new ngrama(palabra, total));
            }

            Console.WriteLine("Ngramas: " + counter.Count);
            tools tools = new tools();
            tools.PrintCounter(counter);
        }
    }
}
