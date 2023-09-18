using Bandages.Common.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bandages.Content.Recipes
{
	public class Any : ModSystem
	{
		public override bool IsLoadingEnabled(Mod mod) {
			return ModContent.GetInstance<Config>().RebalanceVanilla;
		}
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