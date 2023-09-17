using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bandages.Recipes
{
	public class CalamityAddRecipes : ModSystem
	{
		public override void AddRecipes()
		{
			Mod calamity;
			if (ModLoader.TryGetMod("CalamityMod", out calamity))
			{
				if (calamity.TryFind<ModItem>("Equanimity", out ModItem equanimity))
				{
					Recipe recipe = Recipe.Create(equanimity.Type)
						.AddIngredient(ItemID.Trimarang)
						.AddIngredient(ItemID.DarkShard)
						.AddIngredient(ItemID.LightShard)
						.AddTile(TileID.Anvils)
						.Register();
				}
			}
		}
	}
}