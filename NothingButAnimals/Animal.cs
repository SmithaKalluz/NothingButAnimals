using System;
using System.Collections.Generic;
using System.Text;

namespace NothingButAnimals
{
    public abstract class Animal
    {
        public FurColor FurColor { get; set; }
        public string Name { get; set; }

        private int _costOfAnimal;

        public  int CostOfAnimal
        {
            get
            {
                if (this is Bear)
                return 10;
                else if (this is Lion)
                return 20;
                else
                {
                    return 0;
                }
            }
           
        }

        

      
        
        protected Animal(FurColor furColor, string name)
        {
            FurColor = furColor;
            Name = name;
            
        }
    }
}
