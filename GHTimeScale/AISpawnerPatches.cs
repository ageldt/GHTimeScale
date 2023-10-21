
using AIs;
using HarmonyLib;

namespace GHTimeScale
{
    [HarmonyPatch(typeof(AISpawner))]
    public class AISpawnerPatches
    {
        [HarmonyPatch("Start"), HarmonyPostfix]
        public static void StartPostfix(AISpawner __instance)
        {
            if (!GHTimeScale.ScaleCreaturesRespawnTime.Value)
                return;

            __instance.m_ResetTime /= GHTimeScale.getTimeScaleFactor();            
        }


    }
}
