using Bandages.Common;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bandages.Recipes
{
    public class ThoriumToCalamityRecipes : ModSystem
    {
        public override void AddRecipes()
        {
            Mod thorium = ModCheck.ThoriumMod;
            Mod calamity = ModCheck.CalamityMod;
            if (thorium != null && calamity != null)
            {
                if (
                    thorium.TryFind<ModItem>("TerrariumParticleSprinters", out ModItem terrariumParticleSprinters) &&
                    thorium.TryFind<ModItem>("TerrariumWings", out ModItem terrariumWings) &&
                    calamity.TryFind<ModItem>("TracersCelestial", out ModItem tracersCelestial) &&
                    calamity.TryFind<ModItem>("HarpyRing", out ModItem harpyRing)
                )
                {
                    Recipe recipe = Recipe.Create(tracersCelestial.Type)
                        .AddIngredient(terrariumParticleSprinters.Type)
                        .AddIngredient(terrariumWings.Type)
                        .AddIngredient(harpyRing.Type)
                        .AddIngredient(ItemID.LunarBar, 5)
                        .AddTile(TileID.LunarCraftingStation)
                        .Register();
                }
            }
        }
    }

    public class ThoriumEditCalamityItems : ModSystem
    {
        public override void PostAddRecipes()
        {
            Mod thorium = ModCheck.ThoriumMod;
            Mod calamity = ModCheck.CalamityMod;
            if (thorium != null && calamity != null)
            {
                if (
                    calamity.TryFind<ModItem>("PurifiedGel", out ModItem purifiedGel) &&

                    // EVIL RECIPES
                    thorium.TryFind<ModItem>("Sanguine", out ModItem crimsonEvilYoyo) &&
                    thorium.TryFind<ModItem>("Nocturnal", out ModItem corruptEvilYoyo) &&
                    thorium.TryFind<ModItem>("BloodHarvest", out ModItem crimsonEvilHealerScythe) &&
                    thorium.TryFind<ModItem>("FallingTwilight", out ModItem corruptEvilHealerScythe) &&
                    thorium.TryFind<ModItem>("Embowelment", out ModItem crimsonEvilThrowingKnife) &&
                    thorium.TryFind<ModItem>("LightAnguish", out ModItem corruptEvilThrowingKnife) &&

                    // TERRA RECIPES
                    calamity.TryFind<ModItem>("LivingShard", out ModItem planteraShard) &&
                    thorium.TryFind<ModItem>("TerraKnife", out ModItem terraThrowingKnife) &&
                    thorium.TryFind<ModItem>("TerraScythe", out ModItem terraHealerScythe) &&

                    // BOSS SUMMON REQUIREMENTS
                    calamity.TryFind<ModItem>("DesertMedallion", out ModItem desertScourgeSummonItem) &&
                    thorium.TryFind<ModItem>("SandstoneIngot", out ModItem thunderbirdIngot)
                )
                {
                    for (int i = 0; i < Recipe.numRecipes; i++)
                    {
                        // ADD PURIFIED GEL TO EVIL RECIPES
                        Recipe recipe = Main.recipe[i];
                        if (recipe.HasResult(crimsonEvilYoyo) || recipe.HasResult(corruptEvilYoyo) ||
                            recipe.HasResult(crimsonEvilHealerScythe) || recipe.HasResult(corruptEvilHealerScythe) ||
                            recipe.HasResult(crimsonEvilThrowingKnife) || recipe.HasResult(corruptEvilThrowingKnife))
                        {
                            recipe.AddIngredient(purifiedGel.Type, 5);
                        }

                        if (recipe.HasResult(desertScourgeSummonItem))
                        {
                            recipe.AddIngredient(thunderbirdIngot.Type, 5);
                        }

                        if (recipe.HasResult(terraThrowingKnife) || recipe.HasResult(terraHealerScythe))
                        {
                            recipe.AddIngredient(planteraShard.Type, 12);
                        }
                    }
                }
            }
        }
    }

    public class CalamityEditThoriumItems : ModSystem
    {
        public override void PostAddRecipes()
        {
            Mod thorium = ModCheck.ThoriumMod;
            Mod calamity = ModCheck.CalamityMod;
            if (thorium != null && calamity != null)
            {
                if (
                    thorium.TryFind<ModItem>("StreamSting", out ModItem dungeonThoriumBow) &&
                    thorium.TryFind<ModItem>("IllumiteIngot", out ModItem illumiteIngot) &&
                    calamity.TryFind<ModItem>("LunarianBow", out ModItem lunarianBow) &&
                    calamity.TryFind<ModItem>("PearlGod", out ModItem pearlGodGun) &&
                    thorium.TryFind<ModItem>("IllumiteBlade", out ModItem illumiteBlade) &&
                    calamity.TryFind<ModItem>("Hellkite", out ModItem hellkite)
                )
                {
                    for (int i = 0; i < Recipe.numRecipes; i++)
                    {
                        Recipe recipe = Main.recipe[i];
                        if (recipe.HasResult(lunarianBow))
                        {
                            recipe.AddIngredient(dungeonThoriumBow.Type);
                        }

                        if (recipe.HasResult(pearlGodGun))
                        {
                            recipe.AddIngredient(illumiteIngot.Type, 5);
                        }
                        
                        if (recipe.HasResult(hellkite))
                        {
                            recipe.AddIngredient(illumiteBlade.Type);
                        }
                    }
                }
            }
        }
    }

    /* Notes:
     * Thorium seems better than Gold but worse than Platinum.
     */
    public class ThoriumEditItems : GlobalItem
    {
        public class ThoriumPax : GlobalItem
        {
            public override bool AppliesToEntity(Item item, bool lateInstatiation)
            {
                Mod thorium = ModCheck.ThoriumMod;
                Mod calamity = ModCheck.CalamityMod;
                if (thorium != null && calamity != null)
                {
                    if (thorium.TryFind<ModItem>("ThoriumPax", out ModItem thoriumPickaxeAxe))
                    {
                        return item.type == thoriumPickaxeAxe.Type;
                    }
                }

                return false;
            }

            public override void SetDefaults(Item item)
            {
                item.StatsModifiedBy.Add(Mod);
                item.pick = 55;
                item.axe = 11;
            }
        }
    }
}