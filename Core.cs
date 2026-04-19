using MelonLoader;
using HarmonyLib;
using UnityEngine;
using Il2CppQuantum_Game;
using Il2CppQuantum;

[assembly: MelonInfo(typeof(FreeRoam.Core), "FreeRoam", "1.0.0", "taldo", null)]
[assembly: MelonGame("Videocult", "Airframe")]

namespace FreeRoam
{
    public class Core : MelonMod
    {
        [HarmonyPatch(typeof(PlayAreaSystem), "OOBKill", new Type[] {typeof(Frame), typeof(EntityRef)})]
        private class DisableOOB
        {
            public static bool Prefix()
            {
                return false;
            }
        }
        
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Goodbye OOB!");
        }
    }
}