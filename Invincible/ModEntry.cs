using System;
using System.Runtime.CompilerServices;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace Invincible
{
    /// <summary>The mod entry point.</summary>
    internal sealed class ModEntry : Mod
    {
        /*********
        ** Public methods
        *********/
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            helper.Events.GameLoop.OneSecondUpdateTicked += this.OnOneSecondUpdateTicked;
        }


        /*********
        ** Private methods
        *********/
        /// <summary>The method invoked when the game updates its state.</summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OnOneSecondUpdateTicked(object sender, EventArgs e)
        {
            Game1.player.health = Game1.player.maxHealth;
        }
    }
}
