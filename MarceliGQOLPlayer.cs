using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.GameInput;
using Terraria.Chat;
using Terraria.Localization;
using Terraria.ID;

namespace MarceliGQOL {
    public class MarceliGQOLPlayer : ModPlayer {
        internal bool revertSlot = false;
        internal int prevSlot;
        
        // Thanks to https://github.com/JavidPack/HelpfulHotkeys for QuickUse
        public bool PlayerCanSwitchItems => Player.itemAnimation == 0 && Player.ItemTimeIsZero && Player.reuseDelay == 0;
        public void QuickUse(int slot) {
            if (!revertSlot && Player.selectedItem != slot && Player.inventory[slot].type != ItemID.None && PlayerCanSwitchItems) {
                prevSlot = Player.selectedItem;
                revertSlot = true;
                Player.selectedItem = slot;
                Player.controlUseItem = true;
                Player.ItemCheck();
            }
        }

        public override void PostUpdate() {
            if (revertSlot && PlayerCanSwitchItems) {
                    Player.selectedItem = prevSlot;
                    revertSlot = false;
            }
        }

        public override void ProcessTriggers(TriggersSet triggersSet) {
            if (MarceliGQOL.QuickUse1.JustPressed) {
                QuickUse(40);
            }
            if (MarceliGQOL.QuickUse2.JustPressed) {
                QuickUse(41);
            }
            if (MarceliGQOL.QuickUse3.JustPressed) {
                QuickUse(42);
            }
            if (MarceliGQOL.QuickUse4.JustPressed) {
                QuickUse(43);
            }
            if (MarceliGQOL.QuickUse5.JustPressed) {
                QuickUse(44);
            }
            if (MarceliGQOL.QuickUse6.JustPressed) {
                QuickUse(45);
            }
            if (MarceliGQOL.QuickUse7.JustPressed) {
                QuickUse(46);
            }
            if (MarceliGQOL.QuickUse8.JustPressed) {
                QuickUse(47);
            }
            if (MarceliGQOL.QuickUse9.JustPressed) {
                QuickUse(48);
            }
            if (MarceliGQOL.QuickUse10.JustPressed) {
                QuickUse(49);
            }
        }
    }
}
