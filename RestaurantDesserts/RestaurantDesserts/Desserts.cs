﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantDesserts
{
    // Base class for all desserts
    abstract class Dessert
    {
        // Common step
        public void AddSugar()
        {
            Console.WriteLine("Step 1: Add Sugar");
        }

        // Abstract method for the unique preparation
        public abstract void Prepare();

        // Common step
        public void Serve()
        {
            Console.WriteLine("Step 3: Serve to the Customer\n");
        }

        // Template method that calls all steps in order
        public void MakeDessert()
        {
            AddSugar();
            Prepare();   // Dessert-specific step
            Serve();
        }
    }

    // Ice-cream dessert
    class IceCream : Dessert
    {
        public override void Prepare()
        {
            Console.WriteLine("Step 2: Churn and Freeze the mixture");
        }
    }

    // Cake dessert
    class Cake : Dessert
    {
        public override void Prepare()
        {
            Console.WriteLine("Step 2: Bake in the oven");
        }
    }

    // Gulab Jamun dessert
    class GulabJamun : Dessert
    {
        public override void Prepare()
        {
            Console.WriteLine("Step 2: Fry dough balls and soak in syrup");
        }
    }
}

