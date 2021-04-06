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
    public class ModEntry : Mod, IAssetLoader
    {
        static int x = 1;

        public override void Entry(IModHelper helper)
        {

        }

        public bool CanLoad<T>(IAssetInfo asset)
        {
            switch(x)
            {
                case 1:
                    x++;
                    return asset.AssetNameEquals("Charactesrs/Dialogue/Spoop_Dog");
                case 2:
                    x++;
                    return asset.AssetNameEquals("Characters/schedules/Spoop_Dog");
                case 3:
                    x++;
                    return asset.AssetNameEquals("Mods/Assets/Sprite/Spoop_Dog");
                case 4:
                    x++;
                    return asset.AssetNameEquals("Mods/assets/Portrait/Spoop_Dog");
                default:
                    return false;
            }

            //return asset.AssetNameEquals("Charactesrs/Dialogue/Spoop_Dog");
            //return asset.AssetNameEquals("Characters/schedules/Spoop_Dog");
            //return asset.AssetNameEquals("Mods/Assets/Sprite/Spoop_Dog");
            //return asset.AssetNameEquals("Mods/assets/Portrait/Spoop_Dog");
        }

        
        public T Load<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals("Charactesrs/Dialogue/Spoop_Dog"))
            {
                return (T)(object)new Dictionary<string, string>
                {
                    ["Introduction"] = "BOOoOooOoOooOoOooOoOo"
                };
            }
            else if (asset.AssetNameEquals("Characters/schedules/Spoop_Dog"))
            {
                return (T)(object)new Dictionary<string, string>
                {
                    ["spring"] = "600 Town 45 88 2"
                };
            }
            else if (asset.AssetNameEquals("Mods/Assets/Sprite/Spoop_Dog"))
            {
                return this.Helper.Content.Load<T>("Assets/Sprite/Spoop_Dog.png", ContentSource.ModFolder);
            }
            else if (asset.AssetNameEquals("Mods/Assets/Portrait/Spoop_Dog"))
            {
                return this.Helper.Content.Load<T>("Assets/Portrait/Spoop_Dog.png", ContentSource.ModFolder);
            }
            else
            {
                throw new NotImplementedException("Ya broke it");
            }
        }
    }
}