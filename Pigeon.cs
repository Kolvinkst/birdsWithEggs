using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birdsWithEggs
{
    internal class Pigeon : Bird
    {
        public override Egg[] LayEggs(int mumberOfEggs)
        {
            Egg[] eggs = new Egg[mumberOfEggs];
            for (int i = 0;  i < mumberOfEggs; i++)
            {
                eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, "white");
            }
            return eggs;
        }
    }
}
