using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10053887_mudzhadzhi_mulabisana__Part2_POE
{
    internal class Recipe : IComparable<Recipe>
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new List<Ingredient>();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }

        public int CalculateTotalCalories()
        {
            int totalCalories = 0;
            foreach (Ingredient ingredient in Ingredients)
            {
                totalCalories += ingredient.Calories;
            }
            return totalCalories;
        }

        public int CompareTo(Recipe other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
