using System.Collections.Generic;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace WeaponSpeedReachForwarder;

public record Settings
{
    [SettingName("Use Reqtificator Settings")]
    public bool UseReqtificatorSettings { get; set; } = false;

    [SettingName("Weapon Mod Plugin")]
    public List<ModKey> WeaponModPlugin = new List<ModKey>();
}
