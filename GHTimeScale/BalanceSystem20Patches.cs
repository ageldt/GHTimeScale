
using HarmonyLib;

namespace GHTimeScale
{
    [HarmonyPatch(typeof(BalanceSystem20))]
    public class BalanceSystem20Patches
    {
        [HarmonyPatch("ParseParametersScript"), HarmonyPostfix]
        public static void ParseParametersScriptPostfix(ref float ___s_BalanceSpawnerCooldown, ref float ___s_BalanceSpawnerNoSpawnCooldown)
        {
            if (!GHTimeScale.ScaleResourceRespawnTime.Value)
                return;

            ___s_BalanceSpawnerCooldown /= GHTimeScale.getTimeScaleFactor();
            ___s_BalanceSpawnerNoSpawnCooldown /= GHTimeScale.getTimeScaleFactor();
        }
    }
}
