using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mukha.Aquarium
{
    class Cell
    {
        int x { get; set; }
        int y { get; set; }
        public static bool IsEmpty(int x,int y)
        {
            if (Aquarium.arrayCells[x, y] == "|")
            {
                return Convert.ToBoolean("True");
            }
            else
            {
                return Convert.ToBoolean("False");
            }
            
        }
    }
}
