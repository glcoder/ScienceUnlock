using HarmonyLib;

namespace ScienceUnlock
{
    [HarmonyPatch(typeof(ResearchTemplate), nameof(ResearchTemplate.onLoad))]
    internal class ResearchTemplate_onLoad
    {
        static void Postfix(ResearchTemplate __instance)
        {
            __instance.includeInDemo = true;
        }
    }
}
