﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Ingredient : ICloneable
    {
        public Ingredient(int id, string? name, int calories, double quantity)
        {
            Id = id;
            Name = name;
            Calories = calories;
            Quantity = quantity;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Calories { get; set; }
        public double Quantity { get; set; }

        public object Clone()
        {
            return new Ingredient(Id, Name, Calories, Quantity);
        }

        public virtual string GenerateIngredientCode()
        {
            return $"{Id}{Name[..2]}";
        }

        //Overloading
        public virtual string GenerateIngredientCode(string type)
        {
            return $"{Id}{Name[..2]}{type[..2]}";
        }
    }
}
