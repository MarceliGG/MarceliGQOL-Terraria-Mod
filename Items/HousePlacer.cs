using System;

using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

using MarceliGQOL.Config;

namespace MarceliGQOL.Items {
	public class HousePlacer : ModItem {
		public override string Texture => "MarceliGQOL/Tiles/HousePlacer";
		public override bool IsLoadingEnabled (Mod mod) {
			return ServerConfig.Instance.HousePlacer;
		}
		public override void SetDefaults() {
		    Item.useStyle = ItemUseStyleID.Swing;
		    Item.rare = ItemRarityID.Blue;
			Item.useAnimation = 20;
            Item.useTime = 20;
            Item.createTile = ModContent.TileType<Tiles.HousePlacer>();
        }
	}
}
