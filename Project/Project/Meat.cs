using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Meat : Ingredient
    {
        public string? Origin { get; set; }

        public Meat(int id, string? name, string? type, int calories, double quantity, string? origin) : 
            base(id, name, type, calories, quantity)
        {
            Origin = origin;
        }
    }
}
