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
        }

        public void PrintInfo()
        {

        }

        public int Evaluate()
        {

        }

        public string GetCategory()
        {

        }

        public string GetName()
        {

        }

        public bool IsCursed()
        {

        }
    }
}
