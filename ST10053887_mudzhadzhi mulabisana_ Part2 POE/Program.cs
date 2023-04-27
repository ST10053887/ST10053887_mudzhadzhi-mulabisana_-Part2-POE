using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10053887_mudzhadzhi_mulabisana__Part2_POE
{
    internal class Program
    {
        static List<Recipe> recipes = new List<Recipe>();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a recipe name:");
            string name = Console.ReadLine();
            Recipe recipe = new Recipe(name);

            while (true)
            {
                Console.WriteLine("Enter an ingredient name (or 'done' to finish):");
                string ingredientName = Console.ReadLine();
                if (ingredientName.ToLower() == "done")
                {
                    break;
                }

                Console.WriteLine("Enter the number of calories:");
                int calories = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the food group:");
                string foodGroup = Console.ReadLine();

                recipe.AddIngredient(new Ingredient(ingredientName, calories, foodGroup));
            }

        }
    }
}
