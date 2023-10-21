

using HarmonyLib;

namespace GHTimeScale
{
    [HarmonyPatch(typeof(Injury))]
    public class InjuryPatches
    {

        [HarmonyPatch("GetHealingDuration"), HarmonyPostfix]
        public static void GetHealingDurationPostfix(ref float __result)
        {
            __result *= GHTimeScale.InjuryHealDurationFactor.Value;
        }
    }
}
