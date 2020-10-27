using InquirerCS;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Coock
{
    class Program
    {
        static public void Output(Condition[] ingredients)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine(ingredients[i].Name);
            }
        }

        static public void Menu(string path)
        {
            Salad salad = new Salad();
            bool flag = true;
            string choose;
            Console.WriteLine("Choose availeble task. Please use only numbers to choose task:");
            Console.WriteLine("1. Create salad");
            Console.WriteLine("2. Get Calloty");
            Console.WriteLine("3. Sort ingredients for callory");
            Console.WriteLine("4. Sort ingredients for name");
            Console.WriteLine("5. Sort ingredients for storage time");
            Console.WriteLine("6. Sort ingredients for price");
            Console.WriteLine("7. Find ingredient in callory range");
            Console.WriteLine("8. Exit");
            while (flag)
            {
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        salad = Salad.CreateUniqeSalad(path);
                        break;
                    case "2":
                        //salad = Salad.GetCallory(salad);
                        Console.WriteLine("Callory is {0}", salad.Callory);
                        break;
                    case "3":
                        salad = Salad.Sort(salad, "callory");
                        Output(salad.Ingredients);
                        break;
                    case "4":
                        salad = Salad.Sort(salad, "name");
                        Output(salad.Ingredients);
                        break;
                    case "5":
                        salad = Salad.Sort(salad, "storageTime");
                        Output(salad.Ingredients);
                        break;
                    case "6":
                        salad = Salad.Sort(salad, "price");
                        Output(salad.Ingredients);
                        break;
                    case "7":
                        Console.WriteLine("Input left interval:");
                        int left = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Input right interval:");
                        int right = Int32.Parse(Console.ReadLine());
                        Output(Salad.FindCalloryIngredients(salad, left, right));
                        break;
                    case "8":
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Wrong Input. Please Try Again");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            string path = "/Users/Asus/source/repos/Coock/Coock/ingredients.txt";
            Menu(path);
        }
    }
}
