using System;

namespace Prov1
{
    public class Book
    {
        //Alla varibler samt strings
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private Random generator;

        //Konstruktorn som gör huvuddel av programmet, tillkallar andra metoder, etc.
        public Book()
        {
            //Genererar ett "random" värde för bokens värde samt raritet
            rarity = generator.Next(0, 100);
            actualValue = generator.Next(0, 100);

            //Gör det 50% att det kan bli varken true eller false
            if (generator.Next(2) == 0)
            {
                cursed = true;
            }
        }
        
        //Skriver ut bokes info
        public void PrintInfo()
        {
            System.Console.WriteLine("The books name is: " + name);
            System.Console.WriteLine("\nThe books rarity is: " + rarity);
            System.Console.WriteLine("\nThe books category is: " + category);
            System.Console.WriteLine("\n\nThe books final price is: " + price);
        }

        public int Evaluate()
        {
            price = actualValue * rarity;

            if (generator.Next(3) == 1)
            {
                price /= 2;
            }

            if (generator.Next(3) == 3)
            {
                price *= 2;
            }
            
            return price;
        }

        public string GetCategory()
        {
            return category;
        }

        public string GetName()
        {
            return name;
        }

        public bool IsCursed()
        {
            if (generator.Next(10) <= 8)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
