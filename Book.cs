using System;
using System.Collections.Generic;

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
        private bool cursed = false;
        private Random generator = new Random();
        private List<string> categorys = new List<string>();

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

            GetName();
            GetCategory();
            PrintInfo();
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

        //Genererar ett namn från arrayen med namn
        public string GetName()
        {
            string[] names = {"name1", "name2", "name3"};
            
            name = names[generator.Next(names.Length)];
            return name;
        }

        public bool IsCursed()
        {
            //Genererar ett värde och om det är 8 eller mindre, och om det stämmer då fortsätter cursed ha samma värde
            if (generator.Next(10) <= 8)
            {
                cursed = cursed;
            }

            //Annars kommer cursed byta värde (från false till true, vice versa)
            else if (cursed == false)
            {
                cursed = true;
            }

            else if (cursed == true)
            {
                cursed = false;
            }

            //Slutligen returnerar den värdet på cursed
            return cursed;
        }
    }
}
