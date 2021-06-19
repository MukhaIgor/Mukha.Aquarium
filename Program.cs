using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace Mukha.Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Aquarium.ViewAquarium();
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.ReadLine();
            }
        }
    }
}
