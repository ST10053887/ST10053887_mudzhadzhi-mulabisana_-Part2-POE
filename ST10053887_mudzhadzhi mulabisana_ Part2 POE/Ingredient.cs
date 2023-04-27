using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10053887_mudzhadzhi_mulabisana__Part2_POE
{
    internal class Ingredient
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public string FoodGroup { get; set; }

        public Ingredient(string name, int calories, string foodGroup)
        {
            Name = name;
            Calories = calories;
            FoodGroup = foodGroup;
        }
    }
}
