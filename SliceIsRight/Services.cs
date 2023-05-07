using Dalamud.Game.ClientState;
using Dalamud.Game.ClientState.Objects;
using Dalamud.Game.Gui;
using Dalamud.IoC;
using Dalamud.Plugin;

namespace SliceIsRight;

public class Services
{
    [PluginService] public static DalamudPluginInterface PluginInterface { get; private set; } = null!;
    [PluginService] public static ObjectTable ObjectTable { get; private set; } = null!;
    [PluginService] public static ClientState ClientState { get; private set; } = null!; 
    [PluginService] public static GameGui GameGui { get; private set; } = null!;
}