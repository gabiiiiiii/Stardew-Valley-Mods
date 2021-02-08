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

        public bool CanLoad<T>(IAssetInfo asset)
        {
            //Abigail
            if (asset.AssetNameEquals("Characters/Abigail") || asset.AssetNameEquals("Portraits/Abigail"))
            {
                return true;
            }

            //Alex
            if (asset.AssetNameEquals("Characters/Alex") || asset.AssetNameEquals("Portraits/Alex"))
            {
                return true;
            }

            //Caroline
            if (asset.AssetNameEquals("Characters/Caroline") || asset.AssetNameEquals("Portraits/Caroline"))
            {
                return true;
            }

            //Clint
            if (asset.AssetNameEquals("Characters/Clint") || asset.AssetNameEquals("Portraits/Clint"))
            {
                return true;
            }

            //Demetrius
            if (asset.AssetNameEquals("Characters/Demetrius") || asset.AssetNameEquals("Portraits/Demetrius"))
            {
                return true;
            }

            //Elliott
            if (asset.AssetNameEquals("Characters/Elliott") || asset.AssetNameEquals("Portraits/Elliott"))
            {
                return true;
            }

            //Jodi
            if (asset.AssetNameEquals("Characters/Jodi") || asset.AssetNameEquals("Portraits/Jodi"))
            {
                return true;
            }

            //Kent
            if (asset.AssetNameEquals("Characters/Kent") || asset.AssetNameEquals("Portraits/Kent"))
            {
                return true;
            }

            //Shane
            if (asset.AssetNameEquals("Characters/Shane") || asset.AssetNameEquals("Portraits/Shane"))
            {
                return true;
            }

            //Robin
            if (asset.AssetNameEquals("Characters/Shane") || asset.AssetNameEquals("Portraits/Shane"))
            {
                return true;
            }

            return false;
        }

        public T Load<T>(IAssetInfo asset)
        {

            // Abigail
            if (asset.AssetNameEquals("Characters/Abigail"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Abigail"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Alex
            if (asset.AssetNameEquals("Characters/Alex"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Alex"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Caroline
            if (asset.AssetNameEquals("Characters/Caroline"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Caroline"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Clint
            if (asset.AssetNameEquals("Characters/Clint"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Clint"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Demetrius
            if (asset.AssetNameEquals("Characters/Demetrius"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Demetrius"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Elliott
            if (asset.AssetNameEquals("Characters/Elliott"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Elliott"))
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