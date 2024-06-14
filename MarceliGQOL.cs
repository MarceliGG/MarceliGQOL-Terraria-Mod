using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace MarceliGQOL {
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class MarceliGQOL : Mod {
		internal static ModKeybind QuickUse1;
		internal static ModKeybind QuickUse2;
		internal static ModKeybind QuickUse3;
		internal static ModKeybind QuickUse4;
		internal static ModKeybind QuickUse5;
		internal static ModKeybind QuickUse6;
		internal static ModKeybind QuickUse7;
		internal static ModKeybind QuickUse8;
		internal static ModKeybind QuickUse9;
		internal static ModKeybind QuickUse10;

		public override void Load() {
            QuickUse1 = KeybindLoader.RegisterKeybind(this, "Quick Use 1", "<Unbound>");
            QuickUse2 = KeybindLoader.RegisterKeybind(this, "Quick Use 2", "<Unbound>");
            QuickUse3 = KeybindLoader.RegisterKeybind(this, "Quick Use 3", "<Unbound>");
            QuickUse4 = KeybindLoader.RegisterKeybind(this, "Quick Use 4", "<Unbound>");
            QuickUse5 = KeybindLoader.RegisterKeybind(this, "Quick Use 5", "<Unbound>");
            QuickUse6 = KeybindLoader.RegisterKeybind(this, "Quick Use 6", "<Unbound>");
            QuickUse7 = KeybindLoader.RegisterKeybind(this, "Quick Use 7", "<Unbound>");
            QuickUse8 = KeybindLoader.RegisterKeybind(this, "Quick Use 8", "<Unbound>");
            QuickUse9 = KeybindLoader.RegisterKeybind(this, "Quick Use 9", "<Unbound>");
            QuickUse10 = KeybindLoader.RegisterKeybind(this, "Quick Use 10", "<Unbound>");
        }
	}
}
