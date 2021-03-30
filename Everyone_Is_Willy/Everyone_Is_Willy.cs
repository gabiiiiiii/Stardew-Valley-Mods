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
            //Abigail
            /*
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

            //Dana
            if (asset.AssetNameEquals("Characters/Dana") || asset.AssetNameEquals("Portraits/Dana"))
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

            //Emily
            if (asset.AssetNameEquals("Characters/Emily") || asset.AssetNameEquals("Portraits/Emily"))
            {
                return true;
            }

            //Evelyn
            if (asset.AssetNameEquals("Characters/Evelyn") || asset.AssetNameEquals("Portraits/Evelyn"))
            {
                return true;
            }

            //George
            if (asset.AssetNameEquals("Characters/George") || asset.AssetNameEquals("Portraits/George"))
            {
                return true;
            }

            //Gus
            if (asset.AssetNameEquals("Characters/Gus") || asset.AssetNameEquals("Portraits/Gus"))
            {
                return true;
            }

            //Haley
            if (asset.AssetNameEquals("Characters/Haley") || asset.AssetNameEquals("Portraits/Haley"))
            {
                return true;
            }

            //Harvey
            if (asset.AssetNameEquals("Characters/Harvey") || asset.AssetNameEquals("Portraits/Harvey"))
            {
                return true;
            }

            //Jas
            if (asset.AssetNameEquals("Characters/Jas") || asset.AssetNameEquals("Portraits/Jas"))
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

            //Leah
            if (asset.AssetNameEquals("Characters/Leah") || asset.AssetNameEquals("Portraits/Leah"))
            {
                return true;
            }

            //Lewis
            if (asset.AssetNameEquals("Characters/Lewis") || asset.AssetNameEquals("Portraits/Lewis"))
            {
                return true;
            }

            //Linus
            if (asset.AssetNameEquals("Characters/Linus") || asset.AssetNameEquals("Portraits/Linus"))
            {
                return true;
            }

            //Marcello
            if (asset.AssetNameEquals("Characters/Marcello") || asset.AssetNameEquals("Portraits/Marcello"))
            {
                return true;
            }

            //Mariner
            if (asset.AssetNameEquals("Characters/Mariner") || asset.AssetNameEquals("Portraits/Mariner"))
            {
                return true;
            }

            //Marlon
            if (asset.AssetNameEquals("Characters/Marlon") || asset.AssetNameEquals("Portraits/Marlon"))
            {
                return true;
            }

            //Marnie
            if (asset.AssetNameEquals("Characters/Marnie") || asset.AssetNameEquals("Portraits/Marnie"))
            {
                return true;
            }

            //Maru
            if (asset.AssetNameEquals("Characters/Maru") || asset.AssetNameEquals("Portraits/Maru"))
            {
                return true;
            }

            //Morris
            if (asset.AssetNameEquals("Characters/Morris") || asset.AssetNameEquals("Portraits/Morris"))
            {
                return true;
            }

            //Pam
            if (asset.AssetNameEquals("Characters/Pam") || asset.AssetNameEquals("Portraits/Pam"))
            {
                return true;
            }

            //Penny
            if (asset.AssetNameEquals("Characters/Penny") || asset.AssetNameEquals("Portraits/Penny"))
            {
                return true;
            }

            //Pierre
            if (asset.AssetNameEquals("Characters/Pierre") || asset.AssetNameEquals("Portraits/Pierre"))
            {
                return true;
            }

            //Shane
            if (asset.AssetNameEquals("Characters/Shane") || asset.AssetNameEquals("Portraits/Shane"))
            {
                return true;
            }

            //Robin
            if (asset.AssetNameEquals("Characters/Robin") || asset.AssetNameEquals("Portraits/Robin"))
            {
                return true;
            }

            //Sam
            if (asset.AssetNameEquals("Characters/Sam") || asset.AssetNameEquals("Portraits/Sam"))
            {
                return true;
            }

            //Sandy
            if (asset.AssetNameEquals("Characters/Sandy") || asset.AssetNameEquals("Portraits/Sandy"))
            {
                return true;
            }

            //Sebastian
            if (asset.AssetNameEquals("Characters/Sebastian") || asset.AssetNameEquals("Portraits/Sebastian"))
            {
                return true;
            }

            //Vincent
            if (asset.AssetNameEquals("Characters/Vincent") || asset.AssetNameEquals("Portraits/Vincent"))
            {
                return true;
            }

            //Wizard
            if (asset.AssetNameEquals("Characters/Wizard") || asset.AssetNameEquals("Portraits/Wizard"))
            {
                return true;
            }

            //Baby
            if (asset.AssetNameEquals("Characters/Baby"))
            {
                return true;
            }
            */

            return false;
        }

        public T Load<T>(IAssetInfo asset)
        {

            // Abigail
            /*
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

            // Dana
            if (asset.AssetNameEquals("Characters/Dana"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Dana"))
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

            // Emily
            if (asset.AssetNameEquals("Characters/Emily"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Emily"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Evelyn
            if (asset.AssetNameEquals("Characters/Evelyn"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Evelyn"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // George
            if (asset.AssetNameEquals("Characters/George"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/George"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Gus
            if (asset.AssetNameEquals("Characters/Gus"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Gus"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Haley
            if (asset.AssetNameEquals("Characters/Haley"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Haley"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Harvey
            if (asset.AssetNameEquals("Characters/Harvey"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Harvey"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Jas
            if (asset.AssetNameEquals("Characters/Jas"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Jas"))
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

            // Leah
            if (asset.AssetNameEquals("Characters/Leah"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Leah"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Lewis
            if (asset.AssetNameEquals("Characters/Lewis"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Lewis"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Linus
            if (asset.AssetNameEquals("Characters/Linus"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Linus"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Marcello
            if (asset.AssetNameEquals("Characters/Marcello"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Marcello"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Mariner
            if (asset.AssetNameEquals("Characters/Mariner"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Mariner"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Marlon
            if (asset.AssetNameEquals("Characters/Marlon"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Marlon"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Marnie
            if (asset.AssetNameEquals("Characters/Marnie"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Marnie"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Maru
            if (asset.AssetNameEquals("Characters/Maru"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Maru"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Morris
            if (asset.AssetNameEquals("Characters/Morris"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Morris"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Pam
            if (asset.AssetNameEquals("Characters/Pam"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Pam"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Penny
            if (asset.AssetNameEquals("Characters/Penny"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Penny"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Pierre
            if (asset.AssetNameEquals("Characters/Pierre"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Pierre"))
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

            //Sam
            if (asset.AssetNameEquals("Characters/Sam"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Sam"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            //Sandy
            if (asset.AssetNameEquals("Characters/Sandy"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Sandy"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Sebastian
            if (asset.AssetNameEquals("Characters/Sebastian"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Sebastian"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            // Vincent
            if (asset.AssetNameEquals("Characters/Vincent"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Vincent"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            //Wizard
            if (asset.AssetNameEquals("Characters/Wizard"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }

            if (asset.AssetNameEquals("Portraits/Wizard"))
            {
                return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
            }

            //Baby
            if (asset.AssetNameEquals("Characters/Baby"))
            {
                return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
            }
            */

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
                if (asset.AssetNameEquals(charName))
                {
                    return this.Helper.Content.Load<T>("Characters/Willy", ContentSource.GameContent);
                }

                if (asset.AssetNameEquals(porName))
                {
                    return this.Helper.Content.Load<T>("Portraits/Willy", ContentSource.GameContent);
                }
            }

            throw new InvalidOperationException($"Unexpected asset '{asset.AssetName}'.");
        }
    }
}