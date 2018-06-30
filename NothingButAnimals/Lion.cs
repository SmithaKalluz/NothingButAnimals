using System;
using System.Collections.Generic;
using System.Text;

namespace NothingButAnimals
{
    public class Lion : Animal
    {
        public int NumberOfCubs { get; set; }
        
        public Lion(FurColor furColor, string name ,int numberOfCubs) :
            base(furColor, name)
        {
            NumberOfCubs = numberOfCubs;
        }

        
    }
}
