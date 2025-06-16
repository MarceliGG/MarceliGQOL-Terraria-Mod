using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System;

using Terraria.DataStructures;
using Terraria.ObjectData;
using Terraria.ModLoader;
using Terraria.Enums;
using Terraria.ID;
using Terraria;

using MarceliGQOL.Config;

namespace MarceliGQOL.Tiles {
	public class HousePlacer : ModTile {
		public override bool IsLoadingEnabled (Mod mod) {
			return ServerConfig.Instance.HousePlacer;
		}
		public override void SetStaticDefaults() {
			Main.tileFrameImportant[Type] = true;
			TileObjectData.newTile.Width = 1;
            TileObjectData.newTile.Height = 1;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(218, 169, 97));
		}

		public override IEnumerable<Item> GetItemDrops (int i, int j) {
			return null;
		}

		public override bool CreateDust(int i, int j, ref int type) {
            Dust.NewDust(new Vector2(i, j) * 16f, 16, 16, DustID.WoodFurniture, 0f, 0f, 1, new Color(255, 255, 255), 1f);
            return false;
        }

		public override bool RightClick(int x, int y) {
			// Console.WriteLine("i = {0}, j = {1}", x, y);
			WorldGen.PlaceTile(x, y, TileID.Chairs, false, true);
			WorldGen.PlaceTile(x-2, y, TileID.WorkBenches, false, true);
			for (int i = -5; i < 1; i++) {
				WorldGen.PlaceTile(x+i, y-4, TileID.WoodBlock, false, true);
				WorldGen.PlaceTile(x+i, y+1, TileID.WoodBlock, false, true);
			}
			for (int i = 1; i < 5; i++) {
				WorldGen.PlaceTile(x+i, y-4, TileID.Platforms, false, true);
				WorldGen.PlaceTile(x+i, y+1, TileID.Platforms, false, true);
			}
			WorldGen.PlaceTile(x+5, y-4, TileID.WoodBlock, false, true);
			WorldGen.PlaceTile(x+5, y+1, TileID.WoodBlock, false, true);
			WorldGen.PlaceTile(x+5, y-3, TileID.WoodBlock, false, true);
			WorldGen.PlaceTile(x-5, y-3, TileID.WoodBlock, false, true);
			WorldGen.PlaceTile(x+5, y, TileID.ClosedDoor, false, true);
			WorldGen.PlaceTile(x-5, y, TileID.ClosedDoor, false, true);
			for (int i = 0; i < 4; i++) 
				for (int j = -4; j < 5; j++) {
					WorldGen.ReplaceWall(x+j, y+i-3, WallID.Wood);
					WorldGen.PlaceWall(x+j, y+i-3, WallID.Wood);
			}
			WorldGen.PlaceTile(x, y-3, TileID.Torches, false, true);
			return true;
		}
	}
}
