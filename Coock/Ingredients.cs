using System;
using System.Collections.Generic;
using System.Text;

namespace Coock
{
    class Ingredient
    {
        public string Name { get; set; }
        public double Callory { get; set; }
        public double Price { get; set; }
        public double StorageTime { get; set; }
        public double Weight { get; set; }
        public double CoockingTime { get; set; }
    }

    class Specie : Ingredient
    {
        bool Species { get; set; } = true;
    }

    class Sauce : Ingredient
    {
        bool Sauces { get; set; } = true;
    }

    class Condition : Ingredient 
    {
        bool Boil { get; set; }
        bool Fry { get; set; }
        bool Stew { get; set; }
        bool Bake { get; set; }

        static public Condition Boiling(Condition ingredient)
        {
            ingredient.Boil = true;
            ingredient.Weight = ingredient.Weight * 0.9;
            ingredient.StorageTime = 48;
            ingredient.Callory = ingredient.Callory * 0.8;
            ingredient.CoockingTime = 20;
            return ingredient;
        }

        static public Condition Frying(Condition ingredient)
        {
            ingredient.Fry = true;
            ingredient.Weight = ingredient.Weight * 0.8;
            ingredient.StorageTime = 96;
            ingredient.Callory = ingredient.Callory * 0.6;
            ingredient.CoockingTime = 30;
            return ingredient;
        }

        static public Condition Stewing(Condition ingredient)
        {
            ingredient.Stew = true;
            ingredient.Weight = ingredient.Weight * 0.9;
            ingredient.StorageTime = 72;
            ingredient.Callory = ingredient.Callory * 0.8;
            ingredient.CoockingTime = 40;
            return ingredient;
        }

        static public Condition Baking(Condition ingredient)
        {
            ingredient.Bake = true;
            ingredient.Weight = ingredient.Weight * 0.8;
            ingredient.StorageTime = 184;
            ingredient.Callory = ingredient.Callory * 0.7;
            ingredient.CoockingTime = 60;
            return ingredient;
        }
    }
}