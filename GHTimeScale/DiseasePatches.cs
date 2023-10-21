

using HarmonyLib;

namespace GHTimeScale
{
    [HarmonyPatch(typeof(Disease))]
    public class DiseasePatches
    {
        [HarmonyPatch("Activate"), HarmonyPostfix]
        public static void ActivatePostfix(Disease __instance)
        {
            __instance.m_AutoHealTime *= GHTimeScale.DiseaseHealDurationFactor.Value;
        }
    }
}
