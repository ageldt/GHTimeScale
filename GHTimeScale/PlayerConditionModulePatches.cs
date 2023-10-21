

using HarmonyLib;

namespace GHTimeScale
{

    [HarmonyPatch(typeof(PlayerConditionModule))]
    public class PlayerConditionModulePatches
    {
        [HarmonyPatch("PostInitialize"), HarmonyPostfix]
        public static void PostInitializePostfix(
            ref float ___m_NutritionCarbohydratesConsumptionPerSecond,
            ref float ___m_NutritionFatConsumptionPerSecond,
            ref float ___m_NutritionProteinsConsumptionPerSecond,
            ref float ___m_HydrationConsumptionPerSecond,
            ref float ___m_HydrationConsumptionDuringFeverPerSecond,
            ref float ___m_EnergyConsumptionPerSecond,
            ref float ___m_EnergyConsumptionPerSecondNoNutrition,
            ref float ___m_EnergyConsumptionPerSecondFever,
            ref float ___m_EnergyConsumptionPerSecondFoodPoison,
            ref float ___m_HealthRecoveryPerDayEasyMode,
            ref float ___m_HealthRecoveryPerDayNormalMode,
            ref float ___m_HealthRecoveryPerDayHardMode,
            ref float ___m_EnergyLossDueLackOfNutritionPerSecond,
            ref float ___m_EnergyRecoveryDueNutritionPerSecond,
            ref float ___m_EnergyRecoveryDueHydrationPerSecond
            )
        {
            float timeScaleFactor = GHTimeScale.getTimeScaleFactor();

            // nutrition
            ___m_NutritionCarbohydratesConsumptionPerSecond *= timeScaleFactor;
            ___m_NutritionFatConsumptionPerSecond *= timeScaleFactor;
            ___m_NutritionProteinsConsumptionPerSecond *= timeScaleFactor;

            // hydration
            ___m_HydrationConsumptionPerSecond *= timeScaleFactor;
            ___m_HydrationConsumptionDuringFeverPerSecond *= timeScaleFactor;

            // energy
            ___m_EnergyConsumptionPerSecond *= timeScaleFactor;
            ___m_EnergyConsumptionPerSecondNoNutrition *= timeScaleFactor;
            ___m_EnergyConsumptionPerSecondFever *= timeScaleFactor;
            ___m_EnergyConsumptionPerSecondFoodPoison *= timeScaleFactor;
            ___m_EnergyLossDueLackOfNutritionPerSecond *= timeScaleFactor;
            ___m_EnergyRecoveryDueNutritionPerSecond *= timeScaleFactor;
            ___m_EnergyRecoveryDueHydrationPerSecond *= timeScaleFactor;


            // health
            ___m_HealthRecoveryPerDayEasyMode *= timeScaleFactor;
            ___m_HealthRecoveryPerDayNormalMode *= timeScaleFactor;
            ___m_HealthRecoveryPerDayHardMode *= timeScaleFactor;

        }



    }

    
}
