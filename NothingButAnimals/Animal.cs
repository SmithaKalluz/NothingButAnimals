using System;
using System.Collections.Generic;
using System.Text;

namespace NothingButAnimals
{
    public abstract class Animal
    {
        public FurColor FurColor { get; set; }
        public string Name { get; set; }

        protected Animal(FurColor furColor, string name)
        {
            FurColor = furColor;
            Name = name;
        }
    }
}
