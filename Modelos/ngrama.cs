namespace Markov.Modelos
{
    class ngrama
    {
        private string palabra = "";
        private int n = 0;

        public ngrama(string palabra, int n)
        {
            this.n = n;
            this.palabra = palabra;
        }

        public string GetPalabra()
        {
            return this.palabra;
        }

        public int GetN()
        {
            return this.n;
        }
    }
}
