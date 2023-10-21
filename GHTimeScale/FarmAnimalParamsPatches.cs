

using HarmonyLib;

namespace GHTimeScale
{
    [HarmonyPatch(typeof(FarmAnimalParams))]
    public class FarmAnimalParamsPatches
    {

        [HarmonyPatch("Load"), HarmonyPostfix]
        public static void LoadPostfix(ref Key key, FarmAnimalParams __instance)
        {
            float scaleFactor = GHTimeScale.getTimeScaleFactor();

            for (int i = 0; i < key.GetKeysCount(); i++)
            {
                Key param = key.GetKey(i);
                if (param.GetName() == "PregnantCooldown")
                {
                    __instance.m_PregnantCooldown /= scaleFactor;
                }
                else if (param.GetName() == "PregnantDuration")
                {
                    __instance.m_PregnantDuration /= scaleFactor;
                }
                else if (param.GetName() == "MaturationPerSec")
                {
                    __instance.m_MaturationPerSec *= scaleFactor;
                }
                else if (param.GetName() == "DecreaseFoodLevelPerSec")
                {
                    __instance.m_DecreaseFoodLevelPerSec *= scaleFactor;
                }
                else if (param.GetName() == "DecreaseWaterLevelPerSec")
                {
                    __instance.m_DecreaseWaterLevelPerSec *= scaleFactor;
                }
                else if (param.GetName() == "DecreasePoisonLevelPerSec")
                {
                    __instance.m_DecreasePoisonLevelPerSec *= scaleFactor;
                }
                else if (param.GetName() == "DecreaseHealthPerSec")
                {
                    __instance.m_DecreaseHealthPerSec *= scaleFactor;
                }
                else if (param.GetName() == "IncreaseHealthPerSec")
                {
                    __instance.m_IncreaseHealthPerSec *= scaleFactor;
                }
                else if (param.GetName() == "DecreaseTrustPerSec")
                {
                    __instance.m_DecreaseTrustPerSec *= scaleFactor;
                }
                else if (param.GetName() == "IncreaseTrustPerSec")
                {
                    __instance.m_IncreaseTrustPerSec *= scaleFactor;
                }
                else if (param.GetName() == "ShitInterval")
                {
                    __instance.m_ShitInterval /= scaleFactor;
                }
                else if (param.GetName() == "PoisonFromShitPerSec")
                {
                    __instance.m_PoisonFromShitPerSec *= scaleFactor;
                }
                else if (param.GetName() == "OutsideFarmDecreaseTrustPerSec")
                {
                    __instance.m_OutsideFarmDecreaseTrustPerSec *= scaleFactor;
                }

            }

        }
    }
}
