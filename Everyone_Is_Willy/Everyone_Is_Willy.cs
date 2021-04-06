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
            String[] characters =
                {"Abigail", "Abigail_Beach", "Alex", "Alex_Beach", "Baby", "Baby_dark",
                "Caroline", "Caroline_Beach", "Clint", "Clint_Beach", "Dana", "Demetrius",
                "Demetrius_Beach", "Dwarf", "Elliott", "Elliott_Beach", "Emily", "Emily_Beach",
                "Evelyn", "George", "Gus", "Haley", "Haley_Beach", "Harvey", "Harvey_Beach",
                "Jas", "Jodi", "Jodi_Beach", "Kent", "Leah", "Leah_Beach", "Lewis", "Lewis_Beach",
                "Linus", "Marcello", "Marlon", "Marnie", "Marnie_Beach", "Maru", "Maru_Beach",
                "Maru_Hospital", "Morris", "Pam", "Pam_Beach", "Penny", "Penny_Beach", "Pierre",
                "Pierre_Beach", "Robin", "Robin_Beach", "Sam", "Sam_Beach", "Sandy", "Sebastian",
                "Sebastian_Beach", "Shane", "Shane_Beach", "Shane_JojaMart", "Toddler", "Toddler_dark",
                "Toddler_girl", "Toddler_girl_dark", "Vincent", "Wizard"};

            for (int i = 0; i < characters.Length; i++)
            {
                String charName = "Characters/" + characters[i];
                String porName = "Portraits/" + characters[i];
                if (asset.AssetNameEquals(charName) || asset.AssetNameEquals(porName))
                {
                    return true;
                }
            }

            return false;
        }

        public T Load<T>(IAssetInfo asset)
        {


            String[] characters =
                {"Abigail", "Abigail_Beach", "Alex", "Alex_Beach",
                "Caroline", "Caroline_Beach", "Clint", "Clint_Beach", "Dana", "Demetrius",
                "Demetrius_Beach", "Dwarf", "Elliott", "Elliott_Beach", "Emily", "Emily_Beach",
                "Evelyn", "George", "Gus", "Haley", "Haley_Beach", "Harvey", "Harvey_Beach",
                "Jas", "Jodi", "Jodi_Beach", "Kent", "Leah", "Leah_Beach", "Lewis", "Lewis_Beach",
                "Linus", "Marcello", "Marlon", "Marnie", "Marnie_Beach", "Maru", "Maru_Beach",
                "Maru_Hospital", "Morris", "Pam", "Pam_Beach", "Penny", "Penny_Beach", "Pierre",
                "Pierre_Beach", "Robin", "Robin_Beach", "Sam", "Sam_Beach", "Sandy", "Sebastian",
                "Sebastian_Beach", "Shane", "Shane_Beach", "Shane_JojaMart", "Vincent", "Wizard"};

            for (int i = 0; i < characters.Length; i++)
            {
                String charName = "Characters/" + characters[i];
                String porName = "Portraits/" + characters[i];
                if (asset.AssetNameEquals(charName))
                {
                    return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
                }

                if (asset.AssetNameEquals(porName))
                {
                    return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
                }
            }

            String[] baby =
            {
                "Baby", "Baby_dark"
            };

            for (int i = 0; i < baby.Length; i++)
            {
                String charName = "Characters/" + baby[i];
                if (asset.AssetNameEquals(charName))
                {
                    return this.Helper.Content.Load<T>("assets/willy_is_baby.png", ContentSource.ModFolder);
                }
            }

            String[] toddler = {
                "Toddler", "Toddler_dark", "Toddler_girl", "Toddler_girl_dark"
            };

            for (int i = 0; i < toddler.Length; i++)
            {
                String charName = "Characters/" + toddler[i];
                if (asset.AssetNameEquals(charName))
                {
                    return this.Helper.Content.Load<T>("assets/Toddler_willy.png", ContentSource.ModFolder);
                }
            }

            throw new InvalidOperationException($"Unexpected asset '{asset.AssetName}'.");
        }
    }
}