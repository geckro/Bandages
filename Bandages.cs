using Bandages.Common;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Bandages
{
	public class Bandages : Mod
	{
		public override void PostSetupContent()
		{
			ModCheck.InitializeMod();
		}
	}

	public class RecipeGroups : ModSystem
	{
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.GoldBar)}", 
				ItemID.GoldBar, ItemID.PlatinumBar);
			RecipeGroup.RegisterGroup(nameof(ItemID.GoldBar), group);
		}
		
	}
}