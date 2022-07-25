using Project;

//Overriding
Ingredient ingredient01 = new Ingredient(1, "rosie", 18, 40);
Ingredient ingredient02 = new Meat(2, "pulpa", 50, 200, "pui");
Ingredient ingredient03 = new Dairy(3, "lapte", 34, 30, 4);

Console.WriteLine(ingredient01.GenerateIngredientCode());
Console.WriteLine(ingredient02.GenerateIngredientCode());
Console.WriteLine(ingredient03.GenerateIngredientCode());

//IEnumerable
Ingredient[] ingredients = new Ingredient[3]
{
    new Ingredient(4, "mar", 14, 50),
    new Ingredient(5, "banana", 20, 70),
    new Ingredient(6, "portocala", 12, 60)
};

IngredientEnumerable enumerableIngredients = new IngredientEnumerable(ingredients);
foreach (Ingredient ingredient in enumerableIngredients)
{
    Console.WriteLine(ingredient.Name);
}

//ICloneable
Ingredient ingredient04 = new Ingredient(7, "faina", 58, 200);
Ingredient ingredient05 = (Ingredient)ingredient04.Clone();

Console.WriteLine("Ingredient04: " + ingredient04.Id + " " + ingredient04.Name);
Console.WriteLine("Ingredient05: " + ingredient05.Id + " " + ingredient05.Name);