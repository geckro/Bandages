using Bandages.Common.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Bandages.Content.Recipes;

namespace Bandages.Content.Recipes
{
	public class Vanilla : ModSystem
	{
		public override bool IsLoadingEnabled(Mod mod) {
			return ModContent.GetInstance<Config>().AddRecipesToVanillaItems;
		}
		public override void AddRecipes()
		{
			// Nights Edge
			RecipeMaker.MakeRecipe(ItemID.NightsEdge,
				new[] {(ItemID.LightsBane, 1), (ItemID.Muramasa, 1), (ItemID.BladeofGrass, 1), (ItemID.FieryGreatsword, 1)},
				TileID.MythrilAnvil);
			
			RecipeMaker.MakeRecipe(ItemID.NightsEdge,
				new[] {(ItemID.BloodButcherer, 1), (ItemID.Muramasa, 1), (ItemID.BladeofGrass, 1), (ItemID.FieryGreatsword, 1)},
				TileID.MythrilAnvil);
			
			RecipeMaker.MakeRecipe(ItemID.WormFood,
				new[] {(ItemID.VilePowder, 30), (ItemID.RottenChunk, 15)},
				TileID.MythrilAnvil);
			
			RecipeMaker.MakeRecipe(ItemID.BloodySpine,
				new[] {(ItemID.ViciousPowder, 30), (ItemID.Vertebrae, 15)},
				TileID.MythrilAnvil);
			
			RecipeMaker.MakeRecipe(ItemID.SuspiciousLookingEye,
				new[] {(ItemID.Lens, 6)},
				TileID.MythrilAnvil);
			
			RecipeMaker.MakeRecipe(ItemID.DeerThing,
				new[] {(ItemID.FlinxFur, 3), (ItemID.DemoniteOre, 5), (ItemID.Lens, 1)},
				TileID.MythrilAnvil);

			RecipeMaker.MakeRecipe(ItemID.DeerThing,
				new[] {(ItemID.FlinxFur, 3), (ItemID.CrimtaneOre, 5), (ItemID.Lens, 1)},
				TileID.MythrilAnvil);
			
			RecipeMaker.MakeRecipe(ItemID.SlimeCrown,
				new[] {(ItemID.Gel, 20), (ItemID.GoldCrown, 1)},
				TileID.MythrilAnvil);
			
			RecipeMaker.MakeRecipe(ItemID.SlimeCrown,
				new[] {(ItemID.Gel, 20), (ItemID.PlatinumCrown, 1)},
				TileID.MythrilAnvil);
			
			RecipeMaker.MakeRecipe(ItemID.Goggles,
				new[] {(ItemID.Lens, 2)},
				TileID.Tables, TileID.Chairs);
			
			RecipeMaker.MakeRecipe(ItemID.Sunglasses,
				new[] {(ItemID.BlackLens, 2)},
				TileID.Tables, TileID.Chairs);
			
			RecipeMaker.MakeRecipe(ItemID.BallOHurt,
				new[] {(ItemID.DemoniteBar, 10), (ItemID.ShadowScale, 5)},
				TileID.Anvils);

			RecipeMaker.MakeRecipe(ItemID.CloudinaBottle,
				new[] {(ItemID.Bottle, 1), (ItemID.SoulofFlight, 25)},
				TileID.CrystalBall);

			RecipeMaker.MakeRecipe(ItemID.IceBoomerang,
				new[] {(ItemID.EnchantedBoomerang, 1), (ItemID.IceBlock, 100), (ItemID.FlinxFur, 5)},
				TileID.IceMachine);

			RecipeMaker.MakeRecipe(ItemID.Shroomerang,
				new[] {(ItemID.IceBoomerang, 1), (ItemID.GlowingMushroom, 100), (ItemID.MushroomGrassSeeds, 5)},
				TileID.Anvils);
			
			RecipeMaker.MakeRecipe(ItemID.Handgun,
				new[] {(ItemID.FlintlockPistol, 1), (ItemID.Bone, 50)},
				TileID.Anvils);
			
			RecipeMaker.MakeRecipe(ItemID.PiranhaGun,
				new[] {(ItemID.JungleKey, 1), (ItemID.Ectoplasm, 25)},
				TileID.Autohammer);
			
			RecipeMaker.MakeRecipe(ItemID.StaffoftheFrostHydra,
				new[] {(ItemID.FrozenKey, 1), (ItemID.Ectoplasm, 25)},
				TileID.Autohammer);
			
			RecipeMaker.MakeRecipe(ItemID.ScourgeoftheCorruptor,
				new[] {(ItemID.CorruptionKey, 1), (ItemID.Ectoplasm, 25)},
				TileID.Autohammer);
			
			RecipeMaker.MakeRecipe(ItemID.VampireKnives,
				new[] {(ItemID.CrimsonKey, 1), (ItemID.Ectoplasm, 25)},
				TileID.Autohammer);
			
			RecipeMaker.MakeRecipe(ItemID.StormTigerStaff,
				new[] {(ItemID.DungeonDesertKey, 1), (ItemID.Ectoplasm, 25)},
				TileID.Autohammer);
            
			RecipeMaker.MakeRecipe(ItemID.RainbowGun,
				new[] {(ItemID.HallowedKey, 1), (ItemID.Ectoplasm, 25)},
				TileID.Autohammer);
			
			RecipeMaker.MakeRecipe(ItemID.SlimeStaff,
				new[] {(ItemID.SlimeStatue, 1), (ItemID.Wood, 12)},
				TileID.WorkBenches);
			
			RecipeMaker.MakeRecipe(ItemID.Cascade,
				new[] {(ItemID.HelFire, 1)},
				TileID.CrystalBall);
			
			RecipeMaker.MakeRecipe(ItemID.WaterBolt,
				new[] {(ItemID.WaterCandle, 10), (ItemID.Bone, 15), (ItemID.Book, 1)},
				TileID.Bookcases);
			
			RecipeMaker.MakeRecipe(ItemID.BrokenHeroSword,
				new[] {(ItemID.TerraToilet, 1)},
				TileID.CrystalBall);
			
			Recipe.Create(ItemID.Mace)
				.AddRecipeGroup(nameof(ItemID.GoldBar), 12)
				.AddIngredient(ItemID.Ruby)
				.AddTile(TileID.HeavyWorkBench)
				.Register();
            
			Recipe.Create(ItemID.Rally)
				.AddIngredient(ItemID.WoodYoyo)
				.AddRecipeGroup(nameof(ItemID.GoldBar), 12)
				.AddTile(TileID.Anvils)
				.Register();
				
			var watchRecipes = new (short watchItem, short barItem)[]
			{
				(ItemID.CopperWatch, ItemID.CopperBar),
				(ItemID.TinWatch, ItemID.TinBar),
				(ItemID.SilverWatch, ItemID.SilverBar),
				(ItemID.TungstenWatch, ItemID.TungstenBar),
				(ItemID.GoldWatch, ItemID.GoldBar),
				(ItemID.PlatinumWatch, ItemID.PlatinumBar),
			};
			foreach (var recipeData in watchRecipes)
			{
				RecipeMaker.MakeRecipe(recipeData.watchItem,
					new[] {(recipeData.barItem, 10), (ItemID.Chain, 1)},
					TileID.WorkBenches, TileID.Chairs);
			}

		}
	}
}