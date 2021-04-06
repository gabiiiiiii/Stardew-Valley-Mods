using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace Custom_NPC
{
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod, IAssetLoader, IAssetEditor
    {
        public override void Entry(IModHelper helper)
        {

        }

        public bool CanLoad<T>(IAssetInfo asset)
        {
            return asset.AssetNameEquals("Charactesrs/Dialogue/Spoop_Dog");
            return asset.AssetNameEquals("Characters/schedules/Spoop_Dog");
            return asset.AssetNameEquals("Characters/Spoop_Dog");
            return asset.AssetNameEquals("Portraits/Spoop_Dog");
        }

        
        public T Load<T>(IAssetInfo asset)
        {
            return (T)(object)new Dictionary<string, string>
            {
                ["Introduction"] = "BOOoOooOoOooOoOooOoOo"
            };

            return (T)(object)new Dictionary<string, string>
            {

            };

            
        }

        public bool CanEdit<T>(IAssetInfo asset)
        {
            throw new NotImplementedException();
        }

        public void Edit<T>(IAssetData asset)
        {
            throw new NotImplementedException();
        }
    }
}