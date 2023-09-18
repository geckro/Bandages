using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace Bandages.Common.Config
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
		
        // TODO: More granular control for vanilla recipes. Maybe a config for each recipe or a config for categories of recipes. Not sure.
        [Header("General")]
        
        [DefaultValue(true)] 
        [ReloadRequired]
        public bool AddRecipesToVanillaItems;
        
        [DefaultValue(true)] 
        [ReloadRequired]
        public bool RebalanceVanilla;
        
        [Header("ModTweaks")]
        
        [DefaultValue(true)] 
        [ReloadRequired]
        public bool Calamity;
        
        [Header("Compatibility")]
        
        [DefaultValue(true)] 
        [ReloadRequired]
        public bool CalamityThorium;
        
        [DefaultValue(true)] 
        [ReloadRequired]
        public bool CalamityFargowiltas;
    }
}