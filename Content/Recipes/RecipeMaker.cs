using System;
using Terraria;
using Terraria.ModLoader;

namespace Bandages.Content.Recipes
{
    public static class RecipeMaker
    {
        // Asks for an item, a tile and them asks for a param for any amount of items.
        public static void MakeRecipe(short item, (short ingredient, int count)[] ingredients, params ushort[] tiles)
        {
            var recipe = Recipe.Create(item);
            foreach (var ingredient in ingredients) {
                try
                {
                    recipe.AddIngredient(ingredient.ingredient, ingredient.count);
                }
                catch (Exception e)
                {
                    ModContent.GetInstance<Bandages>().Logger.Error("Bandages: Error in MakeRecipe AddIngredient");
                }
            }
            foreach (var tile in tiles) {
                try
                {
                    recipe.AddTile(tile);
                }
                catch (Exception e)
                {
                    ModContent.GetInstance<Bandages>().Logger.Error("Bandages: Error in MakeRecipe AddTile");
                }
            }
            recipe.Register();
        }
    }
}
