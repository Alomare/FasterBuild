using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using Nautilus.Handlers;

namespace Alomare.FasterBuild
{
    [BepInPlugin(MyGuid, PluginName, VersionString)]
    [BepInDependency("com.snmodding.nautilus")]
    public class FasterBuildPlugin : BaseUnityPlugin
    {
        private const string MyGuid = "com.alomare.fasterbuild";
        private const string PluginName = "Faster Build";
        private const string VersionString = "1.0.0";

        private static readonly Harmony Harmony = new Harmony(MyGuid);
        public static ManualLogSource Log;
        public static ModOptions ModOptions;

        private void Awake()
        {
            ModOptions = OptionsPanelHandler.RegisterModOptions<ModOptions>();
            Harmony.PatchAll();
            Logger.LogInfo(PluginName + " " + VersionString + " " + "loaded.");
            Log = Logger;
        }
    }
}
