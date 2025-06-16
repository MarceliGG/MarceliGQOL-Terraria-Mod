//using Microsoft.Xna.Framework;
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
using Terraria;
using MarceliGQOL.Config;

namespace MarceliGQOL {
    public class MarceliGQOLPlayer : ModPlayer {
        internal bool revertSlot = false;
        internal int prevSlot;
        
        // Some QuickUse code from https://github.com/JavidPack/HelpfulHotkeys
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

        public override void PreUpdateBuffs() {

            if (ServerConfig.Instance.DisableUnlimitedBuffs) return;
            foreach (Item item in Player.bank2.item) {
                if (ServerConfig.Instance.UnlimitedPotions > 0 && item.buffType > 0 && item.stack >= ServerConfig.Instance.UnlimitedPotions) {
                    Player.AddBuff(item.buffType, 2);
                } else {
                    switch(item.type) {
                        case ItemID.WarTable:
                            if (ServerConfig.Instance.UnlimitedRClickStations) Player.AddBuff(BuffID.WarTable, 2);
                            break;
                        case ItemID.SharpeningStation:
                            if (ServerConfig.Instance.UnlimitedRClickStations) Player.AddBuff(BuffID.Sharpened, 2);
                            break;
                        case ItemID.CrystalBall:
                            if (ServerConfig.Instance.UnlimitedRClickStations) Player.AddBuff(BuffID.Clairvoyance, 2);
                            break;
                        case ItemID.BewitchingTable:
                            if (ServerConfig.Instance.UnlimitedRClickStations) Player.AddBuff(BuffID.Bewitched, 2);
                            break;
                        case ItemID.AmmoBox:
                            if (ServerConfig.Instance.UnlimitedRClickStations) Player.AddBuff(BuffID.AmmoBox, 2);
                            break;
                        case ItemID.CatBast:
                            if (ServerConfig.Instance.UnlimitedStations > 0 && item.stack >= ServerConfig.Instance.UnlimitedStations) Player.AddBuff(BuffID.CatBast, 2);
                            break;
                        case ItemID.SliceOfCake:
                            if (ServerConfig.Instance.UnlimitedStations > 0 && item.stack >= ServerConfig.Instance.UnlimitedStations) Player.AddBuff(BuffID.SugarRush, 2);
                            break;
                        case ItemID.StarinaBottle:
                            if (ServerConfig.Instance.UnlimitedStations > 0 && item.stack >= ServerConfig.Instance.UnlimitedStations) Player.AddBuff(BuffID.StarInBottle, 2);
                            break;
                        case ItemID.Campfire:
                            if (ServerConfig.Instance.UnlimitedStations > 0 && item.stack >= ServerConfig.Instance.UnlimitedStations) Player.AddBuff(BuffID.Campfire, 2);
                            break;
                        case ItemID.HeartLantern:
                            if (ServerConfig.Instance.UnlimitedStations > 0 && item.stack >= ServerConfig.Instance.UnlimitedStations) Player.AddBuff(BuffID.HeartLamp, 2);
                            break;
                        default:
                            Player.RefreshInfoAccsFromItemType(item);
                            break;
                    }
                }
            }
        }
    }
}
