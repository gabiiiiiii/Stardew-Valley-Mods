using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

// this mod outputs the user input to the SMAPI terminal

namespace Everyone_Is_Willy
{
    public class All_Willy : Mod, IAssetLoader
    {
        public override void Entry(IModHelper helper)
        {
            
        }

        public bool CanLoad<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals("Portraits/Caroline"))
            {
                return true;
            }

            return false;
        }

        public T Load<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals("Portraits/Caroline"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            throw new InvalidOperationException($"Unexpected asset '{asset.AssetName}'.");
        }
    }
}