using System;
using System.Collections;
using Markov.Modelos;

namespace Markov.Herramientas
{
    class tools
    {
        public void PrintCounter(ArrayList counter)
        {
            foreach (ngrama ngrama in counter)
            {
                Console.WriteLine("Ngrama: " + ngrama.GetPalabra() + "\n\tVeces presente: " + ngrama.GetN());
            }
        }
    }
}
