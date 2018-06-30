using System;
using System.Collections.Generic;
using System.Text;

namespace NothingButAnimals
{
    public class AnimalsForSale
    {
        List<ForSale> Animals = new List<ForSale>();

        public List<ForSale> GetAnimals()
        {
            return Animals;
        }
    }
}
