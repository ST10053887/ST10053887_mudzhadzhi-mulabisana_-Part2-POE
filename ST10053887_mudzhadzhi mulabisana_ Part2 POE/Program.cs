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

        }
    }
}
