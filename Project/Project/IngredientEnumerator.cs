using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class IngredientEnumerator : IEnumerator
    {
        private int _position;
        private Ingredient[] _ingredients;

        public IngredientEnumerator(Ingredient[] ingredients)
        {
            _position = -1;
            _ingredients = ingredients;
        }

        public Ingredient Current => _ingredients[_position];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _position++;
            return _position < _ingredients.Length;
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
