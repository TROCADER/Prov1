using System;

namespace Prov1
{
    public class Book
    {
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private Random generator;

        public Book()
        {
            rarity = generator.Next(100);
            actualValue = generator.Next(100);

            //Gör det 50% att det kan bli varken true eller false
            if (generator.Next(2) == 0)
            {
                cursed = true;
            }
        }

        public void PrintInfo()
        {

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
