using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Dairy : Ingredient
    {
        public double Lactose { get; set; }

        public Dairy(int id, string? name, string? type, int calories, double quantity, double lactose) : 
            base(id, name, type, calories, quantity)
        {
            Lactose = lactose;
        }
    }
}
