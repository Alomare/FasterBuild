using HarmonyLib;

namespace Alomare.FasterBuild
{
    [HarmonyPatch(typeof(Constructable))]
    public static class ConstructablePatches
    {
        [HarmonyPatch(typeof(Constructable), nameof(Constructable.GetConstructInterval))]
        class Patch
        {
            static void Postfix(ref float __result)
            {
                __result /= FasterBuildPlugin.ModOptions.ConstructSpeedMultiplier;
            }
        }
    }
}