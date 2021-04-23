using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Markov
{
    class Markov
    {
        
        public Markov(string txt)
        {
            string text = txt;
            init(text);
        }

        public static void init(string text)
        {
            //int orden = 1;
            string[] ngrama = { };
            Console.WriteLine("Texto: \n" + text);
            string[] palUnicas = identificarPalabrasUnicas(text);
            // Console.WriteLine(palUnicas.Length);

            /*foreach (String palabra in palUnicas)
            {
                Console.WriteLine(palabra);
            }*/

            for (int i = 0; i < palUnicas.Length; i++)
            {
                string cadena = palUnicas[i];
                //string cadena = "ABABBA";
                int total = Regex.Matches(text, cadena).Count;
                Console.WriteLine("[" + i + "](" + cadena + "): " + total);

            }

        }

        public static string[] identificarPalabrasUnicas(string txt)
        {
            string[] palabrasUnicas = { };
            string[] split = txt.Split(' ');
            var arlist = new ArrayList();

            for (int i = 0; i < split.Length; i++)
            {
                if (!arlist.Contains(split[i]))
                {
                    arlist.Add(split[i]);
                }
            }
            palabrasUnicas = (string[]) arlist.ToArray(typeof(string));

            return palabrasUnicas;
        }
    }
}
