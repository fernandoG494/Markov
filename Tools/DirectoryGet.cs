using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Markov.Tools
{
    class DirectoryGet
    {
        char separator;
        public DirectoryGet()
        {
            OperatingSystem os = System.Environment.OSVersion;
            Console.WriteLine(os.Platform);
            string plataform = os.Platform.ToString();
            if (plataform == "Unix")
            {
                separator = '/';
            }
            else
            {
                separator = '\\';
            }
        }

        public string GetPath()
        {
            string basePath = AppContext.BaseDirectory;
            string[] split = basePath.Split(separator);
            string path = "";
            for (int i = 0; i < split.Length - 3; i++)
            {
                path += split[i] + separator;
            }
            return path;
        }

        public string GetBookPath()
        {
            string basePath = AppContext.BaseDirectory;
            string[] split = basePath.Split(separator);
            string path = "";
            for (int i = 0; i < split.Length - 3; i++)
            {
                path += split[i] + separator;
            }
            //path += "Resources" + separator + "Books" + separator + "Solitario.txt";
            path += "Resources" + separator + "Books" + separator + "Narrativa_completa_vol1.txt";
            //path += "Resources" + separator + "Books" + separator + "Narrativa_completa_vol2.txt";
            //path += "Resources" + separator + "Books" + separator + "Grandmaster_of_Demonic_vol1.txt";
            //path += "Resources" + separator + "Books" + separator + "Grandmaster_of_Demonic_Cultivation_vol2.txt";
            return path;
        }

        public string GetMidiPath()
        {
            string basePath = AppContext.BaseDirectory;
            string[] split = basePath.Split(separator);
            string path = "";
            for (int i = 0; i < split.Length - 3; i++)
            {
                path += split[i] + separator;
            }
            path += "Resources" + separator + "MidiMusic" + separator + "jm_mozdi.mid";
            return path;
        }
    }
}
