using Bandages.Common;
using Bandages.Common.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bandages.Content.Recipes
{
	public class CalamityAddRecipes : ModSystem
	{
		public override bool IsLoadingEnabled(Mod mod) {
			return ModContent.GetInstance<Config>().Calamity;
		}
		public override void AddRecipes()
		{
			Mod calamity = ModCheck.CalamityMod;
			if (calamity != null)
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