using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Dairy : Ingredient
    {
        public Dairy(int id, string? name, string? type, int calories, double quantity) : 
            base(id, name, type, calories, quantity)
        {
        }
    }
}
