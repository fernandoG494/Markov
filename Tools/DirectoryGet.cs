using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markov.Tools
{
    class DirectoryGet
    {
        public DirectoryGet()
        {

        }

        public string GetPath()
        {
            string basePath = AppContext.BaseDirectory;
            string[] split = basePath.Split('\\');
            string path = "";
            for (int i = 0; i < split.Length - 3; i++)
            {
                path += split[i] + '\\';
            }
            return path;
        }

        public string GetBookPath()
        {
            string basePath = AppContext.BaseDirectory;
            string[] split = basePath.Split('\\');
            string path = "";
            for (int i = 0; i < split.Length - 3; i++)
            {
                path += split[i] + '\\';
            }
            path += "Resources\\Books\\Solitario.txt";
            //path += "Resources\\Books\\Narrativa_completa_vol1.txt";
            //path += "Files\\Narrativa_completa_vol2.txt";
            //path += "Files\\Grandmaster_of_Demonic_vol1.txt";
            //path += "Files\\Grandmaster_of_Demonic_Cultivation_vol2.txt";
            return path;
        }

        public string GetMidiPath()
        {
            string basePath = AppContext.BaseDirectory;
            string[] split = basePath.Split('\\');
            string path = "";
            for (int i = 0; i < split.Length - 3; i++)
            {
                path += split[i] + '\\';
            }
            path += "Resources\\MidiMusic\\jm_mozdi.mid";
            return path;
        }
    }
}
