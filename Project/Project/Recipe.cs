﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Recipe
    {
        public Recipe(int id, string? name, string? author, string? description, RecipeType? type, int calories,
                List<Ingredient>? ingredients)
        {
            Id = id;
            Name = name;
            Author = author;
            Description = description;
            Type = type;
            Calories = calories;
            Ingredients = ingredients;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        public RecipeType? Type { get; set; }
        public int Calories { get; set; }
        public List<Ingredient>? Ingredients { get; set; }
    }
}
