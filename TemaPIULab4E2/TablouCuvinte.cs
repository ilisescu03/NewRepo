using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPIULab4E2
{
    class TablouCuvinte
    {
        private List<string>[] tablouInScara;

        public TablouCuvinte()
        {
            tablouInScara = new List<string>[26];
            for (int i = 0; i < 26; i++)
            {
                tablouInScara[i] = new List<string>();
            }
        }

        public void CitesteDinFisier(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Fișierul nu există!");
                return;
            }

            string[] cuvinte = File.ReadAllLines(filePath)
                                    .SelectMany(line => line.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries))
                                    .ToArray();

            foreach (var cuvant in cuvinte)
            {
                char primaLitera = char.ToLower(cuvant[0]);
                if (primaLitera >= 'a' && primaLitera <= 'z')
                {
                    int index = primaLitera - 'a';
                    tablouInScara[index].Add(cuvant);
                }
            }
        }

        public void AfiseazaTablou()
        {
            for (int i = 0; i < 26; i++)
            {
                char litera = (char)('A' + i);
                Console.WriteLine($"{litera}: {string.Join(", ", tablouInScara[i])}");
            }
        }
    }
}
