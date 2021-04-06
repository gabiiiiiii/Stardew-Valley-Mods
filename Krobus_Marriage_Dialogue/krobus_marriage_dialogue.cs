using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace Krobus_Marriage_Dialogue
{
    class krobus_marriage_dialogue : Mod, IAssetEditor
    {
        public override void Entry(IModHelper helper)
        {

        }

        public bool CanEdit<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals("Data/Characters/Dialogue/MarriageDialogueKrobus"))
            {
                return true;
            }

            return false;
        }

        public void Edit<T>(IAssetData asset)
        {
            var editor = asset.AsDictionary<string, string>();

            editor.Data["Indoor_Day_0"] = "If I could come help you, I would... but I'll do my best to keep the house in order." +
                "$s#$e#I am glad the Wizard was able to put a spell on the town for us to have a wedding.";

            editor.Data["Rainy_Night_1"] = "If the other shadow people knew about us," +
                " they would... 'punish' me.$s#$e#Most of them despise humans, you know.";

            editor.Data["Indoor_Night_4"] = "I want to be a good husband for you, but I never know " +
                "if I'm doing well... *groan* $s#$e#I have a hard time understanding human" +
                " expression. B... but... you're happy living with me?#$e#Okay!$7";

            editor.Data["Good_1"] = "I feel a sensation in my body... this... is love!$l#$b#... Oh, wait... I'm just shedding my skin.$s";

            editor.Data["Neutral_2"] = "Do you think we could get in trouble for being together?$s";

            editor.Data["Neutral_9"] = "I wonder if we'll live in this house our entire lives? Moving would probably be too dangerous for me.";

            editor.Data["Bad_2"] = "Are you still happy, being with me?$s";

            editor.Data["winter_28"] = "Thanks for being with me, @. I'm looking forward to another great year!$h";
        }
    }
}
