using System;
using System.Collections.Generic;
using System.Text;

namespace NothingButAnimals
{
    public class AnimalsForSale
    {
        List<Animal> Animals = new List<Animal>();


        //I know it would make more sense if this CostOfAnimal
        //property was in ForSale, but for learning, lets do it this way
        //SSK you either need ForSale or AnimalForSale not both of them
        //SSK private variables should be declared with _
        
        //SSK the code in here  is not needed

        //-- This is where I am stuck
        //-- CostOfAnimal will change based on the enum in Animal
        
        //-- If Animal FurColor is Brown, CostOfAnimal is 100.
        //-- If Animal is Bear and is Brown, CostOfAnimal is 200.
        //-- If Animal FurColor is Black, CostOfAnimal is 300.
        //-- You get the point

        //-- We don't want to be able to set the CostOfAnimal outside of this class, only get it
       
        //SSK the code in here  is not needed
        public List<Animal> GetAnimals()
        {
            return Animals;
        }
        public int TotalCost()
        {
            int TotalCost = 0;
            foreach (var animal in this.Animals)
            {
                TotalCost += animal.CostOfAnimal;
            }

            return TotalCost;
        }
    }
}
