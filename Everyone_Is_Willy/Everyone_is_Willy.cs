using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

// this mod outputs the user input to the SMAPI terminal

namespace Everyone_is_Willy
{
    public class Everyone_is_Willy : Mod, IAssetLoader
    {
        public override void Entry(IModHelper helper)
        {
            
        }

        /*
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
        } */

        public bool CanLoad<T>(IAssetInfo asset)
        {
            //Caroline
            if (asset.AssetNameEquals("Characters/Caroline"))
            {
                return true;
            }

            if (asset.AssetNameEquals("Portraits/Caroline"))
            {
                return true;
            }

            //Jodi
            if (asset.AssetNameEquals("Characters/Jodi"))
            {
                return true;
            }

            if (asset.AssetNameEquals("Portraits/Jodi"))
            {
                return true;
            }

            //Kent
            if (asset.AssetNameEquals("Characters/Kent"))
            {
                return true;
            }

            if (asset.AssetNameEquals("Portraits/Kent"))
            {
                return true;
            }

            //Shane
            if (asset.AssetNameEquals("Characters/Shane"))
            {
                return true;
            }

            if (asset.AssetNameEquals("Portraits/Shane"))
            {
                return true;
            }

            //Robin
            if (asset.AssetNameEquals("Characters/Shane"))
            {
                return true;
            }

            if (asset.AssetNameEquals("Portraits/Shane"))
            {
                return true;
            }


            return false;
        }

        public T Load<T>(IAssetInfo asset)
        {
            // Caroline
            if (asset.AssetNameEquals("Characters/Caroline"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Caroline"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            //Jodi
            if (asset.AssetNameEquals("Characters/Jodi"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Jodi"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            //Kent
            if (asset.AssetNameEquals("Characters/Kent"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Kent"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            //Shane
            if (asset.AssetNameEquals("Characters/Shane"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Shane"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            //Robin
            if (asset.AssetNameEquals("Characters/Robin"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Robin"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            throw new InvalidOperationException($"Unexpected asset '{asset.AssetName}'.");
        }
    }
}