using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace MarceliGQOL.Config;

public class ServerConfig : ModConfig {
	public static ServerConfig Instance;
	public override ConfigScope Mode => ConfigScope.ServerSide;

	[DefaultValue(false)]
	public bool DisableUnlimitedBuffs;

	[Range(0, 100)]
    [DefaultValue(30)]
    public uint UnlimitedPotions;

	[Range(0, 100)]
    [DefaultValue(10)]
    public uint UnlimitedStations;

    [DefaultValue(true)]
    public bool UnlimitedRClickStations;
}

