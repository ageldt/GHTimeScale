
using AIs;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

namespace GHTimeScale
{
    [HarmonyPatch(typeof(FallenObjectsManager))]
    public class FallenObjectsManagerPatches
    {
        

        [HarmonyPatch("ParseScript"), HarmonyPostfix]
        public static void ParseScriptPostfix(Dictionary<string, List<FallenObjectData>> ___m_Data)
        {

            if (!GHTimeScale.ScaleResourceRespawnTime.Value)
                return;

            foreach (KeyValuePair<string, List<FallenObjectData>> entry in ___m_Data)
            {
                List<FallenObjectData> list = entry.Value;
                foreach (FallenObjectData foData in list)
                {
                    foData.m_Cooldown /= GHTimeScale.getTimeScaleFactor();
                }
            }

        }


    }
}
