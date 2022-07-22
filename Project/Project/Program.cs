using Project;

Ingredient ingredient01 = new Ingredient(1, "rosie", 18, 40);
Ingredient ingredient02 = new Meat(2, "pulpa", 50, 200, "pui");
Ingredient ingredient03 = new Dairy(3, "lapte", 34, 30, 4);

Console.WriteLine(ingredient01.GenerateIngredientCode());
Console.WriteLine(ingredient02.GenerateIngredientCode());
Console.WriteLine(ingredient03.GenerateIngredientCode());