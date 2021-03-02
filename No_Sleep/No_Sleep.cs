using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace YourProjectName
{
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod
    {
        /*********
        ** Public methods
        *********/
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            helper.Events.GameLoop.TimeChanged += GameLoop_TimeChanged;
        }

        /*
         * Private Methods
         */
        private void GameLoop_TimeChanged(object sender, TimeChangedEventArgs e)
        {
            if (e.NewTime == 2500)
            {
                IReflectedField<int> timePass = this.Helper.Reflection.GetField<int>(typeof(Game1), "timeOfDay");
                timePass.SetValue(2400);
                
            }
            //throw new NotImplementedException();
        }


        
    }
}