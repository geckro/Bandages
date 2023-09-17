using Terraria.ModLoader;

namespace Bandages.Common
{
    public static class ModCheck
    {
        public static Mod ThoriumMod;
        public static Mod CalamityMod;
        public static Mod FargosMod;

        public static void InitializeMod()
        {
            ModLoader.TryGetMod("ThoriumMod", out ThoriumMod);
            ModLoader.TryGetMod("CalamityMod", out CalamityMod);
            ModLoader.TryGetMod("Fargowiltas", out FargosMod);
        }
    }
}