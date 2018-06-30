using System;
using System.Collections.Generic;
using System.Text;

namespace NothingButAnimals
{
    public class ForSale
    {
        public Animal Animal { get; private set; }

        public ForSale(Animal animal)
        {
            Animal = animal;
        }
    }
}
