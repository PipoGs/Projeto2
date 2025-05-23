using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPlanner.Model
{
    public class Ingredient : IIngredient
    {

        public string Type { get; }
        public string Name { get; }

        public Ingredient(string type, string name)
        {
            Type = type;
            Name = name;
        }

        public bool Equals(IIngredient obj)
        {
            if (obj == null || obj.GetType() != GetType()) return false;
            Ingredient other = (Ingredient)obj;
            return Type == other.Type || Name == other.Name;
        }
    }
}