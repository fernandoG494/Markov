using MarkovSharp.TokenisationStrategies;
using Sanford.Multimedia.Midi;
using System;
using System.Collections;
using System.Linq;
using Markov.Tools;
using System.IO;

namespace Markov
{
    class Markov
    {
        private string[] lines;
        private DirectoryGet DirGet = new DirectoryGet();

        public Markov(string[] lines)
        {
            this.lines = lines;
        }

        public void GenerateQuotes(int n)
        {
            int numeroCadenas = 4;
            var model = new StringMarkov(n);
            Console.WriteLine("\nTraining ...");
            model.Learn(lines);

            Console.WriteLine("============================================");
            for (int i = 0; i < numeroCadenas; i++)
            {
                Console.WriteLine("[" + i + "]: " + model.Walk().First());
            }
        }

        public void MidiGen()
        {
            try
            {
                string midiFile = DirGet.GetMidiPath();

                Sequence seq = new Sequence(midiFile);
                Sequence seqNew = new Sequence(seq.Division);

                // Get a random track to learn from
                // Take more to produce output on multiple tracks.
                var ints = Enumerable.Range(0, seq.Count).OrderBy(a => Guid.NewGuid()).Take(1);
                foreach (int i in ints)
                {
                    Track t = seq[i];
                    SanfordMidiMarkov model = new SanfordMidiMarkov(2);
                    model.EnsureUniqueWalk = true;

                    // Learn the track
                    model.Learn(t);

                    // Walk the model
                    var result = model.Walk().FirstOrDefault();

                    // Add the result to the new sequence
                    seqNew.Add(result);
                }

                // Write a new midi file
                seqNew.Save(DirGet.GetPath() + "Generated\\Midi\\aaaaaaaa.mid");
            }
            catch (DirectoryNotFoundException dirEx)
            {
                // Let the user know that the directory did not exist.
                Console.WriteLine("Directory not found: " + dirEx.Message);
            }
            
        }
    }
}
