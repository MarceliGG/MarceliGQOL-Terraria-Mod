using System;
using Terraria.ModLoader;
using Terraria;
using MarceliGQOL.Config;

namespace MarceliGQOL.AccesorySlots {
	public class WingSlot : ModAccessorySlot {
		public override string FunctionalTexture => "MarceliGQOL/Assets/wing";
		public override bool CanAcceptItem (Item checkItem, AccessorySlotType context) {
			return checkItem.wingSlot >= 0;
		}
		public override bool IsEnabled() => ServerConfig.Instance.WingSlot;
	}
}
