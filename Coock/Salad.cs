using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace Coock
{
    class Salad
    {
        public Condition[] Ingredients { get; set; }
        public Specie[] Spicies { get; set; }
        public Sauce[] Sauces { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Callory { get; set; }
        public double CoockingTime { get; set; }

        static public Condition[] GetIngredients(string path)
        {
            int i = 0;
            using (StreamReader sr = File.OpenText(path))
            {
                
                while (!sr.EndOfStream)
                {
                    string[] buffer = new string[5];
                    buffer = sr.ReadLine().Split('/');
                    if (buffer[4] == "ing")
                    {
                        i++;
                    }
                }
            }
            Condition[] ingredients = new Condition[i];
            i = 0;
            using (StreamReader sr = File.OpenText(path))
            { 
                while (!sr.EndOfStream)
                {
                    string[] buffer = new string[5];
                    buffer = sr.ReadLine().Split('/');
                    if (buffer[4] == "ing")
                    { 
                        ingredients[i] = new Condition();
                        ingredients[i].Name = buffer[0];
                        ingredients[i].Callory = Int32.Parse(buffer[1]);
                        ingredients[i].Price = Int32.Parse(buffer[2]);
                        ingredients[i].StorageTime = Int32.Parse(buffer[3]);
                        i++;
                    }
                }
            }
            return ingredients;
        }

        static public Specie[] GetSpicies(string path)
        {
            int i = 0;
            using (StreamReader sr = File.OpenText(path))
            {

                while (!sr.EndOfStream)
                {
                    string[] buffer = new string[5];
                    buffer = sr.ReadLine().Split('/');
                    if (buffer[4] == "spicie")
                    {
                        i++;
                    }
                }
            }
            Specie[] spicies = new Specie[i];
            i = 0;
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] buffer = new string[5];
                    buffer = sr.ReadLine().Split('/');
                    if (buffer[4] == "spicie")
                    {
                        spicies[i] = new Specie();
                        spicies[i].Name = buffer[0];
                        spicies[i].Callory = Int32.Parse(buffer[1]);
                        spicies[i].Price = Int32.Parse(buffer[2]);
                        spicies[i].StorageTime = Int32.Parse(buffer[3]);
                        i++;
                    }
                }
            }
            return spicies;
        }

        static public Sauce[] GetSauce(string path)
        {
            int i = 0;
            using (StreamReader sr = File.OpenText(path))
            {

                while (!sr.EndOfStream)
                {
                    string[] buffer = new string[5];
                    buffer = sr.ReadLine().Split('/');
                    if (buffer[4] == "sauce")
                    {
                        i++;
                    }
                }
            }
            Sauce[] sauce = new Sauce[i];
            i = 0;
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] buffer = new string[5];
                    buffer = sr.ReadLine().Split('/');
                    if (buffer[4] == "sauce")
                    {
                        sauce[i] = new Sauce();
                        sauce[i].Name = buffer[0];
                        sauce[i].Callory = Int32.Parse(buffer[1]);
                        sauce[i].Price = Int32.Parse(buffer[2]);
                        sauce[i].StorageTime = Int32.Parse(buffer[3]);
                        i++;
                    }
                }
            }
            return sauce;
        }

        //static public Ingredient[] ChooseIngredientsFromList(Ingredient[] ingredients)
        //{
        //    for (int i = 0; i < ingredients.Length; i++)
        //    {
        //        Console.WriteLine("\t {0} {1}", i, ingredients[i].Name);
        //    }
        //    Console.WriteLine("Choose ingredients from the list please use numbers(for example: 1,2,3,4,5,6): ");
        //    string[] buffer = Console.ReadLine().Split(',');
        //    Ingredient[] chosenIngredients = new Ingredient[buffer.Length];
        //    for (int i = 0; i < buffer.Length; i++)
        //    {
        //        chosenIngredients[i] = new Ingredient();
        //        chosenIngredients[i].Name = ingredients[Int32.Parse(buffer[i])].Name;
        //    }
        //    return chosenIngredients;
        //}

        static public Condition[] ChooseIngredientsFromList(Condition[] ingredients)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine("\t {0} {1}", i, ingredients[i].Name);
            }
            Console.WriteLine("Choose ingredients from the list please use numbers(for example: 1,2,3,4,5,6): ");
            string[] buffer = Console.ReadLine().Split(',');
            Condition[] chosenIngredients = new Condition[buffer.Length];
            for (int i = 0; i < buffer.Length; i++)
            {
                chosenIngredients[i] = new Condition();
                chosenIngredients[i] = ingredients[Int32.Parse(buffer[i])];
            }
            return chosenIngredients;
        }

        static public Specie[] ChooseIngredientsFromList(Specie[] ingredients)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine("\t {0} {1}", i, ingredients[i].Name);
            }
            Console.WriteLine("Choose ingredients from the list please use numbers(for example: 1,2,3,4,5,6): ");
            string[] buffer = Console.ReadLine().Split(',');
            Specie[] chosenIngredients = new Specie[buffer.Length];
            for (int i = 0; i < buffer.Length; i++)
            {
                chosenIngredients[i] = new Specie();
                chosenIngredients[i] = ingredients[Int32.Parse(buffer[i])];
            }
            return chosenIngredients;
        }

        static public Sauce[] ChooseIngredientsFromList(Sauce[] ingredients)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine("\t {0} {1}", i, ingredients[i].Name);
            }
            Console.WriteLine("Choose ingredients from the list please use numbers(for example: 1,2,3,4,5,6): ");
            string[] buffer = Console.ReadLine().Split(',');
            Sauce[] chosenIngredients = new Sauce[buffer.Length];
            for (int i = 0; i < buffer.Length; i++)
            {
                chosenIngredients[i] = new Sauce();
                chosenIngredients[i] = ingredients[Int32.Parse(buffer[i])];
            }
            return chosenIngredients;
        }

        //static public bool Check(Ingredient[] ingredients, string input)
        //{
        //    for(int i = 0; i < ingredients.Length; i++)
        //    {
        //        if(ingredients[i].Name == input)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //static public Ingredient FindIngredient(Ingredient[] ingredients, string name)
        //{
        //    for (int i = 0; i < ingredients.Length; i++)
        //    {
        //        if (ingredients[i].Name == name)
        //        {
        //            return ingredients[i];
        //        }
        //    }
        //    return null;
        //}

        //static public Ingredient[] ChooseIngredients(Ingredient[] ingredients)
        //{
        //    string ingredientsNames = "";
        //    Console.WriteLine("Input the names of ingredients(egg, paprika, salt etc.). Input 'exit' to close the input: ");
        //    while (true)
        //    {
        //        string buffer = Console.ReadLine();
        //        if(buffer == "exit")
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            if (Check(ingredients, buffer))
        //            {
        //                ingredientsNames += buffer + "/"; 
        //            }
        //        }
        //    }
        //    string[] Names = ingredientsNames.Split('/');
        //    Ingredient[] chosenIngredients = new Ingredient[Names.Length];
        //    for (int i = 0; i < Names.Length; i++)
        //    {
        //        chosenIngredients[i] = new Ingredient();
        //        chosenIngredients[i] = FindIngredient(ingredients, Names[i]);
        //    }
        //    return chosenIngredients;
        //}

        static public Condition Coocking(Condition ingredient)
        {
            Console.WriteLine("Choose what you gonna do with {0}", ingredient.Name);
            Console.WriteLine("1. Boiling     ::     2. Frying     ::     3. Stewing     ::     4. Baking     ::     5. Nothing");
            switch (Console.ReadLine())
            {
                case "1":
                    ingredient = Condition.Boiling(ingredient);
                    break;
                case "2":
                    ingredient = Condition.Frying(ingredient);
                    break;
                case "3":
                    ingredient = Condition.Stewing(ingredient);
                    break;
                case "4":
                    ingredient = Condition.Baking(ingredient);
                    break;
                default:
                    break;
            }
            return ingredient;
        }

        static public Salad GetCallory(Salad salad)
        {
            salad.Callory = 0;
            for (int i = 0; i < salad.Ingredients.Length; i++)
            {
                salad.Callory += salad.Ingredients[i].Callory * salad.Ingredients[i].Weight / 100;
            }

            for (int i = 0; i < salad.Sauces.Length; i++)
            {
                salad.Callory += salad.Sauces[i].Callory * salad.Sauces[i].Weight / 100;
            }

            for (int i = 0; i < salad.Spicies.Length; i++)
            {
                salad.Callory += salad.Spicies[i].Callory * salad.Spicies[i].Weight / 100;
            }
            return salad;
        }

        static public Salad GetPrice(Salad salad)
        {
            salad.Price = 0;
            for (int i = 0; i < salad.Ingredients.Length; i++)
            {
                salad.Price += salad.Ingredients[i].Price * salad.Ingredients[i].Weight / 100;
            }

            for (int i = 0; i < salad.Spicies.Length; i++)
            {
                salad.Price += salad.Spicies[i].Price * salad.Spicies[i].Weight / 100;
            }

            for (int i = 0; i < salad.Sauces.Length; i++)
            {
                salad.Price += salad.Sauces[i].Price * salad.Sauces[i].Weight / 100;
            }
            return salad;
        }

        static public Salad GetCoockingTime(Salad salad)
        {
            salad.CoockingTime = 10;
            for (int i = 0; i < salad.Ingredients.Length; i++)
            {
                salad.CoockingTime += salad.Ingredients[i].CoockingTime;
            }
            return salad;
        }

        static public Salad CreateUniqeSalad(string path)
        {
            Salad salad = new Salad();
            Condition[] ingredients = GetIngredients(path);
            Specie[] species = GetSpicies(path);
            Sauce[] sauces = GetSauce(path);
            Console.WriteLine("Input salad name:");
            salad.Name = Console.ReadLine();
            Console.WriteLine("Choose ingredients from list");
            salad.Ingredients = ChooseIngredientsFromList(ingredients);
            Console.WriteLine("Choose spicies from list");
            salad.Spicies = ChooseIngredientsFromList(species);
            Console.WriteLine("Choose sauces/ingridient for sauces from list");
            salad.Sauces = ChooseIngredientsFromList(sauces);
            for(int i = 0; i < salad.Ingredients.Length; i++)
            {
                Console.WriteLine("Input {0} weight: ", salad.Ingredients[i].Name);
                salad.Ingredients[i].Weight = Int32.Parse(Console.ReadLine());
                Coocking(salad.Ingredients[i]);
            }
            for (int i = 0; i < salad.Spicies.Length; i++)
            {
                Console.WriteLine("Input {0} weight: ", salad.Spicies[i].Name); ;
                salad.Spicies[i].Weight = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < salad.Sauces.Length; i++)
            {
                Console.WriteLine("Input {0} weight: ", salad.Sauces[i].Name);
                salad.Sauces[i].Weight = Int32.Parse(Console.ReadLine());
            }
            salad = GetPrice(salad);
            salad = GetCallory(salad);
            salad = GetCoockingTime(salad);
            Console.WriteLine("Salad is ready ^-^");
            //Console.WriteLine("Input 'keyboard' if you wanna input ingridients from keybord, or input 'list', if you wanna choose ingredients from list");
            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    if (input == "keyboard")
            //    {
            //        salad.ingredients = ChooseIngredients(ingredients);
            //        break;
            //    }
            //    else
            //    {
            //        if (input == "list")
            //        {
            //            salad.ingredients = ChooseIngredientsFromList(ingredients);
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Wrong input. Please try again:");
            //        }
            //    }
            //}        
            return salad;
        }

        static public Salad Sort(Salad salad, string parametr)
        {
            switch (parametr)
            {
                case "name":
                salad.Ingredients = salad.Ingredients.OrderBy(o => o.Name).ToArray();
                    break;

                case "callory":
                    salad.Ingredients = salad.Ingredients.OrderBy(o => o.Callory).ToArray();
                    break;

                case "price":
                    salad.Ingredients = salad.Ingredients.OrderBy(o => o.Price).ToArray();
                    break;

                case "storageTime":
                    salad.Ingredients = salad.Ingredients.OrderBy(o => o.StorageTime).ToArray();
                    break;
            }
            return salad;
        }

        static public Condition[] FindCalloryIngredients(Salad salad, int left, int right)
        {
            Condition[] buffer = new Condition[salad.Ingredients.Length];
            int counter = 0;
            for(int i = 0; i < salad.Ingredients.Length; i++)
            {
                if (salad.Ingredients[i].Callory >= left && salad.Ingredients[i].Callory <= right) 
                {
                    buffer[counter] = new Condition();
                    buffer[counter] = salad.Ingredients[i];
                    counter++;
                }
            }
            Condition[] answer = new Condition[counter];
            answer = buffer;
            return answer;
        }
    }
}