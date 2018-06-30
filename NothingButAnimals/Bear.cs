using System;
using System.Collections.Generic;
using System.Text;

namespace NothingButAnimals
{
    public class Bear : Animal
    {
        public int Weight { get; private set; }
        public Bear(FurColor furColor, string name, int weight) : base(furColor, name)
        {
            Weight = weight;
        }
    }
}
