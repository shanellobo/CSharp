using System;

namespace RestaurantDesserts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create objects for each dessert
            Dessert iceCream = new IceCream();
            Dessert cake = new Cake();
            Dessert gulabJamun = new GulabJamun();

            Console.WriteLine("=== Ice-Cream Preparation ===");
            iceCream.MakeDessert();

            Console.WriteLine("=== Cake Preparation ===");
            cake.MakeDessert();

            Console.WriteLine("=== Gulab Jamun Preparation ===");
            gulabJamun.MakeDessert();
        }
    }
}

