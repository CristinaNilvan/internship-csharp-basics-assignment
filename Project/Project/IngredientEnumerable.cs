using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class IngredientEnumerable : IEnumerable
    {
        private Ingredient[] _ingredients;

        public IngredientEnumerable(Ingredient[] ingredients)
        {
            _ingredients = new Ingredient[ingredients.Length];
            for (int i = 0; i < ingredients.Length; i++)
            {
                _ingredients[i] = ingredients[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public IngredientEnumerator GetEnumerator()
        {
            return new IngredientEnumerator(_ingredients);
        }
    }
}
