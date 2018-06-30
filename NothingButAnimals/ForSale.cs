using System;
using System.Collections.Generic;
using System.Text;

namespace NothingButAnimals
{
    public class ForSale
    {
        public Animal Animal { get; private set; }

        private int costOfAnimal;
        //-- This is where I am stuck
        //-- CostOfAnimal will change based on the enum in Animal
        //-- If Animal FurColor is Brown, CostOfAnimal is 100.
        //-- If Animal is Bear and is Brown, CostOfAnimal is 200.
        //-- If Animal FurColor is Black, CostOfAnimal is 300.
        //-- You get the point

        //-- We don't want to be able to set the CostOfAnimal outside of this class, only get it
        public int CostOfAnimal
        {
            get { return costOfAnimal; }
            private set { costOfAnimal = value; }
        }

        public ForSale(Animal animal)
        {
            Animal = animal;
        }
    }
}
