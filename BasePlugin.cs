using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using HarmonyLib;
using Reactor;

namespace PluginName
{
    [BepInAutoPlugin("gg.reactor.Example")]
    [BepInProcess("Among Us.exe")]
    [BepInDependency(ReactorPlugin.Id)]
    public partial class PluginNamePlugin : BasePlugin
    {
        public override void Load()
        {
            Harmony.PatchAll();
        }
    }
}
