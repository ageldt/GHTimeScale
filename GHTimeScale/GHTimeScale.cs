using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

namespace GHTimeScale
{
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class GHTimeScale : BaseUnityPlugin
    {
        public const string PLUGIN_GUID = "agel500.greenhell.ghtimescale";
        public const string PLUGIN_NAME = "GHTimeScale";
        public const string PLUGIN_VERSION = "1.2.0";

        // general
        public static ConfigEntry<bool> GHTimeScaleEnabled;
        public static ConfigEntry<float> DayLength;
        public static ConfigEntry<float> NightLength;

        // respawn
        public static ConfigEntry<bool> ScaleCreaturesRespawnTime;
        public static ConfigEntry<bool> ScaleResourceRespawnTime;

        // diseases & injuries
        public static ConfigEntry<float> DiseaseHealDurationFactor;
        public static ConfigEntry<float> InjuryHealDurationFactor;

        public void Awake()
        {

            GHTimeScaleEnabled = Config.Bind("1 General", "GHTimeScaleEnabled", true, "Is GHTimeScale Mod enabled?");
            DayLength = Config.Bind("1 General", "DayLength", 90f, "Day Length in minutes. (vanilla: 20)");
            NightLength = Config.Bind("1 General", "NightLength", 90f, "Day Length in minutes. (vanilla: 10)");
            ScaleCreaturesRespawnTime = Config.Bind("2 Respawn", "ScaleCreaturesRespawnTime", true, "Apply time scale factor to creature respawn times (animals + natives)");
            ScaleResourceRespawnTime = Config.Bind("2 Respawn", "ScaleResourceRespawnTime", true, "Apply time scale factor to resource respawn times (animals + natives)");
            DiseaseHealDurationFactor = Config.Bind("3 Diseases & Injuries", "DiseaseHealDurationFactor", 3f, "Scale how long diseases heal");
            InjuryHealDurationFactor = Config.Bind("3 Diseases & Injuries", "InjuryHealDurationFactor", 10f, "Scale how long injuries heal");

            Harmony harmony = new Harmony(PLUGIN_GUID);
            harmony.PatchAll();
            Logger.LogInfo(string.Format("{0} v.{1} successfully loaded.", PLUGIN_NAME, PLUGIN_VERSION));
        }

        public static float getTimeScaleFactor()
        {
            return 20 / GHTimeScale.DayLength.Value;
        }
    }
}
