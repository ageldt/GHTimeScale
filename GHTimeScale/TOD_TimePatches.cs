using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GHTimeScale
{
    [HarmonyPatch(typeof(TOD_Time))]
    public class TOD_TimePatches
    {

        [HarmonyPatch("Awake"), HarmonyPrefix]
        public static void AwakePrefix(TOD_Time __instance)
        {
            __instance.m_DayLengthInMinutes = GHTimeScale.DayLength.Value;
            __instance.m_NightLengthInMinutes = GHTimeScale.NightLength.Value;

        }
    }
}
