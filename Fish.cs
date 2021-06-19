using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mukha.Aquarium
{
    abstract class Fish
    {
        int AgeCurrent { get; set; }
        int ageMax { get; set; }
        int ageBeginMature { get; set; }
        int ageEndMature { get; set; }
        double energyCurrent { get; set; }
        double energyMax { get; set; }
        double energyHungryLevel { get; set; }
        double energyDecreaseOnIteration { get; set; }
        int moveCurrentLength { get; set; }
        int moveMaxLength { get; set; }
        bool isMale { get; set; }
        bool isFreeCell { get; set; }
    }
}
