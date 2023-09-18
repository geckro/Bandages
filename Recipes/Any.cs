using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Bandages.Recipes
{
	public class Any : ModSystem
	{
		public override void AddRecipes()
		{
			Recipe.Create(ItemID.NightsEdge)
				.AddIngredient(ItemID.LightsBane)
				.AddIngredient(ItemID.Muramasa)
				.AddIngredient(ItemID.BladeofGrass)
				.AddIngredient(ItemID.FieryGreatsword)
				.AddTile(TileID.MythrilAnvil)
				.Register();
			Recipe.Create(ItemID.NightsEdge)
				.AddIngredient(ItemID.BloodButcherer)
				.AddIngredient(ItemID.Muramasa)
				.AddIngredient(ItemID.BladeofGrass)
				.AddIngredient(ItemID.FieryGreatsword)
				.AddTile(TileID.MythrilAnvil)
				.Register();
			Recipe.Create(ItemID.WormFood)
				.AddIngredient(ItemID.VilePowder, 30)
				.AddIngredient(ItemID.RottenChunk, 15)
				.AddTile(TileID.MythrilAnvil)
				.Register();
			Recipe.Create(ItemID.BloodySpine)
				.AddIngredient(ItemID.ViciousPowder, 30)
				.AddIngredient(ItemID.Vertebrae, 15)
				.AddTile(TileID.MythrilAnvil)
				.Register();
			Recipe.Create(ItemID.SuspiciousLookingEye)
				.AddIngredient(ItemID.Lens, 6)
				.AddTile(TileID.MythrilAnvil)
				.Register();
			Recipe.Create(ItemID.DeerThing)
				.AddIngredient(ItemID.FlinxFur, 3)
				.AddIngredient(ItemID.DemoniteOre, 5)
				.AddIngredient(ItemID.Lens)
				.AddTile(TileID.MythrilAnvil)
				.Register();
			Recipe.Create(ItemID.SlimeCrown)
				.AddIngredient(ItemID.Gel, 20)
				.AddIngredient(ItemID.GoldCrown)
				.AddTile(TileID.MythrilAnvil)
				.Register();
			Recipe.Create(ItemID.SlimeCrown)
				.AddIngredient(ItemID.Gel, 20)
				.AddIngredient(ItemID.PlatinumCrown)
				.AddTile(TileID.MythrilAnvil)
				.Register();
			Recipe.Create(ItemID.Goggles)
				.AddIngredient(ItemID.Lens, 2)
				.AddTile(TileID.Tables)
				.AddTile(TileID.Chairs)
				.Register();
			Recipe.Create(ItemID.Sunglasses)
				.AddIngredient(ItemID.BlackLens, 2)
				.AddTile(TileID.Tables)
				.AddTile(TileID.Chairs)
				.Register();
			Recipe.Create(ItemID.BallOHurt)
				.AddIngredient(ItemID.DemoniteBar, 10)
				.AddIngredient(ItemID.ShadowScale, 5)
				.AddTile(TileID.Anvils)
				.Register();
			Recipe.Create(ItemID.CloudinaBottle)
				.AddIngredient(ItemID.Bottle)
				.AddIngredient(ItemID.SoulofFlight, 25)
				.AddTile(TileID.CrystalBall)
				.Register();
			Recipe.Create(ItemID.IceBoomerang)
				.AddIngredient(ItemID.EnchantedBoomerang)
				.AddIngredient(ItemID.IceBlock, 100)
				.AddIngredient(ItemID.FlinxFur, 5)
				.AddTile(TileID.IceMachine)
				.Register();
			Recipe.Create(ItemID.Shroomerang)
				.AddIngredient(ItemID.IceBoomerang)
				.AddIngredient(ItemID.GlowingMushroom, 100)
				.AddIngredient(ItemID.MushroomGrassSeeds, 5)
				.AddTile(TileID.Anvils)
				.Register();
			Recipe.Create(ItemID.Handgun)
				.AddIngredient(ItemID.FlintlockPistol)
				.AddIngredient(ItemID.Bone, 50)
				.AddTile(TileID.BoneWelder)
				.Register();
			Recipe.Create(ItemID.PiranhaGun)
				.AddIngredient(ItemID.JungleKey)
				.AddIngredient(ItemID.Ectoplasm, 25)
				.AddTile(TileID.Autohammer)
				.Register();
			Recipe.Create(ItemID.StaffoftheFrostHydra)
				.AddIngredient(ItemID.FrozenKey)
				.AddIngredient(ItemID.Ectoplasm, 25)
				.AddTile(TileID.Autohammer)
				.Register();
			Recipe.Create(ItemID.ScourgeoftheCorruptor)
				.AddIngredient(ItemID.CorruptionKey)
				.AddIngredient(ItemID.Ectoplasm, 25)
				.AddTile(TileID.Autohammer)
				.Register();
			Recipe.Create(ItemID.VampireKnives)
				.AddIngredient(ItemID.CrimsonKey)
				.AddIngredient(ItemID.Ectoplasm, 25)
				.AddTile(TileID.Autohammer)
				.Register();
			Recipe.Create(ItemID.Mace)
				.AddRecipeGroup(nameof(ItemID.GoldBar), 12)
				.AddIngredient(ItemID.Ruby)
				.AddTile(TileID.HeavyWorkBench)
				.Register();
			Recipe.Create(ItemID.SlimeStaff)
				.AddIngredient(ItemID.SlimeStatue)
				.AddIngredient(ItemID.Wood, 12)
				.AddTile(TileID.WorkBenches)
				.Register();
			Recipe.Create(ItemID.RainbowGun)
				.AddIngredient(ItemID.HallowedKey)
				.AddIngredient(ItemID.Ectoplasm, 25)
				.AddTile(TileID.Autohammer)
				.Register();
			Recipe.Create(ItemID.StormTigerStaff)
				.AddIngredient(ItemID.DungeonDesertKey)
				.AddIngredient(ItemID.Ectoplasm, 25)
				.AddTile(TileID.Autohammer)
				.Register();
			Recipe.Create(ItemID.Rally)
				.AddIngredient(ItemID.WoodYoyo)
				.AddRecipeGroup(nameof(ItemID.GoldBar), 12)
				.AddTile(TileID.Anvils)
				.Register();
			Recipe.Create(ItemID.Cascade)
				.AddIngredient(ItemID.HelFire)
				.AddTile(TileID.CrystalBall)
				.Register();
			Recipe.Create(ItemID.WaterBolt)
				.AddIngredient(ItemID.WaterCandle, 10)
				.AddIngredient(ItemID.Bone, 15)
				.AddIngredient(ItemID.Book)
				.AddTile(TileID.Bookcases)
				.Register();
			Recipe.Create(ItemID.BrokenHeroSword)
				.AddIngredient(ItemID.TerraToilet)
				.AddTile(TileID.CrystalBall)
				.Register();
			
			var watchRecipes = new (int watchItem, int barItem)[]
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
				Recipe.Create(recipeData.watchItem)
					.AddIngredient(recipeData.barItem, 10)
					.AddIngredient(ItemID.Chain)
					.AddTile(TileID.WorkBenches)
					.AddTile(TileID.Chairs)
					.Register();
			}

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