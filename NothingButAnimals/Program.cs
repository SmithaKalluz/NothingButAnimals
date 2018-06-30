using System;

namespace NothingButAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            //doing this cause of static main
            var animals = new AnimalsForSale();
            var listOfAnimals = animals.GetAnimals();
            //=======================================

            Console.WriteLine("What is the name of the animal? ");
            var resName = Console.ReadLine();

            Console.WriteLine("What color is the fur? (black/brown/white) ");
            var resFur = Console.ReadLine().ToLower();

            FurColor furColor = FurColor.Unspecified;
            switch (resFur)
            {
                case "black":
                    furColor = FurColor.Black;
                    break;

                case "brown":
                    furColor = FurColor.Brown;
                    break;

                case "white":
                    furColor = FurColor.White;
                    break;

                default:
                    furColor = FurColor.Unspecified;
                    break;
            }

            Console.WriteLine("What is the animal? (bear/lion)");
            var resType = Console.ReadLine().ToLower();

            if (resType == "bear")
            {
                Console.WriteLine("How much does the bear weigh? ");
                var resWeightString = Console.ReadLine();
                var resWeight = Convert.ToInt32(resWeightString);

                var animal = new Bear(furColor, resName, resWeight);
                var forSale = new ForSale(animal);
                listOfAnimals.Add(forSale);

                Console.WriteLine("The cost of the animal is: " + animals.CostOfAnimal);
            }
            else if (resType == "lion")
            {
                Console.WriteLine("How many cubs does the Lion have? ");
                var resCubsString = Console.ReadLine();
                var resCubs = Convert.ToInt32(resCubsString);

                var animal = new Lion(furColor, resName, resCubs);
                var forSale = new ForSale(animal);
                listOfAnimals.Add(forSale);

                Console.WriteLine("The cost of the animal is: " + animals.CostOfAnimal);
            }

        }
    }
}
