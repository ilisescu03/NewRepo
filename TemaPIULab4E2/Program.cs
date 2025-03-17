using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPIULab4E2
{
    class Program
    {
        static void Main(string[] args)
        {

            TablouCuvinte tablou = new TablouCuvinte();
            string filePath = "cuvinte.txt"; 
            tablou.CitesteDinFisier(filePath);
            tablou.AfiseazaTablou();
        }
    }
}
