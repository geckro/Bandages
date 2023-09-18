using Bandages.Common;
using Bandages.Common.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bandages.Content.Recipes
{
    public class FargosAddCrucibleToCalamityItems : ModSystem
    {
        public override bool IsLoadingEnabled(Mod mod) {
            return ModContent.GetInstance<Config>().CalamityFargowiltas;
        }
        public override void PostAddRecipes()
        {
            Mod fargos = ModCheck.FargosMod;
            Mod calamity = ModCheck.CalamityMod;
            if (fargos != null && calamity != null)
            {
                if (
                    fargos.TryFind<ModTile>("CrucibleCosmosSheet", out ModTile crucible) &&
                    calamity.TryFind<ModItem>("LifeAlloy", out ModItem lifeAlloy)
                    )
                {
                    for (int i = 0; i < Recipe.numRecipes; i++)
                    {
                        Recipe recipe = Main.recipe[i];
                        if (recipe.HasIngredient(lifeAlloy) && recipe.HasTile(TileID.LunarCraftingStation))
                        {
                            recipe.RemoveTile(TileID.LunarCraftingStation);
                            recipe.AddTile(crucible.Type);
                        }
                    }
                }
            }
        }
    }
}