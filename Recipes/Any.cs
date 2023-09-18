using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bandages.Recipes
{
	public class Any : ModSystem
	{
		public override void PostAddRecipes()
		{
			for (int i = 0; i < Recipe.numRecipes; i++)
			{
				Recipe recipe = Main.recipe[i];
				if (recipe.HasResult(ItemID.Muramasa) && recipe.HasTile(TileID.Anvils))
				{
					recipe.RemoveTile(TileID.Anvils);
					recipe.AddTile(TileID.BoneWelder);
				}
			}
		}
	}
}