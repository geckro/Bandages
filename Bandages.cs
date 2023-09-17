using Bandages.Common;
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
	}
}