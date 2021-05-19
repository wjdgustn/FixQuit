using HarmonyLib;
using UnityEngine.SceneManagement;

namespace FixQuit.MainPatch {
    [HarmonyPatch(typeof(scnEditor), "TryApplicationQuit")]
    
    internal static class FixQuit {
        private static bool Prefix(ref bool __result) {
            if (SceneManager.GetActiveScene().name != "scnEditor") {
                __result = true;
                return false;
            }

            return true;
        }
    }
}