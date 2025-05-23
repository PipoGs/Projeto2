using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlanner.Model
{

    namespace MealPlanner.Model
    {
        public class Recipe : IRecipe
        {
            public string Name { get; private set; }

            public IReadOnlyDictionary<IIngredient, int> IngredientsNeeded { get; private set; }

            public double SuccessRate { get; }

            public Recipe(string name, Dictionary<IIngredient, int> ingredientsNeeded, double successRate)
            {
                Name = name;
                IngredientsNeeded = ingredientsNeeded;
                SuccessRate = successRate;
            }

            public int CompareTo(IRecipe other)
            {
                if (other == null) return 1;
                return string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
            }
        }

    }

}